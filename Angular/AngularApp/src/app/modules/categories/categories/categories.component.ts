import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Category } from '../models/categories';
import { CategoryService } from '../services/category.service';
import { Router } from '@angular/router';




@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.css']
})
export class CategoriesComponent implements OnInit {

    public form : FormGroup;
    public listCategories: Array<Category> = [];
    public formUpdate: FormGroup;
    
 

  constructor(private  fb: FormBuilder, private categoriesService: CategoryService, private router: Router) { }

  get formControls(){

    return this.form.controls;



  }

  ngOnInit(): void {

    this.initForm();

    this.obtenerCategories();

    this.actualizarFormulario();

    

    
  }

  initForm(){

    this.form = this.fb.group({

      CategoryName : new FormControl('', [Validators.required, Validators.pattern('[a-zA-Z]*'), Validators.maxLength(17)])




    })




  }
  
  guardar(){

    var categories = new Category();
    categories.CategoryName = this.form.get('CategoryName')?.value

    this.categoriesService.crearCategory(categories).subscribe(res => {

      
      this.form.reset();
      this.obtenerCategories();

    },
    error => console.error('Fallo'))


  }

  cancelarFormulario(){

    this.form.reset();

  }

  obtenerCategories(){

    this.categoriesService.obtenerCategoriesTs().subscribe(res =>{

      this.listCategories = res;

      


    });



  }

  borrarCategories(id: number) {


    this.categoriesService.borrarCategories(id).subscribe(
      () => this.ngOnInit()
      
    );
  }

  actualizarFormulario(){

    this.formUpdate = this.fb.group({

      CategoryName : new FormControl('', Validators.required)





    })





  }

  editCategory(Id : any, CategoryName: string){

    let newCategory:Category = {

      Id : Id,
      CategoryName : this.form.get('CategoryName')?.value




    }

    this.categoriesService.modificarCategories(newCategory).subscribe(()=>{this.obtenerCategories(),this.form.reset()});
    
    

  }



  }


 

