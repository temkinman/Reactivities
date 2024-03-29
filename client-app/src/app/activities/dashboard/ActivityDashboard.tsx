import { observer } from "mobx-react-lite";
import React, { useEffect } from "react";
import { Grid } from "semantic-ui-react";
import LoadingComponent from "../../layout/LoadingComponent";
import { useStore } from "../../stores/store";
import ActivityDetails from "../details/ActivityDetails";
import ActivityForm from "../form/ActivityForm";
import ActivityFilter from "./ActivityFilter";
import ActivityList from "./ActivityList";

export default observer(function ActivityDashboard() {
    const {activityStore} = useStore();
    const {loadActivities, activityRegistry} = activityStore;

    useEffect(() => {
        if(activityRegistry.size <= 1) {
            loadActivities();
        }
    }, [activityRegistry.size, loadActivities]);

    if(activityStore.loadingInitial) {
        return (<LoadingComponent content="Loading activities..." />);
    }

    return (
        <Grid>
            <Grid.Column width='10'>
                <ActivityList />
            </Grid.Column>
            <Grid.Column width='6'>
                {/* {selectedActivity && !editMode &&
                <ActivityDetails />}

                {editMode &&
                <ActivityForm />} */}
                <ActivityFilter/>
            </Grid.Column>
        </Grid>
    )
})