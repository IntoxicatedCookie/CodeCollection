import React from 'react'
import { faTools } from '@fortawesome/free-solid-svg-icons'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'

function Maintenance() {
  return (
    <div className="flex flex-row justify-center mt-32 animate-fade-in">
        <div className="p-5 md:w-1/2 max-w-48 bg-[#0082FF] rounded-lg text-pale truncate">
            <FontAwesomeIcon className="mr-3" icon={faTools} /> A sheduled maintenance is coming up. <a className="text-pale" href="/maintenance/">More Details</a>
        </div>
    </div>
  )
}

export default Maintenance