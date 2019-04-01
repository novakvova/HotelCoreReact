import { SET_OFFERS } from "../actions/types";
import { bindActionCreators } from "redux";

const initialState = {
   offers = []
  };
  
export default function offers(state=initialState, action={}) {
    switch(action.type) {
        case SET_OFFERS:
            return action.offers;
        default: return state;
    }
}