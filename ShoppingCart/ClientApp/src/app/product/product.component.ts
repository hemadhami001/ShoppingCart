import { Component } from '@angular/core';
import { Product } from '../Common/Models/product.model';
import { ApiService } from '../services/api.service';


@Component({
  selector: 'app-product',
  standalone: false,
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {
  product: Product = new Product();
constructor(private _apiService:ApiService){ }

 addProduct(){
this._apiService.addProduct(this.product).subscribe(
  res=>{
    alert("Successfully Added Product");
  },
  err=>{
   console.log(err); 
   }
  );
 }
}
