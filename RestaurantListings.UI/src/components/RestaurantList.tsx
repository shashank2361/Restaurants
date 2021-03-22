import React, { Fragment } from "react";

import { Restaurant } from "../interfaces/restaurant";
import { RestaurantItem } from "./RestaurantItem";

export interface RestaurantListProps {
  restaurants?: Restaurant[];
}

 function RestaurantList(props: RestaurantListProps) {
  const { restaurants = [] } = props;

 
  return (
      <Fragment>

      {restaurants.map((restaurant) => (
          <RestaurantItem key={restaurant.id }restaurant={restaurant} />
      ))}
      </Fragment>
  );
}
export default RestaurantList;
