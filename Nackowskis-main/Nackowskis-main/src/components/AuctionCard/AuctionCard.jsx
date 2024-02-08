import stol from '../../assets/vitstol.jpg'
import './AuctionCard.css'
import React from 'react';
import { useNavigate, NavLink, Link } from 'react-router-dom';
import AuctionView from '../AuctionView/AuctionView';



const AuctionCard = ({ auction }) => {

    const navigate = useNavigate();
    // objektet auction har följande properties:
    //auktionID":1,
    //"titel":"Guernica av Picasso",
    //"beskrivning":"Tavla från 1937, olja på duk",
    //"startDatum":"2024-01-24T00:00:00",
    //"slutDatum":"2024-02-24T00:00:00",
    //"utropspris":250000,
    //"skapadAv":"Kalle"},
    
    
    const endDate = new Date(auction.slutDatum); 
    const timeLeft = endDate - (new Date());
    const days = Math.floor(timeLeft / (1000 * 60 * 60 * 24));
    const bidInfo = () => {
        const { bidList } = auction;
        if (!bidList || bidList.length === 0) {
            return 'Inga bud!';
        } else {
            return bidList.reverse()[0].summa + 'kr';
        }
    }

    const handleClick = () => {
        navigate("/auktion", { state: {auction}})
    }

    return (

        //<Link to={{pathname: '/auktion', state: {auction: {auction}}}}>
            <div className="auction-card" onClick={handleClick}>
                <img id="auctioncard-img" src={stol} alt="" />
                <p id="time-left">{ timeLeft > 0 ? `Tid kvar: ${days} dagar` : 'Avslutad'}</p>
                <div className="info-product">
                    <p id="titel-product">{auction.titel}</p>
                    <p id="highest-bid-product">{bidInfo()}</p>
                </div>
            </div>
        // </Link>

    );
}

export default AuctionCard; 