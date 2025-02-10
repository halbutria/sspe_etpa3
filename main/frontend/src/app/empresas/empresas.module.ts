import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutEmpresasComponent } from './pages/layout-empresas/layout-empresas.component';
import { HomeEmpresasComponent } from './pages/home-empresas/home-empresas.component';
import { EmpresasRoutingModule } from './empresas-routing.module';
import { RegistrarVacanteComponent } from './pages/registrar-vacante/registrar-vacante.component';
import { FooterModule } from '../shared/components/footer/footer.module';
import { HeaderModule } from '../shared/components/header/header.module';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { SeleccionarTipoRegistroVacanteComponent } from './pages/seleccionar-tipo-registro-vacante/seleccionar-tipo-registro-vacante.component';
import { NgbNavModule, NgbPaginationModule } from '@ng-bootstrap/ng-bootstrap';
import { StarRatingModule } from 'angular-star-rating';
import { ListadoVacantesComponent } from './pages/listado-vacantes/listado-vacantes.component';
import { RegistrarVacanteModule } from './pages/registrar-vacante/registrar-vacante.module';
import { HeaderUpdateModule } from '../shared/components/header-update/header-update.module';
import { ReactiveFormsModule } from '@angular/forms';
import { CountdownTimerModule } from '../shared/components/countdown-timer/countdown-timer.module';
import { VacanteDetalleListaComponent } from './pages/listado-vacantes/components/vacante-detalle-lista/vacante-detalle-lista.component';
import { DateAsAgoPipe } from '../shared/pipes/date-as-ago.pipe';
import { ModalNotificacionComponent } from './pages/listado-vacantes/components/modal-notificacion/modal-notificacion.component';
import { ModalLoadingComponent } from '../shared/components/modal-loading/modal-loading.component';
import { ModalSuccessFormModule } from '../shared/components/modal-success-form/modal-success-form.module';
import { ModalLoadingModule } from '../shared/components/modal-loading/modal-loading.module';
import { ModalErrorFormModule } from '../shared/components/modal-error-form/modal-error-form.module';
import { ModalConfirmationFormModule } from '../shared/components/modal-confirmation-form/modal-confirmation-form.module';


@NgModule({
  declarations: [
    LayoutEmpresasComponent,
    HomeEmpresasComponent,
    SeleccionarTipoRegistroVacanteComponent,
    ListadoVacantesComponent,
    VacanteDetalleListaComponent,
    DateAsAgoPipe,
    ModalNotificacionComponent
  ],
  imports: [
    CommonModule,
    EmpresasRoutingModule,
    FooterModule,
    HeaderModule,
    HeaderUpdateModule,
    FontAwesomeModule,
    NgbNavModule,
    StarRatingModule,
    NgbPaginationModule,
    RegistrarVacanteModule,
    ReactiveFormsModule,
    CountdownTimerModule,
    ModalSuccessFormModule,
    ModalLoadingModule,
    ModalErrorFormModule,
    ModalConfirmationFormModule
  ],
})
export class EmpresasModule {}
