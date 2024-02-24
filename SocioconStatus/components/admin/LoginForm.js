

// function LoginForm() {
//   return (
//     <div className="mt-16 flex flex-col items-center">
//         <h1 className="mb-2">Login</h1>
//         <span>Please sign in to manage the statuspage.</span>
//         <form className="grid space-y-5 place-items-center mt-10 px-16 py-32 border-royal-red border-2 rounded-lg" action="/api/auth">
//           <input type="text" class="form-input px-4 py-2 rounded-lg" placeholder="Username / email" />
//           <input type="password" class="form-input px-4 py-2 rounded-lg" placeholder="Password" />
//           <input type="submit" class="form-input px-4 py-2 rounded-lg" />
//         </form>
//     </div>
//   )
// }

import { getCsrfToken, signIn } from "next-auth/react"

// export default function SignIn({ csrfToken }) {
//   return (
//     <form method="post" action="/api/auth/signin">
//       <input name="csrfToken" type="hidden" defaultValue={csrfToken} />
//       <label>
//         Email address
//         <input type="email" id="email" name="email" />
//       </label>
//       <button type="submit">Sign in with Email</button>
//     </form>
//   )
// }

export default ({ email }) => (
  <button onClick={() => signIn("email", { email })}>Sign in with Email</button>
)

// export async function getServerSideProps(context) {
//   const csrfToken = await getCsrfToken(context)
//   return {
//     props: { csrfToken },
//   }
// }

//export default LoginForm