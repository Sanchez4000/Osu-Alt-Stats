import { Component, Vue, toNative } from "vue-facing-decorator";

@Component
class ProfileBlock extends Vue {
  private activeProfileName: string | undefined = undefined;
  private profileNames = ["Профиль 1", "Профиль 2", "Профиль 3"];

  private getActiveProfileName(): string {
    if (this.profileNames.length === 0) return "Нет профиля";
    if (this.activeProfileName === undefined) return "Нет профиля";

    return this.activeProfileName;
  }
}

export default toNative(ProfileBlock);
