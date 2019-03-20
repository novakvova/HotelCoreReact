import React, { Component } from "react";
import { Link } from "react-router-dom";
import { connect } from "react-redux";
import { Glyphicon, Nav, Navbar, NavItem, Col, Row, Carousel, Button} from "react-bootstrap";
import { LinkContainer } from "react-router-bootstrap";
import { logout } from '../../actions/authActions';
import DatePicker from 'react-datepicker'
import './NavMenu.css';
import 'react-datepicker/dist/react-datepicker.css';

class NavMenu extends Component {
  state = {}

  logout(e) {
    e.preventDefault();
    this.props.logout();
  }
  render() {
    const props = this.props;
    const { isAuthenticated, user } = this.props.auth;
    console.log(isAuthenticated);

    const userLinks = (
      <Navbar.Collapse className="justify-content-end">
        <Navbar.Text>
          {user.name} &nbsp;
                  <a href="#" onClick={this.logout.bind(this)}><Glyphicon glyph="log-out" /> Logout</a>
        </Navbar.Text>
      </Navbar.Collapse>
    );

    const guestLinks = (
      <LinkContainer to={"/login"}>
        <NavItem>
          <Glyphicon glyph="th-list" /> Login Form
            </NavItem>
      </LinkContainer>
    );
    return (
      <Navbar inverse fluid collapseOnSelect style={{ borderRadius: '0px', background:'#2E2E2E', borderColor:'#2E2E2E' }}>
        <Row className='top-line'>
          <div className='container'>
            <div className='left box'>
              <Link to='/'>
                <img src='http://cityhotel.ua/wp-content/uploads/2018/06/footer-logo1.png' />
              </Link>
            </div>
            <div className='center box' >
              <p>
                KYIV, UKRAINE
              </p>
              <p>
                56А, Bohdana Khmelnytskoho Str.
              </p>
            </div>
            <div className='right box' >
              <Link to='/'>
                <img src='http://cityhotel.ua/wp-content/uploads/2018/06/footer-logo3.png' />
              </Link>
            </div>
          </div>
        </Row>
        <Row className='language-line'>
          <Link to='/'>
            ENG
          </Link>
          <Link to='/'>
            РУС
          </Link>
          <Link to='/'>
            УКР
          </Link>
        </Row>
        <Row className='menu-line'>
          <Link to='/'>
            ROOMS
          </Link>
          <Link to='/'>
            OFFERS
          </Link>
          <Link to='/contacts'>
            CONTACTS
          </Link>
        </Row>
        <Row>
          <Carousel indicators={false} controls={false} keyboard={false}>
            <Carousel.Item>
              <img
                className="d-block w-100"
                src='/img/Img1.jpg'
                alt="First slide"
                width={'100%'} />
            </Carousel.Item>
          </Carousel>
        </Row>
        <Row className='reserve-line'>
          <div className='container'>
            <div className='box' style={{marginLeft:'330px'}}>
              <p>From</p>
            </div>
            <div className='box'>
              <DatePicker id='form_date' dateFormat='yyyy/MM/dd' className='datepicker' showTimeSelect>

              </DatePicker>
            </div>
            <div className='box'>
              <p>To</p>
            </div>
            <div className='box'>
              <DatePicker id='to_date' dateFormat='yyyy/MM/dd' className='datepicker' showTimeSelect>

              </DatePicker>
            </div>
            <div className='box'>
              <input className='button' type='button' value='BOOK NOW'/>
            </div>
          </div>
        </Row>
      </Navbar>
    );
  }
}

const mapStateToProps = (state) => {
  return {
    auth: state.auth
  };
}

export default connect(mapStateToProps, { logout })(NavMenu);