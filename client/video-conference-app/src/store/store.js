import rootReducer from './reducers/index';

const initialState = {}

const store = configureStore({
    initialState,
    reducer: rootReducer
})
  
  export default store