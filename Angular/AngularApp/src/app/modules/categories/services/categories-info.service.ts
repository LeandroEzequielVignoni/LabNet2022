import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Category } from '../models/categories';


@Injectable({
  providedIn: 'root'
})
export class CategoriesInfoService {

  public categoriesInfo = new BehaviorSubject<Category>(new Category());
  public categoriesInfo$ = this.categoriesInfo.asObservable();

  constructor() { }

  sendShipper(category: Category) {
    this.categoriesInfo.next(category);
  }
}





