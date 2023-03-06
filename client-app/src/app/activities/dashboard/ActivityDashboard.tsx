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
    createOrEdit: (activity: Activity) => void;
    deleteActivity: (id: string) => void;
}

export default function ActivityDashboard(
    {
        activities,
        selectedActivity,
        editMode,
        createOrEdit,
        selectActivity,
        cancelSelectActivity,
        openForm,
        closeForm,
        deleteActivity
    }: Props) {
    return (
        <Grid>
            <Grid.Column width='10'>
                <ActivityList 
                    activities={activities}
                    selectActivity={selectActivity}
                    deleteActivity={deleteActivity}
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
                    createOrEdit={createOrEdit}
                />}
            </Grid.Column>
        </Grid>
    )
}