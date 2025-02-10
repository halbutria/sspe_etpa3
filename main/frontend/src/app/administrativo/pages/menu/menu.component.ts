import { Component, OnInit } from '@angular/core';

import { ParametricosList } from "../../domain/enum/parametricos.enum";
import { ParametricosAdmin } from "../../domain/dto/parametricos-admin";
import { ParametricoListado, Parametrico } from "src/app/model/parametricos";

import { PARAMETRICOS, ParametricosService, PARAMETRICOS_FILTROS } from "src/app/services/parametricos.service";
import { AdministrativoService } from "src/app/services/administrativo.service";

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  nameUser: string = '';
  PARAMETRICOS = PARAMETRICOS;
  listParametricos: ParametricosAdmin[] = ParametricosList;
  listCategories: string[] = [];

  constructor(
    private adminService: AdministrativoService,
  ) { }

  ngOnInit(): void {
    this.nameUser = 'administrador';
    // Extrae las categorias del listado de parametricos
    this.listParametricos.forEach((item) => {
      const category = item.category;

      // Comprobar si la categoría ya existe en el arreglo this.listCategories
      if (this.listCategories.indexOf(category) === -1) {
        // Si no existe, agregarla al arreglo this.listCategories
        this.listCategories.push(category);
      }
    });
  }

  /**
   * Función que recibe el click de alguno parametrico para generar la lógica en app content
   */
  selectParametrico(parametrico: ParametricosAdmin) {
    this.adminService.updateParametrico(parametrico);
  }

  getCategoriaSinEspacios(category: string) {
    return category.replace(/\s+/g, '');
  }

}
