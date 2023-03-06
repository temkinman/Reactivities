import React from "react";
import { Button, Form, Segment } from "semantic-ui-react";
import { Activity } from "../../models/activity";

interface Props {
    activity: Activity | undefined;
    closeForm: () => void;
}

export default function ActivityForm({activity, closeForm}: Props) {
    return (
        <Segment clearing>
            <Form>
                <Form.Input placeholder='Title' name='title' value={activity?.title} />
                <Form.TextArea placeholder='Description' name='description' value={activity?.description} />
                <Form.Input placeholder='Category' value={activity?.category} />
                <Form.Input placeholder='Date' value={activity?.date} />
                <Form.Input placeholder='City' value={activity?.city} />
                <Form.Input placeholder='Venue' value={activity?.venue} />
                <Button floated='right' positive type='submit' content='Submit' />
                <Button onClick={closeForm} floated='right' type='button' content='Cancel' />
                {/* <Form.Input placeholder='Title' value={activity.title} name='title' onChange={handleInputChange} />
                <Form.TextArea placeholder='Description' value={activity.description} name='description' onChange={handleInputChange} />
                <Form.Input placeholder='Category' value={activity.category} name='category' onChange={handleInputChange} />
                <Form.Input placeholder='Date' value={activity.date} name='date' onChange={handleInputChange} />
                <Form.Input placeholder='City' value={activity.city} name='city' onChange={handleInputChange} />
                <Form.Input placeholder='Venue' value={activity.venue} name='venue' onChange={handleInputChange} />
                <Button floated='right' positive type='submit' content='Submit' />
                <Button onClick={closeForm} floated='right' type='button' content='Cancel' /> */}
            </Form>
        </Segment>
    );
}
