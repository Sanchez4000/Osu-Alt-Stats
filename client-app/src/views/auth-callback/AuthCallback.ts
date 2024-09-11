import PageDataModel from "@/models/PageDataModel";
import AxiosDecorator from "@/utilities/AxiosDecorator";
import PageDataToArrayConverter from "@/utilities/PageDataToArrayConverter";
import { Component, Vue, toNative } from "vue-facing-decorator";

@Component
class AuthCallback extends Vue {
  private mounted(): void {
    const currentUrl = window.location.href;

    if (currentUrl.includes("?")) {
      const questionMarkIndex = currentUrl.indexOf("?");

      const pageData = currentUrl.substring(questionMarkIndex + 1);
      const params = PageDataToArrayConverter.convert(pageData);

      const codeParam: PageDataModel | undefined = params.find(
        (x) => x.Name === "code"
      );
      if (codeParam !== undefined) {
        const requestData = {
          AuthorizationCode: codeParam.Value,
        };

        AxiosDecorator.post("/Authorization/Authorize", requestData)
          .then((r) => console.log(r.status))
          .catch((e) => console.log(e));
      }
    } else {
      console.log("error");
    }
  }
}

export default toNative(AuthCallback);
