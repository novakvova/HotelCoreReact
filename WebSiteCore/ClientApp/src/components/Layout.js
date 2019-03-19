import React from 'react';
import { Col, Grid, Row } from 'react-bootstrap';
import NavMenu from './navmenu/NavMenu';

export default props => (
  <Grid fluid>
    <Row>
      <NavMenu />
    </Row>
    <Row>
      {props.children}
    </Row>
  </Grid>
);
