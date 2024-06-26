import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  baseUrl:string='https://localhost:7135'

  constructor(private _httpService: HttpClient) { }

 // addProduct():Observable<any>{
 //   return this._httpService.post(this.baseUrl+'/api/Product')
 // }
}
