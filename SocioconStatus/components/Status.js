import React from 'react'
import { faCheckCircle } from '@fortawesome/free-solid-svg-icons'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'

function Status() {
  return (
    <div className="flex flex-row justify-center animate-fade-in">
        <div className="mt-10 mb-10 p-5 md:w-1/2 max-w-72 bg-[#04bb04] rounded-lg text-pale shadow-2xl">
            <FontAwesomeIcon className="mr-3" icon={faCheckCircle} /> All systems are operational
        </div>
    </div>
  )
}

export default Status