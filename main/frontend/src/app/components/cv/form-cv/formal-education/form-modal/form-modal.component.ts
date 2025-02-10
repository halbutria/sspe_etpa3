import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";
import { NgbActiveModal, NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';

import { ParametricosService, PARAMETRICOS } from "src/app/services/parametricos.service"
import { CvService } from "src/app/services/cv.service"

import { EducacionFormal } from "src/app/model/ciudadano";
import { ParametricoListado, Parametrico } from "src/app/model/parametricos";
import { map, Observable, of } from 'rxjs';

@Component({
  selector: 'app-form-modal',
  templateUrl: './form-modal.component.html',
  styleUrls: ['./form-modal.component.css']
})
export class FormModalComponent implements OnInit {

  @Input() public type: string = 'new';
  @Input() public ciudadanoId: string = '';
  @Input() public data?: EducacionFormal;
  @Input() public list?: EducacionFormal[];

  formalEducationForm!: FormGroup;
  submitted: boolean = false;
  iniciando: boolean = false;
  showLoading: boolean = false;
  showNucleo: boolean = true;
  showPais: boolean = true;
  showFieldsTarjetaProfesional: boolean = true;
  showFieldFechaFin: boolean = true;
  showTarjetaProfesional: boolean = true;
  showPracticaEmpresarial: boolean = false;
  showInstitucionSelect: boolean = true;
  showInstitucion: boolean = true;
  typeStr: string = '';
  listTituloHomologadoFull: Parametrico[] = [];
  $listTituloHomologado: Observable<Parametrico[]> = of([]);
  controlsBloqued = ['id', 'ciudadanoId', 'nivelEducativoId'];

  fechaFinalizacion: NgbDateStruct | undefined;
  fechaExpedicion: NgbDateStruct | undefined;
  dateNow = new Date;
  minDate = { year: 1900, month: 1, day: 1 };
  minDateFExp = { year: 1900, month: 1, day: 1 };
  maxDate = { year: this.dateNow.getFullYear(), month: this.dateNow.getMonth() + 1, day: this.dateNow.getDate() };

  NIVELES6ENADELANTE = [6, 7, 8, 9, 10, 11, 12];

  constructor(
    public formBuilder: FormBuilder,
    public cvService: CvService,
    public prs: ParametricosService,
    public modalActiveService: NgbActiveModal,
  ) {
    this.formalEducationForm = this.formBuilder.group({
      id: [null],
      ciudadanoId: [null],
      nivelEducativoId: [null, Validators.required],
      nucleoConocimientoId: [null],
      areaConocimientoId: [null],
      tituloObtenido: [null, Validators.maxLength(100)],
      tituloHomologadoId: [null],
      institucion: [null],
      institucionId: [null],
      paisId: [null],
      estadoId: [null, Validators.required],
      fechaFinalizacion: [null],
      tarjetaProfesional: [null],
      numeroTarjetaProfesional: [null, [Validators.required, Validators.maxLength(20)]],
      fechaExpedicionTarjetaProfesional: [null, Validators.required],
      observacion: [null],
      practicaEmpresarial: [null],
    });
  }

  ngOnInit(): void {
    this.iniciando = true;
    this.getParametricos();
    this.cambiaNivelEducativo();
    this.cambiaNucleoConocimiento();
    this.cambiaTarjetaProfesional();
    this.cambiaEstado();
    this.cambiaPais();
    this.cambiaFechaFinalizacion();
    this.typeStr = this.type == 'new' ? 'Agregar' : 'Editar';
    this.f['ciudadanoId'].setValue(this.ciudadanoId);

    if (this.data !== undefined) {
      this.formalEducationForm.patchValue(this.data);
      this.f['tarjetaProfesional'].setValue(this.data.tarjetaProfesional === true ? '1' : '0');
      this.f['tituloHomologadoId'].setValue(this.data.tituloHomologadoId !== null ? this.data.tituloHomologadoId?.toString() : this.data.tituloHomologadoId);
      this.f['institucionId'].setValue(this.data.institucionId !== null ? this.data.institucionId?.toString() : this.data.institucionId);
      this.fechaFinalizacion = this.cvService.convertStringToDate(this.data.fechaFinalizacion);
      this.fechaExpedicion = this.cvService.convertStringToDate(this.data.fechaExpedicionTarjetaProfesional);
    }
    setTimeout(() => {
      this.iniciando = false;
    }, 500);
  }

  // Getter para fácil acceso a los controles de formulario
  get f() {
    return this.formalEducationForm.controls;
  }

  getParametricos() {
    // this.cvService.$tituloHomologado.subscribe(titulos => { this.listTituloHomologadoFull = titulos });
  }

  addFormalEducation() {
    this.submitted = true;
    if (this.formalEducationForm.valid) {
      this.showLoading = true;
      // this.formalEducationForm.disable();
      const formSend: EducacionFormal = this.formalEducationForm.value;

      formSend.tarjetaProfesional = this.f['tarjetaProfesional'].value == 1 ? true : false;
      formSend.areaConocimientoId = (this.f['areaConocimientoId'].value === null || this.f['areaConocimientoId'].value === '') ? null : +this.f['areaConocimientoId'].value;
      formSend.estadoId = +this.f['estadoId'].value;
      formSend.nivelEducativoId = +this.f['nivelEducativoId'].value;
      formSend.nucleoConocimientoId = (this.f['nucleoConocimientoId'].value === null || this.f['nucleoConocimientoId'].value === '') ? null : +this.f['nucleoConocimientoId'].value;
      formSend.paisId = (this.f['paisId'].value === null || this.f['paisId'].value === '') ? null : +this.f['paisId'].value;
      formSend.tituloHomologadoId = (this.f['tituloHomologadoId'].value === null || this.f['tituloHomologadoId'].value === '') ? null : +this.f['tituloHomologadoId'].value;
      formSend.institucionId = (this.f['institucionId'].value === null || this.f['institucionId'].value === '') ? null : +this.f['institucionId'].value;
      formSend.fechaFinalizacion = this.cvService.convertSringDate(this.f['fechaFinalizacion'].value);
      formSend.fechaExpedicionTarjetaProfesional = this.cvService.convertSringDate(this.f['fechaExpedicionTarjetaProfesional'].value);
      formSend.practicaEmpresarial = this.f['practicaEmpresarial'].value === null ? false : this.f['practicaEmpresarial'].value;

      if (this.type == 'new') {
        this.cvService.addFormalEducation(formSend).subscribe(
          response => {
            if (this.list?.length == 0) {
              this.cvService.putTieneEducacionFormal(this.ciudadanoId, true).subscribe(
                response => {
                  this.cvService.toggleBooleanDataCiudadano('tieneEducacionFormal', response.tieneEducacionFormal);
                },
                error => {
                  console.log(error);
                }
              );
            }
            this.showLoading = false;
            this.modalActiveService.close(formSend);
          },
          error => {
            this.showLoading = false;
            console.log(error);
          }
        );
      } else if (this.type == 'edit') {
        this.cvService.editFormalEducation(formSend).subscribe(
          response => {
            this.showLoading = false;
            this.modalActiveService.close(response);
          },
          error => {
            this.showLoading = false;
            console.log(error);
          }
        );
      }
    }
  }

  onCheckboxChange(e: any) {
    if (e.target.checked) {
      this.f['practicaEmpresarial'].setValue(true);
    } else {
      this.f['practicaEmpresarial'].setValue(false);
    }
  }

  closeModal() {
    this.modalActiveService.close(null);
  }

  cambiaNivelEducativo() {
    this.f['nivelEducativoId'].valueChanges.subscribe(
      nivel => {
        if (nivel !== null && nivel !== undefined) {
          if (!this.iniciando) {
            // Recorre todos los controles del formulario para hacerles reset menos los bloqueados de reset
            Object.keys(this.formalEducationForm.controls).forEach(key => {
              if (!this.controlsBloqued.includes(key)) {
                this.f[key].reset();
              }
            });
          }
          const nivelesConNucleo = [7, 8, 9, 10, 11, 12];
          const nivelesConTituloHomologado = [2, 3, 4, 5, 13, 14, 15, 16, 17, 18, 19, 20, 21];

          this.f['nucleoConocimientoId'].clearValidators();
          this.f['areaConocimientoId'].clearValidators();
          this.f['tituloHomologadoId'].clearValidators();
          this.f['paisId'].clearValidators();
          this.f['tarjetaProfesional'].clearValidators();

          // Validacion Nucleo de conocimiento
          if (nivelesConNucleo.includes(+nivel)) {
            this.showNucleo = true;
            this.f['nucleoConocimientoId'].addValidators([Validators.required]);
          } else {
            this.showNucleo = false;
          }
          // Validacion Area de conocimiento
          if (nivel == 6) {
            this.f['areaConocimientoId'].addValidators([Validators.required]);
          } else if (nivelesConTituloHomologado.includes(+nivel)) {
            // Validacion Titulo homologado
            this.$listTituloHomologado = this.prs.getParametricos(PARAMETRICOS.TITULO_HOMOLOGADO).pipe(
              map(titulos => {
                return titulos.filter(item => item.nivelEducativoId == nivel);
              })
            );
            if (+nivel !== 4) {
              this.$listTituloHomologado.subscribe(
                listado => {
                  if (listado[0] !== undefined) {
                    // Setea el por defecto del titulo homologado
                    if (!this.iniciando) {
                      this.f['tituloHomologadoId'].setValue(listado[0].id);
                    }
                  }
                }
              );
            }
            this.f['tituloHomologadoId'].addValidators([Validators.required]);
            // Validacion Institución
            this.setValidarInstitucion(true);
          } else if (this.f['nucleoConocimientoId'].value !== '' || this.f['nucleoConocimientoId'].value !== null) {
            this.$listTituloHomologado = this.prs.getParametricos(PARAMETRICOS.TITULO_HOMOLOGADO).pipe(
              map(titulos => {
                return titulos.filter(item => item.nivelEducativoId == nivel && item.nucleoConocimientoId == this.f['nucleoConocimientoId'].value);
              },)
            );
            this.f['tituloHomologadoId'].addValidators([Validators.required]);
          }
          // Validaciones del nivel educativo 6 en adelante
          if (this.NIVELES6ENADELANTE.includes(+nivel)) {
            // Pais
            this.f['paisId'].addValidators([Validators.required]);
            // Tarjeta profesional
            if (this.f['estadoId'].value == 3) {
              this.showTarjetaProfesional = true;
              this.showPracticaEmpresarial = true;
              this.f['tarjetaProfesional'].addValidators([Validators.required]);
            } else {
              this.showTarjetaProfesional = false;
              this.showPracticaEmpresarial = false;
            }
            // Validacion Institución
            this.setValidarInstitucion(false);
          } else {
            this.showTarjetaProfesional = false;
          }

          this.f['nucleoConocimientoId'].updateValueAndValidity();
          this.f['areaConocimientoId'].updateValueAndValidity();
          this.f['tituloHomologadoId'].updateValueAndValidity();
          this.f['paisId'].updateValueAndValidity();
          this.f['tarjetaProfesional'].updateValueAndValidity();
        }
      }
    );
  }

  cambiaNucleoConocimiento() {
    this.f['nucleoConocimientoId'].valueChanges.subscribe(
      nucleo => {
        if (nucleo !== null && nucleo !== 0 && nucleo !== undefined && nucleo !== '') {
          const nivel = this.f['nivelEducativoId'].value;
          this.$listTituloHomologado = this.prs.getParametricos(PARAMETRICOS.TITULO_HOMOLOGADO).pipe(
            map(titulos => {
              return titulos.filter(item => item.nivelEducativoId == nivel && item.nucleoConocimientoId == nucleo);
            })
          );
        }
      }
    );
  }

  cambiaTarjetaProfesional() {
    this.f['tarjetaProfesional'].valueChanges.subscribe(
      value => {
        this.f['numeroTarjetaProfesional'].clearValidators();
        this.f['fechaExpedicionTarjetaProfesional'].clearValidators();
        // Si la tarjeta cambia a si, entonces pide requerido el numero y la fecha
        if (value == 1) {
          this.showFieldsTarjetaProfesional = true;
          this.f['numeroTarjetaProfesional'].addValidators([Validators.required, Validators.maxLength(20)]);
          this.f['fechaExpedicionTarjetaProfesional'].addValidators([Validators.required]);
        } else {
          this.showFieldsTarjetaProfesional = false;
          this.f['numeroTarjetaProfesional'].setValue('');
          this.f['fechaExpedicionTarjetaProfesional'].setValue('');
        }
        this.f['numeroTarjetaProfesional'].updateValueAndValidity();
        this.f['fechaExpedicionTarjetaProfesional'].updateValueAndValidity();
      }
    );
  }

  cambiaEstado() {
    this.f['estadoId'].valueChanges.subscribe(
      value => {
        if (value !== null) {
          this.f['fechaFinalizacion'].clearValidators();
          this.f['tarjetaProfesional'].clearValidators();

          // Si el estado es incompleto o graduado, entonces pide requerida la fecha de finalización
          if (value == 2 || value == 3) {
            this.showFieldFechaFin = true;
            this.f['fechaFinalizacion'].addValidators([Validators.required]);
          } else {
            this.showFieldFechaFin = false;
            this.f['fechaFinalizacion'].setValue('');
          }
          // Validaciones Tarjeta profesional
          if (value == 3 && this.NIVELES6ENADELANTE.includes(+this.f['nivelEducativoId'].value)) {
            this.f['tarjetaProfesional'].addValidators([Validators.required]);
            this.showTarjetaProfesional = true;
            this.showPracticaEmpresarial = true;
          } else {
            this.showTarjetaProfesional = false;
            this.showPracticaEmpresarial = false;
          }

          this.f['fechaFinalizacion'].updateValueAndValidity();
          this.f['tarjetaProfesional'].updateValueAndValidity();
        }
      }
    );
  }

  /**
   * Función que se encarga de asegurar que el campo institucion SELECT en el formuarlio cambie
   */
  cambiaInstitucion($event: { itemData: Parametrico; }) {
    let itemData: Parametrico = $event.itemData;
    setTimeout(() => {
      this.f['institucionId'].setValue(itemData.id);
    }, 300);
  }

  setValidarInstitucion(mediaAbajo: boolean) {
    /**
     *  - Nivel educativo es de media hacia abajo debe ser un texto abierto y NO obligatorio
     *  - Nivel educativo de tecnico laboral hacia arriba y el pais es difernte a COlombia es obligatorio y texto abierto
     *  - Nivel educativo de tecnico laboral hacia arriba y el pais es Colombia debe mostrar el campo select con búsqueda con listado de parametricos (institucion) REQUERIDO
     */
    this.f['institucionId'].clearValidators();
    this.f['institucion'].clearValidators();
    const pais = this.f['paisId'].value;

    if (mediaAbajo) {
      this.showInstitucion = true;
      this.showInstitucionSelect = false;
    } else {
      if (pais == 48) {
        this.showInstitucionSelect = true;
        this.showInstitucion = false;
        this.f['institucionId'].addValidators([Validators.required]);
        if (!this.iniciando) {
          this.f['institucion'].setValue(null);
        }
      } else {
        this.showInstitucionSelect = false;
        this.showInstitucion = true;
        this.f['institucion'].addValidators([Validators.required]);
        if (!this.iniciando) {
          this.f['institucionId'].setValue(null);
        }
      }
    }

    this.f['institucionId'].updateValueAndValidity();
    this.f['institucion'].updateValueAndValidity();
  }

  cambiaPais() {
    this.f['paisId'].valueChanges.subscribe(
      pais => {
        if (pais !== null && pais !== undefined && pais !== '') {
          // Validacion Institución
          const nivel = this.f['nivelEducativoId'].value;
          if (nivel <= 5) {
            this.setValidarInstitucion(true);
          } else {
            this.setValidarInstitucion(false);
          }
        }
      }
    );
  }

  cambiaFechaFinalizacion() {
    this.f['fechaFinalizacion'].valueChanges.subscribe(
      fecha => {
        if (fecha !== null && fecha !== undefined && fecha !== '') {
          // Setea la fecha mínima para la fecha de expedición de la tarjeta
          this.minDateFExp = fecha;
        }
      }
    );
  }

}
