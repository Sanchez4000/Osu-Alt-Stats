import { Component, Vue, toNative } from "vue-facing-decorator";

@Component
class Settings extends Vue {
  private clientId = 0;
  private clientSecret = "";
  private canSeeSecret = false;

  public get secretFieldType(): string {
    return this.canSeeSecret ? "text" : "password";
  }

  private mounted(): void {
    //load clientId + clientSecret
  }

  private save() {
    //saving all fields
  }
}

export default toNative(Settings);
