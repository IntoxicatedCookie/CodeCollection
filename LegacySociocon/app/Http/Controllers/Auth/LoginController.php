<?php

namespace App\Http\Controllers\Auth;

use App\Http\Controllers\Controller;
use App\Providers\RouteServiceProvider;
use Illuminate\Foundation\Auth\AuthenticatesUsers;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

class LoginController extends Controller
{
    /*
    |--------------------------------------------------------------------------
    | Login Controller
    |--------------------------------------------------------------------------
    |
    | This controller handles authenticating users for the application and
    | redirecting them to your home screen. The controller uses a trait
    | to conveniently provide its functionality to your applications.
    |
    */

    use AuthenticatesUsers;

    /**
     * Create a new controller instance.
     *
     * @return void
     */
    public function __construct()
    {
      $this->middleware('guest')->except('logout');

      $this->username = $this->findUsername();
    }

    public function findUsername()
    {
        $login = request()->input('username');
 
        $fieldType = filter_var($login, FILTER_VALIDATE_EMAIL) ? 'email' : 'username';
 
        request()->merge([$fieldType => $login]);
 
        return $fieldType;
    }

     /**
     * Handle an authentication attempt.
     *
     * @param  \Illuminate\Http\Request $request
     * @return \Illuminate\Http\Response
     */
    public function login(Request $request)
    {
        $val_args = [
            'username' => 'required',
            'password' => 'required',
            //'captcha' => 'required' // Note: start Captcha integration
        ]; 

        $this->validate($request, $val_args);
    
        $login_type = $this->findUsername();
    
        if (Auth::attempt($request->only($login_type, 'password'))) {
            return redirect()->intended($this->redirectPath());
        }
    
        return redirect()->back()->withInput()
            ->withErrors([
                'username' => 'The entered credentials are incorrect.',
            ]);
    }
     
    public function username()
    {
        return $this->username;
    }

    /**
     * Where to redirect users after login.
     *
     * @var string
     */

    protected $redirectTo = '/u/auth';

    /**
     * Log the user out of the application.
     *
     * @param  \Illuminate\Http\Request $request
     * @return \Illuminate\Http\Response
    */
    public function logout(Request $request)
    {
        Auth::logout();

        $request->session()->invalidate();

        $request->session()->regenerateToken();
        return redirect('/');
    }
}
