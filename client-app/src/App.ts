import { Component, Vue, toNative } from "vue-facing-decorator";
import Layout from "@/components/layout/Layout.vue";

@Component({
  components: {
    Layout,
  },
})
class App extends Vue {
  private t = "text";
}

export default toNative(App);
