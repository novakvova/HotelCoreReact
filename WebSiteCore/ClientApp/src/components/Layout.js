import React from 'react';
import {Grid, Row } from 'react-bootstrap';
import NavMenu from './navmenu/NavMenu';
import Footer from './footer/Footer';

export default props => (
  <Grid fluid>
    <Row>
      <NavMenu />
    </Row>
    <Row>
      {props.children}
    </Row>
    <Row>
        <Footer/>
    </Row>
  </Grid>
);
