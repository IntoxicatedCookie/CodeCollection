import Banner from '../components/Banner'
import Status from '../components/Status'
import Services from '../components/Services'
import Incidents from '../components/Incidents'


export default function Home() {
  return (
    <div>
      <head>
        <title>Sociocon Status</title>
        <meta name="description" content="Statuspage of Sociocon." />
        <link rel="icon" href="/favicon.ico" />
      </head>
      <main className="overflow-x-hidden m-0">
        <Banner />
        <Status />
        <Services />
        <Incidents />
      </main>
    </div>
  )
}
