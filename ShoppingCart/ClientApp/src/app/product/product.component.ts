import { Component } from '@angular/core';
import { Product } from '../Common/Models/product.model';
import { FormsModule } from '@angular/forms';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-product',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {
  product: Product = new Product();
constructor(private _apiService:ApiService){ }

 addProduct(){
this._apiService.addProduct(this.product);
 }
}
