import React, { Component } from 'react';
import { Col, Row } from 'react-bootstrap';
import SignUpForm from './SignUpForm';
import { register } from '../../../actions/authActions';
import { connect } from 'react-redux';
import PropTypes from 'prop-types';

class SignUpPage extends Component {
    render() {
        const { register }=this.props;
        return (
            <Row>
                <Col md={4} mdOffset={3} >
                    <SignUpForm  register={register}/>
                </Col>
            </Row>
        );
    }
}

SignUpForm.propTypes = {
    register: PropTypes.func.isRequired
}

export default connect(null, {register})(SignUpPage);