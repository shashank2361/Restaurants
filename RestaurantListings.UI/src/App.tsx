import React , {useState} from "react";
import { Routes, Route, Navigate } from "react-router-dom";

import { Label } from 'semantic-ui-react';
import { Navbar } from "./components/Navbar";
import { NavbarLink } from "./components/NavbarLink";
import { Stack } from "./components/Stack";

import { useAuthContext } from "./auth/authContext";
import { AuthRoot } from "./auth/AuthRoot";

import { Restaurants } from "./pages/Restaurants";

// interface IName {
//    name?: string;
// }
  function App() {
  const { isAuthenticated , authService } = useAuthContext();
  const [name , setName] = useState("");
  
  getUser() 
   
   
   async function getUser( )  {
   var result = await authService.getUser();
    console.log(result?.name)
      
      if (isAuthenticated){
        var userName = result?.name  
        if  (userName != null ){
          setName(userName)  
        }
        
      }
   }
   return (
    <>
      <Navbar>
        <NavbarLink to="/">RestaurantListings</NavbarLink>
      
        <Stack>
          {isAuthenticated ? (
            <>  <Label color ="blue">Welcome {name} </Label>
            <NavbarLink to="/auth/logout">Logout</NavbarLink>
            </> 
          ) : (         <> 
            <NavbarLink to="/auth/register">Register</NavbarLink>
            <NavbarLink to="/auth/login">Login</NavbarLink>
            </>
          )}
        </Stack>
      </Navbar>

      <Routes>
        <Route path="/" element={<Navigate to="/restaurants" />} />
        <Route path="/restaurants" element={<Restaurants />} />
        <Route path="/auth/*" element={<AuthRoot />} />
      </Routes>
    </>
  );
}

export default App;
