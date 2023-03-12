import { observer } from "mobx-react-lite";
import React, { ChangeEvent, useEffect, useState } from "react";
import { useParams, useNavigate, Link, NavLink } from "react-router-dom";
import { Button, Form, Segment } from "semantic-ui-react";
import LoadingComponent from "../../layout/LoadingComponent";
import { useStore } from "../../stores/store";
import {v4 as uuid} from "uuid";
import { Formik, FormikHelpers, FormikValues } from "formik";

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

    // const handleSubmit = () => {
    //     if (activity.id.length === 0) {
    //         let newActivity = {
    //             ...activity,
    //             id: uuid()
    //         }
    //         console.log('newActivity id: ' + newActivity.id);
    //         createActivity(newActivity)
    //         .then(() => navigate(`/activities/${newActivity.id}`));
    //     }
    //     else {
    //         updateActivity(activity)
    //         .then(() => navigate(`/activities/${activity.id}`));
    //     }
    // }

    // const handleInputChange = (e: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
    //     const {name, value} = e.target;
    //     setActivity({...activity, [name]: value})
    // }

    if(loadingInitial && id){
        return <LoadingComponent content="Loading activities..."/>
    }

    return (
        <Segment clearing>
            <Formik enableReinitialize initialValues={activity} onSubmit={values =>console.log(values)}>
                {({values: activity, handleChange, handleSubmit}) => (
                    <Form onSubmit={handleSubmit} autoComplete='off'>
                        <Form.Input placeholder='Title' name='title' value={activity?.title} onChange={handleChange} />
                        <Form.TextArea placeholder='Description' name='description' value={activity?.description} onChange={handleChange} />
                        <Form.Input placeholder='Category' name='category' value={activity?.category} onChange={handleChange} />
                        <Form.Input placeholder='Date' type="date" name='date' value={activity?.date} onChange={handleChange} />
                        <Form.Input placeholder='City' name='city' value={activity?.city} onChange={handleChange} />
                        <Form.Input placeholder='Venue' name='venue' value={activity?.venue} onChange={handleChange} />
                        <Button loading={loading} floated='right' positive type='submit' content='Submit' />
                        <Button as={NavLink} to='/activities' floated='right' type='button' content='Cancel' />
                    </Form>
                )}
            </Formik>
            
        </Segment>
    );
})

function useEfect(arg0: () => void) {
    throw new Error("Function not implemented.");
}
