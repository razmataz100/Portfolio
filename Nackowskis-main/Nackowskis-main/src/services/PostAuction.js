export const NewAuction = (auction) => {
    const url = 'http://localhost:5145/api/Auktion/';
    fetch(url, {
    method: "POST",
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

export const EditAuction = (auction) => {


    const formattedAuction = {
        ...auction,
        StartDatum: auction.StartDatum.slice(0,10),
        SlutDatum: auction.SlutDatum.slice(0,10)
    }
    console.log(formattedAuction);

    const url = 'http://localhost:5145/api/Auktion/';
    fetch(url, {
    method: "PUT",
    body: JSON.stringify(formattedAuction),
    headers: {
        'Accept': 'application/json, text/plain, */*',
        'Content-Type': 'application/json'
    }
    })
    .then(response => response.json())
    .then( console.log('Request success: ', 'posten skapad'))
    .catch( error => console.log(error));
    }
