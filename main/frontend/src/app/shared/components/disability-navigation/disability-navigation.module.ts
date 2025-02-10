import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import { DisabilityNavigationComponent } from "./disability-navigation.component";

@NgModule({
  declarations: [
    DisabilityNavigationComponent
  ],
  imports: [
    CommonModule,
    FontAwesomeModule
  ],
  exports: [
    DisabilityNavigationComponent
  ]
})
export class DisabilityNavigationModule { }
