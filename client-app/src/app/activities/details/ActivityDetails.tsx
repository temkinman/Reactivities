import React, { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { Grid } from "semantic-ui-react";
import LoadingComponent from "../../layout/LoadingComponent";
import { useStore } from "../../stores/store";
import ActivityDetaledChat from "./ActivityDetailedChat";
import ActivityDetaledHeader from "./ActivityDetailedHeader";
import ActivityDetailedInfo from "./ActivityDetailedInfo";
import ActivityDetailedSidebar from "./ActivityDetailedSidebar";

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
        <Grid>
            <Grid.Column width={10}>
                <ActivityDetaledHeader activity={activity}/>
                <ActivityDetailedInfo activity={activity}/>
                <ActivityDetaledChat/>
            </Grid.Column>
            <Grid.Column width={6}>
                <ActivityDetailedSidebar />
            </Grid.Column>
        </Grid>
    );
}
