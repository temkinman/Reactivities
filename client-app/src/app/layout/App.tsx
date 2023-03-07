import React, { useEffect, useState } from "react";
import "./styles.css";
import { Container } from "semantic-ui-react";
import { Activity } from "../models/activity";
import NavBar from "./NavBar";
import ActivityDashboard from "../activities/dashboard/ActivityDashboard";
import agent from "../api/agent";
import LoadingComponent from "./LoadingComponent";
import { useStore } from "../stores/store";
import { observer } from "mobx-react-lite";

function App() {
    const {activityStore} = useStore();

    const [activities, setActivities] = useState<Activity[]>([]);
    const [submitting, setSubmitting] = useState(false);

    useEffect(() => {
        activityStore.loadActivities();
    }, [activityStore]);

    const handleCreateOrEditActivity = async (activity: Activity) => {
        setSubmitting(true);

        // if(activity.id) {
        //     agent.Activities.update(activity)
        //     .then(() => {
        //         setActivities([...activities].filter(x => x.id !== activity.id))
        //         setSelectedActivity(activity);
        //         setSubmitting(false);
        //         setEditMode(false);
        //     });
        // }
        // else {
        //     activity.id = uuid();
        //     agent.Activities.create(activity)
        //     .then(() => {
        //         setActivities([...activities, activity]);
        //         activityStore.selectedActivity(activity);
        //         setSubmitting(false);
        //         setEditMode(false);
        //     });
        // }
    }

    const handleDeleteActivity = (id: string) => {
        setSubmitting(true);

        agent.Activities.delete(id)
        .then(() => {
            setSubmitting(false);
            setActivities([...activities].filter(x => x.id !== id));
        })
    }

    if(activityStore.loadingInitial) {
        return (<LoadingComponent content="Loading app" />);
    }

    return (
        <>
            <NavBar />
            <Container style={{marginTop: '7em'}}>
                <ActivityDashboard 
                    activities={activityStore.activities}
                    submitting={submitting}
                    createOrEdit={handleCreateOrEditActivity}
                    deleteActivity={handleDeleteActivity}
                />
            </Container>
        </>
    );
}

export default observer(App);
