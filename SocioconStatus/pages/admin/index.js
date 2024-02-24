import LoginForm from '../../components/admin/LoginForm'

export default function Home() {
  return (
    <div>
      <head>
        <title>Login - Sociocon Status</title>  
        <link rel="icon" href="/favicon.ico" />
      </head>
      <main className="overflow-x-hidden m-0">
        <LoginForm />
      </main>

      <footer>
      </footer>
    </div>
  )
}
