import React, { useReducer, Reducer, useEffect, useState} from "react";
import styled from "@emotion/styled";
import { Segment , Image , Item, Header, Button } from 'semantic-ui-react';

import { ToggleFilter } from "./ToggleFilter";

export interface RestaurantFiltersState {
  tags: string[];
  isFamilyFriendly: boolean;
  isVeganFriendly: boolean;
    
}

export interface RestaurantFiltersProps {
    tags: string[];
    onTagsChange?: (value: RestaurantFiltersState) => unknown;
}


const FilterGroup = styled.div({
    marginBottom: "1rem",

});

const FilterTitle = styled.h4({
    marginBottom: "1rem",
    fontSize: "1.1rem",
    fontWeight: 500,
    color: "#2c2c2c",
});


type RestaurantFiltersAction =
  | { type: "toggleTag"; payload: { tag: string } }
  | { type: "toggleFamilyFriendly" }
  | { type: "toggleVeganFriendly" };



const restaurantFiltersReducer: Reducer<  RestaurantFiltersState,  RestaurantFiltersAction > = (state, action) => {
      //  return { ...state, tags: state.tags.splice(tagIndex, 1) };

      
  switch (action.type) {
      case "toggleTag": {
          const tagIndex = state.tags.indexOf(action.payload.tag);
          console.log("state", state, tagIndex   );
          if (tagIndex !== -1) {
              
              const filtertags = state.tags.filter(item => item !== action.payload.tag)
               const newstate = { ...state, tags: filtertags};
              return newstate;
          } else {

        return { ...state, tags: [...state.tags, action.payload.tag] };
      }
    }

      case "toggleFamilyFriendly": {
          var famfrstate = { ...state, isFamilyFriendly: !state.isFamilyFriendly }
          console.log(famfrstate)
          return famfrstate;
    }

    case "toggleVeganFriendly": {
           console.log("vegan" , state)
          return { ...state, isVeganFriendly: !state.isVeganFriendly };
    }

      default:
          return state;
          //throw Error();
  }
};




export function RestaurantFilters(props: RestaurantFiltersProps) {
    const { tags = [], onTagsChange } = props;


  const [state, dispatch] = useReducer(restaurantFiltersReducer, {
    tags: [],
    isFamilyFriendly: false,
    isVeganFriendly: false,
  });

    const [checkedcategory, setcheckedcategory] = useState([])


    useEffect(() => {
         onTagsChange?.(state  );
    }, [state]);
    //}, [state, onTagsChange, state.tags.length, dispatch , handleChange]);

    function handleChange (e: any, tag: string)   {
       
       
        dispatch({ type: "toggleTag", payload: { tag } })
     }
 
  
  return (
      <Segment secondary  attached ="top" left aligned  >

       <FilterGroup>
        <FilterTitle>Tags</FilterTitle>

              {tags.filter(function (value, index, array) { return array.indexOf(value) == index }).map((tag) => (
                   
                  <ToggleFilter key= {tag}
                      label={tag}
                      isChecked={state.tags.includes(tag)}
                      onToggleChange={ (e) => handleChange( e, tag  )}
                      /> 
        ))}
      </FilterGroup>

      <FilterGroup>
        <FilterTitle>Other</FilterTitle>

        <ToggleFilter
          label="Family friendly"
          isChecked={state.isFamilyFriendly}
                  onToggleChange={() => dispatch({ type: "toggleFamilyFriendly" })}
        />

        <ToggleFilter
          label="Vegan"
          isChecked={state.isVeganFriendly}
                  onToggleChange={() => dispatch({ type: "toggleVeganFriendly" })}
        />
      </FilterGroup>
    </Segment>
  );
}
//style = {{ flex: "1 0 250px" }
