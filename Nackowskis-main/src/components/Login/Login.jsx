import './Login.css'
import { useRef, useContext } from 'react';
import { UserContext } from '../../context/UserProvider/UserProvider';


const Login = () => {

    const {user, setUser} = useContext(UserContext);
    const username = useRef();
    
    const handleLogin = () => {

        setUser(username.current.value);
        console.log("logging in: ", user);
        username.current.value = '';
    };

    const handleLogout = () => {
        console.log("logging out ", user);

        setUser(null);
        console.log(user);
    }

    return(
        
        <div className="modal">
            <div className="modal-content">
                <div className="credentials" id="username-input-style">
                    { user != null ? <div id="logged-in-user">{user}</div> : <input type="text" placeholder="Username" ref={username} />}
                </div>
                <div className="credentials" id="password-input-style">
                    { user ? <div> </div> : <input type="password" placeholder="Password" /> }
                </div>
                <div className="login-button-container">
                        { user == null ? <button onClick={handleLogin} className='login-button-style'>Logga in</button> :
                                    <button onClick={handleLogout} className='login-button-style'>Logga ut</button> }
                </div>
            </div>
        </div>
        
    )
}
export default Login;