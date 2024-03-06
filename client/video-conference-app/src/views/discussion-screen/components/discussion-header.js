import React from "react";
import { useSelector } from 'react-redux';


const DiscussionHeader = () => {
    const {name, description, caseNumber} = useSelector(state => state.discussion); 

    return <>
        <p>{name}</p>
        <p>{description}</p>
        <p>{caseNumber} תיק מספר:</p>
    </>
}

export default DiscussionHeader;