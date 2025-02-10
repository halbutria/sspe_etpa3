import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';


import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import { NgbAlertModule, NgbDateParserFormatter, NgbDatepickerI18n, NgbDatepickerModule, NgbModule, NgbNavModule } from '@ng-bootstrap/ng-bootstrap';
import { NgxMaskModule, IConfig } from 'ngx-mask';
import { StarRatingModule } from 'angular-star-rating';
import { RegistrarVacanteComponent } from './registrar-vacante.component';
import { RegistrarVacanteInformacionGeneralComponent } from './components/registrar-vacante-informacion-general/registrar-vacante-informacion-general.component';
import { RegistrarVacanteDescripcionComponent } from './components/registrar-vacante-descripcion/registrar-vacante-descripcion.component';
import { RegistrarVacacanteDetalleContratacionComponent } from './components/registrar-vacacante-detalle-contratacion/registrar-vacacante-detalle-contratacion.component';
import { RegistrarVacanteService } from '../../use-cases/registrar-vacante.service';
import { ReactiveFormsModule } from '@angular/forms';
import { DropDownListModule, MultiSelectModule } from '@syncfusion/ej2-angular-dropdowns';
import { NgbDateCustomParserFormatter } from 'src/app/shared/date-format';
import { CustomDatepickerI18nService, I18n } from 'src/app/services/custom-datepicker-i18n.service';

import { ReplacePipe } from 'src/app/shared/pipes/replace.pipe';
import { diasHabilesService } from '../../use-cases/dias-habiles.service';

export const options: Partial<IConfig> = {
  thousandSeparator: "."
};

@NgModule({
  declarations: [
    RegistrarVacanteComponent,
    RegistrarVacanteInformacionGeneralComponent,
    RegistrarVacanteDescripcionComponent,
    RegistrarVacacanteDetalleContratacionComponent,
    ReplacePipe
  ],
  imports: [
    CommonModule,
    FontAwesomeModule,
    NgbNavModule,
    StarRatingModule,
    ReactiveFormsModule,
    DropDownListModule,
    MultiSelectModule,
    NgbAlertModule,
    NgbModule,
    NgbDatepickerModule,
    NgxMaskModule.forRoot(options)
  ],
  exports:[
    RegistrarVacanteComponent
  ],
  providers:[
    RegistrarVacanteService,
    diasHabilesService,
    { provide: NgbDateParserFormatter, useClass: NgbDateCustomParserFormatter },
    I18n, { provide: NgbDatepickerI18n, useClass: CustomDatepickerI18nService }
  ]
})
export class RegistrarVacanteModule {}
