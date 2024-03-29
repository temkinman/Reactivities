import { observer } from "mobx-react-lite";
import React, { useEffect, useState } from "react";
import { useParams, useNavigate, NavLink } from "react-router-dom";
import { Button, Header, Segment } from "semantic-ui-react";
import LoadingComponent from "../../layout/LoadingComponent";
import { useStore } from "../../stores/store";
import {v4 as uuid} from "uuid";
import { Formik, Form } from "formik";
import * as Yup from 'yup';
import MyTextInput from "../../common/form/MyTextInput";
import MyTextArea from "../../common/form/MyTextArea";
import MySelectInput from "../../common/form/MySelectInput";
import { categoryOptions } from "../../common/form/options/categoryOptions";
import MyDateInput from "../../common/form/MyDateInput";
import { Activity } from "../../models/activity";

export default observer(function ActivityForm() {
    const navigate = useNavigate (); 
    const {activityStore} = useStore();
    const {selectedActivity, createActivity,
            updateActivity, loading, loadingInitial, loadActivity} = activityStore;
    const {id} = useParams<{id: string}>();

    const emtyActivity: Activity = {
        id: '',
        title: '',
        category: '',
        city: '',
        venue: '',
        date: null,
        description: ''
    }

    const[activity, setActivity] = useState<Activity>(emtyActivity);

    const validationSchema = Yup.object({
        title: Yup.string().required('The activity title is reqiered'),
        description: Yup.string().required('The activity description is reqiered'),
        category: Yup.string().required(),
        date: Yup.string().required(),
        venue: Yup.string().required(),
        city: Yup.string().required(),
    })

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

    const handleFormSubmit = (activity: Activity) => {
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

    // const handleInputChange = (e: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
    //     const {name, value} = e.target;
    //     setActivity({...activity, [name]: value})
    // }

    if(loadingInitial && id){
        return <LoadingComponent content="Loading activities..."/>
    }

    return (
        <Segment clearing>
            <Header content="Activity Details" sub color="teal" />
            <Formik 
                validationSchema={validationSchema}
                enableReinitialize
                initialValues={activity}
                onSubmit={values => handleFormSubmit(values)}>
                {({ handleSubmit, isValid, isSubmitting, dirty }) => (
                    <Form className="ui form" onSubmit={handleSubmit} autoComplete='off'>
                        <MyTextInput name='title'
                                    placeholder="Title" />
                        <MyTextArea name='description'
                                    placeholder="Description"
                                    rows={3} />
                        <MySelectInput name='category'
                                    options={categoryOptions}
                                    placeholder="Category" />
                        <MyDateInput name='date'
                                    placeholderText="Date"
                                    showTimeSelect
                                    timeCaption='time'
                                    dateFormat='dd MMM yyyy h:mm:ss ' />
                        <Header content="Location Details" sub color="teal" />
                        <MyTextInput name='city'
                                    placeholder="City" />
                        <MyTextInput name='venue'
                                    placeholder="Venue" />
                        <Button loading={loading}
                                disabled={isSubmitting || !dirty || !isValid}
                                floated='right'
                                positive type='submit'
                                content='Submit' />
                        <Button as={NavLink}
                                to='/activities'
                                floated='right'
                                type='button'
                                content='Cancel' />
                    </Form>
                )}
            </Formik>
            
        </Segment>
    );
})

// function useEfect(arg0: () => void) {
//     throw new Error("Function not implemented.");
// }
