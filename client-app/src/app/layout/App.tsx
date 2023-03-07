import React, { useEffect, useState } from "react";
import "./styles.css";
import { Button, Container } from "semantic-ui-react";
import { Activity } from "../models/activity";
import NavBar from "./NavBar";
import ActivityDashboard from "../activities/dashboard/ActivityDashboard";
import {v4 as uuid} from "uuid";
import agent from "../api/agent";
import LoadingComponent from "./LoadingComponent";
import { useStore } from "../stores/store";
import { observer } from "mobx-react-lite";

function App() {
    const {activityStore} = useStore();

    const [activities, setActivities] = useState<Activity[]>([]);
    const [selectedActivity, setSelectedActivity] = useState<Activity | undefined>(undefined);
    const [editMode, setEditMode] = useState(false);
    const [loading, setLoading] = useState(true);
    const [submitting, setSubmitting] = useState(false);

    useEffect(() => {
        agent.Activities
            .list()
            .then((response) => {
                let activities: Activity[] = [];

                response.forEach((activity: Activity) => {
                    activity.date = activity.date.split('T')[0];
                    activities.push(activity);
                });
                setLoading(false);
                setActivities(activities);
            });
    }, []);

    const handleSelectActivity = async(id: string) => {
        setSelectedActivity(activities.find(x => x.id === id));
    }

    const handleCancelSelectActivity = () => {
        setSelectedActivity(undefined);
    }

    const handleFormOpen = (id?: string) => {
        id ? handleSelectActivity(id) : handleCancelSelectActivity();
        setEditMode(true);
    }

    const handleFormClose = () => {
        setEditMode(false);
    }

    
    const handleCreateOrEditActivity = async (activity: Activity) => {
        setSubmitting(true);

        if(activity.id) {
            agent.Activities.update(activity)
            .then(() => {
                setActivities([...activities].filter(x => x.id !== activity.id))
                setSelectedActivity(activity);
                setSubmitting(false);
                setEditMode(false);
            });
        }
        else {
            activity.id = uuid();
            agent.Activities.create(activity)
            .then(() => {
                setActivities([...activities, activity]);
                setSelectedActivity(activity);
                setSubmitting(false);
                setEditMode(false);
            });
        }
    }

    const handleDeleteActivity = (id: string) => {
        setSubmitting(true);

        agent.Activities.delete(id)
        .then(() => {
            setSubmitting(false);
            setActivities([...activities].filter(x => x.id !== id));
        })
    }

    if(loading) {
        return (<LoadingComponent
                    content="Loading app"
                    inverted={loading}
                />);
    }

    return (
        <>
            <NavBar openForm={handleFormOpen}/>
            <Container style={{marginTop: '7em'}}>
                <h2>{activityStore.title}</h2>
                <Button onClick={activityStore.setTitle} positive content='add exclamantion'/>
                <ActivityDashboard 
                    activities={activities}
                    selectedActivity={selectedActivity}
                    submitting={submitting}
                    cancelSelectActivity={handleCancelSelectActivity}
                    selectActivity={handleSelectActivity}
                    editMode={editMode}
                    openForm={handleFormOpen}
                    closeForm={handleFormClose}
                    createOrEdit={handleCreateOrEditActivity}
                    deleteActivity={handleDeleteActivity}
                />
            </Container>
        </>
    );
}

export default observer(App);
