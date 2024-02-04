@extends('layouts.header2')

@section('title', 'Settings')
@section('content')
@extends('browsers.check')
<div class="container-fluid">
    <div class="row w-300">
        <div class="col-3 text-center">
          <h1>Settings</h1>
          <ul class="d-inline-flex flex-column pt-5 list">
            <li class="mt-3 selected"><i class="fas fa-user-circle"></i> Account</li>
            <li class="mt-3"><i class="fas fa-lock"></i> Privacy</li>
            <li class="mt-3"><i class="fas fa-globe"></i> Language</li>
            <li class="mt-3"><i class="fas fa-palette"></i> Display</li>
          </ul>
        </div>
          <div class="col-5 pl-8 pt-5">
            <form method="post" class="pt-5" enctype="multipart/form-data" action="/u/{{ $usr->tag }}/settings">
              @csrf
              @method('PATCH')
              <div class="float-left d-flex flex-column" id="pfp_form">
                <div id="pfp-wrap" class="pfp-wrap" role="button">
                  <img id="pfp" class="profile-img" draggable="false" src="{{ env('CDN') }}/data/{{ $usr->profile->pimg }}" alt="Profile picture of {{ $usr->username }}">
                  <div class="pfp-edit"><i class="fas fa-pen fa-3x"></i></div>
                </div> 
                <div class="pt-1 text-center">156x156</div>
                <div id="delete_pfp" class="text-center">Delete</div>
                <button id="save_btn" disabled type="submit" class="btn btn-primary mb-4">
                  {{ __('Save') }}
              </button>
              </form>
              <div data-toggle="modal" data-target="#deletemodal" class="mt-8">Delete account</div>
              <div class="modal fade bd-example-modal-lg" id="deletemodal" tabindex="-1" role="dialog">
                <div class="modal-dialog modal-lg" role="document">
                  <div class="modal-content">
                    <div class="modal-header">
                      <h5 class="modal-title">Delete Account</h5>
                      <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true"><i class="fas fa-times-circle"></i></span>
                      </button>
                    </div>
                    <div class="modal-body">
                      <div class="alert alert-danger" role="alert">
                        <i class="fas fa-exclamation-triangle"></i> <b>Watch out!</b> You're about to <b>permanently delete</b> your account. You cannot undo this action.<br> Please type in your password below to verify that you really want to do this.
                      </div>
                      <div class="form-group row justify-content-md-center ml-2">
                        <form method="POST" enctype="multipart/form-data" action="{{ route('register') }}">
                          @csrf
                         
                          <input id="password" type="password" class="col-md-10 form-control @error('password') is-invalid @enderror" name="password" value="{{ old('username') }}" placeholder="Verify Password" autofocus>
      
                          @error('password')
                            <span class="invalid-feedback" role="alert">
                                <strong>{{ $message }}</strong>
                            </span>
                          @enderror
                      </div>
                    </div>
                    <div class="modal-footer">
                      <button type="button" class="btn btn-primary">Delete</button>
                      <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    </div>
                  </div>
                </div>
              </div>
              </div>
              <div class="pl-5 d-flex flex-column">
                <h3 class="text-truncate pull-left"><b>{{ $usr->username }}</b></h3>
                <div><b>ID:</b> {{ $usr->uid }}</div>
                <div class="text-truncate"><b>Email:</b> {{ $usr->email ?? 'Unknown' }}</div>
                <div class="text-truncate"><b>Phone:</b> {{ $usr->phone ?? 'Phone number not set' }}</i></div>
                <a href="" data-toggle="modal" data-target="#editmodal"><i class="fas fa-pen"></i> Edit Account</a>
              </div>
          </div>

          <div class="modal fade bd-example-modal-lg" id="editmodal" tabindex="-1" role="dialog">
            <div class="modal-dialog modal-lg" role="document">
              <div class="modal-content">
                <div class="modal-header">
                  <h5 class="modal-title"><b>Edit Account</b></h5>
                  <button class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true"><i class="fas fa-times-circle"></i></span>
                  </button>
                </div>
                <div class="modal-body">
                  <form method="POST" enctype="multipart/form-data" action="{{ route('register') }}">
                    @csrf

                    <div class="form-group row justify-content-md-center ml-2">
                        <div class="col-md">
                            <label for="username" class="ml-3 col-form-label"><i class="info nw fas fa-info-circle" data-tooltip="Test"></i> {{ __('Change Username') }}</label>
                            <input id="username" type="text" class="col-md-10 form-control @error('username') is-invalid @enderror" name="username" value="{{ old('username') }}" placeholder="{{ $usr->username }}" autofocus>

                            @error('username')
                                <span class="invalid-feedback" role="alert">
                                    <strong>{{ $message }}</strong>
                                </span>
                            @enderror

                            <label for="email" class="mt-3 ml-3 col-form-label">{{ __('Change Email') }}</label>
                            <input id="email" type="email" class="col-md-10 form-control @error('email') is-invalid @enderror" name="email" value="{{ old('email') }}" placeholder="{{ $usr->email }}" autofocus>

                            @error('email')
                                <span class="invalid-feedback" role="alert">
                                    <strong>{{ $message }}</strong>
                                </span>
                            @enderror

                            <label for="phone" class="mt-3 ml-3 col-form-label">{{ __('Change Phone') }}</label>
                            <input id="phone" type="tel" class="col-md-10 form-control @error('phone') is-invalid @enderror" pattern="[0-9]{3}-[0-9]{2}-[0-9]{3}" name="phone" value="{{ old('phone') }}" placeholder="{{ $usr->phone  ?? 'Phone number not set' }}" autofocus>
    
                            @error('phone')
                                <span class="invalid-feedback" role="alert">
                                    <strong>{{ $message }}</strong>
                                </span>
                            @enderror
                        </div>
                        <div class="col-md">
                            <label for="password" class="ml-3 col-form-label">{{ __('Change Password') }}</label>
                            <input id="password" type="password" class="form-control @error('password') is-invalid @enderror" name="password" value="{{ old('password') }}" placeholder="Password" autofocus>
      
                            @error('password')
                                <span class="invalid-feedback" role="alert">
                                    <strong>{{ $message }}</strong>
                                </span>
                            @enderror

                            <label for="verifypass" class="mt-3 ml-3 col-form-label">{{ __('Verify Password') }}</label>
                            <input id="verifypass" type="password" class="form-control @error('verifypass') is-invalid @enderror" name="verifypass" value="{{ old('verifypass') }}" placeholder="Verify Password" autofocus>
      
                            @error('verifypass')
                                <span class="invalid-feedback" role="alert">
                                    <strong>{{ $message }}</strong>
                                </span>
                            @enderror
                        </div>
                      </div>
                </div>
                <div class="modal-footer">
                  <button type="submit" class="btn btn-primary">Save changes</button>
                  <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                </div>
              </form>
              </div>
            </div>
          </div>
