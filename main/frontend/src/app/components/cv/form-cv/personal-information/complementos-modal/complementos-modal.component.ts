import { Component, OnInit } from '@angular/core';
import { NgbActiveModal, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";

import { PARAMETRICOS, ParametricosService, PARAMETRICOS_FILTROS } from "src/app/services/parametricos.service";
import { CvService } from "src/app/services/cv.service";
import { Complemento } from 'src/app/model/ciudadano';

@Component({
  selector: 'app-complementos-modal',
  templateUrl: './complementos-modal.component.html',
  styleUrls: ['./complementos-modal.component.css']
})
export class ComplementosModalComponent implements OnInit {

  complementForm!: FormGroup;
  submitted: boolean = false;
  listComplementos: { id: string, texto: string }[] = [];

  constructor(
    public formBuilder: FormBuilder,
    public activeModal: NgbActiveModal,
    public cvService: CvService,
  ) {
    this.complementForm = this.formBuilder.group({
      direccionId: [null],
      complementoId: [null, Validators.required],
      complementoNombre: [null],
      complemento: [null, Validators.required],
    });
  }

  ngOnInit(): void {
    this.getParametricos();
  }

  // Getter para fácil acceso a los controles de formulario
  get f() {
    return this.complementForm.controls;
  }

  getParametricos() {
    this.listComplementos = this.cvService.getListComplementos;
  }

  saveAddComplement() {
    if (this.complementForm.valid) {
      this.submitted = true;
      const formResponse: Complemento = this.complementForm.value;
      formResponse.complementoNombre = this.listComplementos[this.listComplementos.findIndex(c => c.id == formResponse.complementoId)].texto;
      this.activeModal.close(formResponse);
    }

  }

}
