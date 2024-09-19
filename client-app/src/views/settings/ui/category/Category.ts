import { Component, Prop, Vue, toNative } from "vue-facing-decorator";

@Component
class Category extends Vue {
  @Prop({
    required: false,
    type: String,
    default: "New Category",
  })
  private name!: string;
}

export default toNative(Category);
