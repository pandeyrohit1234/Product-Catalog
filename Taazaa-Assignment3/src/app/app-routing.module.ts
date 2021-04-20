import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddCategoryComponent } from './add-category/add-category.component';
import { AddProductComponent } from './add-product/add-product.component';
import { CategoryComponent } from './category/category.component';
import { DisplayCategoryComponent } from './display-category/display-category.component';
import { DisplayProductComponent } from './display-product/display-product.component';
import { HomeComponent } from './home/home.component';
import { ProductComponent } from './product/product.component';
import { SearchCategoryComponent } from './search-category/search-category.component';
import { SearchProductComponent } from './search-product/search-product.component';

const routes: Routes = [
  {path  : 'home' , component : HomeComponent },
  
  {path  : 'category' , component : CategoryComponent ,children: 
[
  {path  : 'displaycategory' , component : DisplayCategoryComponent },
  {path  : 'searchcategory' , component : SearchCategoryComponent },
  {path  : 'addcategory' , component : AddCategoryComponent },
]
},
  {path  : 'product' , component : ProductComponent ,children:[

  
  {path  : 'searchproduct' , component : SearchProductComponent },
  {path  : 'displayproduct' , component : DisplayProductComponent },
  {path  : 'addproduct' , component : AddProductComponent },
  
]},
  
  {path  : '' , redirectTo :'home',pathMatch :'full'  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }



