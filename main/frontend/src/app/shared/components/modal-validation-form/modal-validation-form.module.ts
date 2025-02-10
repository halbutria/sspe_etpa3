import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ModalValidationFormComponent } from "./modal-validation-form.component";

@NgModule({
  declarations: [
    ModalValidationFormComponent
  ],
  imports: [
    CommonModule,
  ],
  exports: [
    ModalValidationFormComponent
  ]
})
export class ModalValidationFormModule { }
