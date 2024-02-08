import { useState, useContext} from "react";
import { UserContext } from "../../context/UserProvider/UserProvider";
import { NewAuction, EditAuction } from "../../services/PostAuction.js";
import { useLocation } from 'react-router-dom';
import './RegisterAuction.css'

const RegisterAuction = () => {

    const {state} = useLocation();
    const {auction} = state ? state : {auction: null}; 
    const {user} = useContext(UserContext)

    const formattedStartDate = auction ? new Date(auction.startDatum).toISOString().split('T')[0] : "";
    const formattedEndDate = auction ? new Date(auction.slutDatum).toISOString().split('T')[0] : "";

    const [newArticle, setNewArticle] = useState({
        Titel: auction ? auction.titel : "",
        Beskrivning: auction ? auction.beskrivning : "",
        StartDatum: formattedStartDate,
        SlutDatum: formattedEndDate,
        Gruppkod: 100,
        Utropspris: auction ? auction.utropspris : "",
        SkapadAv: user
    });

    console.log(newArticle);
    

    const handleFormSubmit = (e) => {
        e.preventDefault();

        const currentDate = new Date();
        const formattedDate = currentDate.toISOString().split('T')[0];
       
        const article = {
            ...newArticle,
            StartDatum: newArticle.StartDatum ? newArticle.StartDatum : formattedDate
        };
    
        const postFunction = auction ? EditAuction : NewAuction;
        postFunction(auction? {...article, AuktionID: auction.auktionID} : article);

        setNewArticle({
            Titel: "",
            Beskrivning: "",
            StartDatum: "",
            SlutDatum: "",
            Gruppkod: 100,
            Utropspris: "",
            SkapadAv: user
        });   
    }
    
    return(
        <>
        <div className="container">
            <div className ="logoBackground">
                <h1 className="addAuction">Lägg till en ny auktion</h1>
            </div>
        </div>
        <div className="Form">
        <form className="form-style" onSubmit={handleFormSubmit}>
        <input type="text" className="formInput"
        value={newArticle.Titel}
        onChange={(e) => setNewArticle({...newArticle, Titel: e.target.value})}
        placeholder="Titel"
        />
        <textarea name="text" id="description" cols="30" rows="10" value={newArticle.Beskrivning}
        onChange={(e) => setNewArticle({...newArticle, Beskrivning: e.target.value})}
        placeholder="  Beskrivning">
        </textarea>
        <input type="date" className="formInput"
        value={newArticle.SlutDatum}
        onChange={(e) => setNewArticle({...newArticle, SlutDatum: e.target.value})}
        placeholder="Slutdatum"
        />
        <input type="text" className="formInput"
        value={newArticle.Utropspris}
        onChange={(e) => setNewArticle({...newArticle, Utropspris: e.target.value})}
        placeholder="Utropspris"
        />
        <button type="submit" className="submit">{auction ? 'Spara ändringar' : 'Lägg till auktion'}</button>
        </form>
        </div>
        </>
    );
}
export default RegisterAuction