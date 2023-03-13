import { makeAutoObservable, runInAction } from "mobx";
import agent from "../api/agent";
import { Activity } from "../models/activity";
import format from "date-fns/format";

export default class ActivityStore {
    activities: Activity[] = [];
    selectedActivity: Activity | undefined = undefined;
    activityRegistry = new Map<string, Activity>(); 
    editMode = false;
    loading = false;
    loadingInitial = true;

    constructor() {
        makeAutoObservable(this)
    }

    get activitiesByDate() {
        return Array.from(this.activityRegistry.values())
                    .sort((a, b) => a.date!.getTime() - b.date!.getTime());
    }

    get groupedActivities() {
        return Object.entries(
            this.activitiesByDate.reduce((activities, activity) => {
                const date = format(activity.date!, 'dd MMM yyyy h:mm:ss sss');
                activities[date] = activities[date] ? [...activities[date], activity] : [activity];
                return activities
            }, {} as {[key: string]: Activity[]})
        )
    }

    loadActivities = async () => {
        try {
            const activities = await agent.Activities.list();

            activities.forEach((activity: Activity) => {
                this.setActivity(activity);
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

    loadActivity = async (id: string) => {
        let activity = this.getActivity(id);

        if(activity){
            console.log('getting from cash...')
            this.selectedActivity = activity;
            return activity;
        }
        else {
            console.log('getting from API...')
            this.setLoadingInitial(true);
            try {
                activity = await agent.Activities.details(id);
                this.setActivity(activity!);
                // runInAction(() => {
                //     this.selectedActivity = activity;
                // });
                this.setLoadingInitial(false);
                this.loading = false;
                return activity;
            } catch (error) {
                console.log(error);
                this.setLoadingInitial(false);
            }
        }
    }

    private getActivity = (id:string) => {
        return this.activityRegistry.get(id);
    }

    private setActivity = (activity: Activity) => {
        activity.date = new Date(activity.date!);
        this.activityRegistry.set(activity.id, activity);
    }

    closeForm = () => {
        this.editMode = false;
    }

    createActivity = async (activity: Activity) => {
        this.loading = true;
        
        try {
           await agent.Activities.create(activity);
           runInAction(() => {
                this.activityRegistry.set(activity.id, activity);
                this.selectedActivity = activity;
                this.editMode = false;
                this.loading = false; 
           }) 
        } catch (error) {
            console.log(error);
            runInAction(() => {
                this.loading = false; 
           }) 
        }
    }

    updateActivity = async (activity: Activity) => {
        this.loading = true;

        try {
            await agent.Activities.update(activity);
            runInAction(() => {
                this.activityRegistry.set(activity.id, activity);
                this.selectedActivity = activity;
                this.editMode = false;
                this.loading = false; 
            }) 
         } catch (error) {
            console.log(error);
             runInAction(() => {
                 this.loading = false; 
            }) 
         }
    }

    deleteActivity = async (id:string) => {
        this.loading = true;

        try {
            await agent.Activities.delete(id);
            runInAction(() => {
                this.activityRegistry.delete(id);
                this.loading = false; 
            }) 
        } catch (error) {
            console.log(error);
             runInAction(() => {
                 this.loading = false; 
            })
        }
    }
}