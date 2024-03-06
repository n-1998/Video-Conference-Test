import {
  LOGIN_REQUEST,
  LOGIN_FAILURE,
  LOGIN_SUCCEEDED,
  CLEAR_LOGIN_DETAILS,
} from '../../types/authentication/authentication-types'

const authenticationReducer = (action = {}, state = {}) => {
  switch (action.type) {
    case LOGIN_REQUEST:
      return { ...state, loginRequest: true }
    case LOGIN_SUCCEEDED:
      return {
        ...state,
        authenticatedUser: action.payload.user,
        authenticationToken: action.payload.token,
        isUserAuthenticated: true,
      }
    case LOGIN_FAILURE:
      return {
        ...state,
        loginError: action.payload,
        isUserAuthenticated: false,
        loginErrorOccurred: true,
      }
    case CLEAR_LOGIN_DETAILS:
      return {
        ...state,
        authenticationToken: null,
        isUserAuthenticated: null,
        loginErrorOccurred: null,
      }
    default:
      return state
  }
}

export default authenticationReducer;
