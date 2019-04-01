import axios from 'axios';
import { SET_OFFERS } from './types';

export function setOffers(offers){
    return {
        type: SET_OFFERS,
        offers
    }
}

export function fetchOffers(){
    return dispatch => {
        return axios.get('https://localhost:44342/api/offer')
        .then(res => dispatch(setOffers(res.data)))
    }
}