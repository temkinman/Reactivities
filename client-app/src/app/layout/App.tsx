import React from "react";
import "./styles.css";
import { Container } from "semantic-ui-react";
import NavBar from "./NavBar";
import ActivityDashboard from "../activities/dashboard/ActivityDashboard";
import { observer } from "mobx-react-lite";
import HomePage from "../home/HomePage";
import { Route, Routes, useLocation } from "react-router-dom";
import ActivityForm from "../activities/form/ActivityForm";
import ActivityDetails from "../activities/details/ActivityDetails";
import TestErrors from "../features/errors/TestError";
import { ToastContainer } from "react-toastify";
import NotFound from "../features/errors/NotFound";
import ServerError from "../features/errors/ServerError";

function App() {
    const location = useLocation();
    return (
        <>
            <ToastContainer position="bottom-right" hideProgressBar />
            <NavBar />
            <Container style={{marginTop: '7em'}}>
                <Routes>
                    <Route path='/activities' element={<ActivityDashboard/>}/>
                    <Route path='/activities/:id' element={<ActivityDetails/>}/>
                    <Route key={location.key} path={'/createActivity'} element={<ActivityForm/>}/>
                    <Route key={location.key} path={'/manage/:id'} element={<ActivityForm/>}/>
                    <Route path={'/errors'} element={<TestErrors/>}/>
                    <Route path={'/server-error'} element={<ServerError/>}/>
                    <Route path="/*" element={<NotFound/>} />
                </Routes>
            </Container>
        </>
    );
}

export default observer(App);
