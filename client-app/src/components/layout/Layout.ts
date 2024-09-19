import { Component, Vue, toNative } from "vue-facing-decorator";
import NavBarButton from "@/ui-kit/nav-bar-button/NavBarButton.vue";

@Component({
  components: {
    NavBarButton,
  },
})
class Layout extends Vue {
  private readonly responseType = "code";
  private readonly osuAuthUrl = "https://osu.ppy.sh/oauth/authorize";

  private clientId = 0;

  private getAuthorizeUrl(): string {
    return `${this.osuAuthUrl}?client_id=${this.clientId}&response_type=${this.responseType}&scope=public+identify`;
  }
}

export default toNative(Layout);
