<template>
  <div>
    <div id="nav-bar">
      <div id="nav-bar-buttons">
        <NavBarButton :link="'/'" :label="'Home'" />
        <NavBarButton :link="'/about'" :label="'About'" />
      </div>
      <div id="user-block">
        <a :href="getAuthorizeUrl()">Авторизация</a>
      </div>
    </div>
    <div id="content">
      <h1 @click="logUserData()">Получить инфу о себе</h1>
      <slot></slot>
    </div>
  </div>
</template>
<script src="./Layout.ts" />
<style src="./Layout.css" scoped />
