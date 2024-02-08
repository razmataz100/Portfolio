import {Routes, Route} from 'react-router-dom';
import UserProvider from './context/UserProvider/UserProvider.jsx';
import NavigationBar from './components/NavigationBar/NavigationBar';
import AuctionList from './components/AuctionList/AuctionList.jsx';
import SearchProvider from './context/SearchProvider/SearchProvider.jsx';
import AuctionView from './components/AuctionView/AuctionView.jsx';
import RegisterAuction from './components/RegisterAuction/RegisterAuction.jsx';
import './App.css';


function App() {

  return (
    <>
    
    <div className="Background">
      <UserProvider>
        <SearchProvider>
          <NavigationBar />
            <Routes>
              <Route path="/RegisterAuction" element={<RegisterAuction />}/>
              <Route exact path="/" element={<AuctionList />} />
              <Route path="/auktion" element={<AuctionView />} />
            </Routes>
        </SearchProvider>
      </UserProvider>
    </div> 
    </>
  );
}

export default App;
