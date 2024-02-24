import React from 'react'
import Banner from '../components/Banner'
import { faPersonRunning, faHouse, faHeadset, faComments } from '@fortawesome/free-solid-svg-icons'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'

function Error404() {
  return (
    <div>
      <head>
        <title>Page not found - Sociocon Status</title>
        <meta name="description" content="Statuspage of Sociocon." />
        <link rel="icon" href="/favicon.ico" />
      </head>
      <main>
        <Banner />
        <div className="mt-16 flex flex-col items-center">
          <div className="grid space-y-6 p-4 text-center md:w-1/2 max-w-20 border-royal-red border-2 rounded-lg shadow-2xl bg-pale">
              <span><FontAwesomeIcon className="text-royal-red" icon={faPersonRunning} size="5x" /></span>
              <h1>Went out for milk</h1>
              <span>The page you're looking for does not exist (anymore).<br /> Check out these options instead:</span>
              <div className="space-x-5">
                <a className="secret-link hover:text-royal-red" href="/"><FontAwesomeIcon className="text-royal-red" icon={faHouse} /> Homepage</a>
                <a className="secret-link hover:text-royal-red" href="https://support.sociocon.com"><FontAwesomeIcon className="text-royal-red" icon={faHeadset} /> Support</a>
                <a className="secret-link hover:text-royal-red" href="https://forum.sociocon.com"><FontAwesomeIcon className="text-royal-red" icon={faComments} /> Forum</a>
              </div>
          </div>
        </div>
      </main>
    </div>
  )
}

export default Error404