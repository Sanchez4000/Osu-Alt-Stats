<template>
  <div>
    <div>
      <label for="client-id">ClientId: </label>
      <input type="number" name="ClientId" id="client-id" v-model="clientId" />
    </div>
    <div>
      <label for="client-secret">ClientSecret: </label>
      <input
        :type="secretFieldType"
        name="ClientSecret"
        id="client-secret"
        v-model="clientSecret"
      />
      <input
        type="checkbox"
        name="CanSeeSecret"
        id="can-see-secret"
        v-model="canSeeSecret"
      />
    </div>
    <div>
      <button type="submit" @click="save()">Сохранить</button>
    </div>
  </div>
</template>
<script src="./Settings.ts" />
<style src="./Settings.css" />
