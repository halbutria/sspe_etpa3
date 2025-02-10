import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";
import { NgbActiveModal, NgbModal } from '@ng-bootstrap/ng-bootstrap';

import { Parametrico } from "src/app/model/parametricos";
import { ParametricosAdmin } from "../../../../domain/dto/parametricos-admin";

import { AdministrativoService } from "src/app/services/administrativo.service";

@Component({
  selector: 'app-modal-form-criterios-match',
  templateUrl: './modal-form-criterios-match.component.html',
  styleUrls: ['./modal-form-criterios-match.component.css']
})
export class ModalFormCriteriosMatchComponent implements OnInit {

  @Input() public title: string = "";
  @Input() public type: string = 'new';
  @Input() public data: Parametrico | undefined;
  @Input() public listCriterios: Parametrico[] = [];
  @Input() public currentTipoVacante: number = 1;

  submitted: boolean = false;
  showLoading: boolean = false;
  criterioForm!: FormGroup;
  typeStr: string = '';
  msg: string = '';

  constructor(
    private administrativoService: AdministrativoService,
    public formBuilder: FormBuilder,
    public modalActiveService: NgbActiveModal,
  ) {
    this.criterioForm = this.formBuilder.group({
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
      descripcion: [null, Validators.required],
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
      tipoVacanteId: [null],
      peso: [0, Validators.required],
      estado: [false, Validators.required],
      fechaCreacion: [null],
      fechaModificacion: [null],
    });
  }

  ngOnInit(): void {
    // this.typeStr = this.type == 'new' ? 'Agregar' : 'Editar';
    this.typeStr = 'Guardar';

    // si llega data entonces hace patch value al form
    if (this.data !== undefined) {
      this.criterioForm.patchValue(this.data);
    }
  }

  // Getter para fácil acceso a los controles de formulario
  get f() {
    return this.criterioForm.controls;
  }

  closeModal() {
    this.modalActiveService.close(null);
  }

  /**
   * Función para controlar el guardado de add o edit del formulario de criterios match
   */
  saveForm() {
    this.submitted = true;
    if (this.criterioForm.valid) {
      this.showLoading = true;
      this.msg = '';

      let formSend: Parametrico | any = this.criterioForm.value;
      formSend.tipoVacanteId = this.currentTipoVacante;

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

      // Valida el peso total
      if (this.validaPesoTotal(formSend)) {
        if (this.type == 'new') {
          this.administrativoService.saveNewParametrico(formSend, 'CriterioMatch').subscribe(
            response => {
              this.modalActiveService.close(formSend);
            },
            error => {
              console.log(error);
              this.showLoading = false;
            }
          );
        } else if (this.type == 'edit') {
          this.administrativoService.saveEditParametrico(formSend, 'CriterioMatch').subscribe(
            response => {
              this.modalActiveService.close(formSend);
            },
            error => {
              console.log(error);
              this.showLoading = false;
            }
          );
        }
      } else {
        this.msg = 'La sumatoria del peso de los criterios no debe ser mayor a 100!';
        this.showLoading = false;
      }

    }
  }

  /**
   * Función que valida el número en el campo peso
   */
  validarNumeroPeso(event: KeyboardEvent) {
    // Obtén el valor actual del campo de entrada
    const inputValue = (event.target as HTMLInputElement).value;
    // Obtén el código de la tecla presionada
    const keyCode = event.keyCode || event.which;
    // Verifica si el código de la tecla está en el rango de los dígitos del 0 al 9
    const isDigit = keyCode >= 48 && keyCode <= 57;

    // Valida que solo se ingrese un máximo de 2 dígitos
    if (!isDigit || inputValue.length >= 2) {
      event.preventDefault(); // Evita que se ingrese el carácter
    }
  }

  /**
   * Función que valida el total del peso de cada criterio. La sumatoria de los que hayan activos debe ser máximo 100
   */
  validaPesoTotal(data: Parametrico | null = null) {
    const id = data?.id;
    let sumaPeso = 0;

    // Verifica si existe id  para la validación
    if (id !== undefined) {
      // Extrae el peso del listado sin tener en cuenta el id
      sumaPeso = this.listCriterios.reduce((totalPeso, item) => {
        if (item.estado === true && typeof item.peso === 'number' && item.id !== id) {
          return totalPeso + item.peso;
        }
        return totalPeso;
      }, 0);
    } else {
      // Extrae el peso del listado sin tener
      sumaPeso = this.listCriterios.reduce((totalPeso, item) => {
        if (item.estado === true && typeof item.peso === 'number') {
          return totalPeso + item.peso;
        }
        return totalPeso;
      }, 0);
    }

    // Suma el peso de la data del formulario ya sea que sea de nuevo o edit, pero sólo si está activo
    sumaPeso += data && typeof data.peso === 'number' && data.estado ? data.peso : 0;

    return sumaPeso <= 100 ? true : false;
  }

  /**
   * Función que devuelve el criterio como parametrico
   */
  returnCriterio() {
    this.submitted = true;
    if (this.criterioForm.valid) {
      this.showLoading = true;

      let formSend: Parametrico | any = this.criterioForm.value;
      formSend.tipoVacanteId = this.currentTipoVacante;

      // Si el peso es null por defecto lo pone en 0 y si es 0 el activo siempre va a ser false
      if (formSend.peso == null) {
        formSend.peso = 0;
      }
      formSend.estado = formSend.peso == 0 ? false : true;

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

      this.modalActiveService.close(formSend);
    }
  }

}
