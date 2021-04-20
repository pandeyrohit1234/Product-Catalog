import { Component, OnInit } from '@angular/core';
import { IProduct } from '../product/IProduct';
import { SProductService } from '../sproduct.service';

@Component({
  selector: 'app-search-product',
  templateUrl: './search-product.component.html',
  styleUrls: ['./search-product.component.css']
})
export class SearchProductComponent implements OnInit {

  products : IProduct[]=[]

  constructor(private SProduct : SProductService ) { }

  ngOnInit(): void {
    this.products = this.SProduct.getProducts();
  }

  searchId:number;
  searchPrice : number;
  searchName:string;
  

}
