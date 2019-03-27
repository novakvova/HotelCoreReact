import React, { Component } from 'react'
import './roomStandartStyle.css'
import { Row } from 'react-bootstrap'
import { Link } from "react-router-dom";

class RoomStandart extends Component {
    constructor() {
        super()
        this.state = {
            roomStandart: 'FAMILY STANDART',
            description: 'Family Room - a perfect solution for family travel. Room consists of a bedroom with a king-size bed and a living room with a comfortable sofa. This stylish and modern room is designed for those who spend time together but value privacy at the same time.',
            price: 230,
            img: 'https://www.regalhotel.com/uploads/rrh/accommodations/720x475/DeluxeSuite_FINAL_large.jpg',
        }
    }

    render() {
        return (
            <Row className='room-container'>
                <div className='room-content'>
                    <h3>{this.state.roomStandart}</h3>
                    <p>{this.state.description} <Link to='/room'>Details</Link></p>
                    <h4>Price: {this.state.price} EURO*</h4>
                    <Link className='btn' to='/room' >BOOK NOW</Link>
                </div>
                <div className='img-box' >
                    <img src={this.state.img}></img>
                </div>
            </Row>
        )
    }
}

export default RoomStandart