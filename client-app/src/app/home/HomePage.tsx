import React from "react";
import { Link } from "react-router-dom";
import { Button, Container, Header, Segment, Image } from "semantic-ui-react";
import LoginForm from "../features/users/LoginForm";
import { useStore } from "../stores/store";

export default function HomePage() {
    const {userStore, modalStore} = useStore();
    return (
        <Segment inverted textAlign='center' vertical className='masthead' >
            <Container text>
                <Header as='h1' inverted>
                    <Image size='massive' src='/assets/logo.png' alt='logo' style={{ marginBottom: 12 }} />
                    Reactivities
                </Header>
                {userStore.isLoggedIn ?
                (
                    <>
                        <Header as='h2' inverted content='Welcome to Reactivities' />
                        <Button as={Link} to='/activities' size='huge' inverted>
                            Go to activities!
                        </Button>
                    </>
                ) : 
                (
                    <>
                        <Button onClick={() => modalStore.openModal(<LoginForm />)} size='huge' inverted>
                            Login!
                        </Button>
                        <Button onClick={() => modalStore.openModal(<h1>Register</h1>)} size='huge' inverted>
                            Register!
                        </Button>
                    </>
                    
                )}
            </Container>
        </Segment>
    )
}