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

        <main>
            @yield('content')
        </main>
    </div>
</body>
</html>
