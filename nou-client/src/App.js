import React, { useState, useEffect } from 'react';
import getLatestMessage from './api';

function App() {
  const [messageBody, setMessageBody] = useState('');
  const [messageUser, setMessageUser] = useState('');

  useEffect(() => {
    const interval = setInterval(() => {
      getLatestMessage()
        .then((res) => {
          setMessageBody(res.body);
          setMessageUser(res.user);
        })
        .catch((err) => {
          console.log(err);
        });
    }, 1000);
    return () => clearInterval(interval);
  }, []);

  return (
    <h1 style={{ color: 'red', fontSize: '48px' }}>
      {messageUser} says "{messageBody}"
    </h1>
  );
}

export default App;
