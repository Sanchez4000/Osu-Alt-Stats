import OsuClientSettings from "./components/osuClient/OsuClientSettings.vue";
import { Component, Vue, toNative } from "vue-facing-decorator";

@Component({
  components: {
    OsuClientSettings,
  },
})
class Settings extends Vue {}

export default toNative(Settings);
