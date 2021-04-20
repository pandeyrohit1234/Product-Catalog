
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { IProduct } from '../product/IProduct';
import { SProductService } from '../sproduct.service';


@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent implements OnInit {

  constructor(private SProduct : SProductService) { }

  x : number;

  product : IProduct[]=[];
  productForm= new FormGroup({
    ProductID: new FormControl(null,[Validators.required]),
    ProductName: new FormControl(null,[Validators.required]),
    Manufacturer: new FormControl(null,[Validators.required]),
    SellingPrice: new FormControl(null,[Validators.required, Validators.min(10)]),
    ShortCode: new FormControl(null,[Validators.required,Validators.minLength(4)] ),
    Description: new FormControl(null,[Validators.required]),
    deleteid:new FormControl(null)
  
 
  })
  
  add()
  {
   var x: IProduct={
    ProductID : this.productForm.controls['ProductID'].value,
    ProductName:this.productForm.controls['ProductName'].value,
    Manufacturer:this.productForm.controls['Manufacturer'].value,
    SellingPrice:this.productForm.controls['SellingPrice'].value,
    ShortCode: this.productForm.controls['ShortCode'].value,
    Description:this.productForm.controls['Description'].value,
    
   };
   this.product.push(x);
  
    this.senddata();
    
 
  }

  senddata(){
    this.SProduct.pro.push({
    ProductID : this.productForm.controls['ProductID'].value,
    ProductName:this.productForm.controls['ProductName'].value,
    Manufacturer:this.productForm.controls['Manufacturer'].value,
    SellingPrice:this.productForm.controls['SellingPrice'].value,
    ShortCode: this.productForm.controls['ShortCode'].value,
    Description:this.productForm.controls['Description'].value,
    

    })
  }

  delete(){
    this.SProduct.pro = this.SProduct.pro.filter(item => item.ProductID !== this.x );
    
    
  }


  clear()
  {
    this.productForm.reset();
 
  }
  
 
 

  ngOnInit(): void {
  }

}


