import React from 'react';

const Participant = (props) => {
    const  { name, role, settings, videoUrl, screanUrl, audioUrl } = props;
    return (
        <div>
            <h3>{name}</h3>
            <p>{role}</p>
            {settings.showVideo && <CameraVideo url={videoUrl}/>}
            {!settings.isMuted &&<MicrophoneAudio url={audioUrl}/>}
            {settings.isSharing &&<ScreenSharing url={screanUrl}/>}
            
            {settings.isMuted? <MicrophoneOffIcon/> : <MicrophoneIcon/>}
        </div>
    );
}

export default Participant;