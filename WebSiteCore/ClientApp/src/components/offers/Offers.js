import React, { Component } from "react";
import { Link } from "react-router-dom";
import { Glyphicon, Nav, Navbar, NavItem, Col, Row, Carousel } from "react-bootstrap";
import './Offers.css';

function Offer(props) {
    return (
        <Row>
            <div className='container offer-card'>
                <div className='box'>
                    <Link to='/'>
                        <img src={props.img} />
                    </Link>
                </div>
                <div className='offer-form'>
                    <div className='box title'>
                        <p>
                            {props.title}
                        </p>
                    </div>
                    <div className='box date'>
                        <p>
                            Valid: {props.date}
                        </p>
                    </div>
                    <div className=' description'>
                        <p>
                            {props.description}
                        </p>
                    </div>
                </div>
            </div>
        </Row>
    )
}

class Offers extends Component {
    render() {
        return (
            <div className='offers'>
                <Row className='title'>
                    <div className='container'>
                        <p>
                            OFFERS
                        </p>
                    </div>
                </Row>
                <Offer img='http://cityhotel.ua/wp-content/uploads/2019/02/spring-e1551256058479.jpeg'
                    title='Spring Weekdays' date='04.03.2019 - 26.04.2019'
                    description='Great offer in CITYHOTEL! 15% OFF for accommodation on weekdays!' />
                <Offer img='http://cityhotel.ua/wp-content/uploads/2019/02/spring-e1551256058479.jpeg'
                    title='Spring Weekdays' date='04.03.2019 - 26.04.2019'
                    description='Great offer in CITYHOTEL! 15% OFF for accommodation on weekdays!' />
                <Offer img='http://cityhotel.ua/wp-content/uploads/2019/02/spring-e1551256058479.jpeg'
                    title='Spring Weekdays' date='04.03.2019 - 26.04.2019'
                    description='Great offer in CITYHOTEL! 15% OFF for accommodation on weekdays!' />
            </div>
        )
    };
}
export default Offers;