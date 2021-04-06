import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { BaseResponse } from "../models/base-response.model";
import { PropertyListResponseModel } from "../models/property-list-response.model";
import { PropertyModel } from "../models/property.model";

@Injectable()
export class DataService {
  private BASE_URL: string = "api/Property/";

  constructor(private http: HttpClient) { }

  getList(): Observable<PropertyListResponseModel> {
    return this.http.get<PropertyListResponseModel>(`${this.BASE_URL}GetList`);
  }

  postProperty(data: PropertyModel): Observable<BaseResponse> {
    console.log(data);
    return this.http.post<BaseResponse>(`${this.BASE_URL}Post`, data);
  }
}