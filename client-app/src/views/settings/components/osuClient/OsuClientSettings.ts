import SettingsApi from "@/api/SettingsApi";
import Category from "../../ui/category/Category.vue";
import Field from "../../ui/field/Field.vue";
import { Component, Vue, toNative } from "vue-facing-decorator";
import OsuClient from "@/models/OsuClient";

@Component({
  components: {
    Category,
    Field,
  },
})
class OsuClientSettings extends Vue {
  private clientId = 0;
  private clientSecret = "";
  private canSeeSecret = false;

  public get secretFieldType(): string {
    return this.canSeeSecret ? "text" : "password";
  }

  private mounted(): void {
    SettingsApi.getOsuClientData()
      .then((client) => {
        if (client === null) return;

        this.clientId = client.clientId;
        this.clientSecret = client.clientSecret;
      })
      .catch((e) => {
        console.log(e);
      });
  }

  private save() {
    const data: OsuClient = {
      clientId: this.clientId,
      clientSecret: this.clientSecret,
    };

    SettingsApi.setOsuClientData(data).then((client) => {
      this.clientId = client.clientId;
      this.clientSecret = client.clientSecret;
    });
  }
}

export default toNative(OsuClientSettings);
