import React, { useState, useContext } from 'react';
import './Search.css'
import { Link } from 'react-router-dom';
import { SearchContext } from '../../context/SearchProvider/SearchProvider';
import { GetAuction } from '../../services/AuctionSearch';
import { useNavigate } from 'react-router-dom';
const Search = () => {

    const {setSearchQuery} = useContext(SearchContext);
    const [searchText, setSearchText] = useState('');
    const {navigate} = useNavigate();

    const handleSearch = () =>{

        setSearchQuery(searchText);
        navigate("/", { state: {from: 'search'}});
    }

    return (
        <div className="search-container">
            <input id="search-input"
                   type="text"
                   placeholder="Sök på annons"
                   value={searchText}
                   onChange={(e) => setSearchText(e.target.value)}/>
                
            <button id="search-button" onClick={handleSearch}>Sök</button>
        </div>
    );

}

export default Search; 