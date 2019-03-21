import React, { Component } from "react";
import { Col, Row } from "react-bootstrap";
import { Link } from "react-router-dom";
import './Contacts.css';
import MapContainer from './MapContainer';
import {Map, InfoWindow, Marker, GoogleApiWrapper} from 'google-maps-react';

class Contacts extends Component {
    state = {}

    render() {
        return (
            <div>
                <Row className='contacts-title'>
                    <div className='container'>
                        <p>
                            Contacts
                        </p>
                        <hr />
                    </div>
                </Row>
                <Row className='contacts-description'>
                    <div className='container'>
                        <Col md={4}>
                            <h3 style={{ paddingBottom: '25px' }}>
                                CITYHOTEL
                            </h3>
                            <p>01030, Ukraine, Kyiv</p>
                            <p>56А, Bohdana Khmelnitskogo Str.</p>
                            <p>
                                <a className='number'>+38 044 393 59 00</a>
                            </p>
                            <p>
                                <a className='number'>+38 067 467 01 31</a>
                            </p>
                            <p>cityhotel.ua</p>
                        </Col>
                        <Col md={5} className='center'>
                            <h3 style={{ paddingBottom: '25px'}}>
                                PR & MARKETING DEPARTMENT
                            </h3>
                            <p>
                                <a className='number'>+38 097 571 44 96</a>
                            </p>
                            <p>
                                <a className='number'>+38 067 467 01 44</a>
                            </p>
                            <p>pr@cityhotel.ua</p>
                        </Col>
                        <Col md={3} className='right'>
                            <h3 style={{ paddingBottom: '25px' }}>
                                SALES DEPARTMENT
                            </h3>
                            <p>
                                <a className='number'>+38 044 393 59 13(22)</a>
                            </p>
                            <p>
                                <a className='number'>+38 067 467 01 45</a>
                            </p>
                            <p>
                                <a className='number'>+38 067 216 19 96</a>
                            </p>
                            <p>sale@cityhotel.ua</p>
                            <p>development@cityhotel.ua</p>
                        </Col>
                    </div>
                </Row>
                <Row>
                    <div className='container map' style={{height:'500px'}}>
                        <MapContainer />
                    </div>
                </Row>
            </div>
        );
    }
}
export default Contacts;