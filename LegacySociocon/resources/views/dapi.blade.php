{{ json_encode([
  'resptime' => number_format((float)microtime(true) - LARAVEL_START, 3, '.', '.'),
  'ip' => request()->server('SERVER_ADDR'),
  'dapi_version' => 'v0.0.1',
]) }}