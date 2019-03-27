import React, { Component } from "react";
import { Navbar, Col, Row } from "react-bootstrap";
import { Link } from "react-router-dom";
import './Booking.css';

class Footer extends Component {
    state = {}

    render() {
        return (
            <div className='booking'>
                <Row className='booking-title'>
                    <div className='container'>
                        <p>
                            BOKKING
                        </p>
                    </div>
                </Row>
                <div className='container'>
                    <div className='box travel-data'>
                        <p>
                            TRAVEL DATA
                        </p>
                        <div>
                            <span> From </span>
                            <span> To </span>
                        </div>
                        <div>
                            <input type='text' value='03/27/2019' className='form-control box' />
                            <input type='text' value='03/27/2019' className='form-control box' />
                        </div>
                        <div className='travel-line'>
                            <i class="fa fa-male"></i>
                            <span>Number of Adults</span>
                        </div>
                        <div className='travel-line'>
                            <i class="fa fa-bed"></i>
                            <span>Number of Rooms</span>
                        </div>
                    </div>
                    <div className='box'>
                        <p>
                            BOOKING DATA
                        </p>
                    </div>
                </div>
            </div>
        );
    }
}
export default Footer;