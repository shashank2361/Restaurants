import React , {useState} from 'react'
import { Rating } from 'semantic-ui-react'
import { Restaurant } from "../interfaces/restaurant";
import { RestaurantItemProps } from "./RestaurantItem";
import {postRestaurantsRating} from "../api/restaurants"
 import { useAuthContext } from "../auth/authContext";
 import {  useNavigate } from "react-router-dom";

export interface RatingStars{ 
 rating : number
}


export  function Ratings( props: RestaurantItemProps) {

  const navigate = useNavigate();
  const { isAuthenticated } = useAuthContext();
  const { restaurant} =  props;
  const [newRating, setRating] = useState(restaurant.rating);
 
  async function PostRating(restaurant: Restaurant) {
    const data = await postRestaurantsRating( restaurant  );
    setRating(data.rating);

  }


  const handleChangeOnRate = ( e :any ,  { rating  } : any    ) =>{
    e.preventDefault();
    if (isAuthenticated){
      var newRestaurant = {...restaurant , rating :  rating}
      console.log(newRestaurant);
      PostRating(newRestaurant )     
    }
    else{
      navigate("/auth/Login")

    }
  }
    
    return   <div>
      <Rating maxRating={5}  defaultRating = {newRating} value={newRating} onRate={handleChangeOnRate} />
   </div>
  }

 