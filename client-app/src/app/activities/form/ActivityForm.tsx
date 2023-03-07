import React, { ChangeEvent, useState } from "react";
import { Button, Form, Segment } from "semantic-ui-react";
import { Activity } from "../../models/activity";
import { useStore } from "../../stores/store";

interface Props {
    submitting: boolean;
    createOrEdit: (activity: Activity) => void;
}

export default function ActivityForm({
    submitting,
    createOrEdit
}: Props) {

    const {activityStore} = useStore();
    const {selectedActivity, closeForm} = activityStore;

    const initialState = selectedActivity ?? {
        id: '',
        title: '',
        category: '',
        city: '',
        venue: '',
        date: '',
        description: ''
    }

    const[activity, setActivity] = useState(initialState);

    const handleSubmit = () => {
        createOrEdit(activity);
    }

    const handleInputChange = (e: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
        const {name, value} = e.target;
        console.log('name: ' + name);
        console.log('value: ' + value);
        setActivity({...activity, [name]: value})
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
                <Button loading={submitting} floated='right' positive type='submit' content='Submit' />
                <Button onClick={closeForm} floated='right' type='button' content='Cancel' />
            </Form>
        </Segment>
    );
}
