export const SubscribeToMessages = (connection, eventName, action) => {

    connection.on(eventName, (message) => {
        action(message);
    });
}


const setUpSignalRConnection = async (discussionId, url) => {
    //Dodo: define connection 
    return connection;
};

export default setUpSignalRConnection;