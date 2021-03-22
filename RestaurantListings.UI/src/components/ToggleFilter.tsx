import React, { useState } from 'react'
import { Checkbox } from 'semantic-ui-react'

export interface ToggleFilterProps {
  label: string;
  isChecked?: boolean;
  onToggleChange: (isChecked: boolean) => void;
}

export function ToggleFilter(props: ToggleFilterProps) {

    const { label, isChecked = false, onToggleChange } = props;

     const handleChange = (e: any) => {
        //console.log("event 2", e.target, e.target.name, e.target.value, tagscheck)
        // settagscheck(!tagscheck)
        onToggleChange(!isChecked)
    }
   

  return (
      <div key={label}>
          <Checkbox label= {label}  type="checkbox"
                  checked={isChecked}
                  onChange={handleChange}
                  name={label}
                   style={{  padding: "2px"}} >
             
                   </Checkbox>
     </div>
  );
}



//<div>
//    <label>
//        <input
//            type="checkbox"
//            checked={isChecked}
//            onChange={() => onChange?.(!isChecked)}
//        />

//        {label}
//    </label>
//</div>


{/* <input
//id={label}
type="checkbox"
checked={isChecked}
onChange={handleChange}
name={label}
// value={tagscheck}
/>
<label> {label} </label> */}