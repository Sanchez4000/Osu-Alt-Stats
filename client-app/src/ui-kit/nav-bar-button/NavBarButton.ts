import { Component, Prop, Vue, toNative } from "vue-facing-decorator";

@Component
class NavBarButton extends Vue {
  @Prop({
    required: true,
    default: "#",
    type: String,
  })
  private link!: string;
  @Prop({
    required: true,
    default: "Button",
    type: String,
  })
  private label!: string;
}

export default toNative(NavBarButton);
