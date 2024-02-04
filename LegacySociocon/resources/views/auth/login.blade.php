@extends('layouts.meta')
@section('title', 'Login')

@section('root')
@extends('browsers.check')

@endsection

@section('content')
<div class="container-fluid bg-secondary pb-0">
    <div class="row justify-content-center p-8">
        <div class="d-flex justify-content-center">
            <div class="card" style="width: 450px; height: 500px;">
                <div class="card-header text-center"><h3><b>{{ __('Login') }}</b></h3></div>

                <div class="card-body">
                    <form method="POST" action="{{ route('login') }}">
                        @csrf

                        <div class="form-group row justify-content-md-center">
                            <label for="username" class="col-md-7 col-form-label">{{ __('Username / Email') }}</label>

                            <div class="col-md-8">
                                <input id="username" type="text" class="form-control @error('username') is-invalid @enderror" name="username" value="{{ old('username') }}" autofocus>

                                @error('username')
                                    <span class="invalid-feedback" role="alert">
                                        <strong>{{ $message }}</strong>
                                    </span>
                                @enderror
                            </div>
                        </div>

                        <div class="form-group row justify-content-md-center">
                            <label for="password" class="col-md-7 col-form-label">{{ __('Password') }}</label>

                            <div class="col-md-8">
                                <input id="password" type="password" class="form-control @error('password') is-invalid @enderror" name="password" autocomplete="current-password">

                                @error('password')
                                    <span class="invalid-feedback" role="alert">
                                        <strong>{{ $message }}</strong>
                                    </span>
                                @enderror
                            </div>
                        </div>

                        <div class="form-group row justify-content-md-center">
                            <div class="col-md-8">
                                <div class="form-check">
                                    <input class="form-check-input" type="checkbox" name="remember" id="remember" {{ old('remember') ? 'checked' : '' }}>

                                    <label class="form-check-label" for="remember">
                                        {{ __('Remember me') }}
                                    </label>
                                </div>
                            </div>
                        </div>

                        <div class="form-group row justify-content-md-center pt-4">
                            <div class="col-md-5">
                                <button type="submit" class="btn btn-primary mb-4">
                                    {{ __('Login') }}
                                </button>
                            </div>
                                @if (Route::has('password.request') && Route::has('register'))
                                <div class="d-flex align-items-center">
                                    <a class="btn btn-link-black" href="{{ route('password.request') }}">
                                        <b><i class="fas fa-lock"></i> {{ __('Forgot your password?') }}</b>
                                    </a>
                                    <a class="btn btn-link-black" href="{{ route('register') }}">
                                        <b><i class="fas fa-user-plus"></i> {{ __('No account? Register') }}</b>
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
