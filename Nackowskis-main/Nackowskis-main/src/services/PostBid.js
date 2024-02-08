
export const PostBid = (auctionBid) => {
    return new Promise((resolve, reject) => {
        // const { auktionID } = auctionBid;
        const url = 'http://localhost:5145/api/Bud/' //+ auktionID;

        fetch(url, {
        method: "POST",
        body: JSON.stringify(auctionBid),
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        }
    })
    .then(response => response.json())
    .then(newId => { console.log(newId); auctionBid = {...auctionBid, budID: newId} })
    .then( console.log('Request success: ', 'posten skapad'));
    resolve(auctionBid);

    })
    .catch(error => {
        console.error('Error in PostBid', error);
        reject(error);
    });
    // return auctionBid;
    };
