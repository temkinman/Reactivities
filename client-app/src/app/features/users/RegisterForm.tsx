import React from "react";
import { ErrorMessage, Form, Formik } from "formik";
import { observer } from "mobx-react-lite";
import { Button, Header } from "semantic-ui-react";
import MyTextInput from "../../common/form/MyTextInput";
import { useStore } from "../../stores/store";
import { useNavigate } from "react-router-dom";
import * as Yup from 'yup';
import ValidationErrors from "../errors/ValidationErrors";

export default observer(function RegisterForm() {
    const {userStore} = useStore();
    const navigate = useNavigate();
    return (
        <Formik 
            initialValues={{displayName: '', userName: '', email: '', password: '', error: null}}
            onSubmit={(values, {setErrors, setSubmitting }) => {
                userStore.register(values)
                .then(() => navigate('/activities'))
                .catch(error =>
                    setErrors({error: error}))
                .finally(() => setSubmitting(false))
            }}
            validationSchema={Yup.object({
                DisplayName: Yup.string().required(),
                UserName: Yup.string().required(),
                Email: Yup.string().required().email(),
                Password: Yup.string().required()
            })}
        >
            {({handleSubmit, isSubmitting, errors, isValid, dirty}) => (
                <Form className="ui form error" onSubmit={handleSubmit} autoComplete='off'>
                    <Header as='h2' content='Sign up to Reactivities' color="teal" textAlign="center" />
                    <MyTextInput name="DisplayName" placeholder="Display Name" />
                    <MyTextInput name="UserName" placeholder="UserName" />
                    <MyTextInput name="Email" placeholder="Email" />
                    <MyTextInput name="Password" placeholder="Password" type="password"/>
                    <ErrorMessage name="error" render={() =>
                        <ValidationErrors errors={errors.error} />} 
                    />
                    <Button disabled={!isValid || !dirty || isSubmitting} loading={isSubmitting} positive content="Register" type="submit" fluid/>
                </Form>
            )}
        </Formik>
    )
})