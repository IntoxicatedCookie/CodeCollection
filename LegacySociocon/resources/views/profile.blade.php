@extends('layouts.meta')

@section('title', 'Profile of ' . e($usr->username) . '')
@section('content')
@extends('browsers.check')
<div class="container-fluid">
    <div class="row w-100">
        <div class="col-3 pl-5 text-center">
          <div class="wrap">
            <img class="profile-img mt-3" draggable="false" src="{{ env('CDN') }}/data/{{ $usr->profile->pimg }}" alt="Profile picture of {{ $usr->username  }}">
             <h3 class="pt-3 mb-0 pl-1 text-truncate"><b>{{ $usr->username }}</b></h3>
             <div>{{ $usr->tag }}</div>
             @can('update', $usr->profile)
              <a href="/u/{{ $usr->tag }}/settings"><i class="fas fa-user-cog"></i> Settings</a>
             @endcan
             <hr class="soscss_hr-s">
             <div class="d-inline-flex flex-column align-items-baseline justify-content-center">
                <div class="p-1"><i class="fas fa-calendar-alt mr-2"></i> Member since {{ $usr->profile->created_at->format('j F Y') }}</div>
                <div class="p-1"><i class="fas fa-globe mr-2"></i> Active on {{ $usr->profile->platforms }} platform(s)</div>
                <div class="p-1"><i class="fas fa-clock mr-2"></i> Total of N/A hours spent</div>
              </div>
             <hr class="soscss_hr-s">
             <div class="d-inline-flex flex-column align-items-baseline justify-content-center">
              <div class="p-5"><i class="fas fa-satellite fa-3x"></i><br><br>
              There's nothing here just yet!</div>
            </div>
          </div>
        </div>
        <!-- <div class="col-8 ml-8 text-center">
          <div class="wrap banner justify-content">
            <div class="btn-circle mr-5 mb-5"><i class="fas fa-pen mt-3"></i></div>
          </div> -->
        </div>
    </div>
</div>
@endsection
