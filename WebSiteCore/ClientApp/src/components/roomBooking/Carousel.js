import React from 'react';
import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";
import Slider from "react-slick";

class Carousel extends React.Component {

  setImages() {
    let allImages = []

    this.props.images.forEach(imgUrl => {
      allImages.push(
        <div>
          <img src={imgUrl}
            width='250' height='200' alt='img'></img>
        </div>
      )
    });
    return allImages
  }

  render() {
    var settings = {
      dots: true,
      infinite: true,
      slidesToShow: 4,
      slidesToScroll: 4,
      speed: 500,
    };
    return (
      <Slider {...settings}>
        {this.setImages()}
      </Slider>
    );
  }
}

export default Carousel