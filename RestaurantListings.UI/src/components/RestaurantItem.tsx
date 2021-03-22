import { Restaurant } from "../interfaces/restaurant";
import  {Ratings}  from "./Ratings"
import { Segment ,  Grid ,Image , Item, Header, Button } from 'semantic-ui-react';

export interface RestaurantItemProps {
  restaurant: Restaurant;
  
}




export function RestaurantItem(props: RestaurantItemProps) {
  const { restaurant    } = props;
    return (
        <Segment clearing key={ restaurant.id} >
        <Segment>
            <Item.Group>
                   <Item>
                   <Image size='medium' style={{ maxHeight: '20rem' , maxWidth:'23rem'}} className="photo-img"  src={restaurant.photoUri} fluid/>
          <Item.Content>
                            <Header  size='medium' >{restaurant.name}
                               <Ratings   restaurant = {restaurant}/>
                            </Header>
                            <div className="meta">{restaurant.address}</div>
              <div className="description">{restaurant.description}</div>
              <div className="description">{restaurant.phoneNumber}</div>
          </Item.Content>
                </Item>
            </Item.Group>
            </Segment>
        </Segment>
  );
}

//style = {{ float: "left" }}
