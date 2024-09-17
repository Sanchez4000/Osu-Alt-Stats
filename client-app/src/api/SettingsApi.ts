import SettingsModel from "@/models/SettingsModel";
import AxiosDecorator from "@/utilities/AxiosDecorator";

export default class SettingsApi {
  public static async loadSettings(): Promise<SettingsModel> {
    const response = await AxiosDecorator.post("/Settings/Load");
    return response.data;
  }
  public static async saveSettings(data: SettingsModel): Promise<void> {
    await AxiosDecorator.post("/Settings/Save", data);
  }
}
