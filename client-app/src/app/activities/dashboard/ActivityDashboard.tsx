import React from "react";
import { Grid } from "semantic-ui-react";
import { Activity } from "../../models/activity";
import ActivityDetails from "../details/ActivityDetails";
import ActivityForm from "../form/ActivityForm";
import ActivityList from "./ActivityList";

interface Props {
    activities: Activity[];
    selectedActivity: Activity | undefined;
    editMode: boolean;
    selectActivity: (id: string) => void;
    cancelSelectActivity: () => void;
    openForm: (id: string) => void;
    closeForm: () => void;
}

export default function ActivityDashboard(
    {
        activities,
        selectedActivity,
        editMode,
        selectActivity,
        cancelSelectActivity,
        openForm,
        closeForm
    }: Props) {
    return (
        <Grid>
            <Grid.Column width='10'>
                <ActivityList 
                    activities={activities}
                    selectActivity={selectActivity}
                />
            </Grid.Column>
            <Grid.Column width='6'>
                {selectedActivity && !editMode &&
                <ActivityDetails 
                    activity={selectedActivity}
                    cancelSelectActivity={cancelSelectActivity}
                    openForm={openForm}
                />}

                {editMode &&
                <ActivityForm 
                    closeForm={closeForm}
                    activity={selectedActivity}
                />}
            </Grid.Column>
        </Grid>
    )
}