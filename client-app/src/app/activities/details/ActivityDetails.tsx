import React, { useEffect, useState } from "react";
import { Link, useParams } from "react-router-dom";
import { Button, Card, Image } from "semantic-ui-react";
import LoadingComponent from "../../layout/LoadingComponent";
import { useStore } from "../../stores/store";

export default function ActivityDetails() {

    const {activityStore} = useStore();
    const {id} = useParams<{id: string}>();

    const {loadActivity, loadingInitial} = activityStore;
    
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
        console.log('try to load in ActivityDetails...')
        console.log('id: ' + id)
        if(id) {
            loadActivity(id).then(activity => setActivity(activity!));
            console.log(activity);
        }
    },  [id, loadActivity])


    // useEffect(() => {
    //     console.log('id: '+ id)
    //     if(id) activityStore.loadActivity(id)
    //         .then(act => {
    //             activity_2 = act;
    //         })
    //     //activityStore.loadActivity(id);
    // }, [id, activityStore]);

    if(loadingInitial) return <LoadingComponent content={""}/>;

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
