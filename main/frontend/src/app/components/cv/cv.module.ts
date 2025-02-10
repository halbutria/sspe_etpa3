import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { Routes } from '@angular/router';

import { NgbPaginationModule, NgbAlertModule, NgbModule, NgbRatingModule } from '@ng-bootstrap/ng-bootstrap';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { DropDownListModule, MultiSelectModule } from '@syncfusion/ej2-angular-dropdowns';

import { CvComponent } from "./cv.component";
import { HeaderModule } from '../../shared/components/header/header.module';
import { FooterModule } from '../../shared/components/footer/footer.module';
import { SocialMediaCvComponent } from './data-aside/social-media-cv/social-media-cv.component';
import { ModalValidationFormModule } from '../../shared/components/modal-validation-form/modal-validation-form.module';
import { ModalConfirmationFormModule } from '../../shared/components/modal-confirmation-form/modal-confirmation-form.module';
import { ModalSuccessFormModule } from '../../shared/components/modal-success-form/modal-success-form.module';
import { DisabilityNavigationModule } from '../../shared/components/disability-navigation/disability-navigation.module';
import { MainNavigationComponent } from './main-navigation/main-navigation.component';
import { DataAsideComponent } from './data-aside/data-aside.component';
import { FormCvComponent } from './form-cv/form-cv.component';
import { PersonalInformationComponent } from './form-cv/personal-information/personal-information.component';
import { FormalEducationComponent } from './form-cv/formal-education/formal-education.component';
import { WorkingInformationComponent } from './form-cv/working-information/working-information.component';
import { NoFormalEducationComponent } from './form-cv/no-formal-education/no-formal-education.component';
import { KnowledgeSkillsComponent } from './form-cv/knowledge-skills/knowledge-skills.component';
import { FormModalComponent } from './form-cv/formal-education/form-modal/form-modal.component';
import { ModalFormWorkingInformationComponent } from './form-cv/working-information/modal-form-working-information/modal-form-working-information.component';
import { ComplementosModalComponent } from './form-cv/personal-information/complementos-modal/complementos-modal.component';
import { ModalFormNoFormalEducationComponent } from './form-cv/no-formal-education/modal-form-no-formal-education/modal-form-no-formal-education.component';
import { HeaderUpdateModule } from 'src/app/shared/components/header-update/header-update.module';
// Idioma
import { LanguagesComponent } from './form-cv/languages/languages.component';
import { ModalFormLanguagesComponent } from './form-cv/languages/modal-form-languages/modal-form-languages.component';
// Experiencia previa
import { PreviousExperienceComponent } from './form-cv/previous-experience/previous-experience.component';
import { FormModalPreviousExperienceComponent } from './form-cv/previous-experience/form-modal-previous-experience/form-modal-previous-experience.component';
import { InformacionEquivalenciasComponent } from './form-cv/previous-experience/informacion-equivalencias/informacion-equivalencias.component';

export const LAZY_ROUTES: Routes = [
  {
    path: '',
    component: CvComponent,
    children: [
      {
        path: 'main-navigation',
        component: MainNavigationComponent
      },
      {
        path: 'data-aside',
        component: DataAsideComponent
      },
      {
        path: 'form-cv',
        component: FormCvComponent
      }
    ]
  }
];

@NgModule({
  declarations: [
    CvComponent,
    MainNavigationComponent,
    DataAsideComponent,
    FormCvComponent,
    PersonalInformationComponent,
    FormalEducationComponent,
    WorkingInformationComponent,
    NoFormalEducationComponent,
    LanguagesComponent,
    KnowledgeSkillsComponent,
    FormModalComponent,
    ModalFormWorkingInformationComponent,
    ComplementosModalComponent,
    ModalFormNoFormalEducationComponent,
    ModalFormLanguagesComponent,
    PreviousExperienceComponent,
    FormModalPreviousExperienceComponent,
    InformacionEquivalenciasComponent,
    SocialMediaCvComponent
  ],
  imports: [
    BrowserModule,
    CommonModule,
    DisabilityNavigationModule,
    DropDownListModule,
    FormsModule,
    FooterModule,
    FontAwesomeModule,
    HeaderModule,
    HeaderUpdateModule,
    ModalValidationFormModule,
    ModalConfirmationFormModule,
    ModalSuccessFormModule,
    MultiSelectModule,
    NgbAlertModule,
    NgbModule,
    NgbPaginationModule,
    NgbRatingModule,
    ReactiveFormsModule
  ]
})
export class CvModule { }
