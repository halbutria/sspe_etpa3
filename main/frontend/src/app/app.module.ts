import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { HttpClientModule } from "@angular/common/http";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StoreModule } from '@ngrx/store';
import { StoreDevtoolsModule } from '@ngrx/store-devtools';
import { RecaptchaV3Module, RECAPTCHA_V3_SITE_KEY } from 'ng-recaptcha';
import { NgxCaptchaModule } from 'ngx-captcha';
import { NgbPaginationModule, NgbAlertModule, NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { NgxMaskModule, IConfig } from 'ngx-mask';

import { environment } from '../environments/environment';

import { LoginComponent } from './components/login/login.component';
import { RegisterModule } from "./components/register/register.module";
import { CvModule } from './components/cv/cv.module';
import { HeaderModule } from "./shared/components/header/header.module";
import { FooterModule } from "./shared/components/footer/footer.module";
import { AdministrativoModule } from './administrativo/administrativo.module';
import { FaIconLibrary, FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { fas } from '@fortawesome/free-solid-svg-icons';
import { far } from '@fortawesome/free-regular-svg-icons';
import { fab } from '@fortawesome/free-brands-svg-icons';
import { StarRatingModule } from 'angular-star-rating';

export const options: Partial<IConfig> = {
  thousandSeparator: "."
};

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent
  ],
  imports: [
    AppRoutingModule,
    FormsModule,
    BrowserModule,
    HttpClientModule,
    NgbPaginationModule,
    NgbAlertModule,
    NgxCaptchaModule,
    ReactiveFormsModule,
    RecaptchaV3Module,
    RegisterModule,
    HeaderModule,
    FooterModule,
    CvModule,
    AdministrativoModule,
    StoreModule.forRoot({}, {}),
    StoreDevtoolsModule.instrument({ name: 'TEST' }),
    NgbModule,
    FontAwesomeModule,
    StarRatingModule.forRoot(),
    NgxMaskModule.forRoot(options)
  ],
  providers: [
    {
      provide: RECAPTCHA_V3_SITE_KEY,
      useValue: environment.recaptcha.siteKey,
    }
  ],
  bootstrap: [AppComponent],
})
export class AppModule {

  constructor(library: FaIconLibrary){
    library.addIconPacks(fab, far, fas);
  }
}
