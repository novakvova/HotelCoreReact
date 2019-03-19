import React, { Component } from 'react';
import { Col, Row } from 'react-bootstrap';
import { Redirect } from "react-router";
import { Link } from 'react-router-dom'
import './roomStyle.css'
import Carousel from './Carousel'
import Gallery from './Gallery'

class Room extends Component {
    constructor() {
        super()
        this.state = {
            roomStandart: 'Family Standart',
            price: 140,
            totalArea: 100,
            bed: '200X200 cm (height mattress - 40 cm)',
            description: 'Family Room - a perfect solution for family travel. Room consists of a bedroom with a king-size bed and a living room with a comfortable sofa. This stylish and modern room is designed for those who spend time together but value privacy at the same time.',
            equipment: 'bathroom with shower, luggage stand, central air conditioning, WI-FI (free of charge), direct local/international connection, mini-safe, mini bar, LED TV, kettle, tea/coffee sets, mineral water, a set of mini cosmetics, bath accessories, bathrobe, hair dryer.',
            images: [
                // 'https://t-ec.bstatic.com/images/hotel/max1024x768/546/54686729.jpg',
                // 'https://cdn.ostrovok.ru/t/640x400/content/6d/42/6d42ff9aa6b026f3dc033b76675a0712a286ab12.jpeg',
                // 'https://s-ec.bstatic.com/images/hotel/max1024x768/130/130850553.jpg',
                // 'http://www.orangesmile.com/common/img_final_large/dubai_sightseeing.jpg',
                // 'https://www.ahstatic.com/photos/6146_ho_00_p_2048x1536.jpg',
                // 'https://lookinhotels.ru/data/public/1795/28043/dubai-burj-al-arab-hotel-1920x1080-wallpaper-8568.jpg',
                // 'https://s-ec.bstatic.com/images/hotel/max1024x768/731/73118462.jpg'
            ]
        }
    }
    imageClick = () => {

        alert("click");
    }

    render() {
        return (
            <div>
                <Row className='mainContent'>
                    <Row>
                        <a className='link' to=''>Main page</a>
                        <p>/ {this.state.roomStandart}</p>
                    </Row>
                    <Row className='standartsRow'>
                        <Link className='standarts' style={{ marginLeft: '15mm' }} to=''>SINGLE STANDART</Link>
                        <Link className='standarts' to=''>DBL STANDART</Link>
                        <Link className='standarts' to=''>TWIN STANDART</Link>
                        <Link className='standarts' to=''>SUPERIOR</Link>
                        <Link className='standarts' to=''>STUDIO DOUBLE</Link>
                        <Link className='standarts' to=''>FAMILY STANDART</Link>
                        <Link className='standarts' to=''>JUNIOR SUITE</Link>
                    </Row>
                    <Row className='headerRow'>
                        <hr className='leftHr' width="20%" />
                        <h1>{this.state.roomStandart}</h1>
                        <hr className='rightHr' width="20%" />
                    </Row>
                    <Row>
                        <Col md='7'>
                           <Gallery images = {this.state.images} />
                        </Col>
                        <Col md='5'>
                            <h4>Price: <b>{this.state.price} €</b></h4>
                            <h4>Total area: {this.state.totalArea} m²</h4>
                            <h4>Bed: {this.state.bed}</h4>
                            <button className='bookNowButton'>BOOK NOW</button>
                            <h4>{this.state.description}</h4>
                        </Col>
                    </Row>
                    <Row>
                        <h4>Room equipment: {this.state.equipment}</h4>
                    </Row>
                    <Row>
                        <div className='galaryDiv'>
                            <Carousel images = {this.state.images} />
                        </div>
                        <h5>* Payment is accepted in national currency (UAH) according to the official NBU rate on the day of payment.</h5>
                    </Row>
                </Row>
            </div>
        )
    }
}

export default Room