<template>
  <div id="layout">
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
      <div>
        <slot></slot>
      </div>
    </div>
  </div>
</template>
<script src="./Layout.ts" />
<style src="./Layout.css" scoped />
