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



 