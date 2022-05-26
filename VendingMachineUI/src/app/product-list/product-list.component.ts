import { Component, OnInit } from '@angular/core';
import { HttpClientModule, HttpClient } from  "@angular/common/http";
import { Product } from '../products';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';


@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent {

  constructor(private  httpClient:HttpClient) {
 }

getProducts() : Observable<Product[]> {
  return this.httpClient.get<Product[]>("https://localhost:44375/product").pipe(map(res => {return res.map(item => {return item as Product}) }));

}
  

}
