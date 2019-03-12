import React, { Component } from 'react';
import { Col, Row } from 'react-bootstrap';
import SignUpForm from './SignUpForm';

class SignUpPage extends Component {
    render() {
        return (
            <Row>
                <Col md={4} mdOffset={3} >
                    <SignUpForm />
                </Col>
            </Row>
        );
    }
}
export default SignUpPage;