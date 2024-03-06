import React from 'react';

const MuteButton = ({ isAdmin, onMuteAll }) => {
    return (
        <button onClick={onMuteAll} disabled={!isAdmin}>Mute All</button>
    );
}

export default MuteButton;