import React from "react";
import { useSelector } from 'react-redux';
import { updateParticipantsSettings } from "../../../store/actions/virtual-discussion/discussion-actions";

const changeType = {
    Camera: 'Camera',
    Microphone: 'Microphone',
    ShareScreen: 'ShareScreen'
}

const ActionsBar = () => {

    const user = useSelector(state => state.authentication.authenticatedUser.id)
    const discussion = useSelector(state => state.discussion)
    const {settings} = useSelector(state => 
        state.discussion.participants.find(p => p.id = user.id)
    ); 

    const handleClick = (changeType) => {
        let updatedSettings;
        switch (changeType) {
            case changeType.Microphone : updatedSettings = {...settings, isMuted: !settings.isMuted}
                initAudioStream    
                break;
            //implement for all other changes
        }
        updateParticipantsSettings(user.id, discussion.id, updatedSettings)
    }

    //set pear connection to audio/screen/video
    const initAudioStream = () => { };

    const initScreenStream = () => { };

    const initCameraStream = () => { };


    const handleMuteAllClick = () =>{
        modifyAllParticipantSettings(discussion.id, {muteAll: true})
    }

    return (
        <>
            <button onClick={() => handleClick(changeType.Camera)}>מצלמה</button>
            <button onClick={() => handleClick(changeType.Microphone)}>מיקרופון</button>
            <button onClick={() => handleClick(changeType.ShareScreen)}>שיתוף</button>
            {user.permission == 'admin' && 
                <button onClick={handleMuteAllClick()}>השתקת כל המשתתפים</button>
            }
        </>
    )
}

export default ActionsBar;