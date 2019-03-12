import React, { Component } from 'react';
import { Col, Row, Navbar } from 'react-bootstrap';
import './ChambermaidPage.css'


class ChambermaidForm extends Component {
    render() {
        return (
            <div className='container' style={{marginTop:'20px'}}>
                <Row>
                    <Col md={4} mdOffset={4}>
                    <div class="form-group">
                        <label for="exampleInputEmail1">Full Name</label>
                        <input type="text" class="form-control" id="input" placeholder="Enter Full Name" />
                    </div>
               
                    <div class="form-group">
                        <label for="exampleInputEmail1">Age</label>
                        <input type="text" class="form-control" id="inputAge" placeholder="Enter Age" />
                    </div>
                
                    <div class="form-group">
                        <label for="exampleInputEmail1">Email</label>
                        <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter Email" />
                        <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
                    </div>
                    <button type="submit" class="btn btn-primary">Submit</button>
                    </Col>
                </Row>
            </div>
        );
    }
}
export default ChambermaidForm;