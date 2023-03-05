import React from "react";
import { Grid, List } from "semantic-ui-react";
import { Activity } from "../../models/activity";

interface Props {
    activities: Activity[];
}

export default function ActivityDashboard({activities}: Props) {
    return (
        <Grid>
            <Grid.Column width='10'>
                <List>
                    {activities.map((activity) => (
                        <li key={activity.id}>{activity.title}</li>
                    ))}
                </List>
            </Grid.Column>
        </Grid>
    )
}