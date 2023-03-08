import { observer } from "mobx-react-lite";
import React, { Fragment } from "react";
import { Header, Item, Segment } from "semantic-ui-react";
import { useStore } from "../../stores/store";
import ActivityListItem from "./ActivityListItem";

export default observer(function ActivityList() {
    const {activityStore} = useStore();
    const {activitiesByDate, groupedActivities} = activityStore;

    if(!activitiesByDate.length) {
        return (
            <h2 style={{textAlign:'center'}}>Activities are not found</h2>
        )
    }

    return (
        <>
            {groupedActivities.map(([group, activities]) => (
                <Fragment>
                    <Header sub color='teal'>
                        {group}
                    </Header>
                    <Segment>
                    <Item.Group divided>
                        {activities.map( activity => (
                            <ActivityListItem
                                key={activity.id}
                                activity={activity}/>    
                        ))}
                    </Item.Group>    
                </Segment>
                </Fragment>
            ))}
        </>
        
    )
})