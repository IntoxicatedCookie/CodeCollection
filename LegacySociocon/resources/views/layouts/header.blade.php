<!doctype html>
<html lang="{{ str_replace('_', '-', app()->getLocale()) }}">
<head>
    <!-- META -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="csrf-token" content="{{ csrf_token() }}">

    <title>@yield('title') | {{ config('app.name') }}</title>
    
    <!-- CSS -->
    <link href="{{ env('CDN') }}/css/app.css" rel="stylesheet">

    <!-- JS -->
    <script src="{{ env('CDN') }}/js/app.js" defer></script>
</head>
<body>
    <div id="app">
        @yield('root')

        <nav class="navbar navbar-expand-lg navbar-light bg-primary">
          <div class="container">
            <a class="navbar-brand" href="/"><img src="{{ env('CDN') }}/assets/logo_2.svg" width="70" height="70" alt="Logo"></a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
              <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
              <ul class="navbar-nav mx-auto me-auto mb-2 mb-lg-0">
                <li class="nav-item">
                  <a class="nav-link active mx-4" aria-current="page" href="#"><i class="fas fa-home"></i> Home</a>
                </li>
                <li class="nav-item">
                  <a class="nav-link active mx-4" aria-current="page" href="#"><i class="fas fa-comments"></i> Forum</a>
                </li>
                <li class="nav-item">
                  <a class="nav-link active mx-4" aria-current="page" href="#"><i class="fas fa-life-ring"></i> Support</a>
                </li>
              </ul>
            @guest
              <ul class="navbar-nav gap-3">
                <li class="nav-item"><a href="/login" class="btn btn-secondary transp">Login</a></li>
                <li class="nav-item"><a href="/register" class="btn btn-secondary transp">Register</a></li>
              </ul>       
            @endguest
            @auth
            <div class="dropdown">
              <a class="dropdown-toggle text-secondary" role="button" id="dropdownMenuButton1" data-bs-toggle="dropdown" aria-expanded="false"><img class="m-2 rounded-circle" height="30" width="30" draggable="false" src="{{ env('CDN') }}/data/{{ Auth::user()->profile->pimg }}" alt="Profile Picture of {{ Auth::user()->username  }}"><b>{{ Auth::user()->username }}</b></a>
              <ul class="dropdown-menu dropdown-menu-end">
                <li><a href="/u/auth" class="dropdown-item"><i class="fas fa-sign-in-alt"></i> Enter</a></li>
                <li><a href="#" data-bs-toggle="modal" data-bs-target="#logout-modal" class="dropdown-item"><i class="fas fa-door-open"></i> Log Out</a></li>
              </ul> 
            </div>
            <div class="modal fade" id="logout-modal" tabindex="-1">
              <div class="modal-dialog">
                <div class="modal-content">
                  <div class="modal-header">
                    <h3 class="modal-title">You're about to leave...</h3>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"><i class="fas fa-times"></i></button>
                  </div>
                  <div class="modal-body">
                    <p class="text-center">Are you sure you want to logout from {{ config('app.name') }}?</p>
                  </div>
                  <div class="modal-footer">
                    <a role="button" class="btn btn-secondary" data-bs-dismiss="modal">Nevermind</a>
                    <a href="/logout" role="button" class="btn btn-danger">Continue</a>
                  </div>
                </div>
              </div>
            </div>
            @endauth
            </div>
          </div>
        </nav>

        <main>
            @yield('content')
        </main>
    </div>
</body>
</html>
