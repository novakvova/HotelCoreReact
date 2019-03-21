import React, { Component } from "react";
import { Navbar, Col, Row } from "react-bootstrap";
import { Link } from "react-router-dom";
import './Footer.css';

class Footer extends Component {
    state = {}

    render() {
        return (
            <Navbar inverse fluid collapseOnSelect style={{ borderRadius: '0px', marginBottom:'0px',background:'#2E2E2E' }} className='footer' >
                <Row>
                    <div className='footer-img'>
                        <img src='http://cityhotel.ua/wp-content/themes/cityhotel/img/footer/city-body-white.png' width='100%' />
                    </div>
                </Row>
                <Row className='footer-title-line'>
                    <p>
                        CITYHOTEL – HOTEL IN THE CENTER OF KIEV
                    </p>
                </Row>
                <Row className='footer-description-line padding'>
                    <div className='container'>
                        <Col md={4}>
                            <p>
                                CITYHOTEL — is a new and modern word in the self-expression of business hotels. Our aim is to provide you with courteous service and comfort feeling that allows to devote your time to the main purpose of your visit to Kyiv, whether it is business or tourism trip. Modern high technological equipment and professionally organized space of 124excellent rooms inCITYHOTEL solve perfectly all these problems and tasks.
                            </p>
                        </Col>
                        <Col md={4}>
                            <p>
                                A memorable featureof the hotel is a panoramic view with bottom-top windows.Restaurant Matisse located on the 15th floorof the hotel is a special thrill. All the guests are welcomed to try French and Italian cuisine in a restaurant with a breathtaking view. Magnificent delicate charm of design, natural and fashionable tones of interior create the pleasant and nice atmosphere of business meeting, romantic dinner or family banquet. There is also a lobby-bar for the fans of “relaxation cocktail”.                            </p>
                        </Col>
                        <Col md={4}>
                            <p>
                                One of the biggest advantages of CITYHOTEL is its location. The hotel is situated in the very heart of Kyiv near the most popular Khreshchatyk Streetandwithin easy reach of the major sightseeings. Whether you are coming for business purpose or visiting for pleasure and looking where to stay in Kyiv – this hotel can certainly suit your needs! But do not worry about the downtown noise.
                            </p>
                        </Col>
                    </div>
                </Row>
                <Row className='footer-img-line'>
                    <div className='container'>
                        <div className='left box'>
                            <Link to='/'>
                                <img src='http://cityhotel.ua/wp-content/uploads/2018/06/footer-logo1.png' />
                            </Link>
                        </div>
                        <div className='center box'>
                            <Link to='/'>
                                <img src='http://cityhotel.ua/wp-content/uploads/2018/06/footer-logo2-300x100.png' />
                            </Link>
                        </div>
                        <div className='right box'>
                            <Link to='/'>
                                <img src='http://cityhotel.ua/wp-content/uploads/2018/06/footer-logo3-300x50.png' />
                            </Link>
                        </div>
                    </div>
                </Row>
                <Row className='footer-description-line '>
                    <p>
                        Hotel CITYHOTEL
                    </p>
                    <p>
                        Kiev, 56А , Bohdana Khmelnytskoho str
                    </p>
                    <p>
                        +38 (044) 393-59-00
                    </p>
                </Row>
                <Row className='footer-description-line last'>
                    <p>
                        CITYHOTEL © POWERED BY CREATIVE HUB
                    </p>
                </Row>
            </Navbar>
        );
    }
}
export default Footer;