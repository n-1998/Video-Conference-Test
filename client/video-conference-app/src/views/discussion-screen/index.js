import React, { useEffect } from 'react';
import Menu from './components/menu';
import DiscussionHeader from './components/discussion-header';
import { getDiscussionDetails } from '../../store/actions/virtual-discussion/discussion-actions';
import setUpSignalRConnection, { SubscribeToMessages} from '../../services/SignalRService';
import Participants from './components/participants';
import ActionsBar from './components/actions-bar';

const DiscussionScreen = ({discussionId}) => {

    useEffect(() => {
        getDiscussionDetails(discussionId);
        setSignalRConecction();
    }, [])

    const setSignalRConecction = () => {
        var connection = setUpSignalRConnection(discussionId, '/discussionhub')
        SubscribeToMessages(connection, 'ParticipantsSettingsChanged', updateParticipantsSettings)
        SubscribeToMessages(connection, 'NotifyParticipantsLeftDiscussion', updateParticipantLeft)
        SubscribeToMessages(connection, 'NotifyParticipantsJoinedDiscussion', updateParticipantJoined)
    }

    return (
        <>
            <DiscussionHeader/>
            <Menu/>
            <Participants/>
            <ActionsBar/>
        </>
    );
}
export default DiscussionScreen;