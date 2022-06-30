import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { environment } from 'src/environments/environment';
import { Category } from '../models/categories';
import { throwError as observableThrowError, Observable, catchError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  [x: string]: any;

  constructor(private http: HttpClient) { }

  crearCategory(request : Category): Observable<any>{

    let endpoint = 'api/CategoriesApi'

    return this.http.post(environment.categories + endpoint, request).pipe(catchError((error)=> {

      return this.errorHandler(error)

    })
    )

    

  }

   obtenerCategoriesTs(): Observable<Array<Category>>{

    let endpoint = 'api/CategoriesApi'

    let url = environment.categories + endpoint;
    

    return this.http.get<Array<Category>>(url).pipe(catchError((error)=> {

      return this.errorHandler(error)

    })
    )



  }

  borrarCategories(id: number) {

    let endpoint = 'api/CategoriesApi/'

    let url = environment.categories + endpoint;

    return this.http.delete<Array<Category>>(url + id).pipe(catchError((error)=> {

      return this.errorHandler(error)

    })
    )

    
  }

  modificarCategories(categoriesRequest: Category): Observable<any> {

    let endpoint = 'api/CategoriesApi/'
    

    let url = environment.categories + endpoint;

    return this.http.put<Array<Category>>(url + categoriesRequest.Id, categoriesRequest).pipe(catchError((error)=> {

      return this.errorHandler(error)

    })
    )

    
  }

  errorHandler(error: HttpErrorResponse) {

    return observableThrowError(error.message || 'server error');

  }
}
