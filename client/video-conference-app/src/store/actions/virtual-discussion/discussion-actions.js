import { 
    GET_DISCUSSION_DETAILS,
    LOGOUT_DISCUSSION,
    PARTICIPANTS_ADDED,
    PARTICIPANTS_LEFT,
    UPDATE_PARTICIPANT_SETTINGS
} from "../../types/virtual-discussion/discussion-types";

export const getDiscussionDetails = (participantId, discussionId) => {
    //make get api to get discussion details, 
    //then dispatch the result to update store
    dispatch({
        type: GET_DISCUSSION_DETAILS,
        payload: discussion
    });
};

export const logoutDiscussion = (participantId, discussionId) => {
    //api call for logout, then update store
    dispatch({
        type: LOGOUT_DISCUSSION,
    });
}

export const updateParticipantJoined = (participant) => {
    dispatch({
        type: PARTICIPANTS_ADDED,
        payload: participant
    });
}

export const updateParticipantLeft = (participantId) => {
    //api call for logout, then update store
    dispatch({
        type: PARTICIPANTS_LEFT,
        payload: participantId
    });
}

export const updateParticipantsSettings = () => {
    dispatch({
        type: UPDATE_PARTICIPANT_SETTINGS,
        payload: participantsSettings
    })
}

export const modifyAllParticipantSettings = (discussionId, changeRequest) => {
    //post request to ModifyAllParticipantSettings 
}

export const setAudioUrl = (stream, participantId) => {
    //dispatch SET_MICROPHONE_STREAM to set url to participant
}

export const setVideoUrl = (stream, participantId) => {
    //dispatch SET_VIDEO_STREAM to set url to participant
}

export const setScreenUrl = (stream, participantId) => {
    //dispatch SET_SCREEN_SHARING_STREAM to set url to participant
}
