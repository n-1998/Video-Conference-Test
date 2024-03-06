import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './views/App';
import store from './store/store';

const container = document.getElementById('root');
const root = ReactDOM.createRoot(container);

root.render(
  <React.StrictMode>
    <Provider store={store}>
      <App />
    </Provider>

  </React.StrictMode>
);

