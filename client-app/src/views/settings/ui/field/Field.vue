<template>
  <div class="field">
    <div class="name">
      <span>{{ name }}</span>
    </div>
    <div class="edit-tool">
      <div><slot></slot></div>
    </div>
  </div>
</template>
<script src="./Field.ts" />
<style src="./Field.css" scoped />
