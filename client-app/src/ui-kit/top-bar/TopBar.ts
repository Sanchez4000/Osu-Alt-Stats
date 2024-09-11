import { Component, Vue, toNative } from "vue-facing-decorator";

@Component
class TopBar extends Vue {}

export default toNative(TopBar);
