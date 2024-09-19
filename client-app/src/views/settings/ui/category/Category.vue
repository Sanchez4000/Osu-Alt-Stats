<template>
  <div class="category">
    <h1 class="category-name">{{ name }}</h1>
    <div class="category-content">
      <slot></slot>
    </div>
  </div>
</template>
<script src="./Category.ts" />
<style src="./Category.css" scoped />
