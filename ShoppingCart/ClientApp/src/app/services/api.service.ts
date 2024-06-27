import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from '../Common/Models/product.model';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  baseUrl:string='https://localhost:7135'

  constructor(private _httpService: HttpClient) { }

    addProduct(productDetail:Product):Observable<any>{
     return this._httpService.post(this.baseUrl+'/api/Product', productDetail);
  }
}
