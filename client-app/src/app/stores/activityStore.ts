import { makeAutoObservable } from "mobx";
import agent from "../api/agent";
import { Activity } from "../models/activity";

export default class ActivityStore {
    activities: Activity[] = [];
    selectedActivity: Activity | undefined = undefined;
    editMode = false;
    loading = false;
    loadingInitial = false;

    constructor() {
        makeAutoObservable(this)
    }

    loadActivities = async () => {
        this.loadingInitial = true;

        try {
            const activities = await agent.Activities.list();

            activities.forEach((activity: Activity) => {
                activity.date = activity.date.split('T')[0];
                this.activities.push(activity);
            });

            this.setLoadingInitial(false)
            
        } catch (error) {
            console.log(error);
            this.setLoadingInitial(false)
        }
    }

    setLoadingInitial = (state: boolean) => {
        this.loadingInitial = state;
    }

    selectActivity = async (id: string) => {
        this.selectedActivity = this.activities.find(x => x.id === id);
    }

    cancelSelectActivity = () => {
        this.selectedActivity = undefined;
    }

    openForm = (id?: string) => {
        id ? this.selectActivity(id) : this.cancelSelectActivity();
        this.editMode = true;
    }

    closeForm = () => {
        this.editMode = false;
    }
}