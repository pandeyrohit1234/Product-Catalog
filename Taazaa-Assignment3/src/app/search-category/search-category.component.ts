import { Component, OnInit } from '@angular/core';
import { ICategory } from '../category/ICategory';
import { SCategoryService } from '../scategory.service';

@Component({
  selector: 'app-search-category',
  templateUrl: './search-category.component.html',
  styleUrls: ['./search-category.component.css']
})
export class SearchCategoryComponent implements OnInit {

  categories : ICategory[] = []
  constructor(private SCategory:SCategoryService) { 
    this.categories = this.SCategory.getProducts();

  }

  ngOnInit(): void {
  }
  searchId:number;
  searchName:string;
}
