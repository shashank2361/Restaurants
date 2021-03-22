import React, { Fragment, useCallback, useEffect, useState  , Suspense, lazy   } from "react";

import { Container ,Segment ,  Grid  } from 'semantic-ui-react';


import { getRestaurants, getRestaurantsbyTags } from "../api/restaurants";
//import { Container } from "../components/Container";
//import { RestaurantList } from "../components/RestaurantList";
 import {
  RestaurantFilters,
  RestaurantFiltersState,
} from "../components/RestaurantFilters";

import { Restaurant } from "../interfaces/restaurant";


 
const LazyRestaurantList = React.lazy(() => import('../components/RestaurantList'));

export default LazyRestaurantList as React.FC;

export function Restaurants() {
  const [tags, setTags] = useState<string[]>([]);
  const [restaurants, setRestaurants] = useState<Restaurant[]>([]);

  useEffect(() => {
    fetchRestaurants();
  }, [ ]);

    async function fetchRestaurants() {
        const data = await getRestaurants();
        setRestaurants(data);
        var datatags = data.flatMap((x) => x.tags);
        setTags(datatags.filter(function (value, index, array) { return array.indexOf(value) == index }).sort());
     }


    async function fetchRestaurantswithtags(value: RestaurantFiltersState ) {
        var datatags = await getRestaurantsbyTags(value?.tags?.toString());
        console.log(datatags)
        if (value.isFamilyFriendly) {
            datatags = datatags.filter((r) => r.familyFriendly);
        }
        if (value.isVeganFriendly) {
            datatags = datatags.filter((r) => r.veganFriendly);
        }
        setRestaurants(datatags);
         return datatags;
    }

    const handleFiltersChange = ( (value: RestaurantFiltersState) => {
  
        if (value.tags.length || value.isFamilyFriendly || value.isVeganFriendly ) {
            fetchRestaurantswithtags(value )        
        }
        else {
            fetchRestaurants()
        }
  });



    return (
      <Fragment>
          <Container left aligned doubling >
                 <Grid   columns={2}   stackable  >
                  <Grid.Row>
                        <Grid.Column width={4} style={{ minWidth: "90px" }} >
                         <RestaurantFilters tags={tags} onTagsChange={handleFiltersChange} />
                        </Grid.Column>


                      <Grid.Column width={12}>
                            <Segment.Group>
                                <Suspense fallback={<h1> Loading ....</h1>}>
                                    <LazyRestaurantList restaurants={restaurants} />
                                </Suspense>
                       
                      </Segment.Group>
            </Grid.Column>
                  </Grid.Row>
              </Grid>
           </Container>
      </Fragment>
  );
}
