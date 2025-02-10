import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ModalConfirmationFormComponent } from "./modal-confirmation-form.component";

@NgModule({
  declarations: [
    ModalConfirmationFormComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    ModalConfirmationFormComponent
  ]
})
export class ModalConfirmationFormModule { }
