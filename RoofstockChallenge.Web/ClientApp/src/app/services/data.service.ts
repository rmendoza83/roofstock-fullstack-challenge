import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { BaseResponse } from "../models/base-response.model";
import { PropertyRawResponseModel } from "../models/property-raw-response.model";
import { PropertyModel } from "../models/property.model";

export class DataService {
  private BASE_URL: string = "api/Property/";

  constructor(private http: HttpClient) { }

  getList(): Observable<PropertyRawResponseModel> {
    return this.http.get<PropertyRawResponseModel>(`${this.BASE_URL}GetList`);
  }

  postProperty(data: PropertyModel): Observable<BaseResponse> {
    return this.http.post<BaseResponse>(`${this.BASE_URL}Post`, data);
  }
}