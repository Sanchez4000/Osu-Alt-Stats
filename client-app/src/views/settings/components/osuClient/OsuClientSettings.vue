<template>
  <Category name="OsuClient">
    <Field name="Client Id">
      <input type="number" v-model="clientId" />
    </Field>
    <Field name="Client Secret">
      <input type="checkbox" v-model="canSeeSecret" />
      <input :type="secretFieldType" v-model="clientSecret" />
    </Field>
    <button type="submit" @click="save()">Сохранить</button>
  </Category>
</template>
<script src="./OsuClientSettings.ts" />
