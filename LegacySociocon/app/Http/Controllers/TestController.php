<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

use App\Events\Test;

class MessageController extends Controller
{
    public function broadcast(Request $request) {

        if (! $request->filled('message')) {
            return response()->json([
                'message' => 'No message to send'
            ], 422);
        }

        // TODO: Sanitize input

        event(new Test($request->message, $request->user));

        return response()->json([], 200);

    }
}