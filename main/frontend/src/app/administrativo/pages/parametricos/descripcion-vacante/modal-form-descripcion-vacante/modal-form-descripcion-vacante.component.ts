import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

import { ParametricosAdmin, Variable } from "../../../../domain/dto/parametricos-admin";
import { Parametrico } from "src/app/model/parametricos";

import { AdministrativoService } from "src/app/services/administrativo.service";

@Component({
  selector: 'app-modal-form-descripcion-vacante',
  templateUrl: './modal-form-descripcion-vacante.component.html',
  styleUrls: ['./modal-form-descripcion-vacante.component.css']
})
export class ModalFormDescripcionVacanteComponent implements OnInit {

  @Input() public title: string = "";
  @Input() public type: string = 'new';
  @Input() public data: Parametrico | undefined;
  @Input() public listCriterios: Parametrico[] = [];
  @Input() public parametrico: ParametricosAdmin | null = null;

  submitted: boolean = false;
  showLoading: boolean = false;
  descVacanteForm!: FormGroup;
  typeStr: string = '';
  listVariables: Variable[] = [];

  constructor(
    private administrativoService: AdministrativoService,
    public formBuilder: FormBuilder,
    public modalActiveService: NgbActiveModal,
  ) {
    this.descVacanteForm = this.formBuilder.group({
      id: [null],
      descripcion: [null, Validators.required],
      texto: [null, Validators.required],
    });
  }

  ngOnInit(): void {
    // this.typeStr = this.type == 'new' ? 'Agregar' : 'Editar';
    this.typeStr = 'Guardar';
    this.setListVariables();

    // si llega data entonces hace patch value al form
    if (this.data !== undefined) {
      this.descVacanteForm.patchValue(this.data);
    }
  }

  // Getter para fácil acceso a los controles de formulario
  get f() {
    return this.descVacanteForm.controls;
  }

  closeModal() {
    this.modalActiveService.close(null);
  }

  /**
   * Función para controlar el guardado de add o edit del formulario de criterios match
   */
  saveForm() {
    this.submitted = true;
    if (this.descVacanteForm.valid) {
      this.showLoading = true;

      let formSend: Parametrico | any = this.descVacanteForm.value;

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

  onBadgeClick(text: string) {
    this.copyToClipboard(`[${text}]`);
  }

  copyToClipboard(text: string) {
    const textarea = document.createElement('textarea');
    textarea.value = text;
    document.body.appendChild(textarea);
    textarea.select();
    document.execCommand('copy');
    document.body.removeChild(textarea);
  }

  setListVariables() {
    this.listVariables = [
      {
        codigo: "001",
        variable: "Razón social",
      },
      {
        codigo: "002",
        variable: "Tipo de documento",
      },
      {
        codigo: "003",
        variable: "Número de documento",
      },
      {
        codigo: "004",
        variable: "Sector económico",
      },
      {
        codigo: "005",
        variable: "Número de puestos de trabajo requeridos",
      },
      {
        codigo: "006",
        variable: "Nombre de vacante",
      },
      {
        codigo: "007",
        variable: "Nivel mínimo de estudios",
      },
      {
        codigo: "008",
        variable: "Tiempo de experiencia",
      },
      {
        codigo: "009",
        variable: "Ocupación",
      },
      {
        codigo: "010",
        variable: "Experiencia adicional",
      },
    ];
  }

}
