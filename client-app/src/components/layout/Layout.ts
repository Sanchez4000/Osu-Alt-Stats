import { Component, Vue, toNative } from "vue-facing-decorator";
import NavBarButton from "@/ui-kit/nav-bar-button/NavBarButton.vue";
import AxiosDecorator from "@/utilities/AxiosDecorator";

@Component({
  components: {
    NavBarButton,
  },
})
class Layout extends Vue {
  private readonly responseType = "code";
  private readonly osuAuthUrl = "https://osu.ppy.sh/oauth/authorize";

  private clientId = 0;

  private mounted(): void {
    AxiosDecorator.get("/Authorization/GetClientId").then((response) => {
      this.clientId = response.data;
      const url = new URL(`${this.osuAuthUrl}`);

      const params = {
        client_id: this.clientId,
        response_type: this.responseType,
        scope: "public identify",
      };

      const keys = Object.keys(params);
      const values = Object.values(params);

      keys.forEach((key, index) => {
        url.searchParams.append(keys[index], values[index] as string);
      });
    });
  }

  private getAuthorizeUrl(): string {
    return `${this.osuAuthUrl}?client_id=${this.clientId}&response_type=${this.responseType}&scope=public+identify`;
  }

  private logUserData(): void {
    const data = {
      Id: 14168694,
    };

    AxiosDecorator.post("/Users/GetUser", data)
      .then((r) => console.log(r.data))
      .catch((e) => console.log(e));
  }
}

export default toNative(Layout);
