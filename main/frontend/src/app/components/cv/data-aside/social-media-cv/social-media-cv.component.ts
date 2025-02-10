import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";
import { NgbActiveModal, NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';

import { ParametricosService, PARAMETRICOS, PARAMETRICOS_FILTROS } from "src/app/services/parametricos.service"
import { CvService } from "src/app/services/cv.service"

import { RedSocial } from "src/app/model/ciudadano";
import { ParametricoListado, Parametrico } from "src/app/model/parametricos";
import { TitleStrategy } from '@angular/router';

@Component({
  selector: 'app-social-media-cv',
  templateUrl: './social-media-cv.component.html',
  styleUrls: ['./social-media-cv.component.css']
})
export class SocialMediaCvComponent implements OnInit {

  @Input() public ciudadanoId: string = '';
  @Input() public type: string = 'new';
  @Input() public data?: RedSocial;

  socialMediaForm!: FormGroup;
  submitted: boolean = false;
  showLoading: boolean = false;
  typeStr: string = '';
  msgError: string = '';

  constructor(
    public formBuilder: FormBuilder,
    public cvService: CvService,
    public prs: ParametricosService,
    public modalActiveService: NgbActiveModal,
  ) {
    this.socialMediaForm = this.formBuilder.group({
      id: [null],
      ciudadanoId: [null],
      redSocialId: [null, Validators.required],
      nombreRedSocial: [null],
      nombreUsuarioRedSocial: [null, Validators.required],
    });
  }

  ngOnInit(): void {
    this.f['ciudadanoId'].setValue(this.ciudadanoId);
    this.typeStr = this.type == 'new' ? 'Agregar' : 'Editar';
    this.cambiaRedSocial();

    if (this.data !== undefined) {
      this.socialMediaForm.patchValue(this.data);
    }
  }

  // Getter para fácil acceso a los controles de formulario
  get f() {
    return this.socialMediaForm.controls;
  }

  addSocialMedia() {
    this.submitted = true;
    this.msgError = '';
    if (this.socialMediaForm.valid) {
      this.showLoading = true;
      const formSend: RedSocial = this.socialMediaForm.value;
      // formSend.redSocialId = +this.f['redSocialId'].value;

      if (this.type == 'new') {
        this.cvService.addRedSocial(formSend).subscribe(
          response => {
            // Responde al padre con el item creado
            this.showLoading = false;
            this.modalActiveService.close(formSend);
          },
          error => {
            this.showLoading = false;
            console.log(error);
            this.msgError = error.error.error;
          }
        );
      } else if (this.type == 'edit') {
        this.cvService.editRedSocial(formSend).subscribe(
          response => {
            this.showLoading = false;
            this.modalActiveService.close(response);
          },
          error => {
            this.showLoading = false;
            console.log(error);
            this.msgError = error.error.error;
          }
        );
      }
    }
  }

  cambiaRedSocial() {
    this.f['redSocialId'].valueChanges.subscribe(
      red => {
        if (red !== null) {
          this.f['nombreRedSocial'].clearValidators();
          // Otra red social
          if (red == 5) {
            this.f['nombreRedSocial'].addValidators([Validators.required]);
          } else {
            this.f['nombreRedSocial'].setValue('');
          }
          this.f['nombreRedSocial'].updateValueAndValidity();
        }

      }
    );
  }

  closeModal() {
    this.modalActiveService.close(null);
  }

}
