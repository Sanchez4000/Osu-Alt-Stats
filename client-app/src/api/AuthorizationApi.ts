import AxiosDecorator from "@/utilities/AxiosDecorator";

export default class AuthorizationApi {
  public static async getAuthLink(): Promise<string | null> {
    const response = await AxiosDecorator.get("/Authorization/GetAuthLink");
    return response.data;
  }
}
