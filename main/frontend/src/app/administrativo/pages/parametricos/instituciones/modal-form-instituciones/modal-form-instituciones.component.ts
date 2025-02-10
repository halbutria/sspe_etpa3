import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

import { ParametricosAdmin, Variable } from "../../../../domain/dto/parametricos-admin";
import { Parametrico } from "src/app/model/parametricos";

import { AdministrativoService } from "src/app/services/administrativo.service";
import { ParametricosService } from "src/app/services/parametricos.service";

@Component({
  selector: 'app-modal-form-instituciones',
  templateUrl: './modal-form-instituciones.component.html',
  styleUrls: ['./modal-form-instituciones.component.css']
})
export class ModalFormInstitucionesComponent implements OnInit {

  @Input() public title: string = "";
  @Input() public type: string = 'new';
  @Input() public data: Parametrico | undefined;
  @Input() public listNiveles: Parametrico[] = [];
  @Input() public parametrico: ParametricosAdmin | null = null;
  @Input() public nivelSelected: ParametricosAdmin | undefined;

  submitted: boolean = false;
  showLoading: boolean = false;
  institucionesForm!: FormGroup;
  typeStr: string = '';
  isLoadingSelect: boolean = false;
  listInstituciones: Parametrico[] = [];

  constructor(
    private administrativoService: AdministrativoService,
    public formBuilder: FormBuilder,
    public modalActiveService: NgbActiveModal,
    public parametricosService: ParametricosService,
  ) {
    this.institucionesForm = this.formBuilder.group({
      id: [null],
      nombre: [null],
      institucionId: [null],
      nivelEducativoId: [null, Validators.required],
    });
  }

  ngOnInit(): void {
    // this.typeStr = this.type == 'new' ? 'Agregar' : 'Editar';
    this.typeStr = 'Guardar';

    // si llega data entonces hace patch value al form
    if (this.data !== undefined) {
      this.institucionesForm.patchValue(this.data);
    }
    // Valida si hay nivel seleccionado entonces agrega el valor al campo
    if (this.nivelSelected !== undefined) {
      this.f['nivelEducativoId'].setValue(this.nivelSelected?.id);
    }
    // Realiza diferentes acciones depende del tipo
    switch (this.type) {
      case 'new':
        this.f['nivelEducativoId'].setValidators([Validators.required]);
        this.f['nivelEducativoId'].updateValueAndValidity();
        break;
      case 'associate':
        this.getInstituciones();
        this.f['institucionId'].setValidators([Validators.required]);
        this.f['institucionId'].updateValueAndValidity();
        break;
    }
  }

  // Getter para fácil acceso a los controles de formulario
  get f() {
    return this.institucionesForm.controls;
  }

  closeModal() {
    this.modalActiveService.close(null);
  }

  /**
   * Función para controlar el guardado de add del formulario de instituciones relacionado a un nievel educativo
   */
  saveForm() {
    this.submitted = true;
    if (this.institucionesForm.valid) {
      this.showLoading = true;
      const nivelEducativoId = this.f["nivelEducativoId"].value;

      let formSend: Parametrico | any = this.institucionesForm.value;

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
        // Si es new entonces hay que crear y de una vez lo asocia
        this.administrativoService.saveNewParametrico(formSend, this.parametrico?.parametrico).subscribe(
          response => {
            this.modalActiveService.close(formSend);
          },
          error => {
            console.log(error);
            this.showLoading = false;
          }
        );
      } else if (this.type == 'associate') {
        const institucionId = this.f["institucionId"].value;
        this.administrativoService.associateInstitucionNivelEducativo(nivelEducativoId, institucionId).subscribe(
          responseAssociate => {
            this.modalActiveService.close(formSend);
          },
          errorAs => {
            console.log(errorAs);
            this.showLoading = false;
          }
        );
      }
    }
  }

  /**
   * Función que consulta el listado de las instituciones
   */
  getInstituciones() {
    this.isLoadingSelect = true;
    this.parametricosService.getParametricosDefault('Institucion').subscribe(
      (response) => {
        this.listInstituciones = response;
        this.isLoadingSelect = false;
    });
  }

}
