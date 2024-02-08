import {useState, createContext} from 'react';


export const SearchContext = createContext();

const SearchProvider = (props) => {
        
        const [searchQuery, setSearchQuery] = useState("");
    
        const updateSearchQuery = (searchString) =>{
            setSearchQuery(searchString);
        }
    
        return(<SearchContext.Provider value={{ setSearchQuery: updateSearchQuery, searchQuery }}>
                {props.children}
            </SearchContext.Provider>);
}

export default SearchProvider;