import React, { Component } from "react";
import { Link } from "react-router-dom";
import { connect } from "react-redux";
import { Glyphicon, Nav, Navbar, NavItem } from "react-bootstrap";
import { LinkContainer } from "react-router-bootstrap";
import { logout } from '../actions/authActions';
import "./NavMenu.css";


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
                    <Glyphicon glyph="log-in" /> Login
                </NavItem>
            </LinkContainer>
        );
        return (
            <Navbar inverse fixedTop fluid collapseOnSelect>
                <Navbar.Header>
                    <Navbar.Brand>
                        <Link to={"/"}>WebSiteCore</Link>
                    </Navbar.Brand>
                    <Navbar.Toggle />
                </Navbar.Header>
                <Navbar.Collapse>
                    <Nav>
                        <LinkContainer to={"/"} exact>
                            <NavItem>
                                <Glyphicon glyph="home" /> Home
              </NavItem>
                        </LinkContainer>
                        <LinkContainer to={"/roomsInfo"}>
                            <NavItem>
                                <Glyphicon glyph="th-list" /> Rooms
              </NavItem>
                        </LinkContainer>

                        <LinkContainer to={'/profile'}>
                            <NavItem>
                                <Glyphicon glyph='th-list' /> User Profile
          </NavItem>
                        </LinkContainer>

                        <LinkContainer to={"/users"}>
                            <NavItem>
                                <Glyphicon glyph="th-list" /> Users
              </NavItem>
                        </LinkContainer>

           <LinkContainer to={"/signUp"}>
                <NavItem>
                    <Glyphicon glyph="log-in" /> SignUp
                </NavItem>
            </LinkContainer>

                        {isAuthenticated ? userLinks : guestLinks}

                    </Nav>
                </Navbar.Collapse>
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