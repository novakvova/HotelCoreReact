import React, { Component } from 'react';
import { Col, Row } from 'react-bootstrap';

class Room extends Component {
    constructor() {
        super()
        this.state = {
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
                <Col md="1" align-items-center>
                    <h1>{this.state.Number}</h1>
                </Col>
                <Col md="3">
                    <img src={this.state.ImageSrc} width="200" height="200" onClick={this.imageClick} />
                </Col>
                <Col md="1">
                    <h4>Bed:</h4>
                    <br />
                    <h4>TV:</h4>
                    <br />
                    <h4>Sqr.m.:</h4>
                    <br />
                    <h4>Status:</h4>
                </Col>
                <Col md="2">
                    <h4>{this.state.Bed}</h4>
                    <br />
                    <h4>{this.state.TV}</h4>
                    <br />
                    <h4>{this.state.Squere}</h4>
                    <br />
                    <h4>{this.state.Status}</h4>
                </Col>
                <Col>
                    <input type="button" class="btn btn-success" value="Button"></input>
                </Col>
            </Row >
        )
    }
}

export default Room