import { PostBid } from "../../services/PostBid.js";
import { useState, useContext } from 'react';
import { UserContext } from "../../context/UserProvider/UserProvider";

// Denna komponent ska ingå i detaljvyn ovanför budlistan

const PlaceBid = ({auction, onUpdatePrice}) => {
    
    const [bidAmount, setBidAmount] = useState(0);
    const {user} = useContext(UserContext);

    const handleBid = () => {
        const newBid ={AuktionID:auction.auktionID, Summa:bidAmount, Budgivare:user };
        PostBid(newBid).then(() => {
            onUpdatePrice(newBid.bidAmount);
        });
        setBidAmount(0);
    }


    // Eventhandler när man trycker på knapp, kolla att budet är högre än utropspris och ev högsta bud.
    // Om det är det, plocka ihop informationen summa, auktionID och budgivare i ett object och anropa PostBid
    // Om det går bra kommer budet ha ett bud-id med sig tillbaka och kan läggas till i auktionens bidList

    // returnen ska ha en textruta som bara tar heltal och en knapp typ "Lägg bud"
    return(
        <>
        <div className="auctionview-input">
            <input id="auctionview-search-input" type="text" value={bidAmount} onChange={(e) => setBidAmount(Number(e.target.value))} placeholder="Ange bud: " />
            <button id="auctionview-search-button" onClick={handleBid}>OK</button>
        </div>
        </>    
    );
}

export default PlaceBid;