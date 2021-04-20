import { Injectable } from '@angular/core';
import { IProduct } from './product/IProduct';

@Injectable({
  providedIn: 'root'
})
export class SProductService {

  constructor() { }

  pro : IProduct[]=[
    {
      ProductID :1,
      ProductName : "Laptop",
      Manufacturer : "Lenovo",
      ShortCode : "qwe",
      Description : "RAM : 8gb, CORE : I3",
      SellingPrice : 50000
    },
    {
      ProductID : 2,
      ProductName : "Keyboard",
      Manufacturer : "Dell",
      ShortCode : "rty",
      Description : " Portable",
      SellingPrice : 2000
    },
    {
      ProductID :3,
      ProductName : "Dairy",
      Manufacturer : "MotherDairy",
      ShortCode : "klj",
      Description : "Good",
      SellingPrice : 500000
    },
    {
      ProductID : 4,
      ProductName : "Bed",
      Manufacturer : "Carpenter",
      ShortCode : "rtyi",
      Description : " Comfortable",
      SellingPrice : 203232
    },
    {
      ProductID :5,
      ProductName : "Automobiles",
      Manufacturer : "Lenovo",
      ShortCode : "qwj",
      Description : "Good ",
      SellingPrice : 500000
    },
    {
      ProductID : 6,
      ProductName : "Food",
      Manufacturer : "McD",
      ShortCode : "OLO",
      Description : " Tasty",
      SellingPrice : 200
    },
    
  ]

  getProducts() : IProduct[]
  {
    return this.pro;
   
    
  }

}
