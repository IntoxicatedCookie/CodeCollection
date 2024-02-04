<template>
    <div>
        <h1>{{ photos[random()].name}}</h1>
    </div>
</template>

<script>
    new Vue({
        el: '#app',
  data: {
    maintmsg: [
      { msg: 'Test' },
      { msg: 'Test2' },
      { msg: 'Test3' },
    ],
   },

  method: {
    random: function () {
        return Math.floor(Math.random()*2);
    },
  }
});
</script>