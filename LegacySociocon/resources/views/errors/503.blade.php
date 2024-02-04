<!DOCTYPE html>
<head>
   <title>Maintenance | {{ config('app.name') }}</title>
   <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<div class="container">
   <div class="text-center">
      <h1 id="maintmsg" class="pt-5"></h1><br>
      <p>It looks like there is an ongoing maintenance! Please check again later.</p>
   </div>
</div>

<script>
var msg_arr = ['Taking a coffee break.', 'Redecorating the rooms.', 'Thinking of that error...', 'Keep the data, you filthy animal!', 'Pulling some wires...'];
var msg = msg_arr[Math.floor(Math.random() * msg_arr.length)];
var maintmsg = document.getElementById('maintmsg');

maintmsg.innerHTML = msg;
</script>
