import { Component, OnInit, Input, importProvidersFrom } from '@angular/core';
import { FormBuilder, FormGroup } from "@angular/forms";
import { NgbPagination, NgbModal } from '@ng-bootstrap/ng-bootstrap';

import { ParametricosList } from "../../domain/enum/parametricos.enum";
import { Field, ParametricosAdmin, Option} from "../../domain/dto/parametricos-admin";
import { ParametricoListado, Parametrico } from "src/app/model/parametricos";

import { PARAMETRICOS, ParametricosService, PARAMETRICOS_FILTROS } from "src/app/services/parametricos.service";
import { AdministrativoService } from "src/app/services/administrativo.service";

import { AddModalFormComponent } from "./add-modal-form/add-modal-form.component";
import { ModalConfirmationFormComponent } from "src/app/shared/components/modal-confirmation-form/modal-confirmation-form.component";
import { ModalSuccessFormComponent } from 'src/app/shared/components/modal-success-form/modal-success-form.component';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent implements OnInit {

  parametricoSelected: ParametricosAdmin | null;
  PARAMETRICOS = PARAMETRICOS;
  filterForm!: FormGroup;
  showLoading: boolean = false;
  isDisabledEdit: boolean = false;
  isDisabledDelete: boolean = false;

  searchTerm: string = '';
  page = 1;
  pageSize = 10;
  collectionSize: number = 0;
  listParametricos: Parametrico[] = [];
  allData: Parametrico[] = [];
  data: Parametrico[] = [];
  selectLists: any = [];

  constructor(
    private adminService: AdministrativoService,
    public formBuilder: FormBuilder,
    private modalService: NgbModal,
    public parametricosService: ParametricosService,
  ) {
    this.parametricoSelected = null;
    this.filterForm = this.formBuilder.group({
      searchTerm: ['']
    });
  }

  ngOnInit(): void {
    this.listParametricos = this.data;
    this.allData = this.listParametricos;

    // Se suscribe al observable en admin service para recibir actualizaciones del parametrico seleccionado
    this.adminService.getParametrico$().subscribe((newParam) => {
      this.parametricoSelected = newParam;
      // Inicializa el listado de parametricos al cambio de item en el menu
      this.listParametricos = [];

      // Sólo continua con la lógica si NO contiene un component configurado
      if (this.parametricoSelected?.component == undefined) {
        // Verifica en los fields configurados para el parametrico si hay alguno que tenga association para entonces consultar el listado parametrico
        this.parametricoSelected?.fields.forEach(field => {
          // Sólo valida los campos si no tiene hide list o es false
          if (field.hide_list == undefined || !field.hide_list) {
            if (field.association !== undefined) {
              this.getParametricoAssociation(field);
            } else if (field.options !== undefined) {
              this.selectLists[field.name] = field.options;
            }
          }
        });

        setTimeout(() => {
          // Obtiene el listado de parametricos
          this.getTableParametrico();
        }, 600);
      }
    });
  }

  search(): void {
    const value = this.filterForm.controls['searchTerm'].value.toLowerCase();

    this.listParametricos = this.allData.filter((val) => {
      const nombre = val.nombre ? val.nombre.toLowerCase() : ''; // Verificar si nombre es null
      const descripcion = val.descripcion ? val.descripcion.toLowerCase() : ''; // Verificar si descripcion es null
      const contenido = val.contenido ? val.contenido.toLowerCase() : ''; // Verificar si contenido es null
      const tipo = val.tipo ? val.tipo.toLowerCase() : ''; // Verificar si tipo es null
      const detalle = val.detalle ? val.detalle.toLowerCase() : ''; // Verificar si detalle es null
      const codigo = val.codigo ? val.codigo.toLowerCase() : ''; // Verificar si codigo es null
      const texto = val.texto ? val.texto.toLowerCase() : ''; // Verificar si texto es null

      return nombre.includes(value) || descripcion.includes(value) || contenido.includes(value)
        || tipo.includes(value) || detalle.includes(value) || codigo.includes(value) || texto.includes(value);
    });

    this.collectionSize = this.listParametricos.length;
  }

  /**
   * Funcion que con el parametrico seleccionado consulta del api el listado de registros parametricos
   */
  getTableParametrico() {
    if (this.parametricoSelected) {
      this.showLoading = true;
      const parametricoStr = this.parametricoSelected.parametrico_list !== undefined ? this.parametricoSelected.parametrico_list : this.parametricoSelected.parametrico;

      this.parametricosService.getParametricosDefault(parametricoStr).subscribe((response) => {
        this.listParametricos = response;
        this.allData = response;
        this.showLoading = false;
        this.collectionSize = this.listParametricos.length;
      });
    }
  }

  /**
   * Función que abre e inicia el modal con el formulario para poder agregar o editar un parametrico
   */
  openModalForm(type: string, parametrico: Parametrico | null = null) {
    const modalForm = this.modalService.open(AddModalFormComponent, {
      size: 'lg', backdrop: 'static', animation: true
    });

    // Depende del tipo entonces envía información diferente
    switch (type) {
      case 'add':
        modalForm.componentInstance.title = `Crear - ${this.parametricoSelected?.name}`;
        modalForm.componentInstance.type = 'new';
        break;
      case 'edit':
        modalForm.componentInstance.title = `Editar registro # ${parametrico?.id} - ${this.parametricoSelected?.name}`;
        modalForm.componentInstance.type = 'edit';
        modalForm.componentInstance.data = parametrico;
        break;
    }

    // Envía variables por defecto al modal
    modalForm.componentInstance.parametrico = this.parametricoSelected;

    modalForm.result.then(response => {
      if (response != null) {

        const modalSuccessForm = this.modalService.open(ModalSuccessFormComponent, {
          size: 'sm', backdrop: 'static', animation: true
        });
        modalSuccessForm.componentInstance.body =  `Se guardó con éxito el registro paramétrico de ${this.parametricoSelected?.name}!`;
        setTimeout(() => {
          this.getTableParametrico();
        }, 600);
      }
    });
  }

  /**
   * Función que recibe un parametrico y lo elimina con previa confirmación
   * @param parametrico
   */
  deleteParametrico(parametrico: Parametrico) {
    // Lanza modal de confirmación para la eliminación
    const modalConfirm = this.modalService.open(ModalConfirmationFormComponent, {
      size: 'md', backdrop: 'static', animation: true
    });
    modalConfirm.componentInstance.body = `Seguro que desea eliminar el registro #${parametrico.id} de ${this.parametricoSelected?.name}?`;
    modalConfirm.result.then(response => {
      if (response) {
        this.showLoading = true;
        this.adminService.deleteParametrico(parametrico.id, this.parametricoSelected?.parametrico).subscribe(
          response => {
            this.getTableParametrico();
          },
          error => {
            this.showLoading = false;
            console.log(error);
          }
        );
      }
    });
  }

  /**
   * Función que se encarga de identificar el valor o propiedad a poner en la tabla para cada field
   */
  getPropiedad(objeto: any, propiedad: string): any {
    let response = objeto[propiedad];
    // Valida el tipo de field sobre la propiedad
    // Esto para saber si tiene options o associations
    this.parametricoSelected?.fields.forEach(field => {
      // Valida que el name del field coincida con la propiedad
      if (propiedad == field.name) {
        if (field.type == "select") {
          // Si es campo select entonces verifica en las options
          if (field.options !== undefined) {
            // Verifica si existe el valor en el objeto
            const objetoValue = field.options.find(item => item.value === objeto[propiedad]);

            if (objetoValue) {
              // Si se encontró un objeto con el mismo value entonces obtiene su label
              response = objetoValue.label;
            }
          } else if (field.association !== undefined) {
            // Verifica si existe el valor en el objeto
            const objetoValueAssociation = this.selectLists[field.name].find((item: Option) => item.value == objeto[propiedad]);

            if (objetoValueAssociation) {
              // Si se encontró un objeto con el mismo value entonces obtiene su label
              response = objetoValueAssociation.label;
            }
          }
        }
      }
    });
    return response;
  }

  /**
   * Función que obtiene si un campo del item seleccionado es HIDE en el listado
   */
  getHideField(field: Field) {
    // Valida el hide en las configuraciones
    return (field.hide_list !== undefined) ? field.hide_list : false;
  }

  /**
   * Función que se encarga de obtener el listado de parametricos sobre campos de asociación en la tabla
   */
  getParametricoAssociation(field: Field) {
    if (field.association) {
      this.showLoading = true;
      this.parametricosService.getParametricosDefault(field.association).subscribe((response) => {
        this.selectLists[field.name] = response.map(element => {
          return { value: element.id, label: element.nombre };
        });
        this.showLoading = false;
      });
    }
  }

  /**
   * Función que realiza algunas validaciones personalizadas para definir el disabled de los botones de editar y eliminar de la tabla
   */
  customValidationsButtons(objeto: any, button: string) {
    let isDisabled = false;

    switch (this.parametricoSelected?.hu) {
      // Validación para HU267 Pregunta de seguridad
      case 'HU267':
        // Si la pregunta es Pregunta abierta entonces no puede hacer nada
        if (objeto.nombre == 'Pregunta abierta') {
          isDisabled = true;
        }
        break;
    }

    return isDisabled;
  }

}
