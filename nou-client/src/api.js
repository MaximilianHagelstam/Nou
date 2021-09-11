async function getLatestMessage() {
  const res = await fetch(`${process.env.REACT_APP_API_BASE_URI}/message`);
  return res.json();
}

export default getLatestMessage;
