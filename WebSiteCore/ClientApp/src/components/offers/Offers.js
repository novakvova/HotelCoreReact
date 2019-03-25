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
                        <img src={props.img} className='img' />
                    </Link>
                </div>
                <div className='offer-form'>
                    <div className='box'>
                        <h3 className='title'>
                            {props.title}
                        </h3>
                    </div>
                    <div className='right'>
                        <h3 className='date'>
                            Valid: {props.date}
                        </h3>
                    </div>
                    <div>
                        <p className='description'>
                            {props.description}
                        </p>
                    </div>
                    <div>
                        <h4 className='bottom-title'>
                             Special offers and discounts are not summed up.
                        </h4>
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
                <Row className='contacts-title'>
                    <div className='container'>
                        <p>
                            OFFERS
                        </p>
                    </div>
                </Row>
                <Offer img='http://cityhotel.ua/wp-content/uploads/2019/02/spring-e1551256058479.jpeg'
                    title='Spring Weekdays' date='04.03.2019 - 26.04.2019'
                    description='Great offer in CITYHOTEL! 15% OFF for accommodation on weekdays!' />
                <Offer img='http://cityhotel.ua/wp-content/uploads/2018/10/frisatsun-e1540809838517.jpeg'
                    title='FriSatSun' date='04.03.2019 - 26.04.2019'
                    description='Your discount on weekends (Fri - Sun):
                    •	1 day 15% OFF 
                    •	2-3 days 25% OFF ' />
                <Offer img='http://cityhotel.ua/wp-content/uploads/2018/09/Untitled-design-32-e1551462786800.jpeg'
                    title='Weekend Rate' date='03.03.2019 - 26.04.2019'
                    description='25% OFF for accommodation on weekend (FRI till MON)' />
            </div>
        )
    };
}
export default Offers;