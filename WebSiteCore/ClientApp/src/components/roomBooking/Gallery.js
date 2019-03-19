import React, { Component } from 'react'
import './roomStyle.css'

class Gallery extends Component {
    constructor() {
        super()
        this.state = {
            imgID: 0
        }
        this.rightClickEvent = this.rightClickEvent.bind(this)
        this.leftClickEvent = this.leftClickEvent.bind(this)
    }


    rightClickEvent() {
        this.setState(prevState => {
            let imagesLength = this.props.images.length;
            if (prevState.imgID === (imagesLength - 1)) {
                return {
                    imgID: 0
                }
            }
            else {
                return {
                    imgID: prevState.imgID + 1
                }
            }
        })
    }

    leftClickEvent() {
        this.setState(prevState => {
            let imagesLength =  this.props.images.length;
            if (prevState.imgID === 0) {
                return {
                    imgID: imagesLength - 1
                }
            }
            else {
                return {
                    imgID: prevState.imgID - 1
                }
            }
        })
    }

    render() {
        return (
            <div style={{ margin: 10 }}>
                <button name='leftClick' className='leftButton' onClick={this.leftClickEvent}
                    style={{ margin: 10 }}>
                    <span className="glyphicon glyphicon-chevron-left"> </span></ button>
                <img className='galleryImg' src={ this.props.images[this.state.imgID]}
                 alt='img' width="500" height="450" />
                <button name='rightClick' className='rightButton' onClick={this.rightClickEvent}
                    style={{ margin: 10 }}>
                    <span className="glyphicon glyphicon-chevron-right"> </span></ button>
            </div>
        );
    }
}

export default Gallery