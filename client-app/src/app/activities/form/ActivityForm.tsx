import React from "react";
import { Button, Form, Segment } from "semantic-ui-react";
import { Activity } from "../../models/activity";

export default function ActivityForm() {
    return (
        <Segment clearing>
            <Form>
                <Form.Input placeholder='Title' name='title'  />
                <Form.TextArea placeholder='Description'  name='description' />
                <Form.Input placeholder='Category'/>
                <Form.Input placeholder='Date'/>
                <Form.Input placeholder='City' />
                <Form.Input placeholder='Venue' />
                <Button floated='right' positive type='submit' content='Submit' />
                <Button floated='right' type='button' content='Cancel' />
            </Form>
        </Segment>
    );
}
