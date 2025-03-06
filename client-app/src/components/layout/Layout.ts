import { Component, Vue, toNative } from "vue-facing-decorator";
import NavBarButton from "@/ui-kit/nav-bar-button/NavBarButton.vue";
import ProfileBlock from "./localComponents/profileBlock/ProfileBlock.vue";
import AuthorizationApi from "@/api/AuthorizationApi";

@Component({
  components: {
    NavBarButton,
    ProfileBlock,
  },
})
class Layout extends Vue {
  private authLink = "";

  private mounted(): void {
    // AuthorizationApi.getAuthLink().then((r) => {
    //   if (r === null) return;
    //   this.authLink = r;
    // });
  }
}

export default toNative(Layout);
