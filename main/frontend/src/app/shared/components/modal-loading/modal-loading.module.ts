import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ModalLoadingComponent } from './modal-loading.component';



@NgModule({
  declarations: [
    ModalLoadingComponent
  ],
  imports: [
    CommonModule,    
  ],
  exports: [
    ModalLoadingComponent
  ]
})
export class ModalLoadingModule { }
