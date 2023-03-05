import React, { Fragment, useEffect, useState } from "react";
import "./styles.css";
import axios from "axios";
import { Container, List } from "semantic-ui-react";
import { Activity } from "../models/activity";
import NavBar from "./NavBar";

function App() {
    const [activities, setActivities] = useState<Activity[]>([]);

    useEffect(() => {
        axios
            .get<Activity[]>("https://localhost:7115/api/activities")
            .then((response) => {
                setActivities(response.data);
            });
    }, []);

    return (
        <>
            <NavBar/>
            <Container style={{marginTop: '7em'}}>
                <List>
                    {activities.map((activity) => (
                        <li key={activity.id}>{activity.title}</li>
                    ))}
                </List>
            </Container>
        </>
    );
}

export default App;
