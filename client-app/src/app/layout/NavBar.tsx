import { observer } from "mobx-react-lite";
import React from "react";
import { NavLink } from "react-router-dom";
import { Button, Container, Menu } from "semantic-ui-react";

export default observer(function NavBar() {
    return (
        <Menu fixed="top">
            <Container>
                <Menu.Item as={NavLink} to='/login' header>
                    <img src="/assets/logo.png" alt="logo" style={{marginRight: 10}}/>
                    Reactivities
                </Menu.Item>
                <Menu.Item as={NavLink} to='/activities' name="Activities" />
                <Menu.Item>
                    <Button as={NavLink} to="/createActivity" positive content='Create Activity'/>
                </Menu.Item>
                <Menu.Item>
                    <Button as={NavLink} to="/errors" name='Errors' content="Errors"/>
                </Menu.Item>
            </Container>
        </Menu>
    )
})