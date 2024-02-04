<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\User;
use Intervention\Image\Facades\Image;

class ProfilesController extends Controller
{
    public function index(User $usr) {   
        return view('profile', compact('usr'));
    }

    public function edit(User $usr) {
        $this->authorize('update', $usr->profile);

        return view('settings', compact('usr'));
    }

    public function update(User $usr) {
        $this->authorize('update', $usr->profile);

        $data = request()->validate(
            ['pimg' => 'file']
        );

        if (!empty(request('pimg'))) {
            $img_ext = request('pimg')->getMimeType();
            switch ($img_ext) {
                case 'image/png':
                case 'image/jpeg':
                    $imgUpload_path = request('pimg')->store('u', 'cdn');
                    $img = Image::make(public_path('storage/cdn/data/' . $imgUpload_path . ''))->fit(1000, 1000);
                    $img->save();
                    $pimg = ['pimg' => $imgUpload_path];

                    auth()->user()->profile->update(array_merge(
                        $data,
                        $pimg
                    ));

                    return redirect('/u/' . $usr->tag . '/settings');
                break;
                default: return redirect()->back();
                break;
            }
        } elseif (empty(request('pimg')) && !empty(request('dpimg'))) {
            $dpimg = ['pimg' => 'u/0.png'];

            auth()->user()->profile->update($dpimg);

            return redirect('/u/' . $usr->tag . '/settings');
        } else {
            return redirect()->back();
        }
    }
}
