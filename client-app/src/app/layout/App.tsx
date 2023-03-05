import React, { useEffect, useState } from "react";
import "./styles.css";
import axios from "axios";
import { Header, List } from "semantic-ui-react";
import { Activity } from "../models/activity";

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
        <div className="App">
            <Header as="h2" icon="users" content="Reactivities" />
            <List>
                {activities.map((activity) => (
                    <li key={activity.id}>{activity.title}</li>
                ))}
            </List>
        </div>
    );
}

export default App;
