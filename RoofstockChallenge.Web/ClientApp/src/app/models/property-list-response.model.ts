import { BaseResponse } from "./base-response.model";
import { PropertyModel } from "./property.model";

export class PropertyListResponseModel extends BaseResponse {
  public Properties: PropertyModel[] = [];
}