import OsuClient from "@/models/OsuClient";
import AxiosDecorator from "@/utilities/AxiosDecorator";

export default class SettingsApi {
  public static async getOsuClientData(): Promise<OsuClient | null> {
    const response = await AxiosDecorator.post("/Settings/GetOsuClientData");
    return response.data;
  }
  public static async setOsuClientData(data: OsuClient): Promise<OsuClient> {
    const response = await AxiosDecorator.post(
      "/Settings/SetOsuClientData",
      data
    );
    return response.data;
  }
}
