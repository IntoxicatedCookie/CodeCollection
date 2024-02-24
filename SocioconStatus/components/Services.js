import React from 'react'
import { faCloud, faDatabase } from '@fortawesome/free-solid-svg-icons'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'

function Services() {
  return (
    <div className="mt-16 flex flex-col items-center">
        <h1>Services</h1>
        <div className="grid space-y-6 mt-10 p-4 md:w-1/2 max-w-72 border-royal-red border-2 rounded-lg shadow-2xl bg-pale">
            <div><FontAwesomeIcon className="mr-3" icon={faCloud} /> CDN <span className="float-right">Operational</span></div>
            <div><FontAwesomeIcon className="mr-3" icon={faDatabase} /> Gateway <span className="float-right">Operational</span></div>
            <div><FontAwesomeIcon className="mr-3" icon={faDatabase} /> Gateway <span className="float-right">Operational</span></div>
            <div><FontAwesomeIcon className="mr-3" icon={faDatabase} /> Gateway <span className="float-right">Operational</span></div>
        </div>
    </div>
  )
}

export default Services