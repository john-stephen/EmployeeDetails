import { Injectable } from '@angular/core';
import { EmployeeDetail } from './employee-detail.model';
import { HttpClient} from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class EmployeeDetailService {
  formData:EmployeeDetail;
  readonly rootURL = 'http://localhost:58843/api';
  
  constructor(private http:HttpClient) { }

  postEmployeeDetail(formData: EmployeeDetail){
    return this.http.post(this.rootURL+'/EmployeeDetail',formData);
  }
}
