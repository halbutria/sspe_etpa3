import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { Routes } from '@angular/router';

import { NgbPaginationModule, NgbAlertModule, NgbModule, NgbDateParserFormatter } from '@ng-bootstrap/ng-bootstrap';
import { RecaptchaV3Module, RECAPTCHA_V3_SITE_KEY } from 'ng-recaptcha';
import { NgxCaptchaModule } from 'ngx-captcha';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import { environment } from '../../../environments/environment';
import { RegisterComponent } from "./register.component";
import { ValidateComponent } from "./validate/validate.component";
import { BasicDataComponent } from "./basic-data/basic-data.component";
import { NotificationsComponent } from './notifications/notifications.component';
import { HeaderModule } from '../../shared/components/header/header.module';
import { FooterModule } from '../../shared/components/footer/footer.module';
import { HeaderComponent } from "../../shared/components/header/header.component";
import { ModalResponseComponent } from './notifications/modal-response/modal-response.component';
import { ModalValidationComponent } from './modal-validation/modal-validation.component';
import { NgbDateCustomParserFormatter } from "../../shared/date-format";
import { ComplementosDireccionModalComponent } from './basic-data/complementos-direccion-modal/complementos-direccion-modal.component';
import { TratamientoDatosModalComponent } from './basic-data/tratamiento-datos-modal/tratamiento-datos-modal.component';

export const LAZY_ROUTES: Routes = [
  {
    path: '',
    component: ValidateComponent,
    children: [
      {
        path: 'validate',
        component: ValidateComponent
      },
      {
        path: 'notifications',
        component: NotificationsComponent
      },
      {
        path: 'header',
        component: HeaderComponent
      }
    ]
  }
];

@NgModule({
  declarations: [
    RegisterComponent,
    ValidateComponent,
    BasicDataComponent,
    NotificationsComponent,
    ModalResponseComponent,
    ModalValidationComponent,
    ComplementosDireccionModalComponent,
    TratamientoDatosModalComponent
  ],
  imports: [
    CommonModule,
    FontAwesomeModule,
    FormsModule,
    BrowserModule,
    NgbPaginationModule,
    NgbAlertModule,
    NgbModule,
    NgxCaptchaModule,
    ReactiveFormsModule,
    RecaptchaV3Module,
    HeaderModule,
    FooterModule
  ],
  providers: [
    { provide: NgbDateParserFormatter, useClass: NgbDateCustomParserFormatter },
    {
      provide: RECAPTCHA_V3_SITE_KEY,
      useValue: environment.recaptcha.siteKey,
    }
  ]
})
export class RegisterModule { }
