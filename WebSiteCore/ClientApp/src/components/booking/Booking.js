import React, { Component } from "react";
import { Glyphicon, Col, Row } from "react-bootstrap";
import { Link } from "react-router-dom";
import './Booking.css';
import DatePicker from 'react-datepicker'
import 'react-datepicker/dist/react-datepicker.css';

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
                        <div className='datepicker-line'>
                            <input type='text' className='form-control box' placeholder="From" />
                            <input type='text' className='form-control box' placeholder="To" />
                        </div>
                        <div className='info-travel'>
                            <div className='info-line'>
                                <i class="fa fa-male"></i>
                                <span style={{ paddingLeft: '6%' }}>Number of Adults</span>
                            </div>
                            <div className='info-line'>
                                <i class="glyphicon glyphicon-bed"></i>
                                <span style={{ paddingLeft: '5%' }}>Number of Rooms</span>
                            </div>
                        </div>
                    </div>
                    <div className='box availabilities'>
                        <p>
                            AVAILABILITIES
                        </p>
                        <div className='booking-date'>
                            <DatePicker inline minDate={new Date()} selected={this.state.startDate} onChange={this.handleChange}
                             fixedHeight monthsShown={3}/>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
export default Footer;