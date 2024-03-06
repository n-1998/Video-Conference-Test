import { 
    GET_DISCUSSION_DETAILS, 
    UPDATE_PARTICIPANT_SETTINGS,
    PARTICIPANTS_ADDED,
    PARTICIPANTS_LEFT
} from "../../types/virtual-discussion/discussion-types";

const initialState = {
    discussion: undefined
};

const discussionReducer = (state = initialState, action) => {
    switch (action.type) {
        case GET_DISCUSSION_DETAILS:
            return {...state, discussion: action.payload};
        case LOGOUT_DISCUSSION: 
            return {...state, discussion: undefined};
        case UPDATE_PARTICIPANT_SETTINGS:
            return {...state, /* update participants settings in state*/};
        case PARTICIPANTS_ADDED:
            return {...state, /*add participant to participants array*/}
        case PARTICIPANTS_LEFT:
            return {...state, /*remove participant to participants array*/}
        case SET_MICROPHONE_STREAM: 
            return {...state, /*update audio url in participnat */ };
        case SET_SCREEN_SHARING_STREAM: 
            return {...state, /*update screan video url url in participnat */ };
        case SET_VIDEO_STREAM: 
            return {...state, /*update video url url in participnat */ };
        default:
            return state;
    }
};

export default discussionReducer;