import React, { Component } from 'react';
import { Col, Row } from 'react-bootstrap';
import './ChambermaidPage.css'

function Chambermaid(props) {
    return (
        <Row style={{ marginBottom: '50px' }}>
        <hr/>
            <Col md='3'>
                <img src={props.img} width='250px' />
            </Col>
            <div className='info'>
                <Col md="2">
                    <h4>Full Name: </h4>
                    <br />
                    <h4>Rooms to clean: </h4>
                    <br />
                    <h4>Ready rooms: </h4>
                    <br />
                    <h4>Cleanning type: </h4>
                </Col>
                <Col md='2'>
                    <div>
                        <h4>{props.fullName}</h4>
                        <br />
                        <h4>{props.roomsToClean}</h4>
                        <br />
                        <h4>{props.readyRooms}</h4>
                        <br />
                        <h4>{props.cleaningType}</h4>
                    </div>
                </Col>
            </div>
        </Row>
    )
}
class ChambermaidPage extends Component {
    render() {
        return (
            <div className='container'style={{marginTop:'25px'}}>
                <Chambermaid img='https://cdn3.iconfinder.com/data/icons/users-6/100/654854-user-women-512.png'
                    fullName='Korniychuk Olya' roomsToClean='10,20,30' readyRooms='1,4,9'
                    cleaningType='Full' />
                <Chambermaid img='https://cdn3.iconfinder.com/data/icons/users-6/100/654854-user-women-512.png'
                    fullName='Ivanova Tanya' roomsToClean='5,6,36' readyRooms='3,45,29'
                    cleaningType='Easy' />
                <Chambermaid img='https://cdn3.iconfinder.com/data/icons/users-6/100/654854-user-women-512.png'
                    fullName='Ivanova Tanya' roomsToClean='5,6,36' readyRooms='3,45,29'
                    cleaningType='Easy' />
            </div>

        );
    }
}
export default ChambermaidPage;