<template>
  <div id="app">
    <img src="./assets/logoUNRI.png" height="75" width="550">
    <web-toolbar>
      <web-home>
        <web-login></web-login>
      </web-home>
    </web-toolbar>
    <router-view/>
    <web-footer></web-footer>
  </div>
</template>

<script>
import WebToolbar from './components/WebToolbar.vue'
import WebHome from './components/WebHome.vue'
import WebFooter from './components/WebFooter.vue'
import WebLogin from './components/WebLogin.vue'

export default {
  name: 'App',
  components:{WebToolbar, WebLogin, WebHome, WebFooter}
}
</script>

<style>
</style>
