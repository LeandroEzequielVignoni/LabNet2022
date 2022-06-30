import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ejemplo',
  templateUrl: './ejemplo.component.html',
  styleUrls: ['./ejemplo.component.css']
})
export class EjemploComponent implements OnInit {

  nombre : string = "Jose";
  listaNombre : string[] = ["Jose", "Laura", "Kevin"];
  nombreActivo : boolean = true;
  constructor() { }

  ngOnInit(): void {
  }

  getNombre(){

    return this.nombre;



  }

  cambiarEstado(){


    return this.nombreActivo = !this.nombreActivo;


  }
}
