import axios, { AxiosError, AxiosResponse } from "axios";
import { toast } from "react-toastify";
import { Activity } from "../models/activity";
import { store } from "../stores/store";

axios.defaults.baseURL = 'https://localhost:7115/api';

axios.interceptors.response.use(async response => {
    //await sleep(500);
    return response;
}, (error: AxiosError) => {
    const {data, status, config} = error.response as AxiosResponse;
    console.log(data)

    switch(status) {
        case 400:
            if(typeof data === 'string') {
                toast.error(data);
            }

            if (config.method === 'get' && data.errors.hasOwnProperty('id')) {
                window.location.href = '/not-found';
            }
            if (data.errors) {
                const modalStateErrors = [];
                for (const key in data.errors) {
                    if (data.errors[key]) {
                        console.log(data.errors[key]);
                        modalStateErrors.push(data.errors[key])
                    }
                }
                throw modalStateErrors.flat() 
                // console.log('result', result)
            }
            break;
        case 401:  
            toast.error('unauthorised')
            break;
        case 403:
            toast.error('forbidden')
            break;
        case 404:
            toast.error('not found');
            console.log('404....')
            break;
        case 500:
            console.log('in case 500', data);
            store.commonStore.setServerError(data);
            window.location.href = '/server-error';
            //return redirect('/server-error');
            break;
    }
})

const responseBody = <T> (response: AxiosResponse) => response.data;

const requests = {
    get: <T> (url: string) => axios.get<T>(url).then(responseBody),
    post: <T> (url: string, body: {}) => axios.post<T>(url, body).then(responseBody),
    put: <T> (url: string, body: {}) => axios.put<T>(url, body).then(responseBody),
    del: <T> (url: string) => axios.delete<T>(url).then(responseBody)
}

const Activities = {
    list: () => requests.get<Activity[]>('/activities'),
    details: (id: string) => requests.get<Activity>(`/activities/${id}`),
    create: (activity: Activity) => requests.post<void>('/activities', activity),
    update: (activity: Activity) => requests.put<void>(`activities/${activity.id}`, activity),
    delete: (id: string) => requests.del<void>(`/activities/${id}`)
}

const agent = {
    Activities
}

const sleep = (delay: number) => {
    return new Promise((resolve) => {
        setTimeout(resolve, delay);
    })
}

export default agent;