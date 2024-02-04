@extends('layouts.header')
@section('title', '' . env('APP_MOTTO') . '')

@section('root')
@extends('browsers.check')

@endsection

@section('content')
<div class="container-fluid g-0">
<div class="hero">
<div class="row w-100 g-0 p-5">
    <div class="col-md w-100 text-center">
      <h1>{{ env('APP_MOTTO') }}</h1>
      <div class="mt-5 mb-2">
         {{ config('app.name') }} makes the social difference in various ways. We <em>actually</em> value your privacy.<br>
         Share what you want with who you want, it's all up to you. Press the button below to see what exactly makes us one of a kind.</div>
      <a href="#benefits" class="btn circle btn-secondary mt-5 transp"><i class="fas fa-caret-down"></i></a>
    </div>
</div>
</div>
</div>
<div class="row w-100 g-0 justify-content-md-center">
  <h2 class="text-center mt-4">The four horsemen of {{ config('app.name') }}</h2>
  <div class="col-md-8 d-flex flex-sm-row col-sm-3 flex-column pt-5">
    <i class="fas fa-user-secret fa-7x"></i>
    <span class="p-5 pt-2">We do as much as possible to guarantee your privacy on the platform and outside of it. We utilise various privacy practices, read more about that <a href="/privacy">here</a>. {{ config('app.name') }} is one of the few platforms that actually values your privacy.</span>
  </div>
  <div class="col-md-8 d-flex flex-sm-row col-sm-3 flex-column pt-5">
    <i class="fas fa-shield-alt fa-7x"></i>
    <span class="p-5 pt-2">Safety is key. It's even in the word itself. Wait, no, it isn't. We've hired top notch ethical hackers to test our systems for any of the bad stuff so we can improve our security. Great, right?! Whilst we keep improving security in the background, we also have staff to keep you safe on the platform. Don't forget that there's also a lot of security settings which you can change! We take security as serious as privacy here, okay?</span>
  </div>
  <div class="col-md-8 d-flex flex-sm-row col-sm-3 flex-column pt-5" id="benefits">
    <i class="fas fa-users fa-6x"></i>
    <span class="p-5 pt-2">Despite privacy and security, the actual goal of {{ config('app.name') }} is to make people connect on a safe basis. Wanna share a video of a cat doing a wheelie with a motorcycle, sure, why not? The possibilites are endless. We just hope you have fun, meet new people or even reunite with people you haven't seen in a while, who knows. Over time, we will make it possible to connect with people in lots of ways. Which brings us to the next part!</span>
  </div>
  <div class="col-md-8 d-flex flex-sm-row col-sm-3 flex-column pt-5">
    <i class="fas fa-flask fa-8x"></i>
    <span class="p-5 pt-2">{{ config('app.name') }} will never be a finished product. There will be updates pushed out constantly, which is great because they will add more functionality and security <em>*moist*</em>. These features all get rolled out over a certain time span, we first test things out before we mess up and embarrass ourselves. And you, yes, you, can help us with that! Check out <a href="/updates">the beta program</a>. You can sign up for public beta's and give us feedback to improve.</span>
  </div>
</div>
@endsection
</div>


