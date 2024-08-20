/* eslint-disable */
import axios, { AxiosRequestConfig, AxiosResponse } from "axios";

export default class AxiosDecorator {
  private static readonly baseUrl = "http://localhost:8081/api";

  public static get(
    url: string,
    config?: AxiosRequestConfig<any> | undefined
  ): Promise<AxiosResponse<any, any>> {
    return axios.get(this.concatUrl(url), config);
  }

  public static post(
    url: string,
    data?: any,
    config?: AxiosRequestConfig<any> | undefined
  ): Promise<AxiosResponse<any, any>> {
    return axios.post(this.concatUrl(url), data, config);
  }

  private static concatUrl(url: string): string {
    if (url[0] === "/") {
      return `${this.baseUrl}${url}`;
    } else {
      return `${this.baseUrl}/${url}`;
    }
  }
}
