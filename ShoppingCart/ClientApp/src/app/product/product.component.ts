import { Component } from '@angular/core';
import { Product } from '../Common/Models/product.model';

@Component({
  selector: 'app-product',
  standalone: true,
  imports: [],
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {
  product: Product = new Product();
constructor(){}

 addProduct(){

 }
}
