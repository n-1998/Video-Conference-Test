import React from "react";
import { useSelector } from 'react-redux';
import Participant from "./participant";


const Participants = () => {

    const participants = useSelector(state => state.discussion.participants)
    return (
        <>
            {participants.map(participant => {
                <Participant participant={participant}/>
            })}
        </>
    )
}

export default Participants;