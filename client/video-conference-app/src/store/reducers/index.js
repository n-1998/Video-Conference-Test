import { combineReducers } from 'redux'
import discussionReducer from './virtual-discussion/discussion-reducer';
import authenticationReducer from './authentication/authentication-reducer';

const rootReducer = combineReducers({
    discussion: discussionReducer,
    authentication: authenticationReducer
})

export default rootReducer