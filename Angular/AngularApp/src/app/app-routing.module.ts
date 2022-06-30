import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoriesComponent } from './modules/categories/categories/categories.component';
import { EjemploComponent } from './modules/clase1/ejemplo/ejemplo.component';

const routes: Routes = [{

  path: '',
  component : CategoriesComponent

}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
