import React from "react";
import "./styles.css";
import { Container } from "semantic-ui-react";
import NavBar from "./NavBar";
import ActivityDashboard from "../activities/dashboard/ActivityDashboard";
import { observer } from "mobx-react-lite";
import HomePage from "../home/HomePage";
import { Route, Routes } from "react-router-dom";
import ActivityForm from "../activities/form/ActivityForm";
import ActivityDetails from "../activities/details/ActivityDetails";

function App() {
    return (
        <>
            <NavBar />
            <Container style={{marginTop: '7em'}}>
                <Routes>
                    <Route path='/' element={<HomePage/>}/>
                    <Route path='/activities' element={<ActivityDashboard/>}/>
                    <Route path='/activities/:id' element={<ActivityDetails/>}/>
                    <Route path='/createActivity' element={<ActivityForm/>}/>
                </Routes>
            </Container>
        </>
    );
}

export default observer(App);
