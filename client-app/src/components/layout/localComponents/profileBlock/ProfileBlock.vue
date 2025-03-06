<template>
  <div class="profile-block">
    <span class="current-profile-item">{{ getActiveProfileName() }}</span>
    <ul class="dropdown">
      <li v-for="profile in profileNames" :key="profile">
        <a href="#">{{ profile }}</a>
      </li>
      <li><a href="#">Новый профиль</a></li>
    </ul>
  </div>
</template>
<script src="./ProfileBlock.ts"></script>
<style src="./ProfileBlock.css" scoped></style>
