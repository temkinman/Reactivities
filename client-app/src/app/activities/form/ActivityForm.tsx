import { observer } from "mobx-react-lite";
import React, { ChangeEvent, useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { Button, Form, Segment } from "semantic-ui-react";
import LoadingComponent from "../../layout/LoadingComponent";
import { useStore } from "../../stores/store";

export default observer(function ActivityForm() {
    const {activityStore} = useStore();
    const {selectedActivity, createActivity,
            updateActivity, loading, loadingInitial, loadActivity} = activityStore;
    const {id} = useParams<{id: string}>();

    const[activity, setActivity] = useState({
        id: '',
        title: '',
        category: '',
        city: '',
        venue: '',
        date: '',
        description: ''
    });

    useEffect(() => {
        console.log('try to load in ActivityForm...')
        if(id) loadActivity(id).then(activity => setActivity(activity!))
    },  [id, loadActivity])

    const handleSubmit = () => {
        activity.id ? updateActivity(activity) : createActivity(activity);
    }

    const handleInputChange = (e: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
        const {name, value} = e.target;
        setActivity({...activity, [name]: value})
    }

    if(loadingInitial){
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
                <Button floated='right' type='button' content='Cancel' />
            </Form>
        </Segment>
    );
})

function useEfect(arg0: () => void) {
    throw new Error("Function not implemented.");
}