@endsection

<script type="text/javascript">  // TODO: Convert to Vue

window.onload = function() {
  document.getElementById('pfp-wrap').addEventListener("click", importFile, false);
  // document.getElementById('pfp-wrap').addEventListener('error', errorFile, false);
  document.getElementById('delete_pfp').addEventListener("click", deleteFile, false);
};

function errorFile() {
  document.getElementById('pfp').style.borderColor = '#E50000';
  document.getElementById('pfp').style.background = '#E50000';
  document.getElementById('save_btn').disabled = true;
  document.getElementById('pfp').src = '/storage/{{ $usr->profile->pimg }}';
}

function importFile() {
  let input = document.createElement('input');
  let form = document.getElementById('pfp_form');
  input.type = 'file';
  input.name = 'pimg';
  input.accept = '.png, .jpg, .jpeg';
  input.hidden = true;
  form.parentNode.insertBefore(input, form.nextSibling);
  input.click();
  input.onchange = _ => {
  let selectedFile = input.files[0];
  let pfp = document.getElementById('pfp');

  function verifyFileExt() {
     switch(selectedFile.type.toLowerCase()) {
       case 'image/png':
       case 'image/jpeg':
          return true;
       break;
       default: return false;
     }
  } 

  if (verifyFileExt()) {
    let fileReader = new FileReader();
    let pfp = document.getElementById('pfp');
    let saveBtn = document.getElementById('save_btn');

    fileReader.onload = function() {
      pfp.src = this.result;
      saveBtn.disabled = false;
      pfp.style.borderColor = '#000';
      pfp.style.background = '#000';
      pfp.onerror = errorFile;
    };
    fileReader.readAsDataURL(selectedFile);

  } else {
    errorFile();
  };

}
}

function deleteFile() {
  let pfp = document.getElementById('pfp');
  let saveBtn = document.getElementById('save_btn');
  let form = document.getElementById('pfp_form');
  let input = document.createElement('input');
  pfp.src = '/storage/u/0.png';
  saveBtn.disabled = false;
  pfp.style.borderColor = '#000';
  pfp.style.background = '#000';
  input.type = 'text';
  input.value = '0.png';
  input.name = 'dpimg';
  input.hidden = true;
  form.parentNode.insertBefore(input, form.nextSibling);
}
  </script>