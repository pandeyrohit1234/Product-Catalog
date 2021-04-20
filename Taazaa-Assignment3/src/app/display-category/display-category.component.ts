import { Component, OnInit } from '@angular/core';
import { ICategory } from '../category/ICategory';
import { SCategoryService } from '../scategory.service';

@Component({
  selector: 'app-display-category',
  templateUrl: './display-category.component.html',
  styleUrls: ['./display-category.component.css']
})
export class DisplayCategoryComponent implements OnInit {

  categories : ICategory[] = []
  constructor(private SCategory:SCategoryService) { }

  ngOnInit(): void {
    this.categories = this.SCategory.getProducts();
  }

}
