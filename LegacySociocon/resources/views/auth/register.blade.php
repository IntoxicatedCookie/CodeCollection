@extends('layouts.header')

@section('root')
@extends('browsers.check')
<div class="soscss_bg-black">

@endsection

@section('content')
<div class="container-fluid">
    <div class="row justify-content-center">
        <div class="d-flex justify-content-center">
            <div class="card" style="width: 500px; height: 650px;">
                <div class="card-header text-center"><h3><b>{{ __('Register') }}</b></h3></div>

                <div class="card-body">
                    <form method="POST" action="{{ route('register') }}">
                        @csrf

                        <div class="form-group row justify-content-md-center">
                            <label for="username" class="col-md-7 col-form-label">{{ __('Username') }}</label>

                            <div class="col-md-8">
                                <input id="username" type="text" class="form-control @error('username') is-invalid @enderror" name="username" value="{{ old('username') }}" autocomplete="username" autofocus>

                                @error('username')
                                    <span class="invalid-feedback" role="alert">
                                        <strong>{{ $message }}</strong>
                                    </span>
                                @enderror
                            </div>
                        </div>
                        

                        <div class="form-group row justify-content-md-center">
                            <label for="email" class="col-md-7 col-form-label">{{ __('Email') }}</label>

                            <div class="col-md-8">
                                <input id="email" type="email" class="form-control @error('email') is-invalid @enderror" name="email" value="{{ old('email') }}" autocomplete="email">

                                @error('email')
                                    <span class="invalid-feedback" role="alert">
                                        <strong>{{ $message }}</strong>
                                    </span>
                                @enderror
                            </div>
                        </div>

                        <div class="form-group row justify-content-md-center">
                            <label for="password" class="col-md-7 col-form-label">{{ __('Password') }}</label>

                            <div class="col-md-8">
                                <input id="password" type="password" class="form-control @error('password') is-invalid @enderror" name="password" autocomplete="new-password">

                                @error('password')
                                    <span class="invalid-feedback" role="alert">
                                        <strong>{{ $message }}</strong>
                                    </span>
                                @enderror
                            </div>
                        </div>

                        <div class="form-group row justify-content-md-center">
                            <label for="password-confirm" class="col-md-7 col-form-label">{{ __('Confirm Password') }}</label>

                            <div class="col-md-8">
                                <input id="password-confirm" type="password" class="form-control" name="password_confirmation" autocomplete="new-password">
                            </div>
                        </div>

                        <div class="form-group row justify-content-md-center">
                            <div class="col-md-5 mt-4">
                                <button type="submit" class="btn btn-primary mb-4">
                                        {{ __('Register') }}
                                </button>
                            </div>
                                @if (Route::has('login'))
                                <div class="d-flex align-items-center">
                                    <a class="btn btn-link-black" href="{{ route('login') }}">
                                        <b><i class="fas fa-sign-in-alt"></i> {{ __('Do you already have an account? Login') }}</b>
                                    </a>
                                </div>
                                @endif
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</div>
@endsection
</div>