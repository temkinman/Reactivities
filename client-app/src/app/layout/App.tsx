import React, { Fragment, useEffect, useState } from "react";
import "./styles.css";
import axios from "axios";
import { Container, List } from "semantic-ui-react";
import { Activity } from "../models/activity";
import NavBar from "./NavBar";
import ActivityDashboard from "../activities/dashboard/ActivityDashboard";

function App() {
    const [activities, setActivities] = useState<Activity[]>([]);
    const[selectedActivity, setSelectedActivity] = useState<Activity | undefined>(undefined);

    useEffect(() => {
        axios
            .get<Activity[]>("https://localhost:7115/api/activities")
            .then((response) => {
                setActivities(response.data);
            });
    }, []);

    const handleSelectActivity = (id: string) => {
        setSelectedActivity(activities.find(x => x.id == id));
    }

    const handleCancelSelectActivity = () => {
        setSelectedActivity(undefined);
    }

    return (
        <>
            <NavBar/>
            <Container style={{marginTop: '7em'}}>
                <ActivityDashboard 
                    activities={activities}
                    selectedActivity={selectedActivity}
                    cancelSelectActivity={handleCancelSelectActivity}
                    selectActivity={handleSelectActivity}
                />
            </Container>
        </>
    );
}

export default App;
