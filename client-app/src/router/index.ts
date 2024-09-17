import { createRouter, createWebHistory, RouteRecordRaw } from "vue-router";
import HomeView from "../views/HomeView.vue";
import AuthCallback from "@/views/auth-callback/AuthCallback.vue";
import Settings from "@/views/settings/Settings.vue";

const routes: Array<RouteRecordRaw> = [
  {
    path: "/",
    name: "home",
    alias: "/home",
    component: HomeView,
  },
  {
    path: "/about",
    name: "about",
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () =>
      import(/* webpackChunkName: "about" */ "../views/AboutView.vue"),
  },
  {
    path: "/settings",
    name: "Настройки",
    component: Settings,
  },
  {
    path: "/auth-callback",
    name: "auth",
    component: AuthCallback,
  },
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});

export default router;
