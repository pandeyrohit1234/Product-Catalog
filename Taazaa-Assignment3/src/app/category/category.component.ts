import { Component, OnInit } from '@angular/core';
import { SCategoryService } from '../scategory.service';
import { ICategory } from './ICategory';


@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {

  categories : ICategory[] = []
  constructor(private SCategory:SCategoryService) { }

  ngOnInit(): void {
    this.categories = this.SCategory.getProducts();

  }

  OnClick()
  {
    console.log("DISPLAY");
    
  
  }

}
