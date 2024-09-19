import { Component, Prop, Vue, toNative } from "vue-facing-decorator";

@Component
class Field extends Vue {
  @Prop({
    required: false,
    type: String,
    default: "New field",
  })
  private name!: string;
}

export default toNative(Field);
