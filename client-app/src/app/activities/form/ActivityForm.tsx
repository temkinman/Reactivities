import { observer } from "mobx-react-lite";
import React, { ChangeEvent, useEffect, useState } from "react";
import { useParams, useNavigate, Link, NavLink } from "react-router-dom";
import { Button, Form, Segment } from "semantic-ui-react";
import LoadingComponent from "../../layout/LoadingComponent";
import { useStore } from "../../stores/store";
import {v4 as uuid} from "uuid";

export default observer(function ActivityForm() {
    const navigate = useNavigate (); 
    const {activityStore} = useStore();
    const {selectedActivity, createActivity,
            updateActivity, loading, loadingInitial, loadActivity} = activityStore;
    const {id} = useParams<{id: string}>();

    const emtyActivity = {
        id: '',
        title: '',
        category: '',
        city: '',
        venue: '',
        date: '',
        description: ''
    }

    const[activity, setActivity] = useState(emtyActivity);

    useEffect(() => {
        console.log('try to load in ActivityForm...')
        console.log('selected id: ' + selectedActivity?.id);
        if(id) {
            loadActivity(id).then(activity => setActivity(activity!))
        }
        else {
            setActivity(emtyActivity)
        }
    },  [id, loadActivity])

    const handleSubmit = () => {
        if (activity.id.length === 0) {
            let newActivity = {
                ...activity,
                id: uuid()
            }
            console.log('newActivity id: ' + newActivity.id);
            createActivity(newActivity)
            .then(() => navigate(`/activities/${newActivity.id}`));
        }
        else {
            updateActivity(activity)
            .then(() => navigate(`/activities/${activity.id}`));
        }
    }

    const handleInputChange = (e: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
        const {name, value} = e.target;
        setActivity({...activity, [name]: value})
    }

    if(loadingInitial && id){
        return <LoadingComponent content="Loading activities..."/>
    }

    return (
        <Segment clearing>
            <Form onSubmit={handleSubmit} autoComplete='off'>
                <Form.Input placeholder='Title' name='title' value={activity?.title} onChange={handleInputChange} />
                <Form.TextArea placeholder='Description' name='description' value={activity?.description} onChange={handleInputChange} />
                <Form.Input placeholder='Category' name='category' value={activity?.category} onChange={handleInputChange} />
                <Form.Input placeholder='Date' type="date" name='date' value={activity?.date} onChange={handleInputChange} />
                <Form.Input placeholder='City' name='city' value={activity?.city} onChange={handleInputChange} />
                <Form.Input placeholder='Venue' name='venue' value={activity?.venue} onChange={handleInputChange} />
                <Button loading={loading} floated='right' positive type='submit' content='Submit' />
                <Button as={NavLink} to='/activities' floated='right' type='button' content='Cancel' />
            </Form>
        </Segment>
    );
})

function useEfect(arg0: () => void) {
    throw new Error("Function not implemented.");
}
