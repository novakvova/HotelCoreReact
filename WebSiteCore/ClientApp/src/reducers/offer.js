import { SET_OFFERS } from "../actions/types";

export default function offers(state=[], action={}) {
    switch(action.type) {
        case SET_OFFERS:
            return action.offers
        default: return state;
    }
}