import React, { Component } from "react";
import { Link } from "react-router-dom";
import { connect } from "react-redux";
import { Glyphicon, Nav, Navbar, NavItem, Col, Row, Carousel } from "react-bootstrap";
import { LinkContainer } from "react-router-bootstrap";
import { logout } from '../../actions/authActions';
import DatePicker from 'react-datepicker'
import './NavMenu.css';
import 'react-datepicker/dist/react-datepicker.css';
import NumericInput from 'react-numeric-input';
import 'font-awesome/css/font-awesome.min.css';

class NavMenu extends Component {
  constructor(props) {
    super(props);
    this.state = {
      date_To: new Date(),
      date_From: new Date()
    }
  }

  // від 22 строкі до 31 треба оптимізувати можливо можна одим евентом зробить
  from_dateChange = (date) => {
    this.setState({
      date_From: date,
      date_To: date
    });
  }
  to_dateChange = (date) => {
    this.setState({
      date_To: date
    });
  }

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
      <Navbar inverse fluid collapseOnSelect style={{ borderRadius: '0px', background: '#2E2E2E', borderColor: '#2E2E2E' }}>
        <Row className='top-line'>
          <div className='container'>
            <div className='left box'>
              <i className="fas fa-apple-alt" size={15}></i>
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
          <div className='drop'>
            <Link to='/' className='drop-btn'>
              ROOMS
                <Glyphicon glyph='glyphicon glyphicon-triangle-bottom' />
            </Link>
            <div className="drop-content">
              <Link to='/room' >
                ROOMS 1 asdasdas
              </Link>
              <Link to='/room'>
                ROOMS 2 asdasdas
              </Link>
              <Link to='/room'>
                ROOMS 3 asdasdas
              </Link>
            </div>
          </div>
          <Link to='/offers'>
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
            <div className='box' style={{ marginLeft: '25%'}}>
              <p>From</p>
            </div>
            <div className='box'>
              <DatePicker id='from_date' className='datepicker' minDate={new Date()}
                selected={this.state.date_From} onChange={this.from_dateChange} dateFormat="dd/MM/yyyy" />
            </div>
            <div className='box'>
              <p>To</p>
            </div>
            <div className='box'>
              <DatePicker id='to_date' className='datepicker' minDate={this.state.date_From}
                selected={this.state.date_To} onChange={this.to_dateChange} dateFormat="dd/MM/yyyy" />
            </div>
            <div className='box'>
              <i className="fa fa-users"></i>
                <NumericInput className='numeric'/>              
            </div>
            <div className='box'>
              <input className='button' type='button' value='BOOK NOW' />
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