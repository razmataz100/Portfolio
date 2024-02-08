
export const DeleteAuction = (auction) => {
    const {auktionID} = auction;
    const url = 'http://localhost:5145/api/aktion/100/' + auktionID;
    fetch(url, {
    method: "DELETE",
    body: JSON.stringify(auction),
    headers: {
        'Accept': 'application/json, text/plain, */*',
        'Content-Type': 'application/json'
    }
    })
    .then(response => response.json())
    .then( console.log('Request success: ', 'posten skapad'))
    .catch( error => console.log(error));
    }