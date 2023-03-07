import React, { useEffect } from "react";
import { Link, useParams } from "react-router-dom";
import { Button, Card, Image } from "semantic-ui-react";
import LoadingComponent from "../../layout/LoadingComponent";
import { useStore } from "../../stores/store";

export default function ActivityDetails() {

    const {activityStore} = useStore();
    const {selectedActivity: activity} = activityStore;
    // const {id} = useParams<{id: string}>();

    // useEffect(() => {
    //     activityStore.loadActivity(id);
    // }, [id, activityStore]);

    if(!activity) return <LoadingComponent content={""}/>;

    return (
        <Card fluid>
            <Image src={`/assets/categoryImages/${activity.category}.jpg`} />
            <Card.Content>
                <Card.Header>{activity.title}</Card.Header>
                <Card.Meta>
                    <span>{activity.date}</span>
                </Card.Meta>
                <Card.Description>
                    {activity.description}
                </Card.Description>
            </Card.Content>
            <Card.Content extra>
                <Button.Group widths='2'>
                    <Button 
                        as={Link} to={`/manage/${activity.id}`}
                        basic
                        color="blue"
                        content='Edit'/>
                    <Button 
                        as={Link} to='/activities'
                        basic
                        color="blue"
                        content='Cancel'/>
                </Button.Group>
            </Card.Content>
        </Card>
    );
}
