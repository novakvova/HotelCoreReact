import React, { Component } from 'react';
import Room from './Room'

class RoomsInfo extends Component {
    render() {
        return (
            <div style={{ textAlign: 'center' }}>
                <h1>Rooms</h1>
                <Room />
                <Room />
                <Room />
                <Room />
                <Room />
                <Room />
            </div>
        )
    }
}

export default RoomsInfo