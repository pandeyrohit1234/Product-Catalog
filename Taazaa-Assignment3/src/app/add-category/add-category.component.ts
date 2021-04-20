import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

import { ICategory } from '../category/ICategory';
import { SCategoryService } from '../scategory.service';

@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrls: ['./add-category.component.css']
})
export class AddCategoryComponent implements OnInit {

  constructor(private SCategory:SCategoryService ) { }

  x:number;

  product : ICategory[]=[];
  productForm= new FormGroup({
    Category_ID: new FormControl(null,[Validators.required]),
    Category_Name: new FormControl(null,[Validators.required]),
    
    CategoryShortCode: new FormControl(null,[Validators.required,Validators.minLength(4)] ),
    CategoryDescription: new FormControl(null,[Validators.required]),
    deleteid:new FormControl(null)
  
 
  })
  
  add()
  {
   var x: ICategory={
    Category_ID : this.productForm.controls['Category_ID'].value,
    Category_Name:this.productForm.controls['Category_Name'].value,
    CategoryShortCode:this.productForm.controls['CategoryShortCode'].value,
    CategoryDescription: this.productForm.controls['CategoryDescription'].value,
    
   };

   this.product.push(x);
   this.senddata();

  }

  senddata(){
    this.SCategory.cat.push({
    Category_ID : this.productForm.controls['Category_ID'].value,
    Category_Name:this.productForm.controls['Category_Name'].value,
    CategoryShortCode:this.productForm.controls['CategoryShortCode'].value,
    CategoryDescription: this.productForm.controls['CategoryDescription'].value,
    })
  }
  


  delete()
  {
   
    this.SCategory.cat = this.SCategory.cat.filter(item => item.Category_ID !== this.x );
   
  
  }


  clear()
  {
    this.productForm.reset();
 
  }

  ngOnInit(): void {
  }

}
