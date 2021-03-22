import { Console } from "console";
import { Restaurant } from "../interfaces/restaurant";

export async function getRestaurants(): Promise<Restaurant[]> {

  const res = await fetch("api/restaurants");
 
  return await res.json();
}


export async function getRestaurantsbyTags(body : string ): Promise<Restaurant[]> {
     const res = await fetch("api/restaurants/GetbyTags?tags=" + body, )  ;
    return await res.json();
}


export async function postRestaurantsRating( data :Restaurant ): Promise<Restaurant> {
 
 
  const res = await fetch("api/restaurants/" + data.id, {
    method: 'Put', // *GET, POST, PUT, DELETE, etc.
    mode: 'cors', // no-cors, *cors, same-origin
    cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
    credentials: 'same-origin', // include, *same-origin, omit
    headers: {
      'Content-Type': 'application/json'
      // 'Content-Type': 'application/x-www-form-urlencoded',
    },
    redirect: 'follow', // manual, *follow, error
    referrerPolicy: 'no-referrer', // no-referrer, *no-referrer-when-downgrade, origin, origin-when-cross-origin, same-origin, strict-origin, strict-origin-when-cross-origin, unsafe-url
    body: JSON.stringify(data) // body data type must match "Content-Type" header
  });
    
 return await res.json();
}

 