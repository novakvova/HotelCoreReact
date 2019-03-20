import React, { Component } from "react";
import { Map, InfoWindow, Marker, GoogleApiWrapper } from 'google-maps-react';

export class MapContainer extends Component {

    render() {
        return (
            <Map google={this.props.google} style={{ height: '50%', width: '50%' }} zoom={20}>
                <Marker onClick={this.onMarkerClick}
                    name={'Current location'} />
            </Map>
        );
    }
}

export default GoogleApiWrapper({
    apiKey: ('AIzaSyBjpHT87nb7l8EXmbnMPhQzKif70STme7s')
})(MapContainer)