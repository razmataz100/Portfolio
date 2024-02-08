import AuctionCard from '../AuctionCard/AuctionCard';
import { Link } from 'react-router-dom';
import './AuctionView.css';
import React from 'react';
import { useLocation, useNavigate } from 'react-router-dom';
import { useContext } from 'react';
import { UserContext } from '../../context/UserProvider/UserProvider';import PlaceBid from '../PlaceBid/PlaceBid';
import { useState } from 'react';


const AuctionView = () => {

    const { state } = useLocation();
    const { auction } = state;
    console.log("AuctionView:");
    console.log(auction);
    console.log(auction.beskrivning);
    const navigate = useNavigate();
    const {user} = useContext(UserContext);
    
    const handleEdit = () => {
        navigate("/RegisterAuction", { state: {auction}})
    }

    const shortDate = `Slutdatum: ${auction.slutDatum.slice(0, -9)}`;

    const [currentPrice, setCurrentPrice] = useState(auction.Utropspris);

    const updatePrice = (newPrice) => {
        setCurrentPrice(newPrice)
    };

    return (
        <>

            <div className="auctionview-container">
                <AuctionCard auction={auction} />
                <div className="right-sidebar">


                    <div className="auctionInfo">
                        <p className="auctionview-description">{auction.beskrivning}</p>
                        <div className="auctionContainerDiv">
                            <div className="auctionDivSide"></div>
                            <div className="auctionDivMid"></div>
                            <div className="auctionDivSide"></div>
                        </div>
                        <div className="auctionview-info">
                            <p id="endDate">{shortDate}</p>
                            <br />

                            <p id="startPrice">Utropspris: {auction.utropspris} kr</p>
                        </div>

                    <div className="auctionview-input">
                        <input id="auctionview-search-input" type="text" placeholder="Ange bud: " />
                        <button id="auctionview-search-button">OK</button>
                        { user === auction.skapadAv ? <button onClick={handleEdit}>Redigera</button>: <></>}
                    </div>

                        <div className="bid-list">
                            <ul className="noBullet">
                                {auction.bidList && auction.bidList.length > 1 ? (
                                     auction.bidList.slice(1).map((bid, index) => (
                                        <li key={index}>{`Bud ${index + 1}: ${bid.summa} kr`}</li>
                                    ))
                                ) : (
                                    <p>Inga bud lagda</p>
                                )}
                            </ul>
                        </div>
                    </div>
                </div>
            </div>

        </>
    );
}

export default AuctionView;