import { Pipe, PipeTransform } from '@angular/core';
import { ICategory } from './category/ICategory';

@Pipe({
  name: 'searchbyid'
})
export class SearchbyidPipe implements PipeTransform {

  transform(value: ICategory[], args: number): ICategory[] {

    if(!args){
      return value;
    }
    return value.filter(
      item => item.Category_ID == (args)) ;
    
    


  }

}


