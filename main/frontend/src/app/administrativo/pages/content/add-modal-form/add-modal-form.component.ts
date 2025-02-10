import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";
import { NgbActiveModal, NgbModal } from '@ng-bootstrap/ng-bootstrap';

import { Parametrico } from "src/app/model/parametricos";
import { ParametricosAdmin, Field } from "../../../domain/dto/parametricos-admin";

import { AdministrativoService } from "src/app/services/administrativo.service";
import { PARAMETRICOS, ParametricosService } from "src/app/services/parametricos.service";

@Component({
  selector: 'app-add-modal-form',
  templateUrl: './add-modal-form.component.html',
  styleUrls: ['./add-modal-form.component.css']
})
export class AddModalFormComponent implements OnInit {

  @Input() public title: string = "";
  @Input() public type: string = 'new';
  @Input() public parametrico: ParametricosAdmin | undefined;
  @Input() public data: Parametrico | undefined;

  submitted: boolean = false;
  showLoading: boolean = false;
  isLoadingSelect: boolean = false; // Variable para rastrear si se están cargando los datos en los campos
  parametricoForm!: FormGroup;
  typeStr: string = '';
  selectLists: any = [];

  constructor(
    private administrativoService: AdministrativoService,
    public formBuilder: FormBuilder,
    public modalActiveService: NgbActiveModal,
    public parametricosService: ParametricosService,
  ) {
    this.parametricoForm = this.formBuilder.group({
      id: [null],
      nombre: [null],
      sigla: [null],
      coberturaNacional: [null],
      idDepartamento: [null],
      PrestadorId: [null],
      departamentoId: [null],
      valorInicial: [null],
      valorFinal: [null],
      tipo: [null],
      orden: [null],
      equivalencias: [null],
      principal: [null],
      nacionalidad: [null],
      descripcion: [null],
      grupoPrimario: [null],
      ocupacionNueva: [null],
      cuocOcupacionId: [null],
      fuenteDenominacion: [null],
      codigoCNO: [null],
      codigoCIUO: [null],
      rural: [null],
      tipoZonaGeograficaId: [null],
      detalle: [null],
      codigo: [null],
      nivelEducativoId: [null],
      nucleoConocimientoId: [null],
      contenido: [null],
      sectorEconomicoId: [null],
      texto: [null],
      institucionId: [null],
      areaConocimientoId: [null],
      cuocConocimientoId: [null],
      avance: [null],
    });
  }

  ngOnInit(): void {
    // this.typeStr = this.type == 'new' ? 'Agregar' : 'Editar';
    this.typeStr = 'Guardar';

    // Se ejecuta una logica personalizada en el init del componente
    this.logicCustomInit();

    // Verifica con el listado de campos configurados para el parametrico seleccionado cuáles son requeridos en el form
    this.parametrico?.fields.forEach(field => {
      const isHideEdit = (this.type == 'edit' && field.hide_edit !== undefined && field.hide_edit) ? true : false;

      if (this.type == 'add') {
        if (field.required !== undefined && field.required ) {
          this.f[field.name].setValidators([Validators.required]);
          this.f[field.name].updateValueAndValidity();
        }
      } else if (this.type == 'edit') {
        if (field.required !== undefined && field.required && !isHideEdit) {
          this.f[field.name].setValidators([Validators.required]);
          this.f[field.name].updateValueAndValidity();
        }
      }
    });

    // si llega data entonces hace patch value al form
    if (this.data !== undefined) {
      this.parametricoForm.patchValue(this.data);
    }

    // Verifica en los fields configurados para el parametrico si hay alguno que tenga association para entonces consultar el listado parametrico
    this.parametrico?.fields.forEach(field => {
      if (field.association !== undefined) {
        this.getParametricoAssociation(field);
      } else if (field.options !== undefined) {
        this.selectLists[field.name] = field.options;
      }
    });
  }

  // Getter para fácil acceso a los controles de formulario
  get f() {
    return this.parametricoForm.controls;
  }

  closeModal() {
    this.modalActiveService.close(null);
  }

  /**
   * Función para controlar el guardado de add o edit del formulario
   */
  saveParametricoForm() {
    this.submitted = true;
    if (this.parametricoForm.valid) {
      this.showLoading = true;
      const formSend: Parametrico | any = this.parametricoForm.value;
      // Recorre cada valor del formulario a enviar para convertir datos boolean
      Object.keys(formSend).forEach((key) => {
        // Valida si algún valor es true o false en string para enviar el dato como boolean
        if (formSend[key] === 'false') {
          formSend[key] = false;
        }
        if (formSend[key] === 'true') {
          formSend[key] = true;
        }
        // El valor es null entonces lo quita del form
        if (formSend[key] == null) {
          delete formSend[key];
        }
      });

      if (this.type == 'new') {
        this.administrativoService.saveNewParametrico(formSend, this.parametrico?.parametrico).subscribe(
          response => {
            this.modalActiveService.close(formSend);
          },
          error => {
            console.log(error);
            this.showLoading = false;
          }
        );
      } else if (this.type == 'edit') {
        this.administrativoService.saveEditParametrico(formSend, this.parametrico?.parametrico).subscribe(
          response => {
            this.modalActiveService.close(formSend);
          },
          error => {
            console.log(error);
            this.showLoading = false;
          }
        );
      }
    }
  }

  /**
   * Función que se encarga de obtener el listado de parametricos sobre campos de asociación en el form
   */
  getParametricoAssociation(field: Field) {
    if (field.association) {
      this.isLoadingSelect = true;
      this.parametricosService.getParametricosDefault(field.association).subscribe((response) => {
        this.selectLists[field.name] = response.map(element => {
          return { value: element.id, label: element.nombre };
        });
        this.isLoadingSelect = false;
      });
    }
  }

  getHideField(field: any): boolean {
    // Por defecto es false
    let hide = false;
    // Valida si el campo tiene configurado hide en edit
    if (this.type == 'edit' && field.hide_edit !== undefined && field.hide_edit) {
      hide = true;
    }
    return hide;
  }

  /**
   * Función que contiene cierta lógica personalizada por parametrico
   */
  logicCustomInit() {
    // Valida si el parametrico es institiciones
    // if (this.parametrico?.hu == 'HU273') {
    //   // Si es edit entonces debe buscar el nivel educativo
    //   if (this.type == 'edit') {
    //     this.isLoadingSelect = true;
    //     this.administrativoService.getNivelByInstitucion(this.data?.id).subscribe(
    //       response => {

    //       }
    //     );
    //   }
    // }
  }

}
