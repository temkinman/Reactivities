import { observer } from "mobx-react-lite";
import React, { ChangeEvent, useEffect, useState } from "react";
import { useParams, useNavigate, Link, NavLink } from "react-router-dom";
import { Button, Segment } from "semantic-ui-react";
import LoadingComponent from "../../layout/LoadingComponent";
import { useStore } from "../../stores/store";
import {v4 as uuid} from "uuid";
import { Formik, Form, Field } from "formik";

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
                {({ handleSubmit }) => (
                    <Form className="ui form" onSubmit={handleSubmit} autoComplete='off'>
                        <Field placeholder='Title' name='title' />
                        <Field placeholder='Description' name='description' />
                        <Field placeholder='Category' name='category' />
                        <Field placeholder='Date' type="date" name='date' />
                        <Field placeholder='City' name='city' />
                        <Field placeholder='Venue' name='venue' />
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
