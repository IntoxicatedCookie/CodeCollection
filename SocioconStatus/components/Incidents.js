import React from 'react'
import Box from './Box'
import { faCheckCircle, faClockRotateLeft } from '@fortawesome/free-solid-svg-icons'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'

function Services() {
  return (
    <div className="mt-16 flex flex-col items-center overflow-y-hidden">
        <h1>Incidents</h1>
          <Box extra="text-royal-red">
            <div>
              <FontAwesomeIcon className="mr-3 text-[#04bb04]" icon={faCheckCircle} /> No issues have been reported, we're all good. 
              <a className="float-right" href="/history/"><FontAwesomeIcon icon={faClockRotateLeft} /> View History</a>
            </div>
          </Box>
    </div>
  )
}

export default Services