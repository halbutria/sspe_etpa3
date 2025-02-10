import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { Routes } from '@angular/router';
import { NgbPaginationModule, NgbAlertModule, NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { AdministrativoComponent } from "./administrativo.component";
import { HeaderUpdateModule } from "../shared/components/header-update/header-update.module";
import { HeaderModule } from "../shared/components/header/header.module";
import { FooterModule } from "../shared/components/footer/footer.module";
import { MenuComponent } from './pages/menu/menu.component';
import { ContentComponent } from './pages/content/content.component';
import { ListFilterPipe } from './domain/pipe/list-filter.pipe';
import { AddModalFormComponent } from './pages/content/add-modal-form/add-modal-form.component';

import { CriteriosMatchComponent } from './pages/parametricos/criterios-match/criterios-match.component';
import { ModalFormCriteriosMatchComponent } from './pages/parametricos/criterios-match/modal-form-criterios-match/modal-form-criterios-match.component';

import { DescripcionVacanteComponent } from './pages/parametricos/descripcion-vacante/descripcion-vacante.component';
import { ModalFormDescripcionVacanteComponent } from './pages/parametricos/descripcion-vacante/modal-form-descripcion-vacante/modal-form-descripcion-vacante.component';
import { InstitucionesComponent } from './pages/parametricos/instituciones/instituciones.component';
import { ModalFormInstitucionesComponent } from './pages/parametricos/instituciones/modal-form-instituciones/modal-form-instituciones.component';

export const LAZY_ROUTES: Routes = [
  {
    path: '',
    component: AdministrativoComponent,
    children: [
      {
        path: 'menu',
        component: MenuComponent
      }, {
        path: 'content',
        component: ContentComponent
      }
    ]
  }
];

@NgModule({
  declarations: [
    AdministrativoComponent,
    ContentComponent,
    ListFilterPipe,
    MenuComponent,
    AddModalFormComponent,
    CriteriosMatchComponent,
    ModalFormCriteriosMatchComponent,
    DescripcionVacanteComponent,
    ModalFormDescripcionVacanteComponent,
    InstitucionesComponent,
    ModalFormInstitucionesComponent,
  ],
  imports: [
    CommonModule,
    FormsModule,
    FooterModule,
    HeaderModule,
    HeaderUpdateModule,
    NgbPaginationModule,
    NgbAlertModule,
    NgbModule,
    ReactiveFormsModule
  ]
})
export class AdministrativoModule { }
