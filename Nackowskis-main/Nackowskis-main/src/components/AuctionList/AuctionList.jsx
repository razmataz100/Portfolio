import { useState, useEffect, useContext } from 'react';
import { SearchContext } from '../../context/SearchProvider/SearchProvider.jsx';
import { GetAuction } from '../../services/AuctionSearch.js';
import AuctionCard from '../AuctionCard/AuctionCard.jsx';
import { fetchBidList } from '../../services/BidList.js';
import { useLocation } from 'react-router-dom';
import { UserContext } from '../../context/UserProvider/UserProvider.jsx';
import './AuctionList.css';

const AuctionList = (props) => {
    const [auctionList, setAuctionList] = useState([]);
    const { searchQuery, setSearchQuery } = useContext(SearchContext);
    const {user} = useContext(UserContext);
    const [reload, setReload] = useState(false);
    // Hämta in navigation-props och kolla så att de inte är osatta
    const {state} = useLocation();    
    const {from} = state ? state : {from: 'home'}; // Om state inte är satt, så visas sidan som från start
    
    useEffect(() => {

        const CheckReset = () => { 
        if (from === undefined) {
            console.log("from is undefined in auctionList");
            setSearchQuery('');
        } else if (from === 'logo') {
            console.log("from: logo - in auctionList");
            setSearchQuery('');
        } else if (from === 'viewMine') {
            console.log("from: View my auctions - in auctionList");
            setSearchQuery('');
        }
        
        }
        CheckReset();

    }, []);
    
    useEffect(() => {
        const fetchData = async () => {
            try {
                const data = await GetAuction();
                let filteredList = [];

                if (user && from === 'viewMine'){
                    filteredList = data.filter(auction => auction.skapadAv === user)
                    .sort((a, b) => new Date(a.slutDatum) - new Date(b.slutDatum));

                } else if (searchQuery === '') {
                    filteredList = data.filter(auction => new Date(auction.slutDatum) > new Date())
                                       .sort((a, b) => new Date(a.slutDatum) - new Date(b.slutDatum));
                } else {
                    filteredList = data.filter(auction => auction.titel.toLowerCase().includes(searchQuery.toLowerCase()))
                                       .sort((a, b) => new Date(a.slutDatum) - new Date(b.slutDatum));
                }

                const updatedList = await Promise.all(
                    filteredList.map(async auction => {
                        try {
                            const bidList = await fetchBidList(auction.auktionID);
                            return { ...auction, bidList };
                        } catch (error) {
                            console.error('Error fetching bid list:', error);
                            return auction;
                        }
                    })
                );
                // for (let auction of updatedList) {console.log(auction)}
                setAuctionList(updatedList);

            } catch (error) {
                console.error('Error fetching auctions:', error);
            }
        };

        fetchData();
    }, [searchQuery]);

    return (
        <div className='auction-list'>
            {auctionList.map((item, index) => (
            <AuctionCard key={index} auction={item} />
            ))}
        </div>
    );
};

export default AuctionList;
