import React from "react";

const MicrophoneAudio = ({audioUrl}) => {

    return (
        <audio controls autoPlay src={audioUrl} />
    )
}

return MicrophoneAudio;