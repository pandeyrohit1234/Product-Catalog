import { Pipe, PipeTransform } from '@angular/core';
import { ICategory } from './category/ICategory';

@Pipe({
  name: 'searchbyname'
})
export class SearchbynamePipe implements PipeTransform {

  transform(value: ICategory[], args: string): ICategory[] {

    if(!args){
      return value;
    }
    return value.filter(
      item => item.Category_Name.toLowerCase().indexOf(args.toLowerCase()) > -1 );
    
      


  }

}
