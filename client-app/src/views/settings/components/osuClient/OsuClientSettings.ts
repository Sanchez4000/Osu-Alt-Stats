import SettingsApi from "@/api/SettingsApi";
import SettingsModel from "@/models/SettingsModel";
import Category from "../../ui/category/Category.vue";
import Field from "../../ui/field/Field.vue";
import { Component, Vue, toNative } from "vue-facing-decorator";

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
    SettingsApi.loadSettings().then((r) => {
      if (r.osuClient === null) return;

      this.clientId = r.osuClient.clientId;
      this.clientSecret = r.osuClient.clientSecret;
    });
  }

  private save() {
    const data: SettingsModel = {
      osuClient: {
        clientId: this.clientId,
        clientSecret: this.clientSecret,
      },
    };

    SettingsApi.saveSettings(data);
  }
}

export default toNative(OsuClientSettings);
