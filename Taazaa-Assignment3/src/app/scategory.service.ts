import { Injectable } from '@angular/core';
import { ICategory } from './category/ICategory';

@Injectable({
  providedIn: 'root'
})
export class SCategoryService {

  constructor() { }

  cat : ICategory[]=[
    {
      Category_ID :1,
      Category_Name : "Grocery",
      CategoryShortCode : "101",
      CategoryDescription : "Well Satisfied"
    },
    {
      Category_ID :2,
      Category_Name : "Books",
      CategoryShortCode : "102",
      CategoryDescription : "Well Satisfied"
    },
    {
      Category_ID :3,
      Category_Name : "Dairy",
      CategoryShortCode : "103",
      CategoryDescription : "Well Satisfied"
    },
    {
      Category_ID :4,
      Category_Name : "Automobiles",
      CategoryShortCode : "104",
      CategoryDescription : "Well Satisfied"
    },
  ]

  getProducts() : ICategory[]
 {

  return this.cat;

    
  }
}
