import React from 'react'

function Box(props) {
  return (
    <div className={"grid space-y-6 p-4 text-center md:w-1/2 max-w-20 border-royal-red border-2 rounded-lg shadow-2xl bg-pale" + props.extra}>
        {props.children}
    </div>
  )
}

export default Box