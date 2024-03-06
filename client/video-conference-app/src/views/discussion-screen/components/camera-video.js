import React from "react";
import SimplePeer from 'simple-peer';
import setUpSignalRConnection from '../../../services/SignalRService';

const CameraVideo = () => {

    const [stream, setStream] = useState(null);
    const [hubConnection, setHubConnection] = useState(null);

    useEffect(() => {
        setupPeerConnection();
        setupSignalRConnection();
        
    })

    //set connection and subscribe to pear events.
    const setupSignalRConnection = () => {
    }

    const setupPeerConnection = (stream) => {
        //set connection
        //set events
        SubscribeToMessages(connection, 'stream', updateVideoUrl(videoUrl, participantId))
    }

    const cleanup = () => {
     
    };
    
    return (
        <>
            {stream && <video autoPlay src={URL.createObjectURL(user.stream)} />}
        </>
    )
}

return CameraVideo;