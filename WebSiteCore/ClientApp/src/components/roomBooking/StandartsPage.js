import React, { Component } from 'react';
import RoomStandart from './RoomStandart'
import { Row } from 'react-bootstrap'

class App extends Component {
  render() {
    return (
      <div>
        <Row className='headerRow' style={{textAlign: 'center' , width: '100%'}}>
          <hr className='leftHr' width="20%" />
          <h1 className='header'>HOTEL ROOMS</h1>
          <hr className='rightHr' width="20%" />
          <hr className='rightHr' width="80%"/>
        </Row>
        <RoomStandart />
        <RoomStandart />
        <RoomStandart />
        <RoomStandart />
        <RoomStandart />
        <RoomStandart />
      </div>
    );
  }
}

export default App;
