<?php

namespace App\Http\Controllers\Auth;

use App\Http\Controllers\Controller;
use App\Providers\RouteServiceProvider;
use App\Models\User;
use Illuminate\Foundation\Auth\RegistersUsers;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Facades\Validator;

class RegisterController extends Controller
{
    /*
    |--------------------------------------------------------------------------
    | Register Controller
    |--------------------------------------------------------------------------
    |
    | This controller handles the registration of new users as well as their
    | validation and creation. By default this controller uses a trait to
    | provide this functionality without requiring any additional code.
    |
    */

    use RegistersUsers;

    /**
     * Where to redirect users after registration.
     *
     * @var string
     */
    protected $redirectTo = '/u/auth';

    /**
     * Create a new controller instance.
     *
     * @return void
     */
    public function __construct()
    {
        $this->middleware('guest');
    }

    /**
     * Get a validator for an incoming registration request.
     *
     * @param  array  $data
     * @return \Illuminate\Contracts\Validation\Validator
     */
    protected function validator(array $data)
    {
        return $validator = Validator::make($data, [
            'username' => ['required', 'string', 'max:255', 'unique:users', 'not_regex:[\_]'],
            'email' => ['required', 'string', 'email', 'max:255', 'unique:users'],
            'password' => ['required', 'string', 'min:8', 'confirmed'],
        ]);
    }

    /**
     * Create a new user instance after a valid registration.
     *
     * @param  array  $data
     * @return \App\Models\User
     */
    protected function create(array $data)
    {

        function uidExists($uid) {
            return User::where('uid', $uid)->exists();
        }
    
        function genUid() {
            $uid = mt_rand(10000000000000, 99999999999999); 
            if (uidExists($uid)) {
                return genUid();
            } else {
                return $uid;
            }
        }

        function tagExists($tag) {
            return User::where('tag', $tag)->exists();
        }

        function genTag($validator_arr) {
            $nospace_uname = str_replace(' ', '_', $validator_arr['username']);
            $tag = strtolower('@' . $nospace_uname . '');

            if (tagExists($tag)) {
                return $validator->errors()->add(
                    'username', 'Tag is taken, choose4 another username'
                );
            } else {
                return $tag;
            }
        }

        return User::create([
            'uid' => genUid(),
            'tag' => genTag($data),
            'username' => $data['username'],
            'email' => $data['email'],
            'password' => Hash::make($data['password']),
        ]);
    }
}
