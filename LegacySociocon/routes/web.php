<?php

use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
    return view('index');
})->name('index');

Route::get('/email/verify', function () {
    return view('auth.verify-email');
})->middleware('auth')->name('verification.notice');

Route::get('/email/verify/{id}/{hash}', function (EmailVerificationRequest $request) {
    $request->fulfill();

    return redirect('/home');
})->middleware(['auth', 'signed'])->name('verification.verify');

Auth::routes(['verify' => true]);

Route::get('/u/auth', function() {
    if (!Auth::user()) {
        return redirect()->route('index');
    } else {
        return redirect()->route('profile.show', ['usr' => Auth::user()->tag]);
    }
});

Route::get('/u/{usr:tag}', 'App\Http\Controllers\ProfilesController@index')->middleware('verified')->name('profile.show');
Route::get('/u/{usr:tag}/settings', 'App\Http\Controllers\ProfilesController@edit')->middleware('verified')->name('profile.settings');
Route::patch('/u/{usr:tag}/settings', 'App\Http\Controllers\ProfilesController@update')->middleware('verified')->name('profile.update');
Route::get('/logout', 'App\Http\Controllers\Auth\LoginController@logout');
Route::get('/dapi', function () {
    return view('dapi');
});
Route::get('/privacy', function() {
    return view('addview');
});
Route::get('/updates', function() {
    return view('addview');
});
Route::post('/test', 'Test@broadcast');


// The special route... ಠ‿↼
Route::get('/nsfw', function() {
    return redirect('https://www.youtube.com/watch?v=dQw4w9WgXcQ');
});