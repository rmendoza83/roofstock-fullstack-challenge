import { BaseResponse } from "./base-response.model";
import { PropertyRawModel } from "./property-raw.model";

export class PropertyRawResponseModel extends BaseResponse {
  public Properties: PropertyRawModel[] = [];
}