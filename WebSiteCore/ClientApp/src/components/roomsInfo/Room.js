import React, { Component } from 'react';
import { Col, Row } from 'react-bootstrap';
import { Redirect } from "react-router";
import { Link } from 'react-router-dom'

class Room extends Component {
    constructor() {
        super()
        this.state = {
            id: 1,
            Class: 'Lux',
            Price: '1000',
            Floor: '5',
            Number: '1',
            ImageSrc: 'http://www.chantosweb.com/img/rooms/city%20view.jpg',
            Bed: 'King size',
            TV: '+',
            Squere: '1000',
            Status: 'Available'
        }
    }
    imageClick = () => {

        alert("click");
    }

    render() {
        return (
            <Row>
                <hr />
                <Col md="1" >
                    <h1>{this.state.Number}</h1>
                </Col>
                <Col md="3">
                    <img src={this.state.ImageSrc} width="200" height="200" alt="img" onClick={this.imageClick} />
                </Col>
                <Col md="1">
                    <h4>Class:</h4>
                    <br />
                    <h4>Price:</h4>
                    <br />
                    <h4>Floor:</h4>
                    <br />
                    <h4>Status:</h4>
                </Col>
                <Col md="2">
                    <h4>{this.state.Class}</h4>
                    <br />
                    <h4>{this.state.Price}</h4>
                    <br />
                    <h4>{this.state.Floor}</h4>
                    <br />
                    <h4>{this.state.Status}</h4>
                </Col>
                <Col md="1">
                    <h4>Bed:</h4>
                    <br />
                    <h4>TV:</h4>
                    <br />
                    <h4>Sqr.m.:</h4>
                </Col>
                <Col md="2">
                    <h4>{this.state.Bed}</h4>
                    <br />
                    <h4>{this.state.TV}</h4>
                    <br />
                    <h4>{this.state.Squere}</h4>
                </Col>
                <Col>
                    <Link className="btn btn-primary" style={{ marginTop: '7%' }} to={`/ReserveForm/${this.state.id}`}>RESERVE</Link>
                </Col>
            </Row >
        )
    }
}

export default Room