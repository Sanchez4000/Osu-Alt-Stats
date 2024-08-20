export default class PageDataModel {
  private readonly _name: string = "";
  private readonly _value: string = "";

  public get Name(): string {
    return this._name;
  }
  public get Value(): string {
    return this._value;
  }

  constructor(name: string, value: string) {
    this._name = name;
    this._value = value;
  }
}
