import './NavigationBar.css'
import { NavLink, useNavigate } from 'react-router-dom';
import Search from '../Search/Search';
import Login from '../Login/Login';
import {useContext} from 'react';
import {UserContext} from '../../context/UserProvider/UserProvider';


const NavigationBar = () => {

    const {user} = useContext(UserContext);
    
    
    // Gör detta för att navigera från knappar (plus import useNavigate)
    const navigate = useNavigate();

    const viewMine = () => {
        if (user) {
            console.log("Visa mina avsändare NavBar!");
            navigate("/", { state: {from: 'viewMine'}});
        }
    }

    const registerNew = () => {
        if (user) {
            console.log("registrera ny avsändare NavBar");
            navigate("/RegisterAuction", { state: {auction: null}})
        }
    }

    return(
        <>
        <nav className="navBar">
                <Login />
                    <div className="logoContainer">
                        <NavLink to={"/"} state={{from: 'logo'}}><h2 className="Logo">Nackowskis</h2></NavLink>
                    </div>
                    <div className="wrapper">
                        <Search />
                            <div className="Options">
                                
                                { user ? <button className="Register" onClick={registerNew}>Registrera ny auktion</button> : <></> }
                                { user ? <button className="myAuctions" onClick={viewMine}>Mina auktioner</button> : <></> }
                            </div>
                    </div>
        
        </nav>
        </>
    );
}
export default NavigationBar;