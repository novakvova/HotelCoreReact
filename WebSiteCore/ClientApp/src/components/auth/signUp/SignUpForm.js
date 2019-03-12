﻿import React, { Component } from 'react';
import classnames from 'classnames';
import { Redirect } from "react-router";

class SignUpForm extends Component {

    state = {
        name: '',
        surname: '',
        email: '',
        password: '',
        confPassword: '',
        errors: {

        },
        done: false,
        isLoading: false
    }

    setStateByErrors = (name, value) => {
        if (!!this.state.errors[name]) {
            let errors = Object.assign({}, this.state.errors);
            delete errors[name];
            this.setState(
                {
                    [name]: value,
                    errors
                }
            )
        }
        else {
            this.setState(
                { [name]: value })
        }
    }

    handleChange = (e) => {
        this.setStateByErrors(e.target.name, e.target.value);
    }

    onSubmitForm = (e) => {
        e.preventDefault();
        let errors = {};
        if (this.state.name === '') errors.name = "Can't be empty!"
        if (this.state.surname === '') errors.surname = "Can't be empty!"
        if (this.state.email === '') errors.email = "Can't be empty!"
        if (this.state.password === '') errors.password = "Can't be empty!"
        if (this.state.confPassword === '') errors.confPassword = "Can't be empty!"
        if (this.state.password !== this.state.confPassword) errors.confPassword = "Password do not match"

        const isValid = Object.keys(errors).length === 0
        if (isValid) {
            const { email, password } = this.state;
            this.setState({ isLoading: true });
            this.setState({ done: true }),
                (err) => this.setState({ errors: err.response.data, isLoading: false })
            //this.props.login({ Email: email, Password: password })
            //    .then(
            //        () => this.setState({ done: true }),
            //        (err) => this.setState({ errors: err.response.data, isLoading: false })
            //    );
        }
        else {
            this.setState({ errors });
        }
    }

    render() {
        const { errors, isLoading } = this.state;
        const form = (
            <form onSubmit={this.onSubmitForm} style={{ textAlign: 'center' }} >
                <h1>Sign Up</h1>

                {
                    !!errors.invalid ?
                        <div className="alert alert-danger">
                            <strong>Danger!</strong> {errors.invalid}.
                    </div> : ''}


                <div className={classnames('form-group', { 'has-error': !!errors.name })}>
                    <label htmlFor="name">Name</label>
                    <input type="text"
                        className="form-control"
                        id="name"
                        name="name"
                        value={this.state.name}
                        onChange={this.handleChange} />
                    {!!errors.name ? <span className="help-block">{errors.name}</span> : ''}
                </div>


                <div className={classnames('form-group', { 'has-error': !!errors.surname })}>
                    <label htmlFor="surname">Surname</label>
                    <input type="text"
                        className="form-control"
                        id="surname"
                        name="surname"
                        value={this.state.surname}
                        onChange={this.handleChange} />
                    {!!errors.surname ? <span className="help-block">{errors.surname}</span> : ''}
                </div>


                <div className={classnames('form-group', { 'has-error': !!errors.email })}>
                    <label htmlFor="email">Email</label>
                    <input type="text"
                        className="form-control"
                        id="email"
                        name="email"
                        value={this.state.email}
                        onChange={this.handleChange} />
                    {!!errors.email ? <span className="help-block">{errors.email}</span> : ''}
                </div>


                <div className={classnames('form-group', { 'has-error': !!errors.password })}>
                    <label htmlFor="password">Password</label>
                    <input type="password"
                        className="form-control"
                        id="password"
                        name="password"
                        value={this.state.password}
                        onChange={this.handleChange} />
                    {!!errors.password ? <span className="help-block">{errors.password}</span> : ''}
                </div>


                <div className={classnames('form-group', { 'has-error': !!errors.confPassword })}>
                    <label htmlFor="Confirm password">Confirm Password</label>
                    <input type="password"
                        className="form-control"
                        id="confPassword"
                        name="confPassword"
                        value={this.state.confPassword}
                        onChange={this.handleChange} />
                    {!!errors.confPassword ? <span className="help-block">{errors.confPassword}</span> : ''}
                </div>


                <div className="form-group">
                    <div className="col-md-12" >
                        <button type="submit" className="btn btn-warning"
                            disabled={isLoading}>Sign Up <span className="glyphicon glyphicon-send"></span></button>
                    </div>
                </div>
            </form>

        );
        return (
            this.state.done ?
                <Redirect to="/" /> :
                form
        );
    }
}


export default SignUpForm 