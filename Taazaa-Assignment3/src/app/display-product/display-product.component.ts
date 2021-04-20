import { Component, OnInit } from '@angular/core';
import { IProduct } from '../product/IProduct';
import { SProductService } from '../sproduct.service';

@Component({
  selector: 'app-display-product',
  templateUrl: './display-product.component.html',
  styleUrls: ['./display-product.component.css']
})
export class DisplayProductComponent implements OnInit {


products : IProduct[]=[]

  constructor(private SProduct : SProductService) { }

  ngOnInit(): void {
    this.products = this.SProduct.getProducts();

  }

}
