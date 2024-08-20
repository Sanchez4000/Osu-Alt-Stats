import PageDataModel from "@/models/PageDataModel";

export default class PageDataToArrayConverter {
  private static readonly nameIndex = 0;
  private static readonly valueIndex = 1;

  public static convert(data: string): PageDataModel[] {
    const splited = data.split("&");
    const result: PageDataModel[] = [];

    for (let i = 0; i < splited.length; i++) {
      const data = splited[i].split("=");

      result.push(
        new PageDataModel(data[this.nameIndex], data[this.valueIndex])
      );
    }

    return result;
  }
}
