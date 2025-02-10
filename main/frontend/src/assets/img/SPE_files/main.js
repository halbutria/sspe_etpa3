"use strict";
(self["webpackChunksispe"] = self["webpackChunksispe"] || []).push([["main"],{

/***/ 158:
/*!***************************************!*\
  !*** ./src/app/app-routing.module.ts ***!
  \***************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "AppRoutingModule": () => (/* binding */ AppRoutingModule)
/* harmony export */ });
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ 124);
/* harmony import */ var _components_login_login_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./components/login/login.component */ 7143);
/* harmony import */ var _components_register_register_component__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./components/register/register.component */ 3412);
/* harmony import */ var _components_cv_cv_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./components/cv/cv.component */ 9829);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ 2560);






const routes = [
    { path: '', redirectTo: 'login', pathMatch: 'full' },
    { path: 'login', component: _components_login_login_component__WEBPACK_IMPORTED_MODULE_0__.LoginComponent },
    { path: 'register', component: _components_register_register_component__WEBPACK_IMPORTED_MODULE_1__.RegisterComponent },
    { path: 'cv', component: _components_cv_cv_component__WEBPACK_IMPORTED_MODULE_2__.CvComponent },
    {
        path: 'empresas',
        loadChildren: () => __webpack_require__.e(/*! import() */ "src_app_empresas_empresas_module_ts").then(__webpack_require__.bind(__webpack_require__, /*! ./empresas/empresas.module */ 9507)).then(m => m.EmpresasModule)
    },
];
class AppRoutingModule {
}
AppRoutingModule.ɵfac = function AppRoutingModule_Factory(t) { return new (t || AppRoutingModule)(); };
AppRoutingModule.ɵmod = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdefineNgModule"]({ type: AppRoutingModule });
AppRoutingModule.ɵinj = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdefineInjector"]({ imports: [_angular_router__WEBPACK_IMPORTED_MODULE_4__.RouterModule.forRoot(routes), _angular_router__WEBPACK_IMPORTED_MODULE_4__.RouterModule] });
(function () { (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵsetNgModuleScope"](AppRoutingModule, { imports: [_angular_router__WEBPACK_IMPORTED_MODULE_4__.RouterModule], exports: [_angular_router__WEBPACK_IMPORTED_MODULE_4__.RouterModule] }); })();


/***/ }),

/***/ 5041:
/*!**********************************!*\
  !*** ./src/app/app.component.ts ***!
  \**********************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "AppComponent": () => (/* binding */ AppComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ 124);


class AppComponent {
    constructor() {
        this.title = 'sispe';
    }
}
AppComponent.ɵfac = function AppComponent_Factory(t) { return new (t || AppComponent)(); };
AppComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: AppComponent, selectors: [["app-root"]], decls: 1, vars: 0, template: function AppComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](0, "router-outlet");
    } }, dependencies: [_angular_router__WEBPACK_IMPORTED_MODULE_1__.RouterOutlet], styles: ["\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJhcHAuY29tcG9uZW50LmNzcyJ9 */"] });


/***/ }),

/***/ 6747:
/*!*******************************!*\
  !*** ./src/app/app.module.ts ***!
  \*******************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "AppModule": () => (/* binding */ AppModule)
/* harmony export */ });
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! @angular/platform-browser */ 4497);
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! @angular/forms */ 2508);
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! @angular/common/http */ 8987);
/* harmony import */ var _app_routing_module__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./app-routing.module */ 158);
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./app.component */ 5041);
/* harmony import */ var _ngrx_store__WEBPACK_IMPORTED_MODULE_19__ = __webpack_require__(/*! @ngrx/store */ 3488);
/* harmony import */ var _ngrx_store_devtools__WEBPACK_IMPORTED_MODULE_20__ = __webpack_require__(/*! @ngrx/store-devtools */ 5242);
/* harmony import */ var ng_recaptcha__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ng-recaptcha */ 9191);
/* harmony import */ var ngx_captcha__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! ngx-captcha */ 7796);
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ 4534);
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../environments/environment */ 2340);
/* harmony import */ var _components_login_login_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./components/login/login.component */ 7143);
/* harmony import */ var _components_register_register_module__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./components/register/register.module */ 6436);
/* harmony import */ var _components_cv_cv_module__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./components/cv/cv.module */ 248);
/* harmony import */ var _shared_components_header_header_module__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./shared/components/header/header.module */ 3778);
/* harmony import */ var _shared_components_footer_footer_module__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./shared/components/footer/footer.module */ 2735);
/* harmony import */ var _fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! @fortawesome/angular-fontawesome */ 9200);
/* harmony import */ var _fortawesome_free_solid_svg_icons__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! @fortawesome/free-solid-svg-icons */ 655);
/* harmony import */ var _fortawesome_free_regular_svg_icons__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! @fortawesome/free-regular-svg-icons */ 9636);
/* harmony import */ var _fortawesome_free_brands_svg_icons__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @fortawesome/free-brands-svg-icons */ 2186);
/* harmony import */ var angular_star_rating__WEBPACK_IMPORTED_MODULE_21__ = __webpack_require__(/*! angular-star-rating */ 4351);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! @angular/core */ 2560);


























class AppModule {
    constructor(library) {
        library.addIconPacks(_fortawesome_free_brands_svg_icons__WEBPACK_IMPORTED_MODULE_8__.fab, _fortawesome_free_regular_svg_icons__WEBPACK_IMPORTED_MODULE_9__.far, _fortawesome_free_solid_svg_icons__WEBPACK_IMPORTED_MODULE_10__.fas);
    }
}
AppModule.ɵfac = function AppModule_Factory(t) { return new (t || AppModule)(_angular_core__WEBPACK_IMPORTED_MODULE_11__["ɵɵinject"](_fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_12__.FaIconLibrary)); };
AppModule.ɵmod = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_11__["ɵɵdefineNgModule"]({ type: AppModule, bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_1__.AppComponent] });
AppModule.ɵinj = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_11__["ɵɵdefineInjector"]({ providers: [
        {
            provide: ng_recaptcha__WEBPACK_IMPORTED_MODULE_13__.RECAPTCHA_V3_SITE_KEY,
            useValue: _environments_environment__WEBPACK_IMPORTED_MODULE_2__.environment.recaptcha.siteKey,
        }
    ], imports: [_app_routing_module__WEBPACK_IMPORTED_MODULE_0__.AppRoutingModule,
        _angular_forms__WEBPACK_IMPORTED_MODULE_14__.FormsModule,
        _angular_platform_browser__WEBPACK_IMPORTED_MODULE_15__.BrowserModule,
        _angular_common_http__WEBPACK_IMPORTED_MODULE_16__.HttpClientModule,
        _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_17__.NgbPaginationModule,
        _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_17__.NgbAlertModule,
        ngx_captcha__WEBPACK_IMPORTED_MODULE_18__.NgxCaptchaModule,
        _angular_forms__WEBPACK_IMPORTED_MODULE_14__.ReactiveFormsModule,
        ng_recaptcha__WEBPACK_IMPORTED_MODULE_13__.RecaptchaV3Module,
        _components_register_register_module__WEBPACK_IMPORTED_MODULE_4__.RegisterModule,
        _shared_components_header_header_module__WEBPACK_IMPORTED_MODULE_6__.HeaderModule,
        _shared_components_footer_footer_module__WEBPACK_IMPORTED_MODULE_7__.FooterModule,
        _components_cv_cv_module__WEBPACK_IMPORTED_MODULE_5__.CvModule,
        _ngrx_store__WEBPACK_IMPORTED_MODULE_19__.StoreModule.forRoot({}, {}),
        _ngrx_store_devtools__WEBPACK_IMPORTED_MODULE_20__.StoreDevtoolsModule.instrument({ name: 'TEST' }),
        _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_17__.NgbModule,
        _fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_12__.FontAwesomeModule,
        angular_star_rating__WEBPACK_IMPORTED_MODULE_21__.StarRatingModule.forRoot()] });
(function () { (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_11__["ɵɵsetNgModuleScope"](AppModule, { declarations: [_app_component__WEBPACK_IMPORTED_MODULE_1__.AppComponent,
        _components_login_login_component__WEBPACK_IMPORTED_MODULE_3__.LoginComponent], imports: [_app_routing_module__WEBPACK_IMPORTED_MODULE_0__.AppRoutingModule,
        _angular_forms__WEBPACK_IMPORTED_MODULE_14__.FormsModule,
        _angular_platform_browser__WEBPACK_IMPORTED_MODULE_15__.BrowserModule,
        _angular_common_http__WEBPACK_IMPORTED_MODULE_16__.HttpClientModule,
        _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_17__.NgbPaginationModule,
        _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_17__.NgbAlertModule,
        ngx_captcha__WEBPACK_IMPORTED_MODULE_18__.NgxCaptchaModule,
        _angular_forms__WEBPACK_IMPORTED_MODULE_14__.ReactiveFormsModule,
        ng_recaptcha__WEBPACK_IMPORTED_MODULE_13__.RecaptchaV3Module,
        _components_register_register_module__WEBPACK_IMPORTED_MODULE_4__.RegisterModule,
        _shared_components_header_header_module__WEBPACK_IMPORTED_MODULE_6__.HeaderModule,
        _shared_components_footer_footer_module__WEBPACK_IMPORTED_MODULE_7__.FooterModule,
        _components_cv_cv_module__WEBPACK_IMPORTED_MODULE_5__.CvModule, _ngrx_store__WEBPACK_IMPORTED_MODULE_19__.StoreRootModule, _ngrx_store_devtools__WEBPACK_IMPORTED_MODULE_20__.StoreDevtoolsModule, _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_17__.NgbModule,
        _fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_12__.FontAwesomeModule, angular_star_rating__WEBPACK_IMPORTED_MODULE_21__.StarRatingModule] }); })();


/***/ }),

/***/ 9829:
/*!***********************************************!*\
  !*** ./src/app/components/cv/cv.component.ts ***!
  \***********************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CvComponent": () => (/* binding */ CvComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var _services_header_service__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../services/header.service */ 6690);
/* harmony import */ var _services_cv_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../services/cv.service */ 543);
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @angular/router */ 124);
/* harmony import */ var _shared_components_footer_footer_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../shared/components/footer/footer.component */ 6526);
/* harmony import */ var _shared_components_header_header_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../shared/components/header/header.component */ 6290);
/* harmony import */ var _main_navigation_main_navigation_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./main-navigation/main-navigation.component */ 4325);
/* harmony import */ var _data_aside_data_aside_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./data-aside/data-aside.component */ 530);
/* harmony import */ var _form_cv_form_cv_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./form-cv/form-cv.component */ 730);









class CvComponent {
    constructor(headerService, cvService, router) {
        this.headerService = headerService;
        this.cvService = cvService;
        this.router = router;
    }
    ngOnInit() {
        setTimeout(() => {
            this.headerService.setTitle("Mi hoja de vida");
        }, 900);
        // Consulta la información del storage en el servicio
        // Y si está vacío entonces lo redirige al login
        if (this.cvService.getCiudadano === null) {
            this.router.navigate(['/login']);
        }
    }
    logout() {
        this.cvService.resetCiudadano();
        setTimeout(() => {
            this.router.navigate(['/']);
        }, 500);
    }
}
CvComponent.ɵfac = function CvComponent_Factory(t) { return new (t || CvComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdirectiveInject"](_services_header_service__WEBPACK_IMPORTED_MODULE_0__.HeaderService), _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdirectiveInject"](_services_cv_service__WEBPACK_IMPORTED_MODULE_1__.CvService), _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdirectiveInject"](_angular_router__WEBPACK_IMPORTED_MODULE_8__.Router)); };
CvComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdefineComponent"]({ type: CvComponent, selectors: [["app-cv"]], decls: 13, vars: 0, consts: [[1, "cabozote-gris", "d-flex", "align-items-center"], [1, "text-light", "text-start"], ["type", "button", 1, "btn", "text-end", "button-notification"], [1, "fa", "fa-solid", "fa-bell", "text-light"], ["type", "button", 1, "btn", "text-end", "button-exit", 3, "click"], [1, "fa", "fa-solid", "fa-sign-out", "fa-lg", "text-light"], [1, "row", "d-flex", "mt-3"], [1, "col-md-4"], [1, "col-md-8"]], template: function CvComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](0, "section", 0)(1, "p", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtext"](2, "\u00DAltima actualizaci\u00F3n: 27 | 11 | 2022 - 10:45 am");
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](3, "button", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelement"](4, "i", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](5, "button", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵlistener"]("click", function CvComponent_Template_button_click_5_listener() { return ctx.logout(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelement"](6, "i", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelement"](7, "app-header")(8, "app-main-navigation");
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](9, "div", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelement"](10, "app-data-aside", 7)(11, "app-form-cv", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelement"](12, "app-footer");
    } }, dependencies: [_shared_components_footer_footer_component__WEBPACK_IMPORTED_MODULE_2__.FooterComponent, _shared_components_header_header_component__WEBPACK_IMPORTED_MODULE_3__.HeaderComponent, _main_navigation_main_navigation_component__WEBPACK_IMPORTED_MODULE_4__.MainNavigationComponent, _data_aside_data_aside_component__WEBPACK_IMPORTED_MODULE_5__.DataAsideComponent, _form_cv_form_cv_component__WEBPACK_IMPORTED_MODULE_6__.FormCvComponent], styles: [".cabozote-gris[_ngcontent-%COMP%] {\n  background: transparent linear-gradient(180deg, #b6b8bc 0%, #a3a5a8 100%) 0%\n    0% no-repeat padding-box;\n  opacity: 1;\n  height: 83px;\n  max-height: 83px;\n  width: 100%;\n  padding: 0px 5px 0 25px;\n}\n.cabozote-gris[_ngcontent-%COMP%]   p[_ngcontent-%COMP%] {\n  font-size: 21px;\n  text-align: left;\n  font: normal normal medium 21px/29px Futura Std;\n  letter-spacing: 0px;\n  color: #ffffff;\n  opacity: 1;\n}\n.button-notification[_ngcontent-%COMP%] {\n  margin: 0 0 0 auto;\n  border-left: 1px solid white;\n  border-radius: 0;\n}\n.button-notification[_ngcontent-%COMP%]:hover {\n  background-color: #dd2d2b;\n}\n.button-exit[_ngcontent-%COMP%] {\n  border-left: 1px solid white;\n  border-radius: 0;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbImN2LmNvbXBvbmVudC5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDRTs0QkFDMEI7RUFDMUIsVUFBVTtFQUNWLFlBQVk7RUFDWixnQkFBZ0I7RUFDaEIsV0FBVztFQUNYLHVCQUF1QjtBQUN6QjtBQUNBO0VBQ0UsZUFBZTtFQUNmLGdCQUFnQjtFQUNoQiwrQ0FBK0M7RUFDL0MsbUJBQW1CO0VBQ25CLGNBQWM7RUFDZCxVQUFVO0FBQ1o7QUFFQTtFQUNFLGtCQUFrQjtFQUNsQiw0QkFBNEI7RUFDNUIsZ0JBQWdCO0FBQ2xCO0FBQ0E7RUFDRSx5QkFBeUI7QUFDM0I7QUFFQTtFQUNFLDRCQUE0QjtFQUM1QixnQkFBZ0I7QUFDbEIiLCJmaWxlIjoiY3YuY29tcG9uZW50LmNzcyIsInNvdXJjZXNDb250ZW50IjpbIi5jYWJvem90ZS1ncmlzIHtcbiAgYmFja2dyb3VuZDogdHJhbnNwYXJlbnQgbGluZWFyLWdyYWRpZW50KDE4MGRlZywgI2I2YjhiYyAwJSwgI2EzYTVhOCAxMDAlKSAwJVxuICAgIDAlIG5vLXJlcGVhdCBwYWRkaW5nLWJveDtcbiAgb3BhY2l0eTogMTtcbiAgaGVpZ2h0OiA4M3B4O1xuICBtYXgtaGVpZ2h0OiA4M3B4O1xuICB3aWR0aDogMTAwJTtcbiAgcGFkZGluZzogMHB4IDVweCAwIDI1cHg7XG59XG4uY2Fib3pvdGUtZ3JpcyBwIHtcbiAgZm9udC1zaXplOiAyMXB4O1xuICB0ZXh0LWFsaWduOiBsZWZ0O1xuICBmb250OiBub3JtYWwgbm9ybWFsIG1lZGl1bSAyMXB4LzI5cHggRnV0dXJhIFN0ZDtcbiAgbGV0dGVyLXNwYWNpbmc6IDBweDtcbiAgY29sb3I6ICNmZmZmZmY7XG4gIG9wYWNpdHk6IDE7XG59XG5cbi5idXR0b24tbm90aWZpY2F0aW9uIHtcbiAgbWFyZ2luOiAwIDAgMCBhdXRvO1xuICBib3JkZXItbGVmdDogMXB4IHNvbGlkIHdoaXRlO1xuICBib3JkZXItcmFkaXVzOiAwO1xufVxuLmJ1dHRvbi1ub3RpZmljYXRpb246aG92ZXIge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjZGQyZDJiO1xufVxuXG4uYnV0dG9uLWV4aXQge1xuICBib3JkZXItbGVmdDogMXB4IHNvbGlkIHdoaXRlO1xuICBib3JkZXItcmFkaXVzOiAwO1xufVxuIl19 */"] });


/***/ }),

/***/ 248:
/*!********************************************!*\
  !*** ./src/app/components/cv/cv.module.ts ***!
  \********************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CvModule": () => (/* binding */ CvModule),
/* harmony export */   "LAZY_ROUTES": () => (/* binding */ LAZY_ROUTES)
/* harmony export */ });
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! @angular/common */ 4666);
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! @angular/platform-browser */ 4497);
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! @angular/forms */ 2508);
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ 4534);
/* harmony import */ var _fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! @fortawesome/angular-fontawesome */ 9200);
/* harmony import */ var _cv_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./cv.component */ 9829);
/* harmony import */ var _shared_components_header_header_module__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../shared/components/header/header.module */ 3778);
/* harmony import */ var _shared_components_footer_footer_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../shared/components/footer/footer.module */ 2735);
/* harmony import */ var _shared_components_disability_navigation_disability_navigation_module__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../shared/components/disability-navigation/disability-navigation.module */ 4632);
/* harmony import */ var _main_navigation_main_navigation_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./main-navigation/main-navigation.component */ 4325);
/* harmony import */ var _data_aside_data_aside_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./data-aside/data-aside.component */ 530);
/* harmony import */ var _form_cv_form_cv_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./form-cv/form-cv.component */ 730);
/* harmony import */ var _form_cv_personal_information_personal_information_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./form-cv/personal-information/personal-information.component */ 6059);
/* harmony import */ var _form_cv_formal_education_formal_education_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./form-cv/formal-education/formal-education.component */ 9658);
/* harmony import */ var _form_cv_working_information_working_information_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./form-cv/working-information/working-information.component */ 8317);
/* harmony import */ var _form_cv_no_informal_education_no_informal_education_component__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./form-cv/no-informal-education/no-informal-education.component */ 4850);
/* harmony import */ var _form_cv_languages_languages_component__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./form-cv/languages/languages.component */ 6284);
/* harmony import */ var _form_cv_knowledge_skills_knowledge_skills_component__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./form-cv/knowledge-skills/knowledge-skills.component */ 7021);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! @angular/core */ 2560);



















const LAZY_ROUTES = [
    {
        path: '',
        component: _cv_component__WEBPACK_IMPORTED_MODULE_0__.CvComponent,
        children: [
            {
                path: 'main-navigation',
                component: _main_navigation_main_navigation_component__WEBPACK_IMPORTED_MODULE_4__.MainNavigationComponent
            },
            {
                path: 'data-aside',
                component: _data_aside_data_aside_component__WEBPACK_IMPORTED_MODULE_5__.DataAsideComponent
            },
            {
                path: 'form-cv',
                component: _form_cv_form_cv_component__WEBPACK_IMPORTED_MODULE_6__.FormCvComponent
            }
        ]
    }
];
class CvModule {
}
CvModule.ɵfac = function CvModule_Factory(t) { return new (t || CvModule)(); };
CvModule.ɵmod = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_13__["ɵɵdefineNgModule"]({ type: CvModule });
CvModule.ɵinj = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_13__["ɵɵdefineInjector"]({ imports: [_angular_platform_browser__WEBPACK_IMPORTED_MODULE_14__.BrowserModule,
        _angular_common__WEBPACK_IMPORTED_MODULE_15__.CommonModule,
        _shared_components_disability_navigation_disability_navigation_module__WEBPACK_IMPORTED_MODULE_3__.DisabilityNavigationModule,
        _angular_forms__WEBPACK_IMPORTED_MODULE_16__.FormsModule,
        _shared_components_footer_footer_module__WEBPACK_IMPORTED_MODULE_2__.FooterModule,
        _fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_17__.FontAwesomeModule,
        _shared_components_header_header_module__WEBPACK_IMPORTED_MODULE_1__.HeaderModule,
        _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_18__.NgbAlertModule,
        _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_18__.NgbModule,
        _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_18__.NgbPaginationModule,
        _angular_forms__WEBPACK_IMPORTED_MODULE_16__.ReactiveFormsModule] });
(function () { (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_13__["ɵɵsetNgModuleScope"](CvModule, { declarations: [_cv_component__WEBPACK_IMPORTED_MODULE_0__.CvComponent,
        _main_navigation_main_navigation_component__WEBPACK_IMPORTED_MODULE_4__.MainNavigationComponent,
        _data_aside_data_aside_component__WEBPACK_IMPORTED_MODULE_5__.DataAsideComponent,
        _form_cv_form_cv_component__WEBPACK_IMPORTED_MODULE_6__.FormCvComponent,
        _form_cv_personal_information_personal_information_component__WEBPACK_IMPORTED_MODULE_7__.PersonalInformationComponent,
        _form_cv_formal_education_formal_education_component__WEBPACK_IMPORTED_MODULE_8__.FormalEducationComponent,
        _form_cv_working_information_working_information_component__WEBPACK_IMPORTED_MODULE_9__.WorkingInformationComponent,
        _form_cv_no_informal_education_no_informal_education_component__WEBPACK_IMPORTED_MODULE_10__.NoInformalEducationComponent,
        _form_cv_languages_languages_component__WEBPACK_IMPORTED_MODULE_11__.LanguagesComponent,
        _form_cv_knowledge_skills_knowledge_skills_component__WEBPACK_IMPORTED_MODULE_12__.KnowledgeSkillsComponent], imports: [_angular_platform_browser__WEBPACK_IMPORTED_MODULE_14__.BrowserModule,
        _angular_common__WEBPACK_IMPORTED_MODULE_15__.CommonModule,
        _shared_components_disability_navigation_disability_navigation_module__WEBPACK_IMPORTED_MODULE_3__.DisabilityNavigationModule,
        _angular_forms__WEBPACK_IMPORTED_MODULE_16__.FormsModule,
        _shared_components_footer_footer_module__WEBPACK_IMPORTED_MODULE_2__.FooterModule,
        _fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_17__.FontAwesomeModule,
        _shared_components_header_header_module__WEBPACK_IMPORTED_MODULE_1__.HeaderModule,
        _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_18__.NgbAlertModule,
        _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_18__.NgbModule,
        _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_18__.NgbPaginationModule,
        _angular_forms__WEBPACK_IMPORTED_MODULE_16__.ReactiveFormsModule] }); })();


/***/ }),

/***/ 530:
/*!******************************************************************!*\
  !*** ./src/app/components/cv/data-aside/data-aside.component.ts ***!
  \******************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "DataAsideComponent": () => (/* binding */ DataAsideComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var _services_cv_service__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../../services/cv.service */ 543);
/* harmony import */ var _fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @fortawesome/angular-fontawesome */ 9200);



class DataAsideComponent {
    constructor(cvService) {
        this.cvService = cvService;
    }
    ngOnInit() {
        // Consulta la información del storage en el servicio
        this.ciudadano = this.cvService.getCiudadano;
    }
    get showName() {
        if (this.ciudadano !== null) {
            const pNombre = this.ciudadano?.primerNombre;
            const sNombre = this.ciudadano?.segundoNombre == '' ? '' : ' ' + this.ciudadano?.segundoNombre;
            const pApellido = this.ciudadano?.primerApellido == '' ? '' : ' ' + this.ciudadano?.primerApellido;
            const sApellido = this.ciudadano?.segundoApellido == '' ? '' : ' ' + this.ciudadano?.segundoApellido;
            return pNombre + sNombre + pApellido + sApellido;
        }
        else {
            return "";
        }
    }
}
DataAsideComponent.ɵfac = function DataAsideComponent_Factory(t) { return new (t || DataAsideComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdirectiveInject"](_services_cv_service__WEBPACK_IMPORTED_MODULE_0__.CvService)); };
DataAsideComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineComponent"]({ type: DataAsideComponent, selectors: [["app-data-aside"]], decls: 57, vars: 6, consts: [[1, "container"], [1, "info-persona"], [1, "text-bienvenido"], [1, "text-persona"], ["src", "../../../../assets/img/fabio-mangione.jpg", "alt", "Imagen de perfil buscador de empleo", 1, "foto-perfil", "img-fluid", "rounded-circle", "img-thumbnail"], [1, "progreso-cv"], [1, "porcentaje"], [1, "linea-separadora"], [1, "estrellas"], ["icon", "star", 1, "full"], ["icon", "star"], [1, "texto-invitacion"], [1, "secciones-cv"], ["icon", "edit"], [1, "texto-info-adicional"], [1, "btn", "btn-primary-form"]], template: function DataAsideComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div", 0)(1, "section", 1)(2, "p", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](3, "Bienvenido(a)");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](4, "p", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](5);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](6, "img", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](7, "section", 5)(8, "p", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](9, "Tu hoja de vida est\u00E1 al: ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](10, "span");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](11);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](12, "hr", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](13, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](14, "fa-icon", 9)(15, "fa-icon", 9)(16, "fa-icon", 9)(17, "fa-icon", 10)(18, "fa-icon", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](19, "p", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](20, "Te invitamos a completarla para tener mejores oportunidades");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](21, "section", 12)(22, "ul")(23, "li");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](24, " Registro buscador ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](25, "span");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](26, "25%");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](27, "button");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](28, "fa-icon", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](29, "li");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](30, " Informaci\u00F3n personal ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](31, "span");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](32);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](33, "button");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](34, "fa-icon", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](35, "li");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](36, " Educaci\u00F3n formal ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](37, "span");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](38);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](39, "button");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](40, "fa-icon", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](41, "li");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](42, " Informaci\u00F3n laboral ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](43, "span");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](44);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](45, "button");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](46, "fa-icon", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](47, "li");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](48, " Educaci\u00F3n no formal ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](49, "span");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](50);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](51, "button");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](52, "fa-icon", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](53, "p", 14);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](54, "Informaci\u00F3n adicional");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](55, "button", 15);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](56, "Actualizar");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]()()();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](5);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtextInterpolate"](ctx.showName);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtextInterpolate1"]("", ctx.ciudadano == null ? null : ctx.ciudadano.porcentajeHv, "%");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](21);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtextInterpolate1"]("", ctx.ciudadano == null ? null : ctx.ciudadano.porcentajeInfoPersonal, "%");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtextInterpolate1"]("", ctx.ciudadano == null ? null : ctx.ciudadano.porcentajeEduFormal, "%");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtextInterpolate1"]("", ctx.ciudadano == null ? null : ctx.ciudadano.porcentajeInfoLaboral, "%");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtextInterpolate1"]("", ctx.ciudadano == null ? null : ctx.ciudadano.porcentajeEduNoFormal, "%");
    } }, dependencies: [_fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_2__.FaIconComponent], styles: [".info-persona[_ngcontent-%COMP%] {\n}\n.info-persona[_ngcontent-%COMP%]   .foto-perfil[_ngcontent-%COMP%] {\n  width: 136px;\n  height: 137px;\n}\n.info-persona[_ngcontent-%COMP%]   .text-bienvenido[_ngcontent-%COMP%] {\n  text-align: left;\n  font: normal normal medium 38px/54px Futura Std;\n  font-size: 38px;\n  letter-spacing: 0px;\n  color: #707070;\n  opacity: 1;\n  margin-bottom: 0;\n}\n.info-persona[_ngcontent-%COMP%]   .text-persona[_ngcontent-%COMP%] {\n  text-align: left;\n  font: normal normal 900 32px/48px Futura Std;\n  font-size: 32px;\n  letter-spacing: 0px;\n  color: #707070;\n  opacity: 1;\n}\n\n.progreso-cv[_ngcontent-%COMP%] {\n  background: transparent linear-gradient(180deg, #ffffff 0%, #e2e2e2 100%) 0%\n    0% no-repeat padding-box;\n  border-radius: 12px;\n  opacity: 1;\n  padding: 10px;\n}\n.progreso-cv[_ngcontent-%COMP%]   .porcentaje[_ngcontent-%COMP%] {\n  text-align: left;\n  font: normal normal bold 24px/34px Futura Std;\n  font-size: 24px;\n  letter-spacing: 0px;\n  color: #707070;\n  opacity: 1;\n}\n.progreso-cv[_ngcontent-%COMP%]   .porcentaje[_ngcontent-%COMP%]   span[_ngcontent-%COMP%] {\n  font: normal normal 900 47px/48px Futura Std;\n  font-size: 47px;\n  color: #f1ab46 !important;\n}\n.progreso-cv[_ngcontent-%COMP%]   .estrellas[_ngcontent-%COMP%] {\n  margin: 0 10px 0 20px;\n}\n.progreso-cv[_ngcontent-%COMP%]   .estrellas[_ngcontent-%COMP%]   fa-icon[_ngcontent-%COMP%] {\n  font-size: 40px;\n  margin: 6px;\n}\n.progreso-cv[_ngcontent-%COMP%]   .estrellas[_ngcontent-%COMP%]   .full[_ngcontent-%COMP%] {\n  color: #f1ab46;\n}\n.progreso-cv[_ngcontent-%COMP%]   .texto-invitacion[_ngcontent-%COMP%] {\n  text-align: left;\n  font: normal normal medium 22px/18px Futura Std;\n  font-size: 22px;\n  letter-spacing: 0px;\n  color: #707070;\n  opacity: 1;\n}\n\n.secciones-cv[_ngcontent-%COMP%] {\n  background: transparent linear-gradient(180deg, #ffffff 0%, #e2e2e2 100%) 0%\n    0% no-repeat padding-box;\n  border-radius: 12px;\n  opacity: 1;\n  padding: 32px 20px 10px 0px;\n}\n.secciones-cv[_ngcontent-%COMP%]   ul[_ngcontent-%COMP%] {\n  list-style: none;\n}\n.secciones-cv[_ngcontent-%COMP%]   li[_ngcontent-%COMP%] {\n  margin-bottom: 5px;\n  text-align: left;\n  font: normal normal bold 24px/28px Futura Std;\n  font-size: 24px;\n  letter-spacing: 0px;\n  color: #707070;\n  opacity: 1;\n  display: flex;\n  justify-content: space-between;\n}\n.secciones-cv[_ngcontent-%COMP%]   li[_ngcontent-%COMP%]   span[_ngcontent-%COMP%] {\n  font-size: 33px;\n  color: #595a5c !important;\n}\n.secciones-cv[_ngcontent-%COMP%]   li[_ngcontent-%COMP%]   button[_ngcontent-%COMP%]   fa-icon[_ngcontent-%COMP%] {\n  color: #707070;\n  border: none;\n}\n.secciones-cv[_ngcontent-%COMP%]   .texto-info-adicional[_ngcontent-%COMP%] {\n  font-size: 18px;\n  color: #707070;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbImRhdGEtYXNpZGUuY29tcG9uZW50LmNzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtBQUNBO0FBQ0E7RUFDRSxZQUFZO0VBQ1osYUFBYTtBQUNmO0FBQ0E7RUFDRSxnQkFBZ0I7RUFDaEIsK0NBQStDO0VBQy9DLGVBQWU7RUFDZixtQkFBbUI7RUFDbkIsY0FBYztFQUNkLFVBQVU7RUFDVixnQkFBZ0I7QUFDbEI7QUFDQTtFQUNFLGdCQUFnQjtFQUNoQiw0Q0FBNEM7RUFDNUMsZUFBZTtFQUNmLG1CQUFtQjtFQUNuQixjQUFjO0VBQ2QsVUFBVTtBQUNaO0FBRUEseUNBQXlDO0FBQ3pDO0VBQ0U7NEJBQzBCO0VBQzFCLG1CQUFtQjtFQUNuQixVQUFVO0VBQ1YsYUFBYTtBQUNmO0FBQ0E7RUFDRSxnQkFBZ0I7RUFDaEIsNkNBQTZDO0VBQzdDLGVBQWU7RUFDZixtQkFBbUI7RUFDbkIsY0FBYztFQUNkLFVBQVU7QUFDWjtBQUNBO0VBQ0UsNENBQTRDO0VBQzVDLGVBQWU7RUFDZix5QkFBeUI7QUFDM0I7QUFDQTtFQUNFLHFCQUFxQjtBQUN2QjtBQUNBO0VBQ0UsZUFBZTtFQUNmLFdBQVc7QUFDYjtBQUNBO0VBQ0UsY0FBYztBQUNoQjtBQUNBO0VBQ0UsZ0JBQWdCO0VBQ2hCLCtDQUErQztFQUMvQyxlQUFlO0VBQ2YsbUJBQW1CO0VBQ25CLGNBQWM7RUFDZCxVQUFVO0FBQ1o7QUFFQSxpREFBaUQ7QUFDakQ7RUFDRTs0QkFDMEI7RUFDMUIsbUJBQW1CO0VBQ25CLFVBQVU7RUFDViwyQkFBMkI7QUFDN0I7QUFDQTtFQUNFLGdCQUFnQjtBQUNsQjtBQUNBO0VBQ0Usa0JBQWtCO0VBQ2xCLGdCQUFnQjtFQUNoQiw2Q0FBNkM7RUFDN0MsZUFBZTtFQUNmLG1CQUFtQjtFQUNuQixjQUFjO0VBQ2QsVUFBVTtFQUNWLGFBQWE7RUFDYiw4QkFBOEI7QUFDaEM7QUFDQTtFQUNFLGVBQWU7RUFDZix5QkFBeUI7QUFDM0I7QUFDQTtFQUNFLGNBQWM7RUFDZCxZQUFZO0FBQ2Q7QUFDQTtFQUNFLGVBQWU7RUFDZixjQUFjO0FBQ2hCIiwiZmlsZSI6ImRhdGEtYXNpZGUuY29tcG9uZW50LmNzcyIsInNvdXJjZXNDb250ZW50IjpbIi5pbmZvLXBlcnNvbmEge1xufVxuLmluZm8tcGVyc29uYSAuZm90by1wZXJmaWwge1xuICB3aWR0aDogMTM2cHg7XG4gIGhlaWdodDogMTM3cHg7XG59XG4uaW5mby1wZXJzb25hIC50ZXh0LWJpZW52ZW5pZG8ge1xuICB0ZXh0LWFsaWduOiBsZWZ0O1xuICBmb250OiBub3JtYWwgbm9ybWFsIG1lZGl1bSAzOHB4LzU0cHggRnV0dXJhIFN0ZDtcbiAgZm9udC1zaXplOiAzOHB4O1xuICBsZXR0ZXItc3BhY2luZzogMHB4O1xuICBjb2xvcjogIzcwNzA3MDtcbiAgb3BhY2l0eTogMTtcbiAgbWFyZ2luLWJvdHRvbTogMDtcbn1cbi5pbmZvLXBlcnNvbmEgLnRleHQtcGVyc29uYSB7XG4gIHRleHQtYWxpZ246IGxlZnQ7XG4gIGZvbnQ6IG5vcm1hbCBub3JtYWwgOTAwIDMycHgvNDhweCBGdXR1cmEgU3RkO1xuICBmb250LXNpemU6IDMycHg7XG4gIGxldHRlci1zcGFjaW5nOiAwcHg7XG4gIGNvbG9yOiAjNzA3MDcwO1xuICBvcGFjaXR5OiAxO1xufVxuXG4vKiBFc3RpbG9zIHNlY2Npw7NuIGRlIHByb2dyZXNvIGRlIGxhIENWICovXG4ucHJvZ3Jlc28tY3Yge1xuICBiYWNrZ3JvdW5kOiB0cmFuc3BhcmVudCBsaW5lYXItZ3JhZGllbnQoMTgwZGVnLCAjZmZmZmZmIDAlLCAjZTJlMmUyIDEwMCUpIDAlXG4gICAgMCUgbm8tcmVwZWF0IHBhZGRpbmctYm94O1xuICBib3JkZXItcmFkaXVzOiAxMnB4O1xuICBvcGFjaXR5OiAxO1xuICBwYWRkaW5nOiAxMHB4O1xufVxuLnByb2dyZXNvLWN2IC5wb3JjZW50YWplIHtcbiAgdGV4dC1hbGlnbjogbGVmdDtcbiAgZm9udDogbm9ybWFsIG5vcm1hbCBib2xkIDI0cHgvMzRweCBGdXR1cmEgU3RkO1xuICBmb250LXNpemU6IDI0cHg7XG4gIGxldHRlci1zcGFjaW5nOiAwcHg7XG4gIGNvbG9yOiAjNzA3MDcwO1xuICBvcGFjaXR5OiAxO1xufVxuLnByb2dyZXNvLWN2IC5wb3JjZW50YWplIHNwYW4ge1xuICBmb250OiBub3JtYWwgbm9ybWFsIDkwMCA0N3B4LzQ4cHggRnV0dXJhIFN0ZDtcbiAgZm9udC1zaXplOiA0N3B4O1xuICBjb2xvcjogI2YxYWI0NiAhaW1wb3J0YW50O1xufVxuLnByb2dyZXNvLWN2IC5lc3RyZWxsYXMge1xuICBtYXJnaW46IDAgMTBweCAwIDIwcHg7XG59XG4ucHJvZ3Jlc28tY3YgLmVzdHJlbGxhcyBmYS1pY29uIHtcbiAgZm9udC1zaXplOiA0MHB4O1xuICBtYXJnaW46IDZweDtcbn1cbi5wcm9ncmVzby1jdiAuZXN0cmVsbGFzIC5mdWxsIHtcbiAgY29sb3I6ICNmMWFiNDY7XG59XG4ucHJvZ3Jlc28tY3YgLnRleHRvLWludml0YWNpb24ge1xuICB0ZXh0LWFsaWduOiBsZWZ0O1xuICBmb250OiBub3JtYWwgbm9ybWFsIG1lZGl1bSAyMnB4LzE4cHggRnV0dXJhIFN0ZDtcbiAgZm9udC1zaXplOiAyMnB4O1xuICBsZXR0ZXItc3BhY2luZzogMHB4O1xuICBjb2xvcjogIzcwNzA3MDtcbiAgb3BhY2l0eTogMTtcbn1cblxuLyogRXN0aWxvcyBkZSBsYSBpbmZvcm1hY2lvbiBzZWNjaW9uZXMgZGUgbGEgQ1YgKi9cbi5zZWNjaW9uZXMtY3Yge1xuICBiYWNrZ3JvdW5kOiB0cmFuc3BhcmVudCBsaW5lYXItZ3JhZGllbnQoMTgwZGVnLCAjZmZmZmZmIDAlLCAjZTJlMmUyIDEwMCUpIDAlXG4gICAgMCUgbm8tcmVwZWF0IHBhZGRpbmctYm94O1xuICBib3JkZXItcmFkaXVzOiAxMnB4O1xuICBvcGFjaXR5OiAxO1xuICBwYWRkaW5nOiAzMnB4IDIwcHggMTBweCAwcHg7XG59XG4uc2VjY2lvbmVzLWN2IHVsIHtcbiAgbGlzdC1zdHlsZTogbm9uZTtcbn1cbi5zZWNjaW9uZXMtY3YgbGkge1xuICBtYXJnaW4tYm90dG9tOiA1cHg7XG4gIHRleHQtYWxpZ246IGxlZnQ7XG4gIGZvbnQ6IG5vcm1hbCBub3JtYWwgYm9sZCAyNHB4LzI4cHggRnV0dXJhIFN0ZDtcbiAgZm9udC1zaXplOiAyNHB4O1xuICBsZXR0ZXItc3BhY2luZzogMHB4O1xuICBjb2xvcjogIzcwNzA3MDtcbiAgb3BhY2l0eTogMTtcbiAgZGlzcGxheTogZmxleDtcbiAganVzdGlmeS1jb250ZW50OiBzcGFjZS1iZXR3ZWVuO1xufVxuLnNlY2Npb25lcy1jdiBsaSBzcGFuIHtcbiAgZm9udC1zaXplOiAzM3B4O1xuICBjb2xvcjogIzU5NWE1YyAhaW1wb3J0YW50O1xufVxuLnNlY2Npb25lcy1jdiBsaSBidXR0b24gZmEtaWNvbiB7XG4gIGNvbG9yOiAjNzA3MDcwO1xuICBib3JkZXI6IG5vbmU7XG59XG4uc2VjY2lvbmVzLWN2IC50ZXh0by1pbmZvLWFkaWNpb25hbCB7XG4gIGZvbnQtc2l6ZTogMThweDtcbiAgY29sb3I6ICM3MDcwNzA7XG59XG4iXX0= */"] });


/***/ }),

/***/ 730:
/*!************************************************************!*\
  !*** ./src/app/components/cv/form-cv/form-cv.component.ts ***!
  \************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "FormCvComponent": () => (/* binding */ FormCvComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/forms */ 2508);
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ 4534);
/* harmony import */ var _personal_information_personal_information_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./personal-information/personal-information.component */ 6059);
/* harmony import */ var _formal_education_formal_education_component__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./formal-education/formal-education.component */ 9658);
/* harmony import */ var _working_information_working_information_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./working-information/working-information.component */ 8317);
/* harmony import */ var _no_informal_education_no_informal_education_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./no-informal-education/no-informal-education.component */ 4850);
/* harmony import */ var _languages_languages_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./languages/languages.component */ 6284);
/* harmony import */ var _knowledge_skills_knowledge_skills_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./knowledge-skills/knowledge-skills.component */ 7021);










function FormCvComponent_ng_template_7_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelement"](0, "app-personal-information");
} }
function FormCvComponent_ng_template_11_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelement"](0, "app-formal-education");
} }
function FormCvComponent_ng_template_15_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelement"](0, "app-working-information");
} }
function FormCvComponent_ng_template_19_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelement"](0, "app-no-informal-education");
} }
function FormCvComponent_ng_template_23_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelement"](0, "app-languages");
} }
function FormCvComponent_ng_template_27_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelement"](0, "app-knowledge-skills");
} }
class FormCvComponent {
    constructor(formBuilder) {
        this.formBuilder = formBuilder;
        this.active = 1;
    }
    ngOnInit() {
    }
}
FormCvComponent.ɵfac = function FormCvComponent_Factory(t) { return new (t || FormCvComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵdirectiveInject"](_angular_forms__WEBPACK_IMPORTED_MODULE_7__.FormBuilder)); };
FormCvComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵdefineComponent"]({ type: FormCvComponent, selectors: [["app-form-cv"]], decls: 29, vars: 8, consts: [[1, "container"], [1, "col", "mr-auto", "ml-auto"], ["ngbNav", "", 1, "nav-tabs", "tabs-secciones-cv", "Futura_Std_Bold", 3, "activeId", "activeIdChange"], ["nav", "ngbNav"], [3, "ngbNavItem"], ["ngbNavLink", ""], ["ngbNavContent", ""], [1, "mt-2", 3, "ngbNavOutlet"]], template: function FormCvComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementStart"](0, "div", 0)(1, "div", 1)(2, "ul", 2, 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵlistener"]("activeIdChange", function FormCvComponent_Template_ul_activeIdChange_2_listener($event) { return ctx.active = $event; });
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementStart"](4, "li", 4)(5, "a", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵtext"](6, "Informaci\u00F3n personal");
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵtemplate"](7, FormCvComponent_ng_template_7_Template, 1, 0, "ng-template", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementStart"](8, "li", 4)(9, "a", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵtext"](10, "Educaci\u00F3n formal");
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵtemplate"](11, FormCvComponent_ng_template_11_Template, 1, 0, "ng-template", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementStart"](12, "li", 4)(13, "a", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵtext"](14, "Informaci\u00F3n laboral");
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵtemplate"](15, FormCvComponent_ng_template_15_Template, 1, 0, "ng-template", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementStart"](16, "li", 4)(17, "a", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵtext"](18, "Educaci\u00F3n no formal");
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵtemplate"](19, FormCvComponent_ng_template_19_Template, 1, 0, "ng-template", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementStart"](20, "li", 4)(21, "a", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵtext"](22, "Idiomas");
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵtemplate"](23, FormCvComponent_ng_template_23_Template, 1, 0, "ng-template", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementStart"](24, "li", 4)(25, "a", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵtext"](26, "Conocimientos y destrezas");
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵtemplate"](27, FormCvComponent_ng_template_27_Template, 1, 0, "ng-template", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelement"](28, "div", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵelementEnd"]()();
    } if (rf & 2) {
        const _r0 = _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵreference"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵadvance"](2);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵproperty"]("activeId", ctx.active);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵadvance"](2);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵproperty"]("ngbNavItem", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵproperty"]("ngbNavItem", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵproperty"]("ngbNavItem", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵproperty"]("ngbNavItem", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵproperty"]("ngbNavItem", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵproperty"]("ngbNavItem", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵproperty"]("ngbNavOutlet", _r0);
    } }, dependencies: [_ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_8__.NgbNavContent, _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_8__.NgbNav, _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_8__.NgbNavItem, _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_8__.NgbNavLink, _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_8__.NgbNavOutlet, _personal_information_personal_information_component__WEBPACK_IMPORTED_MODULE_0__.PersonalInformationComponent, _formal_education_formal_education_component__WEBPACK_IMPORTED_MODULE_1__.FormalEducationComponent, _working_information_working_information_component__WEBPACK_IMPORTED_MODULE_2__.WorkingInformationComponent, _no_informal_education_no_informal_education_component__WEBPACK_IMPORTED_MODULE_3__.NoInformalEducationComponent, _languages_languages_component__WEBPACK_IMPORTED_MODULE_4__.LanguagesComponent, _knowledge_skills_knowledge_skills_component__WEBPACK_IMPORTED_MODULE_5__.KnowledgeSkillsComponent], styles: [".tabs-secciones-cv[_ngcontent-%COMP%] {\n}\n.tabs-secciones-cv[_ngcontent-%COMP%]   li[_ngcontent-%COMP%] {\n  max-width: 155px;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbImZvcm0tY3YuY29tcG9uZW50LmNzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtBQUNBO0FBQ0E7RUFDRSxnQkFBZ0I7QUFDbEIiLCJmaWxlIjoiZm9ybS1jdi5jb21wb25lbnQuY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLnRhYnMtc2VjY2lvbmVzLWN2IHtcbn1cbi50YWJzLXNlY2Npb25lcy1jdiBsaSB7XG4gIG1heC13aWR0aDogMTU1cHg7XG59XG4iXX0= */"] });


/***/ }),

/***/ 9658:
/*!**************************************************************************************!*\
  !*** ./src/app/components/cv/form-cv/formal-education/formal-education.component.ts ***!
  \**************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "FormalEducationComponent": () => (/* binding */ FormalEducationComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 2560);

class FormalEducationComponent {
    constructor() { }
    ngOnInit() {
    }
}
FormalEducationComponent.ɵfac = function FormalEducationComponent_Factory(t) { return new (t || FormalEducationComponent)(); };
FormalEducationComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: FormalEducationComponent, selectors: [["app-formal-education"]], decls: 2, vars: 0, template: function FormalEducationComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "p");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](1, "formal-education works!");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    } }, styles: ["\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJmb3JtYWwtZWR1Y2F0aW9uLmNvbXBvbmVudC5jc3MifQ== */"] });


/***/ }),

/***/ 7021:
/*!**************************************************************************************!*\
  !*** ./src/app/components/cv/form-cv/knowledge-skills/knowledge-skills.component.ts ***!
  \**************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "KnowledgeSkillsComponent": () => (/* binding */ KnowledgeSkillsComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 2560);

class KnowledgeSkillsComponent {
    constructor() { }
    ngOnInit() {
    }
}
KnowledgeSkillsComponent.ɵfac = function KnowledgeSkillsComponent_Factory(t) { return new (t || KnowledgeSkillsComponent)(); };
KnowledgeSkillsComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: KnowledgeSkillsComponent, selectors: [["app-knowledge-skills"]], decls: 2, vars: 0, template: function KnowledgeSkillsComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "p");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](1, "knowledge-skills works!");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    } }, styles: ["\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJrbm93bGVkZ2Utc2tpbGxzLmNvbXBvbmVudC5jc3MifQ== */"] });


/***/ }),

/***/ 6284:
/*!************************************************************************!*\
  !*** ./src/app/components/cv/form-cv/languages/languages.component.ts ***!
  \************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "LanguagesComponent": () => (/* binding */ LanguagesComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 2560);

class LanguagesComponent {
    constructor() { }
    ngOnInit() {
    }
}
LanguagesComponent.ɵfac = function LanguagesComponent_Factory(t) { return new (t || LanguagesComponent)(); };
LanguagesComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: LanguagesComponent, selectors: [["app-languages"]], decls: 2, vars: 0, template: function LanguagesComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "p");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](1, "languages works!");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    } }, styles: ["\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJsYW5ndWFnZXMuY29tcG9uZW50LmNzcyJ9 */"] });


/***/ }),

/***/ 4850:
/*!************************************************************************************************!*\
  !*** ./src/app/components/cv/form-cv/no-informal-education/no-informal-education.component.ts ***!
  \************************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "NoInformalEducationComponent": () => (/* binding */ NoInformalEducationComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 2560);

class NoInformalEducationComponent {
    constructor() { }
    ngOnInit() {
    }
}
NoInformalEducationComponent.ɵfac = function NoInformalEducationComponent_Factory(t) { return new (t || NoInformalEducationComponent)(); };
NoInformalEducationComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: NoInformalEducationComponent, selectors: [["app-no-informal-education"]], decls: 2, vars: 0, template: function NoInformalEducationComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "p");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](1, "no-informal-education works!");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    } }, styles: ["\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJuby1pbmZvcm1hbC1lZHVjYXRpb24uY29tcG9uZW50LmNzcyJ9 */"] });


/***/ }),

/***/ 6059:
/*!**********************************************************************************************!*\
  !*** ./src/app/components/cv/form-cv/personal-information/personal-information.component.ts ***!
  \**********************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "PersonalInformationComponent": () => (/* binding */ PersonalInformationComponent)
/* harmony export */ });
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/forms */ 2508);
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ 4534);
/* harmony import */ var _services_custom_datepicker_i18n_service__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../../../services/custom-datepicker-i18n.service */ 5154);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var _services_parametricos_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../../../services/parametricos.service */ 7192);
/* harmony import */ var _services_prestador_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../../services/prestador.service */ 8486);
/* harmony import */ var _services_cv_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../../../services/cv.service */ 543);
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/common */ 4666);










function PersonalInformationComponent_div_1_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 93)(1, "div", 94)(2, "span", 95);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](3, "Loading...");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()()();
} }
function PersonalInformationComponent_span_13_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_option_17_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "option", 97);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const tipo_r113 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("value", tipo_r113.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate"](tipo_r113.nombre);
} }
function PersonalInformationComponent_div_18_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Tipo de documento requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_21_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_25_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * N\u00FAmero de documento requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_28_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_32_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Primer nombre requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_35_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_39_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Texto inv\u00E1lido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_42_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_46_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Primer apellido requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_49_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_53_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Texto inv\u00E1lido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_56_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_65_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Fecha de nacimiento requerida ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_68_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_option_72_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "option", 97);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const estCivil_r114 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("value", estCivil_r114.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate"](estCivil_r114.nombre);
} }
function PersonalInformationComponent_div_73_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Estado civil requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_76_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_option_80_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "option", 97);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const genero_r115 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("value", genero_r115.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate"](genero_r115.nombre);
} }
function PersonalInformationComponent_div_81_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * G\u00E9nero requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_84_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_88_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Libreta militar requerida ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_91_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_option_95_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "option", 97);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const pais_r116 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("value", pais_r116.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate"](pais_r116.nombre);
} }
function PersonalInformationComponent_div_96_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Pa\u00EDs de nacimiento requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_99_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_option_103_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "option", 97);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const pais_r117 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("value", pais_r117.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate"](pais_r117.nombre);
} }
function PersonalInformationComponent_div_104_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Nacionalidad requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_105_span_2_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_105_option_6_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "option", 97);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const depto_r121 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("value", depto_r121.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate"](depto_r121.nombre);
} }
function PersonalInformationComponent_div_105_div_7_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Departamento de nacimiento requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
const _c0 = function (a0, a1) { return { "is-valid": a0, "is-invalid": a1 }; };
function PersonalInformationComponent_div_105_Template(rf, ctx) { if (rf & 1) {
    const _r123 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵgetCurrentView"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 8)(1, "label");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](2, PersonalInformationComponent_div_105_span_2_Template, 2, 0, "span", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](3, " Departamento de nacimiento ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](4, "div", 14)(5, "select", 99);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("change", function PersonalInformationComponent_div_105_Template_select_change_5_listener($event) { _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵrestoreView"](_r123); const ctx_r122 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵnextContext"](); return _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵresetView"](ctx_r122.changeDepartamento($event)); });
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](6, PersonalInformationComponent_div_105_option_6_Template, 2, 2, "option", 12);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](7, PersonalInformationComponent_div_105_div_7_Template, 2, 0, "div", 13);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
} if (rf & 2) {
    const ctx_r31 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx_r31.f["departamentoNacimientoId"].hasError("required"));
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](4, _c0, (ctx_r31.f["departamentoNacimientoId"].dirty || ctx_r31.submitted) && !ctx_r31.f["departamentoNacimientoId"].errors, (ctx_r31.f["departamentoNacimientoId"].dirty || ctx_r31.submitted) && ctx_r31.f["departamentoNacimientoId"].errors));
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngForOf", ctx_r31.listDepartamentos);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx_r31.f["departamentoNacimientoId"].dirty || ctx_r31.submitted) && ctx_r31.f["departamentoNacimientoId"].errors);
} }
function PersonalInformationComponent_div_106_span_2_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_106_option_6_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "option", 97);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const mun_r127 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("value", mun_r127.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate"](mun_r127.nombre);
} }
function PersonalInformationComponent_div_106_div_7_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Municipio de nacimiento requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_106_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 8)(1, "label");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](2, PersonalInformationComponent_div_106_span_2_Template, 2, 0, "span", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](3, " Municipio de nacimiento ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](4, "div", 14)(5, "select", 100);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](6, PersonalInformationComponent_div_106_option_6_Template, 2, 2, "option", 12);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](7, PersonalInformationComponent_div_106_div_7_Template, 2, 0, "div", 13);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
} if (rf & 2) {
    const ctx_r32 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx_r32.f["municipioNacimientoId"].hasError("required"));
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](4, _c0, (ctx_r32.f["municipioNacimientoId"].dirty || ctx_r32.submitted) && !ctx_r32.f["municipioNacimientoId"].errors, (ctx_r32.f["municipioNacimientoId"].dirty || ctx_r32.submitted) && ctx_r32.f["municipioNacimientoId"].errors));
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngForOf", ctx_r32.listMunicipios);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx_r32.f["municipioNacimientoId"].dirty || ctx_r32.submitted) && ctx_r32.f["municipioNacimientoId"].errors);
} }
function PersonalInformationComponent_div_107_span_2_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_107_div_10_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Jefe de hogar requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_107_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 8)(1, "label");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](2, PersonalInformationComponent_div_107_span_2_Template, 2, 0, "span", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](3, " Jefe de hogar ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](4, "div", 14)(5, "select", 101)(6, "option", 43);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](7, "SI");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](8, "option", 44);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](9, "NO");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](10, PersonalInformationComponent_div_107_div_10_Template, 2, 0, "div", 13);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
} if (rf & 2) {
    const ctx_r33 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx_r33.f["jefeHogar"].hasError("required"));
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](3, _c0, (ctx_r33.f["jefeHogar"].dirty || ctx_r33.submitted) && !ctx_r33.f["jefeHogar"].errors, (ctx_r33.f["jefeHogar"].dirty || ctx_r33.submitted) && ctx_r33.f["jefeHogar"].errors));
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](5);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx_r33.f["jefeHogar"].dirty || ctx_r33.submitted) && ctx_r33.f["jefeHogar"].errors);
} }
function PersonalInformationComponent_div_108_span_2_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_108_div_10_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Poblaci\u00F3n focalizada requerida ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_108_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 8)(1, "label");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](2, PersonalInformationComponent_div_108_span_2_Template, 2, 0, "span", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](3, " Se reconoce como parte de poblaci\u00F3n focalizada ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](4, "div", 14)(5, "select", 102)(6, "option", 43);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](7, "SI");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](8, "option", 44);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](9, "NO");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](10, PersonalInformationComponent_div_108_div_10_Template, 2, 0, "div", 13);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
} if (rf & 2) {
    const ctx_r34 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx_r34.f["poblacionFocalizada"].hasError("required"));
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](3, _c0, (ctx_r34.f["poblacionFocalizada"].dirty || ctx_r34.submitted) && !ctx_r34.f["poblacionFocalizada"].errors, (ctx_r34.f["poblacionFocalizada"].dirty || ctx_r34.submitted) && ctx_r34.f["poblacionFocalizada"].errors));
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](5);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx_r34.f["poblacionFocalizada"].dirty || ctx_r34.submitted) && ctx_r34.f["poblacionFocalizada"].errors);
} }
function PersonalInformationComponent_div_109_span_2_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_109_div_10_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Sisben requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_109_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 8)(1, "label");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](2, PersonalInformationComponent_div_109_span_2_Template, 2, 0, "span", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](3, " SISBEN ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](4, "div", 14)(5, "select", 103)(6, "option", 43);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](7, "SI");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](8, "option", 44);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](9, "NO");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](10, PersonalInformationComponent_div_109_div_10_Template, 2, 0, "div", 13);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
} if (rf & 2) {
    const ctx_r35 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx_r35.f["sisben"].hasError("required"));
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](3, _c0, (ctx_r35.f["sisben"].dirty || ctx_r35.submitted) && !ctx_r35.f["sisben"].errors, (ctx_r35.f["sisben"].dirty || ctx_r35.submitted) && ctx_r35.f["sisben"].errors));
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](5);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx_r35.f["sisben"].dirty || ctx_r35.submitted) && ctx_r35.f["sisben"].errors);
} }
function PersonalInformationComponent_div_110_span_2_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_110_option_6_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "option", 97);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const eps_r137 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("value", eps_r137.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate"](eps_r137.nombre);
} }
function PersonalInformationComponent_div_110_div_7_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * EPS requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_110_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 8)(1, "label");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](2, PersonalInformationComponent_div_110_span_2_Template, 2, 0, "span", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](3, " EPS ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](4, "div", 14)(5, "select", 104);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](6, PersonalInformationComponent_div_110_option_6_Template, 2, 2, "option", 12);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](7, PersonalInformationComponent_div_110_div_7_Template, 2, 0, "div", 13);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
} if (rf & 2) {
    const ctx_r36 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx_r36.f["epsId"].hasError("required"));
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](4, _c0, (ctx_r36.f["epsId"].dirty || ctx_r36.submitted) && !ctx_r36.f["epsId"].errors, (ctx_r36.f["epsId"].dirty || ctx_r36.submitted) && ctx_r36.f["epsId"].errors));
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngForOf", ctx_r36.listEps);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx_r36.f["epsId"].dirty || ctx_r36.submitted) && ctx_r36.f["epsId"].errors);
} }
function PersonalInformationComponent_span_117_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_121_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Digite un correo electr\u00F3nico v\u00E1lido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_124_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_option_128_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "option", 97);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const pais_r138 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("value", pais_r138.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate"](pais_r138.nombre);
} }
function PersonalInformationComponent_div_129_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Pa\u00EDs de residencia requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_130_span_2_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_130_option_6_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "option", 97);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const depto_r142 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("value", depto_r142.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate"](depto_r142.nombre);
} }
function PersonalInformationComponent_div_130_div_7_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Departamento de residencia requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_130_Template(rf, ctx) { if (rf & 1) {
    const _r144 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵgetCurrentView"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 8)(1, "label");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](2, PersonalInformationComponent_div_130_span_2_Template, 2, 0, "span", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](3, " Departamento de residencia ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](4, "div", 14)(5, "select", 105);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("change", function PersonalInformationComponent_div_130_Template_select_change_5_listener($event) { _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵrestoreView"](_r144); const ctx_r143 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵnextContext"](); return _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵresetView"](ctx_r143.changeDepartamento($event)); });
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](6, PersonalInformationComponent_div_130_option_6_Template, 2, 2, "option", 12);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](7, PersonalInformationComponent_div_130_div_7_Template, 2, 0, "div", 13);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
} if (rf & 2) {
    const ctx_r42 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx_r42.f["departamentoId"].hasError("required"));
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](4, _c0, (ctx_r42.f["departamentoId"].dirty || ctx_r42.submitted) && !ctx_r42.f["departamentoId"].errors, (ctx_r42.f["departamentoId"].dirty || ctx_r42.submitted) && ctx_r42.f["departamentoId"].errors));
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngForOf", ctx_r42.listDepartamentos);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx_r42.f["departamentoId"].dirty || ctx_r42.submitted) && ctx_r42.f["departamentoId"].errors);
} }
function PersonalInformationComponent_div_131_span_2_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_131_option_6_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "option", 97);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const mun_r148 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("value", mun_r148.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate"](mun_r148.nombre);
} }
function PersonalInformationComponent_div_131_div_7_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Municipio de residencia requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_131_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 8)(1, "label");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](2, PersonalInformationComponent_div_131_span_2_Template, 2, 0, "span", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](3, " Municipio de residencia ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](4, "div", 14)(5, "select", 106);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](6, PersonalInformationComponent_div_131_option_6_Template, 2, 2, "option", 12);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](7, PersonalInformationComponent_div_131_div_7_Template, 2, 0, "div", 13);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
} if (rf & 2) {
    const ctx_r43 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx_r43.f["municipioId"].hasError("required"));
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](4, _c0, (ctx_r43.f["municipioId"].dirty || ctx_r43.submitted) && !ctx_r43.f["municipioId"].errors, (ctx_r43.f["municipioId"].dirty || ctx_r43.submitted) && ctx_r43.f["municipioId"].errors));
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngForOf", ctx_r43.listMunicipios);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx_r43.f["municipioId"].dirty || ctx_r43.submitted) && ctx_r43.f["municipioId"].errors);
} }
function PersonalInformationComponent_span_134_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_option_139_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "option", 97);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const prestador_r149 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("value", prestador_r149.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate1"]("", prestador_r149.nombre, " ");
} }
function PersonalInformationComponent_div_143_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Prestador de preferencia requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_146_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_option_150_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "option", 97);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const punto_r150 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("value", punto_r150.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate"](punto_r150.nombre);
} }
function PersonalInformationComponent_div_151_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Punto de atenci\u00F3n requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_154_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_158_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Barrio de residencia requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_161_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_169_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Pertenece a requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_172_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_176_span_1_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Tel\u00E9fono de contacto requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_176_span_2_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const ctx_r152 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵnextContext"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate1"](" * Ingrese m\u00EDnimo ", ctx_r152.countMinDigit, " d\u00EDgitos ");
} }
function PersonalInformationComponent_div_176_span_3_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Ingrese m\u00E1ximo 10 d\u00EDgitos ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_176_span_4_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * El primer d\u00EDgito debe ser 6 o 3 ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_176_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](1, PersonalInformationComponent_div_176_span_1_Template, 2, 0, "span", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](2, PersonalInformationComponent_div_176_span_2_Template, 2, 1, "span", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](3, PersonalInformationComponent_div_176_span_3_Template, 2, 0, "span", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](4, PersonalInformationComponent_div_176_span_4_Template, 2, 0, "span", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const ctx_r55 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx_r55.telefonoRequired);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx_r55.telefonoMinLength);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx_r55.telefonoMaxLength);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx_r55.firstDigitValid);
} }
function PersonalInformationComponent_span_179_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_183_span_1_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Otro tel\u00E9fono requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_183_span_2_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const ctx_r156 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵnextContext"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate1"](" * Ingrese m\u00EDnimo ", ctx_r156.countMinDigit, " d\u00EDgitos ");
} }
function PersonalInformationComponent_div_183_span_3_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Ingrese m\u00E1ximo 10 d\u00EDgitos ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_183_span_4_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * El primer d\u00EDgito debe ser 6 o 3 ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_183_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](1, PersonalInformationComponent_div_183_span_1_Template, 2, 0, "span", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](2, PersonalInformationComponent_div_183_span_2_Template, 2, 1, "span", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](3, PersonalInformationComponent_div_183_span_3_Template, 2, 0, "span", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](4, PersonalInformationComponent_div_183_span_4_Template, 2, 0, "span", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const ctx_r57 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx_r57.otroTelefonoRequired);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx_r57.telefonoMinLength);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx_r57.telefonoMaxLength);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx_r57.firstDigitValid);
} }
function PersonalInformationComponent_span_186_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_191_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Observaciones requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_198_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_216_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * V\u00EDa requerida ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_219_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_223_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * N\u00FAmero requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_226_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_option_231_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "option", 97);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const letra_r159 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("value", letra_r159.toUpperCase());
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate1"]("", letra_r159.toUpperCase(), " ");
} }
function PersonalInformationComponent_div_232_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Letra requerida ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_235_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_241_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * BIS requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_244_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_option_248_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "option", 97);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const letra_r160 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("value", letra_r160.toUpperCase());
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate1"]("", letra_r160.toUpperCase(), " ");
} }
function PersonalInformationComponent_div_249_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Complemento requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_252_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_266_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Cardinalidad requerida ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_272_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_276_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * N\u00FAmero requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_279_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_option_284_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "option", 97);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const letra_r161 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("value", letra_r161.toUpperCase());
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate1"]("", letra_r161.toUpperCase(), " ");
} }
function PersonalInformationComponent_div_285_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Letra requerida ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_288_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_292_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Complemento requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_295_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_309_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Cardinalidad requerida ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_312_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_316_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * C\u00F3digo postal requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_319_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_323_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Estrato requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_326_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_330_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Direcci\u00F3n de residencia requerida ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_337_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_342_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Perfil laboral requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_345_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_option_349_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "option", 97);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const rango_r162 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("value", rango_r162.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate"](rango_r162.nombre);
} }
function PersonalInformationComponent_div_350_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Aspiraci\u00F3n salarial requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_353_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_361_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Posibilidad de trasladarse requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_364_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_372_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Inter\u00E9s en teletrabajo requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_375_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_option_379_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "option", 97);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const item_r163 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("value", item_r163.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate"](item_r163.nombre);
} }
function PersonalInformationComponent_div_380_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Situaci\u00F3n actual de trabajo requerida ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_383_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_391_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Propiedad medio transporte requerida ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_394_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_402_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Tiene licencia para carro requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_405_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_413_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Tiene licencia para moto requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_416_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_420_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Categor\u00EDa licencia para carro requerida ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_423_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_427_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Categor\u00EDa licencia para moto requerida ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_span_434_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 96);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function PersonalInformationComponent_div_439_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 98);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Cargo(s) de inter\u00E9s (Hasta 5) requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
class PersonalInformationComponent {
    constructor(formBuilder, parametricosService, prestadorService, cvService) {
        this.formBuilder = formBuilder;
        this.parametricosService = parametricosService;
        this.prestadorService = prestadorService;
        this.cvService = cvService;
        this.submitted = false;
        this.showLoading = false;
        this.showDepartamento = true;
        this.showMunicipio = true;
        this.minDate = { year: 1900, month: 1, day: 1 };
        this.countMinDigit = 10;
        this.listTipoDocumento = [];
        this.listEstadoCivil = [];
        this.listGeneros = [];
        this.listPaises = [];
        this.listDepartamentos = [];
        this.listMunicipios = [];
        this.listPrestadoresPreferencia = [];
        this.listPuntosAtencion = [];
        this.listEps = [];
        this.listAspiracionSalarial = [];
        this.listSituacionActualTrabajo = [];
        this.alphabet = 'abcdefghijklmnñopqrstuvwxyz';
        this.personalInformationForm = this.formBuilder.group({
            tipoDocumentoId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            numeroDocumento: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            primerNombre: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.pattern("[a-zA-Z ]{1,254}")]],
            segundoNombre: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.pattern("[a-zA-Z ]{1,254}")],
            primerApellido: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.pattern("[a-zA-Z ]{1,254}")]],
            segundoApellido: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.pattern("[a-zA-Z ]{1,254}")],
            fechaNacimiento: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            estadoCivilId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            generoId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            libretaMiltar: [null],
            paisNacimientoId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            nacionalidad: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            departamentoNacimientoId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            municipioNacimientoId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            jefeHogar: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            poblacionFocalizada: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            sisben: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            epsId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            // Datos de contacto
            correoElectronico: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.email]],
            paisResidenciaId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            departamentoId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            municipioId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            prestadorPreferenciaId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            puntoAtencionId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            barrioResidencia: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            perteneceAId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            telefono: [null, [
                    _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required,
                    _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.minLength(10),
                    _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.maxLength(10),
                    this.validateTelefono.bind(this)
                ]],
            otroTelefono: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            observacion: [null],
            // Dirección
            direccionResidencia: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            tipoVia: [null],
            numeroVia: [null],
            letraVia: [null],
            bisVia: [null],
            complementoVia: [null],
            cardinalidadVia: [null],
            signoNumero: [null],
            numeroVia2: [null],
            letraVia2: [null],
            complementoVia2: [null],
            cardinalidadVia2: [null],
            codigoPostal: [null],
            estrato: [null],
            // Datos de perfil laboral
            perfilLaboral: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            rangoSalarialId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            posibilidadTrasladarse: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            interesOfertasTeletrabajo: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            situacionLaboralActual: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            propiedadMedioTransporte: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            licenciaConduccionCarroId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            licenciaConduccionMoto: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            categoriaLicenciaCarroId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            categoriaLicenciaMotoId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            // En que me gustaria trabajar
            cargoIneteres: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required]
        });
        // Define la fecha máxima del campo fecha nacimiento
        const dateNow = new Date;
        this.maxDate = { year: new Date().getFullYear() - 14, month: dateNow.getMonth() + 1, day: dateNow.getDate() };
    }
    ngOnInit() {
        // Convoca función para consultar los parametricos para el formulario
        this.getTipoDocumentos();
        this.getEstadosCivil();
        this.getGeneros();
        this.getPaises();
        this.getDepartamentos();
        this.getMunicipios();
        this.getPuntosAtencion();
        this.getEps();
        this.getAspiracionSalarial();
        this.getSituacionActualTrabajo();
        // Deshabilita algunos campos
        this.f['tipoDocumentoId'].disable();
        this.f['numeroDocumento'].disable();
        this.f['direccionResidencia'].disable();
        this.f['signoNumero'].disable();
        this.f['signoNumero'].setValue('#');
        // Consulta la información del storage en el servicio
        this.ciudadano = this.cvService.getCiudadano;
        if (this.ciudadano !== null) {
            this.personalInformationForm.patchValue(this.ciudadano);
        }
    }
    // Getter para fácil acceso a los controles de formulario
    get f() {
        return this.personalInformationForm.controls;
    }
    /**
     * Función que invoca el servicio para consultar al API los tipos de documentos
     */
    getTipoDocumentos() {
        // Si existen los parametricos de tipo documento
        const listTipoDocumentoStorage = this.parametricosService.getDataKeyParametricosStorage('TipoDocumento');
        if (listTipoDocumentoStorage !== undefined) {
            // Llena el listado de tipos documento con lo registrado en el storage
            this.listTipoDocumento = listTipoDocumentoStorage;
        }
        else {
            this.showLoading = true;
            this.parametricosService.getParametricosDefault('TipoDocumento').subscribe((response) => {
                this.listTipoDocumento = response.map(function (element) {
                    return { id: element.id, nombre: element.nombre, sigla: element.sigla, principal: element.principal };
                });
                setTimeout(() => { this.showLoading = false; }, 300);
            });
        }
    }
    /**
     * Función que invoca el servicio para consultar al API el listado de estado civil
     */
    getEstadosCivil() {
        // Consulta si existen los parametricos de EstadoCivil
        const listEstadoCivilStorage = this.parametricosService.getDataKeyParametricosStorage('EstadoCivil');
        if (listEstadoCivilStorage !== undefined) {
            // Llena el listado de EstadoCivils con lo registrado en el storage
            this.listEstadoCivil = listEstadoCivilStorage;
        }
        else {
            this.showLoading = true;
            this.parametricosService.getParametricosDefault('EstadoCivil').subscribe((response) => {
                this.listEstadoCivil = response.map(function (element) {
                    return { id: element.id, nombre: element.nombre };
                });
                // Consume servicio para añadir parametrico en el storage
                this.parametricosService.addParametricoSessionStorage('EstadoCivil', this.listEstadoCivil);
                setTimeout(() => { this.showLoading = false; }, 300);
            });
        }
    }
    /**
     * Función que invoca el servicio para consultar al API el listado generos
     */
    getGeneros() {
        // Consulta si existen los parametricos de Genero
        const listGeneroStorage = this.parametricosService.getDataKeyParametricosStorage('Genero');
        if (listGeneroStorage !== undefined) {
            // Llena el listado de generos con lo registrado en el storage
            this.listGeneros = listGeneroStorage;
        }
        else {
            this.showLoading = true;
            this.parametricosService.getParametricosDefault('Genero').subscribe((response) => {
                this.listGeneros = response.map(function (element) {
                    return { id: element.id, nombre: element.nombre };
                });
                // Consume servicio para añadir parametrico en el storage
                this.parametricosService.addParametricoSessionStorage('Genero', this.listGeneros);
                setTimeout(() => { this.showLoading = false; }, 300);
            });
        }
    }
    /**
     * Función que invoca el servicio para consultar al API el listado de paises
     */
    getPaises() {
        // Consulta si existen los parametricos de Paises
        const listPaisStorage = this.parametricosService.getDataKeyParametricosStorage('Pais');
        if (listPaisStorage !== undefined) {
            // Llena el listado de Paises con lo registrado en el storage
            this.listPaises = listPaisStorage;
            setTimeout(() => {
                // Consulta los prestadores
                this.getPrestadores(this.f['paisResidenciaId'].value);
            }, 500);
        }
        else {
            this.showLoading = true;
            this.parametricosService.getParametricosDefault('Pais').subscribe((response) => {
                this.listPaises = response.map(function (element) {
                    return { id: element.id, nombre: element.nombre };
                });
                // Consume servicio para añadir parametrico en el storage
                this.parametricosService.addParametricoSessionStorage('Pais', this.listPaises);
                setTimeout(() => {
                    this.showLoading = false;
                    // Consulta los prestadores
                    this.getPrestadores(this.f['paisResidenciaId'].value);
                }, 300);
            });
        }
    }
    /**
     * Función que invoca el servicio para consultar al API el listado de departamentos
     */
    getDepartamentos() {
        // Consulta si existen los parametricos de Departamentos
        const listDepartamentoStorage = this.parametricosService.getDataKeyParametricosStorage('Departamento');
        if (listDepartamentoStorage !== undefined) {
            this.listDepartamentos = listDepartamentoStorage;
        }
        else {
            this.showLoading = true;
            this.parametricosService.getParametricosDefault('Departamento').subscribe((response) => {
                this.listDepartamentos = response.map(function (element) {
                    return { id: element.id, nombre: element.nombre };
                });
                // Consume servicio para añadir parametrico en el storage
                this.parametricosService.addParametricoSessionStorage('Departamento', this.listDepartamentos);
                setTimeout(() => { this.showLoading = false; }, 300);
            });
        }
    }
    /**
     * Función que invoca el servicio para consultar al API o storage el listado de Municipios
     */
    getMunicipios() {
        // Consulta si existen los parametricos de Municipios
        const listMunicipioStorage = this.parametricosService.getDataKeyParametricosStorage('Municipio');
        if (listMunicipioStorage === undefined) {
            this.showLoading = true;
            this.parametricosService.getParametricoById('Municipio', 'departamentoID', '0').subscribe((response) => {
                const responseMunicipios = response.map(function (element) {
                    return { id: element.id, nombre: element.nombre, idDepartamento: element.idDepartamento };
                });
                // Consume servicio para añadir parametrico en el storage
                this.parametricosService.addParametricoSessionStorage('Municipio', responseMunicipios);
                this.showLoading = false;
                setTimeout(() => { this.showLoading = false; }, 1000);
            });
        }
    }
    /**
     * Función que invoca el servicio para consultar al API el listado de prestadores de preferencia
     */
    getPrestadores(pais) {
        const paisColombia = this.listPaises.find(element => element.nombre.toLocaleLowerCase() == 'colombia');
        // Consulta si existen los parametricos de Prestadores
        const listPrestadorStorage = this.prestadorService.getPrestadoresStorage;
        if (listPrestadorStorage.length !== 0) {
            // Llena el listado de Prestadores con lo registrado en el storage pero según el pais
            if (pais !== paisColombia.id) {
                this.listPrestadoresPreferencia = listPrestadorStorage.filter(prest => prest.coberturaNacional === true);
            }
        }
        else {
            this.showLoading = true;
            this.prestadorService.getPrestadoresByDepto(0).subscribe((response) => {
                // Carga los prestadores pero según el pais
                if (pais !== paisColombia.id) {
                    this.listPrestadoresPreferencia = response.filter(prest => prest.coberturaNacional === true);
                }
                // Consume servicio para añadir parametrico en el storage
                this.prestadorService.setPrestadoresStorage(response);
                setTimeout(() => { this.showLoading = false; }, 1000);
            });
        }
    }
    /**
     * Función que invoca el servicio para consultar al API o storage el listado de puntos de atencion
     */
    getPuntosAtencion() {
        // Consulta si existen los parametricos de Puntos de atencion
        const listPuntoAtencionStorage = this.prestadorService.getPuntosAtencionStorage;
        if (listPuntoAtencionStorage.length === 0) {
            this.showLoading = true;
            this.prestadorService.getPuntosAtencionByPrestador('00000000-0000-0000-0000-000000000000').subscribe((response) => {
                const responsePuntosAtencion = response;
                // Consume servicio para añadir parametrico en el storage
                this.prestadorService.setPuntosAtencionStorage(responsePuntosAtencion);
                setTimeout(() => { this.showLoading = false; }, 1000);
            });
        }
    }
    /**
     * Función que invoca el servicio para consultar al API o storage el listado de EPS
     */
    getEps() {
        // Consulta si existen los parametricos de Eps
        const listEpsStorage = this.parametricosService.getDataKeyParametricosStorage('Eps');
        if (listEpsStorage !== undefined) {
            // Llena el listado de Epss con lo registrado en el storage
            this.listEps = listEpsStorage;
        }
        else {
            this.showLoading = true;
            this.parametricosService.getParametricosDefault('Eps').subscribe((response) => {
                this.listEps = response.map(function (element) {
                    return { id: element.id, nombre: element.nombre };
                });
                // Consume servicio para añadir parametrico en el storage
                this.parametricosService.addParametricoSessionStorage('Eps', this.listEps);
                setTimeout(() => { this.showLoading = false; }, 300);
            });
        }
    }
    /**
     * Función que invoca el servicio para consultar al API o storage el listado de Situación actual de trabajo
     */
    getSituacionActualTrabajo() {
        // Consulta si existen los parametricos de Situación actual de trabajo
        const listSituacionActualTrabajoStorage = this.parametricosService.getDataKeyParametricosStorage('SituacionActualTrabajo');
        if (listSituacionActualTrabajoStorage !== undefined) {
            // Llena el listado de Situación actual de trabajo con lo registrado en el storage
            this.listSituacionActualTrabajo = listSituacionActualTrabajoStorage;
        }
        else {
            this.showLoading = true;
            this.parametricosService.getParametricosDefault('SituacionActualTrabajo').subscribe((response) => {
                this.listSituacionActualTrabajo = response.map(function (element) {
                    return { id: element.id, nombre: element.nombre };
                });
                // Consume servicio para añadir parametrico en el storage
                this.parametricosService.addParametricoSessionStorage('SituacionActualTrabajo', this.listSituacionActualTrabajo);
                setTimeout(() => { this.showLoading = false; }, 300);
            });
        }
    }
    /**
     * Función que invoca el servicio para consultar al API o storage el listado de Aspiración salarial
     */
    getAspiracionSalarial() {
        // Consulta si existen los parametricos Aspiración salarial
        const listAspiracionSalarialStorage = this.parametricosService.getDataKeyParametricosStorage('RangoSalarial');
        if (listAspiracionSalarialStorage !== undefined) {
            // Llena el listado Aspiración salarial con lo registrado en el storage
            this.listAspiracionSalarial = listAspiracionSalarialStorage;
        }
        else {
            this.showLoading = true;
            this.parametricosService.getParametricosDefault('RangoSalarial').subscribe((response) => {
                this.listAspiracionSalarial = response.map(function (element) {
                    return { id: element.id, nombre: element.nombre };
                });
                // Consume servicio para añadir parametrico en el storage
                this.parametricosService.addParametricoSessionStorage('RangoSalarial', this.listAspiracionSalarial);
                setTimeout(() => { this.showLoading = false; }, 300);
            });
        }
    }
    /**
     * Función que controla el evento de cambio sobre el campo pais para realizar algunas validaciones
     * @param e event
     */
    changePais(e) {
        const paisSeleccionado = this.listPaises.find(element => element.id == e.target.value);
        this.f['departamentoId'].clearValidators();
        this.f['municipioId'].clearValidators();
        this.f['telefono'].clearValidators();
        // Valida el pais seleccionado
        // Si es Colombia entonces muestra los campos departamento y municipio (deben ser requeridos)
        if (paisSeleccionado.nombre.toLocaleLowerCase() == 'colombia') {
            this.f['departamentoId'].addValidators(_angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required);
            this.f['municipioId'].addValidators(_angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required);
            this.f['telefono'].addValidators([_angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.minLength(10), _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.maxLength(10), this.validateTelefono.bind(this)]);
            this.countMinDigit = 10; // Setea la cantidad de dígitos mínimos para el campo telefono en caso de ser Colombia
            this.showDepartamento = true;
            this.showMunicipio = true;
        }
        else {
            this.f['departamentoId'].setValue('');
            this.f['municipioId'].setValue('');
            this.f['telefono'].addValidators([_angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.minLength(7), _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.maxLength(10), this.validateTelefono.bind(this)]);
            this.countMinDigit = 7; // Setea la cantidad de dígitos mínimos para el campo telefono
            this.showDepartamento = false;
            this.showMunicipio = false;
            // Al no existir departamento entonces filtra el listado de prestadores con respecto a cobertura nacional
            const listPrestadorStorage = this.parametricosService.getDataKeyParametricosStorage('Prestador');
            this.listPrestadoresPreferencia = listPrestadorStorage.filter(prest => prest.coberturaNacional == "True");
        }
        this.f['departamentoId'].updateValueAndValidity();
        this.f['municipioId'].updateValueAndValidity();
        this.f['telefono'].updateValueAndValidity();
    }
    /**
     * Función que controla el evento de cambio sobre el campo departamento y lanza la petición para consultar los municipios
     * @param e event
     */
    changeDepartamento(e) {
        this.showLoading = true;
        const depto = e == null ? this.f['departamentoId'].value : e.target.value;
        // Filtra el listado de municipios con respecto al departamento
        const listMunicipioStorage = this.parametricosService.getDataKeyParametricosStorage('Municipio');
        this.listMunicipios = listMunicipioStorage.filter(muni => muni.idDepartamento == depto);
        // Filtra el listado de prestadores con respecto al departamento
        const listPrestadorStorage = this.parametricosService.getDataKeyParametricosStorage('Prestador');
        this.listPrestadoresPreferencia = listPrestadorStorage.filter(prest => prest.idDepartamento == depto);
        this.showLoading = false;
        // Vacia value de municipio y prestador solo si no es change del campo
        if (e !== null) {
            this.f['municipioId'].setValue('');
            this.f['municipioId'].updateValueAndValidity();
            this.f['prestadorPreferenciaId'].setValue('');
            this.f['prestadorPreferenciaId'].updateValueAndValidity();
        }
    }
    /**
     * Función que controla el evento de cambio sobre el campo prestador de preferencia y lanza la petición para consultar los puntos de atención relacionados
     * @param e event
     */
    changePrestador(e) {
        this.showLoading = true;
        const prestador = e == null ? this.f['prestadorPreferenciaId'].value : e.target.value;
        // Filtra el listado de puntos de atencion con respecto al prestador de preferencia
        const listPuntoAtencionStorage = this.prestadorService.getPuntosAtencionStorage;
        this.listPuntosAtencion = listPuntoAtencionStorage.filter(punto => punto.prestadorId == prestador);
        this.showLoading = false;
        // Vacia value de puntos de atencion solo si no viene de cambiar el prestador
        if (e !== null) {
            this.f['puntoAtencionId'].setValue('');
            this.f['puntoAtencionId'].updateValueAndValidity();
        }
    }
    /**
     * Función del submit del formulario para guardar la informacion personal del ciudadano
     */
    saveAction() {
        this.submitted = true;
        // Valida si el formuario ya contiene los campos requeridos
        // if (this.personalInformationForm.valid) {
        //   this.personalInformationForm.disable();
        //   // let formDataSend: CreateRequest = this.personalInformationForm.value;
        //   // Debe ir al siguiente paso
        //   setTimeout(() => {
        //     this.showLoading = false;
        //   }, 1000);
        // }
    }
    /**
     * Función que valida sobre un input (control) que sólo sean letras
     */
    validateOnlyLetters(evt, control) {
        var regex = new RegExp("^[a-zA-Z ]+$");
        if (!regex.test(evt.target.value)) {
            this.f[control].setValue(evt.target.value.substr(0, evt.target.value.length - 1));
        }
    }
    validateOnlyNumberInput(evt) {
        const code = (evt.which) ? evt.which : evt.keyCode;
        const number = evt.target.value;
        let out = '';
        const filtro = '1234567890'; //Caracteres validos
        if (code != 8) { // backspace.
            //Recorrer el texto y verificar si el caracter se encuentra en la lista de validos
            for (var i = 0; i < number.length; i++) {
                if (filtro.indexOf(number.charAt(i)) != -1) {
                    //Se añaden a la salida los caracteres validos
                    out += number.charAt(i);
                }
            }
            this.f['telefono'].setValue(out);
        }
    }
    /**
     * Función que realiza algunas validaciones custom sobre el campo telefono
     * Si el país de residencia seleccionado es colombia:
     * - El primer número digitado debe ser 6 o 3.
     * - Siempre de 10 digitos
     * Si el país de residencia es diferente a Colombia no se restringe el ingreso.
     * - Solo restringir a mínimo 7 y máximo 10 digitos
     */
    validateTelefono(control) {
        if (control.value !== null) {
            const pais = this.f['paisResidenciaId'].value;
            // Valida si el campo pais tiene algún valor y el listado de paises está lleno
            // if (pais != null && this.listPaises.length > 0) {
            //   const paisSeleccionado: any = this.listPaises.find(element => element.id == pais);
            //   const firstDigit = control.value.substr(0, 1);
            //   if (paisSeleccionado.nombre.toLocaleLowerCase() == 'colombia' && firstDigit != '6' && firstDigit != '3') {
            //     return { firstDigit: true };
            //   }
            // }
        }
        return null;
    }
    get telefonoRequired() {
        return this.f['telefono'].hasError("required");
    }
    get telefonoMinLength() {
        return this.f['telefono'].hasError("minlength");
    }
    get telefonoMaxLength() {
        return this.f['telefono'].hasError("maxlength");
    }
    get firstDigitValid() {
        return this.f['telefono'].hasError("firstDigit");
    }
    get otroTelefonoRequired() {
        return this.f['otroTelefono'].hasError("required");
    }
    // get telefonoMinLength() {
    //   return this.f['telefono'].hasError("minlength");
    // }
    // get telefonoMaxLength() {
    //   return this.f['telefono'].hasError("maxlength");
    // }
    // get firstDigitValid() {
    //   return this.f['telefono'].hasError("firstDigit");
    // }
    concatDireccionResidencia(e) {
        // Concatena los campos de la dirección en el mismo orden y cada vez q haya algún cambio en los campos
        const tipoVia = (this.f['tipoVia'].value == null) ? '' : ' ' + this.f['tipoVia'].value;
        const numeroVia = (this.f['numeroVia'].value == null) ? '' : ' ' + this.f['numeroVia'].value;
        const letraVia = (this.f['letraVia'].value == null) ? '' : ' ' + this.f['letraVia'].value;
        const bisVia = (this.f['bisVia'].value == null) ? '' : ' ' + this.f['bisVia'].value;
        const complementoVia = (this.f['complementoVia'].value == null) ? '' : ' ' + this.f['complementoVia'].value;
        const cardinalidadVia = (this.f['cardinalidadVia'].value == null) ? '' : ' ' + this.f['cardinalidadVia'].value;
        const signoNumero = (this.f['signoNumero'].value == null) ? '' : ' ' + this.f['signoNumero'].value;
        const numeroVia2 = (this.f['numeroVia2'].value == null) ? '' : ' ' + this.f['numeroVia2'].value;
        const letraVia2 = (this.f['letraVia2'].value == null) ? '' : ' ' + this.f['letraVia2'].value;
        const complementoVia2 = (this.f['complementoVia2'].value == null) ? '' : ' ' + this.f['complementoVia2'].value;
        const cardinalidadVia2 = (this.f['cardinalidadVia2'].value == null) ? '' : ' ' + this.f['cardinalidadVia2'].value;
        let strDireccion = tipoVia + numeroVia + letraVia + bisVia + complementoVia + cardinalidadVia +
            signoNumero + numeroVia2 + letraVia2 + complementoVia2 + cardinalidadVia2;
        this.f['direccionResidencia'].setValue(strDireccion);
    }
}
PersonalInformationComponent.ɵfac = function PersonalInformationComponent_Factory(t) { return new (t || PersonalInformationComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdirectiveInject"](_angular_forms__WEBPACK_IMPORTED_MODULE_5__.FormBuilder), _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdirectiveInject"](_services_parametricos_service__WEBPACK_IMPORTED_MODULE_1__.ParametricosService), _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdirectiveInject"](_services_prestador_service__WEBPACK_IMPORTED_MODULE_2__.PrestadorService), _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdirectiveInject"](_services_cv_service__WEBPACK_IMPORTED_MODULE_3__.CvService)); };
PersonalInformationComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdefineComponent"]({ type: PersonalInformationComponent, selectors: [["app-personal-information"]], features: [_angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵProvidersFeature"]([_services_custom_datepicker_i18n_service__WEBPACK_IMPORTED_MODULE_0__.I18n, { provide: _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_6__.NgbDatepickerI18n, useClass: _services_custom_datepicker_i18n_service__WEBPACK_IMPORTED_MODULE_0__.CustomDatepickerI18nService }])], decls: 445, vars: 296, consts: [[1, "container"], ["class", "clearfix cargando", 4, "ngIf"], [1, "content-personal-information"], [1, "head-info", "col-12", "Futura_Std_Bold"], ["novalidate", "", "autocomplete", "off", 1, "", 3, "formGroup", "ngSubmit"], [1, "row", "pt-4", "pe-4", "pb-4", "ps-4"], [1, "col-12"], [1, "sube-foto"], [1, "col-md-6", "mb-2"], ["class", "text-danger", 4, "ngIf"], [1, "form-group-no-border"], ["placeholder", "", "formControlName", "tipoDocumentoId", 1, "form-select", 3, "ngClass"], [3, "value", 4, "ngFor", "ngForOf"], ["class", "invalid-feedback", 4, "ngIf"], [1, "form-group"], ["type", "text", "placeholder", "", "formControlName", "numeroDocumento", 1, "form-control", 3, "ngClass"], ["type", "text", "placeholder", "", "formControlName", "primerNombre", 1, "form-control", 3, "ngClass", "keyup"], ["type", "text", "placeholder", "", "formControlName", "segundoNombre", 1, "form-control", 3, "ngClass", "keyup"], ["type", "text", "placeholder", "", "formControlName", "primerApellido", 1, "form-control", 3, "ngClass", "keyup"], ["type", "text", "placeholder", "", "formControlName", "segundoApellido", 1, "form-control", 3, "ngClass", "keyup"], [1, "input-group", "date"], ["placeholder", "dd/mm/yyyy", "formControlName", "fechaNacimiento", "ngbDatepicker", "", 1, "form-control", 3, "ngModel", "minDate", "maxDate", "ngClass", "ngModelChange", "click"], ["d", "ngbDatepicker"], ["role", "button", 1, "input-group-append", 3, "click"], [1, "glyphicon", "glyphicon-calendar", "input-group-text", 2, "height", "100%"], ["aria-hidden", "true", 1, "fa", "fa-calendar"], ["placeholder", "", "formControlName", "estadoCivilId", 1, "form-select", 3, "ngClass"], ["placeholder", "", "formControlName", "generoId", 1, "form-select", 3, "ngClass"], ["type", "text", "placeholder", "", "formControlName", "libretaMiltar", 1, "form-control", 3, "ngClass", "keyup"], ["placeholder", "", "formControlName", "paisNacimientoId", 1, "form-select", 3, "ngClass", "change"], ["placeholder", "", "formControlName", "nacionalidad", 1, "form-select", 3, "ngClass", "change"], ["class", "col-md-6 mb-2", 4, "ngIf"], [1, "col-md-12", "mb-2"], ["type", "email", "placeholder", "", "formControlName", "correoElectronico", 1, "form-control", 3, "ngClass"], ["placeholder", "", "formControlName", "paisResidenciaId", 1, "form-select", 3, "ngClass", "change"], [1, "input-group"], ["placeholder", "", "formControlName", "prestadorPreferenciaId", 1, "form-select", 3, "ngClass", "change"], [1, "input-group-append"], ["role", "button", "placement", "right", "ngbPopover", "Seg\u00FAn la sentencia 473 del 2019 si no ha cotizado al menos un a\u00F1o en caja de compensaci\u00F3n familiar dentro de los \u00FAltimos 3 a\u00F1os, sus servicios con la caja de compensaci\u00F3n podr\u00EDan estar limitados", "popoverTitle", "Informaci\u00F3n", 1, "glyphicon", "glyphicon-info", "input-group-text", 2, "height", "100%"], ["aria-hidden", "true", 1, "fa", "fa-info", "text-danger"], ["placeholder", "", "formControlName", "puntoAtencionId", 1, "form-select", 3, "ngClass"], ["type", "text", "placeholder", "", "formControlName", "barrioResidencia", 1, "form-control", 3, "ngClass", "keyup"], ["placeholder", "", "formControlName", "perteneceAId", 1, "form-select", 3, "ngClass"], ["value", "1"], ["value", "0"], ["type", "text", "placeholder", "", "formControlName", "telefono", 1, "form-control", 3, "ngClass", "keyup"], ["type", "text", "placeholder", "", "formControlName", "otroTelefono", 1, "form-control", 3, "ngClass", "keyup"], ["placeholder", "", "formControlName", "observacion", "rows", "3", 1, "form-control", 3, "ngClass"], [1, "col-md-4", "mb-2"], ["placeholder", "", "formControlName", "tipoVia", 1, "form-select", 3, "ngClass", "change"], ["value", "AVENIDA CALLE"], ["value", "CALLE"], ["value", "CARRERA"], ["value", "CIRCULAR"], ["value", "CIRCUNVALAR"], ["value", "DIAGONAL"], ["value", "TRANSVERSAL"], ["type", "number", "placeholder", "", "formControlName", "numeroVia", 1, "form-control", 3, "ngClass", "focusout"], ["placeholder", "", "formControlName", "letraVia", 1, "form-select", 3, "ngClass", "change"], ["value", ""], ["placeholder", "", "formControlName", "bisVia", 1, "form-select", 3, "ngClass", "change"], ["value", "BIS"], ["placeholder", "", "formControlName", "complementoVia", 1, "form-select", 3, "ngClass", "change"], ["placeholder", "", "formControlName", "cardinalidadVia", 1, "form-select", 3, "ngClass", "change"], ["value", "NORTE"], ["value", "SUR"], ["value", "ESTE"], ["value", "OESTE"], ["value", "CENTRO"], [1, "form-group", "mt-3"], ["type", "text", "placeholder", "", "formControlName", "signoNumero", 1, "form-control"], ["type", "number", "placeholder", "", "formControlName", "numeroVia2", 1, "form-control", 3, "ngClass", "focusout"], ["placeholder", "", "formControlName", "letraVia2", 1, "form-select", 3, "ngClass", "change"], [1, "col-md-3", "mb-2"], ["type", "number", "placeholder", "", "formControlName", "complementoVia2", 1, "form-control", 3, "ngClass", "focusout"], ["placeholder", "", "formControlName", "cardinalidadVia2", 1, "form-select", 3, "ngClass", "change"], ["type", "number", "placeholder", "", "formControlName", "codigoPostal", 1, "form-control", 3, "ngClass", "focusout"], ["type", "number", "placeholder", "", "formControlName", "estrato", 1, "form-control", 3, "ngClass", "focusout"], ["type", "text", "placeholder", "", "formControlName", "direccionResidencia", 1, "form-control", 3, "ngClass", "focusout"], ["placeholder", "", "formControlName", "perfilLaboral", "rows", "3", 1, "form-control", 3, "ngClass"], ["placeholder", "", "formControlName", "rangoSalarialId", 1, "form-select", 3, "ngClass", "change"], ["placeholder", "", "formControlName", "posibilidadTrasladarse", 1, "form-select", 3, "ngClass"], ["placeholder", "", "formControlName", "interesOfertasTeletrabajo", 1, "form-select", 3, "ngClass"], ["placeholder", "", "formControlName", "situacionLaboralActual", 1, "form-select", 3, "ngClass"], ["placeholder", "", "formControlName", "propiedadMedioTransporte", 1, "form-select", 3, "ngClass"], ["placeholder", "", "formControlName", "licenciaConduccionCarroId", 1, "form-select", 3, "ngClass"], ["placeholder", "", "formControlName", "licenciaConduccionMoto", 1, "form-select", 3, "ngClass"], ["placeholder", "", "formControlName", "categoriaLicenciaCarroId", 1, "form-select", 3, "ngClass"], ["placeholder", "", "formControlName", "categoriaLicenciaMotoId", 1, "form-select", 3, "ngClass"], ["placeholder", "", "formControlName", "cargoIneteres", "rows", "3", 1, "form-control", 3, "ngClass"], [1, "row"], [1, "col", "d-flex", "justify-content-center"], ["type", "submit", 1, "btn", "btn-primary-form"], [1, "clearfix", "cargando"], ["role", "status", 1, "spinner-border", "float-end"], [1, "visually-hidden"], [1, "text-danger"], [3, "value"], [1, "invalid-feedback"], ["placeholder", "", "formControlName", "departamentoNacimientoId", 1, "form-select", 3, "ngClass", "change"], ["placeholder", "", "formControlName", "municipioNacimientoId", 1, "form-select", 3, "ngClass"], ["placeholder", "", "formControlName", "jefeHogar", 1, "form-select", 3, "ngClass"], ["placeholder", "", "formControlName", "poblacionFocalizada", 1, "form-select", 3, "ngClass"], ["placeholder", "", "formControlName", "sisben", 1, "form-select", 3, "ngClass"], ["placeholder", "", "formControlName", "epsId", 1, "form-select", 3, "ngClass"], ["placeholder", "", "formControlName", "departamentoId", 1, "form-select", 3, "ngClass", "change"], ["placeholder", "", "formControlName", "municipioId", 1, "form-select", 3, "ngClass"]], template: function PersonalInformationComponent_Template(rf, ctx) { if (rf & 1) {
        const _r164 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵgetCurrentView"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](1, PersonalInformationComponent_div_1_Template, 4, 0, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](2, "div", 2)(3, "div", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](4, " Datos personales ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](5, "hr");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](6, "form", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("ngSubmit", function PersonalInformationComponent_Template_form_ngSubmit_6_listener() { return ctx.saveAction(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](7, "div", 5)(8, "div", 6)(9, "div", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](10, " Sube tu foto ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](11, "div", 8)(12, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](13, PersonalInformationComponent_span_13_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](14, " Tipo de documento ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](15, "div", 10)(16, "select", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](17, PersonalInformationComponent_option_17_Template, 2, 2, "option", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](18, PersonalInformationComponent_div_18_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](19, "div", 8)(20, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](21, PersonalInformationComponent_span_21_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](22, " N\u00FAmero de documento ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](23, "div", 14);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](24, "input", 15);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](25, PersonalInformationComponent_div_25_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](26, "div", 8)(27, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](28, PersonalInformationComponent_span_28_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](29, " Primer nombre ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](30, "div", 14)(31, "input", 16);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("keyup", function PersonalInformationComponent_Template_input_keyup_31_listener($event) { return ctx.validateOnlyLetters($event, "primerNombre"); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](32, PersonalInformationComponent_div_32_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](33, "div", 8)(34, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](35, PersonalInformationComponent_span_35_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](36, " Segundo nombre ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](37, "div", 14)(38, "input", 17);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("keyup", function PersonalInformationComponent_Template_input_keyup_38_listener($event) { return ctx.validateOnlyLetters($event, "segundoNombre"); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](39, PersonalInformationComponent_div_39_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](40, "div", 8)(41, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](42, PersonalInformationComponent_span_42_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](43, " Primer apellido ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](44, "div", 14)(45, "input", 18);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("keyup", function PersonalInformationComponent_Template_input_keyup_45_listener($event) { return ctx.validateOnlyLetters($event, "primerApellido"); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](46, PersonalInformationComponent_div_46_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](47, "div", 8)(48, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](49, PersonalInformationComponent_span_49_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](50, " Segundo apellido ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](51, "div", 14)(52, "input", 19);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("keyup", function PersonalInformationComponent_Template_input_keyup_52_listener($event) { return ctx.validateOnlyLetters($event, "segundoApellido"); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](53, PersonalInformationComponent_div_53_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](54, "div", 8)(55, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](56, PersonalInformationComponent_span_56_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](57, " Fecha de nacimiento ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](58, "div", 14)(59, "div", 20)(60, "input", 21, 22);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("ngModelChange", function PersonalInformationComponent_Template_input_ngModelChange_60_listener($event) { return ctx.model = $event; })("click", function PersonalInformationComponent_Template_input_click_60_listener() { _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵrestoreView"](_r164); const _r15 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵreference"](61); return _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵresetView"](_r15.toggle()); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](62, "div", 23);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("click", function PersonalInformationComponent_Template_div_click_62_listener() { _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵrestoreView"](_r164); const _r15 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵreference"](61); return _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵresetView"](_r15.toggle()); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](63, "span", 24);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](64, "i", 25);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](65, PersonalInformationComponent_div_65_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](66, "div", 8)(67, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](68, PersonalInformationComponent_span_68_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](69, " Estado civil ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](70, "div", 10)(71, "select", 26);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](72, PersonalInformationComponent_option_72_Template, 2, 2, "option", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](73, PersonalInformationComponent_div_73_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](74, "div", 8)(75, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](76, PersonalInformationComponent_span_76_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](77, " G\u00E9nero ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](78, "div", 14)(79, "select", 27);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](80, PersonalInformationComponent_option_80_Template, 2, 2, "option", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](81, PersonalInformationComponent_div_81_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](82, "div", 8)(83, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](84, PersonalInformationComponent_span_84_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](85, " Libreta militar ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](86, "div", 14)(87, "input", 28);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("keyup", function PersonalInformationComponent_Template_input_keyup_87_listener($event) { return ctx.validateOnlyLetters($event, "libretaMiltar"); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](88, PersonalInformationComponent_div_88_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](89, "div", 8)(90, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](91, PersonalInformationComponent_span_91_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](92, " Pa\u00EDs de nacimiento ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](93, "div", 14)(94, "select", 29);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("change", function PersonalInformationComponent_Template_select_change_94_listener($event) { return ctx.changePais($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](95, PersonalInformationComponent_option_95_Template, 2, 2, "option", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](96, PersonalInformationComponent_div_96_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](97, "div", 8)(98, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](99, PersonalInformationComponent_span_99_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](100, " Nacionalidad ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](101, "div", 14)(102, "select", 30);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("change", function PersonalInformationComponent_Template_select_change_102_listener($event) { return ctx.changePais($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](103, PersonalInformationComponent_option_103_Template, 2, 2, "option", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](104, PersonalInformationComponent_div_104_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](105, PersonalInformationComponent_div_105_Template, 8, 7, "div", 31);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](106, PersonalInformationComponent_div_106_Template, 8, 7, "div", 31);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](107, PersonalInformationComponent_div_107_Template, 11, 6, "div", 31);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](108, PersonalInformationComponent_div_108_Template, 11, 6, "div", 31);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](109, PersonalInformationComponent_div_109_Template, 11, 6, "div", 31);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](110, PersonalInformationComponent_div_110_Template, 8, 7, "div", 31);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](111, "div", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](112, " Datos de contacto ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](113, "hr");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](114, "div", 5)(115, "div", 32)(116, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](117, PersonalInformationComponent_span_117_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](118, " Correo electr\u00F3nico ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](119, "div", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](120, "input", 33);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](121, PersonalInformationComponent_div_121_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](122, "div", 8)(123, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](124, PersonalInformationComponent_span_124_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](125, " Pa\u00EDs de residencia ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](126, "div", 14)(127, "select", 34);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("change", function PersonalInformationComponent_Template_select_change_127_listener($event) { return ctx.changePais($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](128, PersonalInformationComponent_option_128_Template, 2, 2, "option", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](129, PersonalInformationComponent_div_129_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](130, PersonalInformationComponent_div_130_Template, 8, 7, "div", 31);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](131, PersonalInformationComponent_div_131_Template, 8, 7, "div", 31);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](132, "div", 8)(133, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](134, PersonalInformationComponent_span_134_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](135, " Prestador de preferencia ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](136, "div", 14)(137, "div", 35)(138, "select", 36);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("change", function PersonalInformationComponent_Template_select_change_138_listener($event) { return ctx.changePrestador($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](139, PersonalInformationComponent_option_139_Template, 2, 2, "option", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](140, "div", 37)(141, "span", 38);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](142, "i", 39);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](143, PersonalInformationComponent_div_143_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](144, "div", 8)(145, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](146, PersonalInformationComponent_span_146_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](147, " Punto de atenci\u00F3n ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](148, "div", 14)(149, "select", 40);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](150, PersonalInformationComponent_option_150_Template, 2, 2, "option", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](151, PersonalInformationComponent_div_151_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](152, "div", 8)(153, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](154, PersonalInformationComponent_span_154_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](155, " Barrio de residencia ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](156, "div", 14)(157, "input", 41);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("keyup", function PersonalInformationComponent_Template_input_keyup_157_listener($event) { return ctx.validateOnlyLetters($event, "barrioResidencia"); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](158, PersonalInformationComponent_div_158_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](159, "div", 8)(160, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](161, PersonalInformationComponent_span_161_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](162, " Pertenece a ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](163, "div", 14)(164, "select", 42)(165, "option", 43);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](166, "URBANO");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](167, "option", 44);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](168, "RURAL");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](169, PersonalInformationComponent_div_169_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](170, "div", 8)(171, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](172, PersonalInformationComponent_span_172_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](173, " Tel\u00E9fono de contacto ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](174, "div", 14)(175, "input", 45);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("keyup", function PersonalInformationComponent_Template_input_keyup_175_listener($event) { return ctx.validateOnlyNumberInput($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](176, PersonalInformationComponent_div_176_Template, 5, 4, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](177, "div", 8)(178, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](179, PersonalInformationComponent_span_179_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](180, " Otro tel\u00E9fono ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](181, "div", 14)(182, "input", 46);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("keyup", function PersonalInformationComponent_Template_input_keyup_182_listener($event) { return ctx.validateOnlyNumberInput($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](183, PersonalInformationComponent_div_183_Template, 5, 4, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](184, "div", 32)(185, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](186, PersonalInformationComponent_span_186_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](187, " Observaciones ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](188, "div", 14)(189, "textarea", 47);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](190, "            ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](191, PersonalInformationComponent_div_191_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](192, "div", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](193, " Direcci\u00F3n ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](194, "hr");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](195, "div", 5)(196, "div", 48)(197, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](198, PersonalInformationComponent_span_198_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](199, " V\u00EDa ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](200, "div", 14)(201, "select", 49);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("change", function PersonalInformationComponent_Template_select_change_201_listener($event) { return ctx.concatDireccionResidencia($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](202, "option", 50);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](203, "AVENIDA CALLE");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](204, "option", 51);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](205, "CALLE");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](206, "option", 52);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](207, "CARRERA");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](208, "option", 53);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](209, "CIRCULAR");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](210, "option", 54);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](211, "CIRCUNVALAR");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](212, "option", 55);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](213, "DIAGONAL");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](214, "option", 56);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](215, "TRANSVERSAL");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](216, PersonalInformationComponent_div_216_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](217, "div", 48)(218, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](219, PersonalInformationComponent_span_219_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](220, " N\u00FAmero ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](221, "div", 14)(222, "input", 57);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("focusout", function PersonalInformationComponent_Template_input_focusout_222_listener($event) { return ctx.concatDireccionResidencia($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](223, PersonalInformationComponent_div_223_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](224, "div", 48)(225, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](226, PersonalInformationComponent_span_226_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](227, " Letra ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](228, "div", 14)(229, "select", 58);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("change", function PersonalInformationComponent_Template_select_change_229_listener($event) { return ctx.concatDireccionResidencia($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](230, "option", 59);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](231, PersonalInformationComponent_option_231_Template, 2, 2, "option", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](232, PersonalInformationComponent_div_232_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](233, "div", 48)(234, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](235, PersonalInformationComponent_span_235_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](236, " BIS ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](237, "div", 14)(238, "select", 60);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("change", function PersonalInformationComponent_Template_select_change_238_listener($event) { return ctx.concatDireccionResidencia($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](239, "option", 61);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](240, "BIS");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](241, PersonalInformationComponent_div_241_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](242, "div", 48)(243, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](244, PersonalInformationComponent_span_244_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](245, " Complemento ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](246, "div", 14)(247, "select", 62);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("change", function PersonalInformationComponent_Template_select_change_247_listener($event) { return ctx.concatDireccionResidencia($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](248, PersonalInformationComponent_option_248_Template, 2, 2, "option", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](249, PersonalInformationComponent_div_249_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](250, "div", 48)(251, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](252, PersonalInformationComponent_span_252_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](253, " Cardinalidad ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](254, "div", 14)(255, "select", 63);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("change", function PersonalInformationComponent_Template_select_change_255_listener($event) { return ctx.concatDireccionResidencia($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](256, "option", 64);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](257, "NORTE");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](258, "option", 65);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](259, "SUR");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](260, "option", 66);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](261, "ESTE");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](262, "option", 67);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](263, "OESTE");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](264, "option", 68);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](265, "CENTRO");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](266, PersonalInformationComponent_div_266_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](267, "div", 48)(268, "div", 69);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](269, "input", 70);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](270, "div", 48)(271, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](272, PersonalInformationComponent_span_272_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](273, " N\u00FAmero ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](274, "div", 14)(275, "input", 71);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("focusout", function PersonalInformationComponent_Template_input_focusout_275_listener($event) { return ctx.concatDireccionResidencia($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](276, PersonalInformationComponent_div_276_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](277, "div", 48)(278, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](279, PersonalInformationComponent_span_279_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](280, " Letra ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](281, "div", 14)(282, "select", 72);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("change", function PersonalInformationComponent_Template_select_change_282_listener($event) { return ctx.concatDireccionResidencia($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](283, "option", 59);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](284, PersonalInformationComponent_option_284_Template, 2, 2, "option", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](285, PersonalInformationComponent_div_285_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](286, "div", 73)(287, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](288, PersonalInformationComponent_span_288_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](289, " Complemento ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](290, "div", 14)(291, "input", 74);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("focusout", function PersonalInformationComponent_Template_input_focusout_291_listener($event) { return ctx.concatDireccionResidencia($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](292, PersonalInformationComponent_div_292_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](293, "div", 73)(294, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](295, PersonalInformationComponent_span_295_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](296, " Cardinalidad ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](297, "div", 14)(298, "select", 75);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("change", function PersonalInformationComponent_Template_select_change_298_listener($event) { return ctx.concatDireccionResidencia($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](299, "option", 64);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](300, "NORTE");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](301, "option", 65);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](302, "SUR");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](303, "option", 66);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](304, "ESTE");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](305, "option", 67);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](306, "OESTE");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](307, "option", 68);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](308, "CENTRO");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](309, PersonalInformationComponent_div_309_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](310, "div", 73)(311, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](312, PersonalInformationComponent_span_312_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](313, " C\u00F3digo postal ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](314, "div", 14)(315, "input", 76);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("focusout", function PersonalInformationComponent_Template_input_focusout_315_listener($event) { return ctx.concatDireccionResidencia($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](316, PersonalInformationComponent_div_316_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](317, "div", 73)(318, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](319, PersonalInformationComponent_span_319_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](320, " Estrato ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](321, "div", 14)(322, "input", 77);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("focusout", function PersonalInformationComponent_Template_input_focusout_322_listener($event) { return ctx.concatDireccionResidencia($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](323, PersonalInformationComponent_div_323_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](324, "div", 32)(325, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](326, PersonalInformationComponent_span_326_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](327, " Direcci\u00F3n de residencia ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](328, "div", 14)(329, "input", 78);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("focusout", function PersonalInformationComponent_Template_input_focusout_329_listener($event) { return ctx.concatDireccionResidencia($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](330, PersonalInformationComponent_div_330_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](331, "div", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](332, " Datos de perfil laboral ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](333, "hr");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](334, "div", 5)(335, "div", 32)(336, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](337, PersonalInformationComponent_span_337_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](338, " Perfil laboral ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](339, "div", 14)(340, "textarea", 79);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](341, "            ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](342, PersonalInformationComponent_div_342_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](343, "div", 32)(344, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](345, PersonalInformationComponent_span_345_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](346, " Aspiraci\u00F3n salarial ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](347, "div", 14)(348, "select", 80);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("change", function PersonalInformationComponent_Template_select_change_348_listener($event) { return ctx.changePais($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](349, PersonalInformationComponent_option_349_Template, 2, 2, "option", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](350, PersonalInformationComponent_div_350_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](351, "div", 8)(352, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](353, PersonalInformationComponent_span_353_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](354, " Posibilidad de trasladarse ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](355, "div", 14)(356, "select", 81)(357, "option", 43);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](358, "SI");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](359, "option", 44);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](360, "NO");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](361, PersonalInformationComponent_div_361_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](362, "div", 8)(363, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](364, PersonalInformationComponent_span_364_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](365, " Inter\u00E9s en teletrabajo ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](366, "div", 14)(367, "select", 82)(368, "option", 43);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](369, "SI");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](370, "option", 44);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](371, "NO");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](372, PersonalInformationComponent_div_372_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](373, "div", 8)(374, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](375, PersonalInformationComponent_span_375_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](376, " Situaci\u00F3n actual de trabajo ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](377, "div", 14)(378, "select", 83);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](379, PersonalInformationComponent_option_379_Template, 2, 2, "option", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](380, PersonalInformationComponent_div_380_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](381, "div", 8)(382, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](383, PersonalInformationComponent_span_383_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](384, " Propiedad medio transporte ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](385, "div", 14)(386, "select", 84)(387, "option", 43);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](388, "SI");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](389, "option", 44);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](390, "NO");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](391, PersonalInformationComponent_div_391_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](392, "div", 8)(393, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](394, PersonalInformationComponent_span_394_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](395, " Tiene licencia para carro ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](396, "div", 14)(397, "select", 85)(398, "option", 43);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](399, "SI");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](400, "option", 44);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](401, "NO");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](402, PersonalInformationComponent_div_402_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](403, "div", 8)(404, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](405, PersonalInformationComponent_span_405_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](406, " Tiene licencia para moto ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](407, "div", 14)(408, "select", 86)(409, "option", 43);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](410, "SI");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](411, "option", 44);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](412, "NO");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](413, PersonalInformationComponent_div_413_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](414, "div", 8)(415, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](416, PersonalInformationComponent_span_416_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](417, " Categor\u00EDa licencia para carro ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](418, "div", 14);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](419, "select", 87);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](420, PersonalInformationComponent_div_420_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](421, "div", 8)(422, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](423, PersonalInformationComponent_span_423_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](424, " Categor\u00EDa licencia para moto ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](425, "div", 14);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](426, "select", 88);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](427, PersonalInformationComponent_div_427_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](428, "div", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](429, " \u00BFEn qu\u00E9 me gustar\u00EDa trabajar? ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](430, "hr");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](431, "div", 5)(432, "div", 32)(433, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](434, PersonalInformationComponent_span_434_Template, 2, 0, "span", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](435, " Cargo(s) de inter\u00E9s (Hasta 5) ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](436, "div", 14)(437, "textarea", 89);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](438, "            ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](439, PersonalInformationComponent_div_439_Template, 2, 0, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](440, "br");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](441, "div", 90)(442, "div", 91)(443, "button", 92);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](444, "Agregar");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()()()()()();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.showLoading);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](5);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("formGroup", ctx.personalInformationForm);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](7);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["tipoDocumentoId"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](161, _c0, (ctx.f["tipoDocumentoId"].dirty || ctx.submitted) && !ctx.f["tipoDocumentoId"].errors, (ctx.f["tipoDocumentoId"].dirty || ctx.submitted) && ctx.f["tipoDocumentoId"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngForOf", ctx.listTipoDocumento);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["tipoDocumentoId"].dirty || ctx.submitted) && ctx.f["tipoDocumentoId"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["numeroDocumento"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](164, _c0, (ctx.f["numeroDocumento"].dirty || ctx.submitted) && !ctx.f["numeroDocumento"].errors, (ctx.f["numeroDocumento"].dirty || ctx.submitted) && ctx.f["numeroDocumento"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["numeroDocumento"].dirty || ctx.submitted) && ctx.f["numeroDocumento"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["primerNombre"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](167, _c0, (ctx.f["primerNombre"].dirty || ctx.submitted) && !ctx.f["primerNombre"].errors, (ctx.f["primerNombre"].dirty || ctx.submitted) && ctx.f["primerNombre"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["primerNombre"].dirty || ctx.submitted) && ctx.f["primerNombre"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["segundoNombre"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](170, _c0, (ctx.f["segundoNombre"].dirty || ctx.submitted) && !ctx.f["segundoNombre"].errors, (ctx.f["segundoNombre"].dirty || ctx.submitted) && ctx.f["segundoNombre"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["segundoNombre"].dirty || ctx.submitted) && ctx.f["segundoNombre"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["primerApellido"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](173, _c0, (ctx.f["primerApellido"].dirty || ctx.submitted) && !ctx.f["primerApellido"].errors, (ctx.f["primerApellido"].dirty || ctx.submitted) && ctx.f["primerApellido"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["primerApellido"].dirty || ctx.submitted) && ctx.f["primerApellido"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["segundoApellido"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](176, _c0, (ctx.f["segundoApellido"].dirty || ctx.submitted) && !ctx.f["segundoApellido"].errors, (ctx.f["segundoApellido"].dirty || ctx.submitted) && ctx.f["segundoApellido"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["segundoApellido"].dirty || ctx.submitted) && ctx.f["segundoApellido"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["fechaNacimiento"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngModel", ctx.model)("minDate", ctx.minDate)("maxDate", ctx.maxDate)("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](179, _c0, (ctx.f["fechaNacimiento"].dirty || ctx.submitted) && !ctx.f["fechaNacimiento"].errors, (ctx.f["fechaNacimiento"].dirty || ctx.submitted) && ctx.f["fechaNacimiento"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](5);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["fechaNacimiento"].dirty || ctx.submitted) && ctx.f["fechaNacimiento"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["estadoCivilId"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](182, _c0, (ctx.f["estadoCivilId"].dirty || ctx.submitted) && !ctx.f["estadoCivilId"].errors, (ctx.f["estadoCivilId"].dirty || ctx.submitted) && ctx.f["estadoCivilId"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngForOf", ctx.listEstadoCivil);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["estadoCivilId"].dirty || ctx.submitted) && ctx.f["estadoCivilId"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["generoId"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](185, _c0, (ctx.f["generoId"].dirty || ctx.submitted) && !ctx.f["generoId"].errors, (ctx.f["generoId"].dirty || ctx.submitted) && ctx.f["generoId"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngForOf", ctx.listGeneros);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["generoId"].dirty || ctx.submitted) && ctx.f["generoId"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["libretaMiltar"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](188, _c0, (ctx.f["libretaMiltar"].dirty || ctx.submitted) && !ctx.f["libretaMiltar"].errors, (ctx.f["libretaMiltar"].dirty || ctx.submitted) && ctx.f["libretaMiltar"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["libretaMiltar"].dirty || ctx.submitted) && ctx.f["libretaMiltar"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["paisNacimientoId"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](191, _c0, (ctx.f["paisNacimientoId"].dirty || ctx.submitted) && !ctx.f["paisNacimientoId"].errors, (ctx.f["paisNacimientoId"].dirty || ctx.submitted) && ctx.f["paisNacimientoId"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngForOf", ctx.listPaises);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["paisNacimientoId"].dirty || ctx.submitted) && ctx.f["paisNacimientoId"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["nacionalidad"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](194, _c0, (ctx.f["nacionalidad"].dirty || ctx.submitted) && !ctx.f["nacionalidad"].errors, (ctx.f["nacionalidad"].dirty || ctx.submitted) && ctx.f["nacionalidad"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngForOf", ctx.listPaises);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["nacionalidad"].dirty || ctx.submitted) && ctx.f["nacionalidad"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.showDepartamento);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.showMunicipio);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.showMunicipio);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.showMunicipio);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.showMunicipio);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.showMunicipio);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](7);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["correoElectronico"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](197, _c0, (ctx.f["correoElectronico"].dirty || ctx.submitted) && !ctx.f["correoElectronico"].errors, (ctx.f["correoElectronico"].dirty || ctx.submitted) && ctx.f["correoElectronico"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["correoElectronico"].dirty || ctx.submitted) && ctx.f["correoElectronico"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["paisResidenciaId"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](200, _c0, (ctx.f["paisResidenciaId"].dirty || ctx.submitted) && !ctx.f["paisResidenciaId"].errors, (ctx.f["paisResidenciaId"].dirty || ctx.submitted) && ctx.f["paisResidenciaId"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngForOf", ctx.listPaises);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["paisResidenciaId"].dirty || ctx.submitted) && ctx.f["paisResidenciaId"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.showDepartamento);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.showMunicipio);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["prestadorPreferenciaId"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](203, _c0, (ctx.f["prestadorPreferenciaId"].dirty || ctx.submitted) && !ctx.f["prestadorPreferenciaId"].errors, (ctx.f["prestadorPreferenciaId"].dirty || ctx.submitted) && ctx.f["prestadorPreferenciaId"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngForOf", ctx.listPrestadoresPreferencia);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["prestadorPreferenciaId"].dirty || ctx.submitted) && ctx.f["prestadorPreferenciaId"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["puntoAtencionId"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](206, _c0, (ctx.f["puntoAtencionId"].dirty || ctx.submitted) && !ctx.f["puntoAtencionId"].errors, (ctx.f["puntoAtencionId"].dirty || ctx.submitted) && ctx.f["puntoAtencionId"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngForOf", ctx.listPuntosAtencion);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["puntoAtencionId"].dirty || ctx.submitted) && ctx.f["puntoAtencionId"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["barrioResidencia"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](209, _c0, (ctx.f["barrioResidencia"].dirty || ctx.submitted) && !ctx.f["barrioResidencia"].errors, (ctx.f["barrioResidencia"].dirty || ctx.submitted) && ctx.f["barrioResidencia"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["barrioResidencia"].dirty || ctx.submitted) && ctx.f["barrioResidencia"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["perteneceAId"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](212, _c0, (ctx.f["perteneceAId"].dirty || ctx.submitted) && !ctx.f["perteneceAId"].errors, (ctx.f["perteneceAId"].dirty || ctx.submitted) && ctx.f["perteneceAId"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](5);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["perteneceAId"].dirty || ctx.submitted) && ctx.f["perteneceAId"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["telefono"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](215, _c0, (ctx.f["telefono"].dirty || ctx.submitted) && !ctx.f["telefono"].errors, (ctx.f["telefono"].dirty || ctx.submitted) && ctx.f["telefono"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["telefono"].dirty || ctx.submitted) && ctx.f["telefono"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["otroTelefono"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](218, _c0, (ctx.f["otroTelefono"].dirty || ctx.submitted) && !ctx.f["otroTelefono"].errors, (ctx.f["otroTelefono"].dirty || ctx.submitted) && ctx.f["otroTelefono"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["otroTelefono"].dirty || ctx.submitted) && ctx.f["otroTelefono"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["observacion"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](221, _c0, (ctx.f["observacion"].dirty || ctx.submitted) && !ctx.f["observacion"].errors, (ctx.f["observacion"].dirty || ctx.submitted) && ctx.f["observacion"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](2);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["observacion"].dirty || ctx.submitted) && ctx.f["observacion"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](7);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["tipoVia"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](224, _c0, (ctx.f["tipoVia"].dirty || ctx.submitted) && !ctx.f["tipoVia"].errors, (ctx.f["tipoVia"].dirty || ctx.submitted) && ctx.f["tipoVia"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](15);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["tipoVia"].dirty || ctx.submitted) && ctx.f["tipoVia"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["numeroVia"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](227, _c0, (ctx.f["numeroVia"].dirty || ctx.submitted) && !ctx.f["numeroVia"].errors, (ctx.f["numeroVia"].dirty || ctx.submitted) && ctx.f["numeroVia"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["numeroVia"].dirty || ctx.submitted) && ctx.f["numeroVia"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["letraVia"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](230, _c0, (ctx.f["letraVia"].dirty || ctx.submitted) && !ctx.f["letraVia"].errors, (ctx.f["letraVia"].dirty || ctx.submitted) && ctx.f["letraVia"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](2);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngForOf", ctx.alphabet.split(""));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["letraVia"].dirty || ctx.submitted) && ctx.f["letraVia"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["bisVia"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](233, _c0, (ctx.f["bisVia"].dirty || ctx.submitted) && !ctx.f["bisVia"].errors, (ctx.f["bisVia"].dirty || ctx.submitted) && ctx.f["bisVia"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["bisVia"].dirty || ctx.submitted) && ctx.f["bisVia"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["complementoVia"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](236, _c0, (ctx.f["complementoVia"].dirty || ctx.submitted) && !ctx.f["complementoVia"].errors, (ctx.f["complementoVia"].dirty || ctx.submitted) && ctx.f["complementoVia"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngForOf", ctx.alphabet.split(""));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["complementoVia"].dirty || ctx.submitted) && ctx.f["complementoVia"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["cardinalidadVia"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](239, _c0, (ctx.f["cardinalidadVia"].dirty || ctx.submitted) && !ctx.f["cardinalidadVia"].errors, (ctx.f["cardinalidadVia"].dirty || ctx.submitted) && ctx.f["cardinalidadVia"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](11);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["cardinalidadVia"].dirty || ctx.submitted) && ctx.f["cardinalidadVia"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](6);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["numeroVia2"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](242, _c0, (ctx.f["numeroVia2"].dirty || ctx.submitted) && !ctx.f["numeroVia2"].errors, (ctx.f["numeroVia2"].dirty || ctx.submitted) && ctx.f["numeroVia2"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["numeroVia2"].dirty || ctx.submitted) && ctx.f["numeroVia2"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["letraVia2"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](245, _c0, (ctx.f["letraVia2"].dirty || ctx.submitted) && !ctx.f["letraVia2"].errors, (ctx.f["letraVia2"].dirty || ctx.submitted) && ctx.f["letraVia2"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](2);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngForOf", ctx.alphabet.split(""));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["letraVia2"].dirty || ctx.submitted) && ctx.f["letraVia2"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["complementoVia2"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](248, _c0, (ctx.f["complementoVia2"].dirty || ctx.submitted) && !ctx.f["complementoVia2"].errors, (ctx.f["complementoVia2"].dirty || ctx.submitted) && ctx.f["complementoVia2"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["complementoVia2"].dirty || ctx.submitted) && ctx.f["complementoVia2"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["cardinalidadVia2"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](251, _c0, (ctx.f["cardinalidadVia2"].dirty || ctx.submitted) && !ctx.f["cardinalidadVia2"].errors, (ctx.f["cardinalidadVia2"].dirty || ctx.submitted) && ctx.f["cardinalidadVia2"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](11);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["cardinalidadVia2"].dirty || ctx.submitted) && ctx.f["cardinalidadVia2"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["codigoPostal"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](254, _c0, (ctx.f["codigoPostal"].dirty || ctx.submitted) && !ctx.f["codigoPostal"].errors, (ctx.f["codigoPostal"].dirty || ctx.submitted) && ctx.f["codigoPostal"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["codigoPostal"].dirty || ctx.submitted) && ctx.f["codigoPostal"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["estrato"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](257, _c0, (ctx.f["estrato"].dirty || ctx.submitted) && !ctx.f["estrato"].errors, (ctx.f["estrato"].dirty || ctx.submitted) && ctx.f["estrato"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["estrato"].dirty || ctx.submitted) && ctx.f["estrato"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["direccionResidencia"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](260, _c0, (ctx.f["direccionResidencia"].dirty || ctx.submitted) && !ctx.f["direccionResidencia"].errors, (ctx.f["direccionResidencia"].dirty || ctx.submitted) && ctx.f["direccionResidencia"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["direccionResidencia"].dirty || ctx.submitted) && ctx.f["direccionResidencia"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](7);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["perfilLaboral"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](263, _c0, (ctx.f["perfilLaboral"].dirty || ctx.submitted) && !ctx.f["perfilLaboral"].errors, (ctx.f["perfilLaboral"].dirty || ctx.submitted) && ctx.f["perfilLaboral"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](2);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["perfilLaboral"].dirty || ctx.submitted) && ctx.f["perfilLaboral"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["rangoSalarialId"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](266, _c0, (ctx.f["rangoSalarialId"].dirty || ctx.submitted) && !ctx.f["rangoSalarialId"].errors, (ctx.f["rangoSalarialId"].dirty || ctx.submitted) && ctx.f["rangoSalarialId"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngForOf", ctx.listAspiracionSalarial);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["rangoSalarialId"].dirty || ctx.submitted) && ctx.f["rangoSalarialId"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["posibilidadTrasladarse"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](269, _c0, (ctx.f["posibilidadTrasladarse"].dirty || ctx.submitted) && !ctx.f["posibilidadTrasladarse"].errors, (ctx.f["posibilidadTrasladarse"].dirty || ctx.submitted) && ctx.f["posibilidadTrasladarse"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](5);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["posibilidadTrasladarse"].dirty || ctx.submitted) && ctx.f["posibilidadTrasladarse"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["interesOfertasTeletrabajo"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](272, _c0, (ctx.f["interesOfertasTeletrabajo"].dirty || ctx.submitted) && !ctx.f["interesOfertasTeletrabajo"].errors, (ctx.f["interesOfertasTeletrabajo"].dirty || ctx.submitted) && ctx.f["interesOfertasTeletrabajo"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](5);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["interesOfertasTeletrabajo"].dirty || ctx.submitted) && ctx.f["interesOfertasTeletrabajo"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["situacionLaboralActual"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](275, _c0, (ctx.f["situacionLaboralActual"].dirty || ctx.submitted) && !ctx.f["situacionLaboralActual"].errors, (ctx.f["situacionLaboralActual"].dirty || ctx.submitted) && ctx.f["situacionLaboralActual"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngForOf", ctx.listSituacionActualTrabajo);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["situacionLaboralActual"].dirty || ctx.submitted) && ctx.f["situacionLaboralActual"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["propiedadMedioTransporte"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](278, _c0, (ctx.f["propiedadMedioTransporte"].dirty || ctx.submitted) && !ctx.f["propiedadMedioTransporte"].errors, (ctx.f["propiedadMedioTransporte"].dirty || ctx.submitted) && ctx.f["propiedadMedioTransporte"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](5);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["propiedadMedioTransporte"].dirty || ctx.submitted) && ctx.f["propiedadMedioTransporte"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["licenciaConduccionCarroId"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](281, _c0, (ctx.f["licenciaConduccionCarroId"].dirty || ctx.submitted) && !ctx.f["licenciaConduccionCarroId"].errors, (ctx.f["licenciaConduccionCarroId"].dirty || ctx.submitted) && ctx.f["licenciaConduccionCarroId"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](5);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["licenciaConduccionCarroId"].dirty || ctx.submitted) && ctx.f["licenciaConduccionCarroId"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["licenciaConduccionMoto"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](284, _c0, (ctx.f["licenciaConduccionMoto"].dirty || ctx.submitted) && !ctx.f["licenciaConduccionMoto"].errors, (ctx.f["licenciaConduccionMoto"].dirty || ctx.submitted) && ctx.f["licenciaConduccionMoto"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](5);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["licenciaConduccionMoto"].dirty || ctx.submitted) && ctx.f["licenciaConduccionMoto"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["categoriaLicenciaCarroId"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](287, _c0, (ctx.f["categoriaLicenciaCarroId"].dirty || ctx.submitted) && !ctx.f["categoriaLicenciaCarroId"].errors, (ctx.f["categoriaLicenciaCarroId"].dirty || ctx.submitted) && ctx.f["categoriaLicenciaCarroId"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["categoriaLicenciaCarroId"].dirty || ctx.submitted) && ctx.f["categoriaLicenciaCarroId"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["categoriaLicenciaMotoId"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](290, _c0, (ctx.f["categoriaLicenciaMotoId"].dirty || ctx.submitted) && !ctx.f["categoriaLicenciaMotoId"].errors, (ctx.f["categoriaLicenciaMotoId"].dirty || ctx.submitted) && ctx.f["categoriaLicenciaMotoId"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["categoriaLicenciaMotoId"].dirty || ctx.submitted) && ctx.f["categoriaLicenciaMotoId"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](7);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.f["cargoIneteres"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](293, _c0, (ctx.f["cargoIneteres"].dirty || ctx.submitted) && !ctx.f["cargoIneteres"].errors, (ctx.f["cargoIneteres"].dirty || ctx.submitted) && ctx.f["cargoIneteres"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](2);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["cargoIneteres"].dirty || ctx.submitted) && ctx.f["cargoIneteres"].errors);
    } }, dependencies: [_angular_common__WEBPACK_IMPORTED_MODULE_7__.NgClass, _angular_common__WEBPACK_IMPORTED_MODULE_7__.NgForOf, _angular_common__WEBPACK_IMPORTED_MODULE_7__.NgIf, _angular_forms__WEBPACK_IMPORTED_MODULE_5__["ɵNgNoValidate"], _angular_forms__WEBPACK_IMPORTED_MODULE_5__.NgSelectOption, _angular_forms__WEBPACK_IMPORTED_MODULE_5__["ɵNgSelectMultipleOption"], _angular_forms__WEBPACK_IMPORTED_MODULE_5__.DefaultValueAccessor, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.NumberValueAccessor, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.SelectControlValueAccessor, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.NgControlStatus, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.NgControlStatusGroup, _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_6__.NgbInputDatepicker, _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_6__.NgbPopover, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.FormGroupDirective, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.FormControlName], styles: [".head-info[_ngcontent-%COMP%] {\n  color: #dd2d2b;\n}\n.head-info[_ngcontent-%COMP%]   hr[_ngcontent-%COMP%] {\n  width: 50%;\n  border: 2px dashed #707070;\n  opacity: 1;\n  border-color: #707070;\n}\n.sube-foto[_ngcontent-%COMP%] {\n  width: 283px;\n  height: 146px;\n  margin-bottom: 20px;\n  border: 1px solid #707070;\n  border-radius: 8px;\n  opacity: 1;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInBlcnNvbmFsLWluZm9ybWF0aW9uLmNvbXBvbmVudC5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDRSxjQUFjO0FBQ2hCO0FBQ0E7RUFDRSxVQUFVO0VBQ1YsMEJBQTBCO0VBQzFCLFVBQVU7RUFDVixxQkFBcUI7QUFDdkI7QUFFQTtFQUNFLFlBQVk7RUFDWixhQUFhO0VBQ2IsbUJBQW1CO0VBQ25CLHlCQUF5QjtFQUN6QixrQkFBa0I7RUFDbEIsVUFBVTtBQUNaIiwiZmlsZSI6InBlcnNvbmFsLWluZm9ybWF0aW9uLmNvbXBvbmVudC5jc3MiLCJzb3VyY2VzQ29udGVudCI6WyIuaGVhZC1pbmZvIHtcbiAgY29sb3I6ICNkZDJkMmI7XG59XG4uaGVhZC1pbmZvIGhyIHtcbiAgd2lkdGg6IDUwJTtcbiAgYm9yZGVyOiAycHggZGFzaGVkICM3MDcwNzA7XG4gIG9wYWNpdHk6IDE7XG4gIGJvcmRlci1jb2xvcjogIzcwNzA3MDtcbn1cblxuLnN1YmUtZm90byB7XG4gIHdpZHRoOiAyODNweDtcbiAgaGVpZ2h0OiAxNDZweDtcbiAgbWFyZ2luLWJvdHRvbTogMjBweDtcbiAgYm9yZGVyOiAxcHggc29saWQgIzcwNzA3MDtcbiAgYm9yZGVyLXJhZGl1czogOHB4O1xuICBvcGFjaXR5OiAxO1xufVxuIl19 */"] });


/***/ }),

/***/ 8317:
/*!********************************************************************************************!*\
  !*** ./src/app/components/cv/form-cv/working-information/working-information.component.ts ***!
  \********************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "WorkingInformationComponent": () => (/* binding */ WorkingInformationComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 2560);

class WorkingInformationComponent {
    constructor() { }
    ngOnInit() {
    }
}
WorkingInformationComponent.ɵfac = function WorkingInformationComponent_Factory(t) { return new (t || WorkingInformationComponent)(); };
WorkingInformationComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: WorkingInformationComponent, selectors: [["app-working-information"]], decls: 2, vars: 0, template: function WorkingInformationComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "p");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](1, "working-information works!");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    } }, styles: ["\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJ3b3JraW5nLWluZm9ybWF0aW9uLmNvbXBvbmVudC5jc3MifQ== */"] });


/***/ }),

/***/ 4325:
/*!****************************************************************************!*\
  !*** ./src/app/components/cv/main-navigation/main-navigation.component.ts ***!
  \****************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "MainNavigationComponent": () => (/* binding */ MainNavigationComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 2560);

class MainNavigationComponent {
    constructor() { }
    ngOnInit() {
    }
}
MainNavigationComponent.ɵfac = function MainNavigationComponent_Factory(t) { return new (t || MainNavigationComponent)(); };
MainNavigationComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: MainNavigationComponent, selectors: [["app-main-navigation"]], decls: 21, vars: 0, consts: [[1, "content-navigation", "head-navigation", "d-flex", "justify-content-evenly"], ["type", "button", 1, "btn", "fs-40", "d-flex", "align-items-center"], [1, "fa", "fa-solid", "fa-bell", "fa-2xl", "text-light"], [1, "fa", "fa-solid", "fa-sign-out", "fa-2xl", "text-light"], [1, "fa", "fa-solid", "fa-gears", "fa-2xl", "text-light"]], template: function MainNavigationComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "section", 0)(1, "button", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](2, "i", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](3, "span");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](4, "Sube tu hoja de vida");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](5, "button", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](6, "i", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](7, "span");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](8, "Certificado de inscripci\u00F3n");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](9, "button", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](10, "i", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](11, "span");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](12, "Configuraci\u00F3n");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](13, "button", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](14, "i", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](15, "span");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](16, "Descargar HV");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](17, "button", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](18, "i", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](19, "span");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](20, "T\u00E9rminos y condiciones");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()()();
    } }, styles: [".content-navigation[_ngcontent-%COMP%] {\n  width: 100%;\n  height: 110px;\n}\n.fs-40[_ngcontent-%COMP%] {\n  font-size: 40px;\n}\n.fs-40[_ngcontent-%COMP%]   span[_ngcontent-%COMP%] {\n  width: 117px;\n  height: 44px;\n  text-align: left;\n  \n  letter-spacing: 0px;\n  color: #ffffff;\n  opacity: 1;\n  font-size: 22px !important;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIm1haW4tbmF2aWdhdGlvbi5jb21wb25lbnQuY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0UsV0FBVztFQUNYLGFBQWE7QUFDZjtBQUNBO0VBQ0UsZUFBZTtBQUNqQjtBQUNBO0VBQ0UsWUFBWTtFQUNaLFlBQVk7RUFDWixnQkFBZ0I7RUFDaEIscURBQXFEO0VBQ3JELG1CQUFtQjtFQUNuQixjQUFjO0VBQ2QsVUFBVTtFQUNWLDBCQUEwQjtBQUM1QiIsImZpbGUiOiJtYWluLW5hdmlnYXRpb24uY29tcG9uZW50LmNzcyIsInNvdXJjZXNDb250ZW50IjpbIi5jb250ZW50LW5hdmlnYXRpb24ge1xuICB3aWR0aDogMTAwJTtcbiAgaGVpZ2h0OiAxMTBweDtcbn1cbi5mcy00MCB7XG4gIGZvbnQtc2l6ZTogNDBweDtcbn1cbi5mcy00MCBzcGFuIHtcbiAgd2lkdGg6IDExN3B4O1xuICBoZWlnaHQ6IDQ0cHg7XG4gIHRleHQtYWxpZ246IGxlZnQ7XG4gIC8qIGZvbnQ6IG5vcm1hbCBub3JtYWwgbWVkaXVtIDIycHgvMjJweCBGdXR1cmEgU3RkOyAqL1xuICBsZXR0ZXItc3BhY2luZzogMHB4O1xuICBjb2xvcjogI2ZmZmZmZjtcbiAgb3BhY2l0eTogMTtcbiAgZm9udC1zaXplOiAyMnB4ICFpbXBvcnRhbnQ7XG59XG4iXX0= */"] });


/***/ }),

/***/ 7143:
/*!*****************************************************!*\
  !*** ./src/app/components/login/login.component.ts ***!
  \*****************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "LoginComponent": () => (/* binding */ LoginComponent)
/* harmony export */ });
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/forms */ 2508);
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../../environments/environment */ 2340);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var ngx_captcha__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ngx-captcha */ 7796);
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/router */ 124);
/* harmony import */ var _services_parametricos_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../services/parametricos.service */ 7192);
/* harmony import */ var _services_login_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../services/login.service */ 4120);
/* harmony import */ var _services_cv_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../services/cv.service */ 543);
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @angular/common */ 4666);

// import { ReCaptchaV3Service } from 'ng-recaptcha';










const _c0 = ["captchaElem"];
function LoginComponent_option_16_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "option", 32);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const tipo_r5 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("value", tipo_r5.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate"](tipo_r5.nombre);
} }
function LoginComponent_div_17_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 33);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Tipo de documento requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function LoginComponent_div_26_span_1_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 35);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * N\u00FAmero de documento requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function LoginComponent_div_26_span_2_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "span", 35);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](1, " * Excede la longitud m\u00E1xima ");
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} }
function LoginComponent_div_26_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 33);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](1, LoginComponent_div_26_span_1_Template, 2, 0, "span", 34);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](2, LoginComponent_div_26_span_2_Template, 2, 0, "span", 34);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
} if (rf & 2) {
    const ctx_r2 = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx_r2.requiredNumDoc);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx_r2.maxLengthValidNumDoc);
} }
function LoginComponent_span_44_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](0, "span", 36);
} }
const _c1 = function (a0, a1) { return { "is-valid": a0, "is-invalid": a1 }; };
class LoginComponent {
    constructor(formBuilder, reCaptchaV3Service, router, parametricosService, loginService, cvService) {
        this.formBuilder = formBuilder;
        this.reCaptchaV3Service = reCaptchaV3Service;
        this.router = router;
        this.parametricosService = parametricosService;
        this.loginService = loginService;
        this.cvService = cvService;
        this.submitted = false;
        this.showPassword = false;
        this.showLoading = false;
        this.listTipoDocumento = [];
        this.siteKey = _environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.recaptcha.siteKey;
        this.loginForm = this.formBuilder.group({
            tipoDocumento: ['', _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            numeroDocumento: ['', [_angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.pattern("^[0-9]*$"), _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.maxLength(10)]],
            password: ['', _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required]
        });
    }
    ngOnInit() {
        // Convoca función para consultar los parametricos para el formulario
        this.getTipoDocumentos(this.parametricosService.getParametricosSessionStorage);
    }
    /**
     * Función que invoca el servicio para consultar al API los tipos de documentos
     */
    getTipoDocumentos(parametricosSession) {
        // Si existen los parametricos de tipo documento
        const listTipoDocumentoStorage = this.parametricosService.getDataKeyParametricosStorage('TipoDocumento');
        if (listTipoDocumentoStorage !== undefined) {
            // Llena el listado de tipos documento con lo registrado en el storage
            this.listTipoDocumento = listTipoDocumentoStorage.filter(tipoDoc => tipoDoc.principal === true);
        }
        else {
            this.showLoading = true;
            this.parametricosService.getParametricosDefault('TipoDocumento').subscribe((response) => {
                this.listTipoDocumento = response.map(function (element) {
                    return { id: element.id, nombre: element.nombre, sigla: element.sigla, principal: element.principal };
                });
                this.listTipoDocumento = this.listTipoDocumento.filter(tipoDoc => tipoDoc.principal === true);
                // Consume servicio para añadir parametrico en el storage
                this.parametricosService.addParametricoSessionStorage('TipoDocumento', this.listTipoDocumento);
                setTimeout(() => {
                    this.showLoading = false;
                }, 1000);
            });
        }
    }
    loginAction() {
        this.submitted = true;
        // console.log(this.siteKey);
        if (this.loginForm.valid) {
            this.reCaptchaV3Service.execute(this.siteKey, 'login', (token) => {
                console.log('This is your token: ', token);
                // Si retorna token del reCaptcha entonces consume API para búscar el ciudadano
                this.loginService.getCiudadanoByTipoNumero(this.f['tipoDocumento'].value, this.f['numeroDocumento'].value).subscribe((response) => {
                    // Si devuelve la data de forma exitosa entonces la almacena en una variable en el servicio de hoja de vida
                    this.cvService.setCiudadano(response);
                    setTimeout(() => {
                        this.router.navigate(['/cv']);
                    }, 900);
                }, (error) => { console.log(error); });
            }, {
                useGlobalDomain: false
            }, (error) => console.log(error));
        }
    }
    // Getter para fácil acceso a los controles de formulario
    get f() {
        return this.loginForm.controls;
    }
    /**
     * Función que setea validaciones sobre el número documento dependiendo del tipo de documento
     */
    validaNumeroDocumento(e) {
        const tipo = e.target.value;
        this.f['numeroDocumento'].clearValidators();
        switch (tipo) {
            case '1': // CC
            case '2': // TI
                this.f['numeroDocumento'].addValidators([_angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.pattern("^[0-9]*$"), _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.maxLength(10)]);
                break;
            case '3': // DNI
                this.f['numeroDocumento'].addValidators([_angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.pattern("^[0-9]*$"), _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.maxLength(20)]);
                break;
            default:
                this.f['numeroDocumento'].addValidators([_angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.pattern("^[0-9]*$")]);
                break;
        }
        this.f['numeroDocumento'].updateValueAndValidity();
    }
    get requiredNumDoc() {
        return this.f["numeroDocumento"].hasError("required");
    }
    get maxLengthValidNumDoc() {
        return this.f["numeroDocumento"].hasError("maxlength");
    }
    validateOnlyNumberInput(evt) {
        const code = (evt.which) ? evt.which : evt.keyCode;
        const number = evt.target.value;
        let out = '';
        const filtro = '1234567890'; //Caracteres validos
        if (code != 8) { // backspace.
            //Recorrer el texto y verificar si el caracter se encuentra en la lista de validos
            for (var i = 0; i < number.length; i++) {
                if (filtro.indexOf(number.charAt(i)) != -1) {
                    if (i == 0) {
                        if (number.charAt(i) != 0) {
                            //Se añaden a la salida los caracteres validos
                            out += number.charAt(i);
                        }
                    }
                    else {
                        //Se añaden a la salida los caracteres validos
                        out += number.charAt(i);
                    }
                }
            }
            this.f['numeroDocumento'].setValue(out);
        }
    }
    /**
     * Función que se encarga de hacer el toggle de show de un campo tipo password
     * @param controlP string que identifica el control o campo de contraseña
     */
    toggleShowPassword(controlP) {
        if (controlP == 'password') {
            this.showPassword = !this.showPassword;
        }
    }
}
LoginComponent.ɵfac = function LoginComponent_Factory(t) { return new (t || LoginComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdirectiveInject"](_angular_forms__WEBPACK_IMPORTED_MODULE_5__.FormBuilder), _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdirectiveInject"](ngx_captcha__WEBPACK_IMPORTED_MODULE_6__.ReCaptchaV3Service), _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdirectiveInject"](_angular_router__WEBPACK_IMPORTED_MODULE_7__.Router), _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdirectiveInject"](_services_parametricos_service__WEBPACK_IMPORTED_MODULE_1__.ParametricosService), _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdirectiveInject"](_services_login_service__WEBPACK_IMPORTED_MODULE_2__.LoginService), _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdirectiveInject"](_services_cv_service__WEBPACK_IMPORTED_MODULE_3__.CvService)); };
LoginComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdefineComponent"]({ type: LoginComponent, selectors: [["app-login"]], viewQuery: function LoginComponent_Query(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵviewQuery"](_c0, 5);
    } if (rf & 2) {
        let _t;
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵqueryRefresh"](_t = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵloadQuery"]()) && (ctx.captchaElem = _t.first);
    } }, decls: 54, vars: 18, consts: [[1, "page-header", 2, "background-image", "url('./assets/img/daniel-olahs.jpg')"], [1, "container"], [1, "row", 2, "justify-content", "center"], [1, "col-lg-4", "col-sm-6", "mr-auto", "ml-auto", "d-flex", "justify-content-center"], [1, "card", "card-register"], [1, "title", 2, "color", "white !important"], [1, "login-form", 3, "formGroup", "ngSubmit"], [1, "col"], [1, "input-group", "form-group", "form-group-no-border"], [1, "input-group-prepend"], [1, "input-group-text"], [1, "nc-icon", "nc-paper"], ["placeholder", "", "formControlName", "tipoDocumento", 1, "form-select", 3, "ngClass", "change"], [3, "value", 4, "ngFor", "ngForOf"], ["class", "invalid-feedback", 4, "ngIf"], [1, "nc-icon", "nc-circle-10"], ["type", "text", "placeholder", "", "formControlName", "numeroDocumento", 1, "form-control", 3, "ngClass", "keyup"], [1, "nc-icon", "nc-key-25"], ["placeholder", "Contrase\u00F1a", "formControlName", "password", 1, "form-control", 3, "type"], [1, "input-group-append"], ["role", "button", 1, "glyphicon", "glyphicon-info", "input-group-text", 2, "height", "100%", 3, "click"], ["aria-hidden", "true"], [3, "siteKey"], ["captchaElem", ""], [1, "forgot"], ["href", "#", 1, "btn", "btn-link", "btn-warning", 2, "color", "#F17B46"], [1, "d-grid", "gap-2"], ["type", "submit", 1, "btn", "btn-danger", "btn-block", "btn-round", 3, "disabled"], ["class", "spinner-border spinner-border-sm", "role", "status", "aria-hidden", "true", 4, "ngIf"], [1, "texto-registrate"], ["routerLink", "/register", 2, "color", "#F17B46"], [1, "footer", "register-footer", "text-center"], [3, "value"], [1, "invalid-feedback"], ["class", "text-danger", 4, "ngIf"], [1, "text-danger"], ["role", "status", "aria-hidden", "true", 1, "spinner-border", "spinner-border-sm"]], template: function LoginComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 0)(1, "div", 1)(2, "div", 2)(3, "div", 3)(4, "div", 4)(5, "h3", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](6, "SPE");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](7, "form", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("ngSubmit", function LoginComponent_Template_form_ngSubmit_7_listener() { return ctx.loginAction(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](8, "div", 7)(9, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](10, "Tipo de documento");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](11, "div", 8)(12, "div", 9)(13, "span", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](14, "i", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](15, "select", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("change", function LoginComponent_Template_select_change_15_listener($event) { return ctx.validaNumeroDocumento($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](16, LoginComponent_option_16_Template, 2, 2, "option", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](17, LoginComponent_div_17_Template, 2, 0, "div", 14);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](18, "div", 7)(19, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](20, "N\u00FAmero de documento");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](21, "div", 8)(22, "div", 9)(23, "span", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](24, "i", 15);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](25, "input", 16);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("keyup", function LoginComponent_Template_input_keyup_25_listener($event) { return ctx.validateOnlyNumberInput($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](26, LoginComponent_div_26_Template, 3, 2, "div", 14);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](27, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](28, "Contrase\u00F1a");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](29, "div", 8)(30, "div", 9)(31, "span", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](32, "i", 17);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](33, "input", 18);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](34, "div", 19)(35, "span", 20);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("click", function LoginComponent_Template_span_click_35_listener() { return ctx.toggleShowPassword("password"); });
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](36, "i", 21);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](37, "ngx-invisible-recaptcha", 22, 23);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](39, "div", 24)(40, "a", 25);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](41, "Olvid\u00E9 mi usuario o contrase\u00F1a!");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](42, "div", 26)(43, "button", 27);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtemplate"](44, LoginComponent_span_44_Template, 1, 0, "span", 28);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](45, " Iniciar Sesi\u00F3n ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](46, "br")(47, "br");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](48, "p", 29);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](49, "\u00BFNo tienes una cuenta a\u00FAn? ");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](50, "a", 30);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](51, " Reg\u00EDstrate");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](52, " y s\u00E9 parte de nuestra comunidad.");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](53, "div", 31);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]()();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](7);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("formGroup", ctx.loginForm);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](8);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](12, _c1, (ctx.f["tipoDocumento"].dirty || ctx.submitted) && !ctx.f["tipoDocumento"].errors, (ctx.f["tipoDocumento"].dirty || ctx.submitted) && ctx.f["tipoDocumento"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngForOf", ctx.listTipoDocumento);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["tipoDocumento"].dirty || ctx.submitted) && ctx.f["tipoDocumento"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](8);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵpureFunction2"](15, _c1, (ctx.f["numeroDocumento"].dirty || ctx.submitted) && !ctx.f["numeroDocumento"].errors, (ctx.f["numeroDocumento"].dirty || ctx.submitted) && ctx.f["numeroDocumento"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", (ctx.f["numeroDocumento"].dirty || ctx.submitted) && ctx.f["numeroDocumento"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](7);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("type", ctx.showPassword ? "text" : "password");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵclassMap"](ctx.showPassword ? "fa fa-eye-slash" : "fa fa-eye");
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("siteKey", ctx.siteKey);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](6);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("disabled", !ctx.loginForm.valid);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("ngIf", ctx.submitted);
    } }, dependencies: [_angular_router__WEBPACK_IMPORTED_MODULE_7__.RouterLinkWithHref, _angular_forms__WEBPACK_IMPORTED_MODULE_5__["ɵNgNoValidate"], _angular_forms__WEBPACK_IMPORTED_MODULE_5__.NgSelectOption, _angular_forms__WEBPACK_IMPORTED_MODULE_5__["ɵNgSelectMultipleOption"], _angular_forms__WEBPACK_IMPORTED_MODULE_5__.DefaultValueAccessor, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.SelectControlValueAccessor, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.NgControlStatus, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.NgControlStatusGroup, _angular_common__WEBPACK_IMPORTED_MODULE_8__.NgClass, _angular_common__WEBPACK_IMPORTED_MODULE_8__.NgForOf, _angular_common__WEBPACK_IMPORTED_MODULE_8__.NgIf, ngx_captcha__WEBPACK_IMPORTED_MODULE_6__.InvisibleReCaptchaComponent, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.FormGroupDirective, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.FormControlName], styles: [".page-header[_ngcontent-%COMP%] {\n  background-color: #b2afab;\n  background-position: center center;\n  background-size: cover;\n  min-height: 100vh;\n  max-height: 999px;\n  overflow: hidden;\n  position: relative;\n  width: 100%;\n  z-index: 1;\n  display: flex;\n  align-items: center;\n  justify-content: center;\n  -ms-flex-pack: center;\n}\n\n.card-register[_ngcontent-%COMP%] {\n  background-color: #f1ab46;\n  border-radius: 8px;\n  color: #fff;\n  max-width: 350px;\n  margin: 120px 0 70px;\n  min-height: 400px;\n  padding: 30px;\n  z-index: 1;\n}\n\n.card-register[_ngcontent-%COMP%]   .title[_ngcontent-%COMP%] {\n  color: #b33c12;\n  text-align: center;\n}\n\n.card-register[_ngcontent-%COMP%]   .forgot[_ngcontent-%COMP%] {\n  text-align: center;\n}\n\n.texto-registrate[_ngcontent-%COMP%] {\n  font-size: 18px;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbImxvZ2luLmNvbXBvbmVudC5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDRSx5QkFBeUI7RUFDekIsa0NBQWtDO0VBQ2xDLHNCQUFzQjtFQUN0QixpQkFBaUI7RUFDakIsaUJBQWlCO0VBQ2pCLGdCQUFnQjtFQUNoQixrQkFBa0I7RUFDbEIsV0FBVztFQUNYLFVBQVU7RUFDVixhQUFhO0VBQ2IsbUJBQW1CO0VBQ25CLHVCQUF1QjtFQUN2QixxQkFBcUI7QUFDdkI7O0FBRUE7RUFDRSx5QkFBeUI7RUFDekIsa0JBQWtCO0VBQ2xCLFdBQVc7RUFDWCxnQkFBZ0I7RUFDaEIsb0JBQW9CO0VBQ3BCLGlCQUFpQjtFQUNqQixhQUFhO0VBQ2IsVUFBVTtBQUNaOztBQUNBO0VBQ0UsY0FBYztFQUNkLGtCQUFrQjtBQUNwQjs7QUFDQTtFQUNFLGtCQUFrQjtBQUNwQjs7QUFFQTtFQUNFLGVBQWU7QUFDakIiLCJmaWxlIjoibG9naW4uY29tcG9uZW50LmNzcyIsInNvdXJjZXNDb250ZW50IjpbIi5wYWdlLWhlYWRlciB7XG4gIGJhY2tncm91bmQtY29sb3I6ICNiMmFmYWI7XG4gIGJhY2tncm91bmQtcG9zaXRpb246IGNlbnRlciBjZW50ZXI7XG4gIGJhY2tncm91bmQtc2l6ZTogY292ZXI7XG4gIG1pbi1oZWlnaHQ6IDEwMHZoO1xuICBtYXgtaGVpZ2h0OiA5OTlweDtcbiAgb3ZlcmZsb3c6IGhpZGRlbjtcbiAgcG9zaXRpb246IHJlbGF0aXZlO1xuICB3aWR0aDogMTAwJTtcbiAgei1pbmRleDogMTtcbiAgZGlzcGxheTogZmxleDtcbiAgYWxpZ24taXRlbXM6IGNlbnRlcjtcbiAganVzdGlmeS1jb250ZW50OiBjZW50ZXI7XG4gIC1tcy1mbGV4LXBhY2s6IGNlbnRlcjtcbn1cblxuLmNhcmQtcmVnaXN0ZXIge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjZjFhYjQ2O1xuICBib3JkZXItcmFkaXVzOiA4cHg7XG4gIGNvbG9yOiAjZmZmO1xuICBtYXgtd2lkdGg6IDM1MHB4O1xuICBtYXJnaW46IDEyMHB4IDAgNzBweDtcbiAgbWluLWhlaWdodDogNDAwcHg7XG4gIHBhZGRpbmc6IDMwcHg7XG4gIHotaW5kZXg6IDE7XG59XG4uY2FyZC1yZWdpc3RlciAudGl0bGUge1xuICBjb2xvcjogI2IzM2MxMjtcbiAgdGV4dC1hbGlnbjogY2VudGVyO1xufVxuLmNhcmQtcmVnaXN0ZXIgLmZvcmdvdCB7XG4gIHRleHQtYWxpZ246IGNlbnRlcjtcbn1cblxuLnRleHRvLXJlZ2lzdHJhdGUge1xuICBmb250LXNpemU6IDE4cHg7XG59XG4iXX0= */"] });


/***/ }),

/***/ 2230:
/*!************************************************************************!*\
  !*** ./src/app/components/register/basic-data/basic-data.component.ts ***!
  \************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "BasicDataComponent": () => (/* binding */ BasicDataComponent)
/* harmony export */ });
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! @angular/forms */ 2508);
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ 4534);
/* harmony import */ var _model_ciudadano__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../../model/ciudadano */ 5604);
/* harmony import */ var _services_custom_datepicker_i18n_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../../services/custom-datepicker-i18n.service */ 5154);
/* harmony import */ var _modal_validation_modal_validation_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../modal-validation/modal-validation.component */ 6178);
/* harmony import */ var _shared_password_validators__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../../shared/password-validators */ 7531);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var _services_parametricos_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../../services/parametricos.service */ 7192);
/* harmony import */ var _services_ciudadano_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../../../services/ciudadano.service */ 6295);
/* harmony import */ var _services_register_service__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../../../services/register.service */ 1032);
/* harmony import */ var _services_prestador_service__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ../../../services/prestador.service */ 8486);
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! @angular/common */ 4666);
/* harmony import */ var _fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! @fortawesome/angular-fontawesome */ 9200);















function BasicDataComponent_div_1_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 54)(1, "div", 55)(2, "span", 56);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](3, "Loading...");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()()();
} }
function BasicDataComponent_span_5_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_option_9_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "option", 58);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} if (rf & 2) {
    const tipo_r50 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("value", tipo_r50.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtextInterpolate"](tipo_r50.nombre);
} }
function BasicDataComponent_div_10_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * Tipo de documento requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_span_13_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_17_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * N\u00FAmero de documento requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_span_20_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_24_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * Digite un correo electr\u00F3nico v\u00E1lido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_span_28_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_36_span_1_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "* La contrase\u00F1a es requerida");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
const _c0 = function (a0, a1) { return { "text-success": a0, "text-danger": a1 }; };
function BasicDataComponent_div_36_div_2_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 61)(1, "div", 62);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelement"](2, "i");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](3, " Debe tener al menos 8 car\u00E1cteres de longitud ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](4, "div", 62);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelement"](5, "i");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](6, " Debe tener m\u00E1ximo 17 car\u00E1cteres de longitud ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](7, "div", 62);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelement"](8, "i");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](9, " Debe contener al menos 1 n\u00FAmero ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](10, "div", 62);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelement"](11, "i");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](12, " Debe contener al menos 1 car\u00E1cter en may\u00FAscula ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](13, "div", 62);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelement"](14, "i");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](15, " Debe contener al menos 1 car\u00E1cter en min\u00FAscula ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](16, "div", 62);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelement"](17, "i");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](18, " Debe contener al menos 1 car\u00E1cter especial ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
} if (rf & 2) {
    const ctx_r52 = _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵnextContext"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](12, _c0, ctx_r52.minLengthValid, !ctx_r52.minLengthValid));
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵattribute"]("class", ctx_r52.minLengthValid ? "bi-check-square-fill" : "bi-x-square");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](15, _c0, ctx_r52.maxLengthValid, !ctx_r52.maxLengthValid));
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵattribute"]("class", ctx_r52.maxLengthValid ? "bi-check-square-fill" : "bi-x-square");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](18, _c0, ctx_r52.requiresDigitValid, !ctx_r52.requiresDigitValid));
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵattribute"]("class", ctx_r52.requiresDigitValid ? "bi-check-square-fill" : "bi-x-square");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](21, _c0, ctx_r52.requiresUppercaseValid, !ctx_r52.requiresUppercaseValid));
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵattribute"]("class", ctx_r52.requiresUppercaseValid ? "bi-check-square-fill" : "bi-x-square");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](24, _c0, ctx_r52.requiresLowercaseValid, !ctx_r52.requiresLowercaseValid));
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵattribute"]("class", ctx_r52.requiresLowercaseValid ? "bi-check-square-fill" : "bi-x-square");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](27, _c0, ctx_r52.requiresSpecialCharsValid, !ctx_r52.requiresSpecialCharsValid));
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵattribute"]("class", ctx_r52.requiresSpecialCharsValid ? "bi-check-square-fill" : "bi-x-square");
} }
function BasicDataComponent_div_36_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](1, BasicDataComponent_div_36_span_1_Template, 2, 0, "span", 4);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](2, BasicDataComponent_div_36_div_2_Template, 19, 30, "div", 60);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} if (rf & 2) {
    const ctx_r9 = _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx_r9.f["password"].dirty || ctx_r9.submitted) && !ctx_r9.requiredValid);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx_r9.requiredValid);
} }
function BasicDataComponent_span_39_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_47_div_1_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "Confirmar la contrase\u00F1a");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_47_div_2_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "La contrase\u00F1a debe tener al menos 8 caracteres");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_47_div_3_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "Las contrase\u00F1as no coinciden");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_47_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](1, BasicDataComponent_div_47_div_1_Template, 2, 0, "div", 63);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](2, BasicDataComponent_div_47_div_2_Template, 2, 0, "div", 63);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](3, BasicDataComponent_div_47_div_3_Template, 2, 0, "div", 63);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} if (rf & 2) {
    const ctx_r11 = _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx_r11.f["confirmPassword"].errors == null ? null : ctx_r11.f["confirmPassword"].errors["required"]);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx_r11.f["confirmPassword"].errors == null ? null : ctx_r11.f["confirmPassword"].errors["minLength"]);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx_r11.f["confirmPassword"].errors == null ? null : ctx_r11.f["confirmPassword"].errors["mismatch"]);
} }
function BasicDataComponent_span_50_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_54_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * Primer nombre requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_span_57_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_61_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * Texto inv\u00E1lido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_span_64_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_68_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * Primer apellido requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_span_71_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_75_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * Texto inv\u00E1lido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_span_78_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_87_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * Fecha de nacimiento requerida ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_span_90_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_option_94_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "option", 58);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} if (rf & 2) {
    const genero_r56 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("value", genero_r56.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtextInterpolate"](genero_r56.nombre);
} }
function BasicDataComponent_div_95_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * G\u00E9nero requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_span_98_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_102_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * Direcci\u00F3n de residencia requerida ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_span_105_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_option_109_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "option", 58);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} if (rf & 2) {
    const pais_r57 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("value", pais_r57.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtextInterpolate"](pais_r57.nombre);
} }
function BasicDataComponent_div_110_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * Pa\u00EDs de residencia requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_111_span_2_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_111_option_6_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "option", 58);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} if (rf & 2) {
    const depto_r61 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("value", depto_r61.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtextInterpolate"](depto_r61.nombre);
} }
function BasicDataComponent_div_111_div_7_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * Departamento requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
const _c1 = function (a0, a1) { return { "is-valid": a0, "is-invalid": a1 }; };
function BasicDataComponent_div_111_Template(rf, ctx) { if (rf & 1) {
    const _r63 = _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵgetCurrentView"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 3)(1, "label");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](2, BasicDataComponent_div_111_span_2_Template, 2, 0, "span", 4);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](3, " Departamento ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](4, "div", 9)(5, "select", 64);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵlistener"]("change", function BasicDataComponent_div_111_Template_select_change_5_listener($event) { _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵrestoreView"](_r63); const ctx_r62 = _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵnextContext"](); return _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵresetView"](ctx_r62.changeDepartamento($event)); });
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](6, BasicDataComponent_div_111_option_6_Template, 2, 2, "option", 7);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](7, BasicDataComponent_div_111_div_7_Template, 2, 0, "div", 8);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
} if (rf & 2) {
    const ctx_r31 = _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx_r31.f["departamentoId"].hasError("required"));
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](4, _c1, (ctx_r31.f["departamentoId"].dirty || ctx_r31.submitted) && !ctx_r31.f["departamentoId"].errors, (ctx_r31.f["departamentoId"].dirty || ctx_r31.submitted) && ctx_r31.f["departamentoId"].errors));
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngForOf", ctx_r31.listDepartamentos);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx_r31.f["departamentoId"].dirty || ctx_r31.submitted) && ctx_r31.f["departamentoId"].errors);
} }
function BasicDataComponent_div_112_span_2_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_112_option_6_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "option", 58);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} if (rf & 2) {
    const mun_r67 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("value", mun_r67.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtextInterpolate"](mun_r67.nombre);
} }
function BasicDataComponent_div_112_div_7_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * Municipio requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_112_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 3)(1, "label");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](2, BasicDataComponent_div_112_span_2_Template, 2, 0, "span", 4);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](3, " Municipio ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](4, "div", 9)(5, "select", 65);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](6, BasicDataComponent_div_112_option_6_Template, 2, 2, "option", 7);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](7, BasicDataComponent_div_112_div_7_Template, 2, 0, "div", 8);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
} if (rf & 2) {
    const ctx_r32 = _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx_r32.f["municipioId"].hasError("required"));
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](4, _c1, (ctx_r32.f["municipioId"].dirty || ctx_r32.submitted) && !ctx_r32.f["municipioId"].errors, (ctx_r32.f["municipioId"].dirty || ctx_r32.submitted) && ctx_r32.f["municipioId"].errors));
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngForOf", ctx_r32.listMunicipios);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx_r32.f["municipioId"].dirty || ctx_r32.submitted) && ctx_r32.f["municipioId"].errors);
} }
function BasicDataComponent_span_115_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_119_span_1_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * Tel\u00E9fono requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_119_span_2_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} if (rf & 2) {
    const ctx_r69 = _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵnextContext"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtextInterpolate1"](" * Ingrese m\u00EDnimo ", ctx_r69.countMinDigit, " d\u00EDgitos ");
} }
function BasicDataComponent_div_119_span_3_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * Ingrese m\u00E1ximo 10 d\u00EDgitos ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_119_span_4_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * El primer d\u00EDgito debe ser 6 o 3 ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_119_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](1, BasicDataComponent_div_119_span_1_Template, 2, 0, "span", 4);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](2, BasicDataComponent_div_119_span_2_Template, 2, 1, "span", 4);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](3, BasicDataComponent_div_119_span_3_Template, 2, 0, "span", 4);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](4, BasicDataComponent_div_119_span_4_Template, 2, 0, "span", 4);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} if (rf & 2) {
    const ctx_r34 = _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx_r34.telefonoRequired);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx_r34.telefonoMinLength);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx_r34.telefonoMaxLength);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx_r34.firstDigitValid);
} }
function BasicDataComponent_span_122_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_option_127_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "option", 58);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} if (rf & 2) {
    const prestador_r72 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("value", prestador_r72.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtextInterpolate1"]("", prestador_r72.nombre, " ");
} }
function BasicDataComponent_div_131_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * Prestador de preferencia requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_span_134_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_option_138_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "option", 58);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} if (rf & 2) {
    const punto_r73 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("value", punto_r73.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtextInterpolate"](punto_r73.nombre);
} }
function BasicDataComponent_div_139_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * Punto de atenci\u00F3n requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_span_146_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_option_150_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "option", 58);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} if (rf & 2) {
    const pregunta_r74 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("value", pregunta_r74.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtextInterpolate"](pregunta_r74.nombre);
} }
function BasicDataComponent_div_151_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * Pregunta de seguridad requerida ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_span_154_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_158_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * Respuesta requerida ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_span_169_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " *");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_172_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * Selecci\u00F3n de t\u00E9rminos y condiciones es requerida ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_span_181_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "span", 57);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " *");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
function BasicDataComponent_div_184_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "div", 59);
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](1, " * Selecci\u00F3n de pol\u00EDtica de tratamiento de datos personales es requerida ");
    _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
} }
const _c2 = function () { return ["fas", "file-download"]; };
class BasicDataComponent {
    constructor(formBuilder, parametricosService, ciudadanoService, registerService, prestadorService, modalService) {
        this.formBuilder = formBuilder;
        this.parametricosService = parametricosService;
        this.ciudadanoService = ciudadanoService;
        this.registerService = registerService;
        this.prestadorService = prestadorService;
        this.modalService = modalService;
        this.submitted = false;
        this.showLoading = false;
        this.listTipoDocumento = [];
        this.listGeneros = [];
        this.listPaises = [];
        this.listDepartamentos = [];
        this.listMunicipios = [];
        this.listPrestadoresPreferencia = [];
        this.listPuntosAtencion = [];
        this.listPreguntasSeguridad = [];
        this.minDate = { year: 1900, month: 1, day: 1 };
        this.showPassword = false;
        this.showPasswordConfirm = false;
        this.showDepartamento = true;
        this.showMunicipio = true;
        this.countMinDigit = 10;
        //Inicia el formulario
        this.basicDataForm = this.formBuilder.group({
            tipoDocumentoId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            numeroDocumento: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            correoElectronico: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.email]],
            password: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.compose([
                    _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required,
                    _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.minLength(8),
                    _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.maxLength(17),
                    _shared_password_validators__WEBPACK_IMPORTED_MODULE_3__.PasswordValidators.patternValidator(new RegExp("(?=.*[0-9])"), {
                        requiresDigit: true
                    }),
                    _shared_password_validators__WEBPACK_IMPORTED_MODULE_3__.PasswordValidators.patternValidator(new RegExp("(?=.*[A-Z])"), {
                        requiresUppercase: true
                    }),
                    _shared_password_validators__WEBPACK_IMPORTED_MODULE_3__.PasswordValidators.patternValidator(new RegExp("(?=.*[a-z])"), {
                        requiresLowercase: true
                    }),
                    _shared_password_validators__WEBPACK_IMPORTED_MODULE_3__.PasswordValidators.patternValidator(new RegExp("(?=.*[$@^!%*?&#+=•.,¬|=])"), {
                        requiresSpecialChars: true
                    })
                ])],
            confirmPassword: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.minLength(8)]],
            primerNombre: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.pattern("[a-zA-Z ]{1,254}")]],
            segundoNombre: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.pattern("[a-zA-Z ]{1,254}")],
            primerApellido: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.pattern("[a-zA-Z ]{1,254}")]],
            segundoApellido: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.pattern("[a-zA-Z ]{1,254}")],
            fechaNacimiento: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            generoId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            telefono: [null, [
                    _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required,
                    _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.minLength(10),
                    _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.maxLength(10),
                    this.validateTelefono.bind(this)
                ]],
            direccionResidencia: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            paisResidenciaId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            departamentoId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            municipioId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            prestadorPreferenciaId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            puntoAtencionId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            preguntaSeguridadId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            preguntaSeguridadRespuesta: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            terminosCondiciones: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            tratamientoDatosPersonales: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
        }, {
            validators: _shared_password_validators__WEBPACK_IMPORTED_MODULE_3__.PasswordValidators.MatchValidator
        });
        // Define la fecha máxima del campo fecha nacimiento
        const dateNow = new Date;
        this.maxDate = { year: new Date().getFullYear() - 14, month: dateNow.getMonth() + 1, day: dateNow.getDate() };
    }
    ngOnInit() {
        // Convoca función para consultar los parametricos para el formulario
        this.getTipoDocumentos();
        this.getGeneros();
        this.getPaises();
        this.getDepartamentos();
        this.getMunicipios();
        this.getPreguntasSeguridad();
        this.getPuntosAtencion();
        // Valida si ya hay un proceso de registro creado
        const dataRegister = this.registerService.getRegisterData();
        if (dataRegister) {
            this.basicDataForm.patchValue(dataRegister);
            this.model = dataRegister.fechaNacimiento;
            // Simula change del depto para llenar el municipio y el de el prestador para llenar puntos de atencion
            this.changeDepartamento(null);
            this.changePrestador(null);
        }
        else {
            // Valida si ya hay un proceso de validación creado
            const dataValidate = this.registerService.getValidateData();
            if (dataValidate) {
                this.basicDataForm.controls['tipoDocumentoId'].setValue(+dataValidate.TipoDocumentoId);
                this.basicDataForm.controls['numeroDocumento'].setValue(dataValidate.NumeroDocumento);
                this.basicDataForm.controls['correoElectronico'].setValue(dataValidate.CorreoElectronico);
            }
        }
        // Deja disabled los campos que vienen llenos para que no los pueda editar
        this.f['tipoDocumentoId'].disable();
        this.f['numeroDocumento'].disable();
        this.f['correoElectronico'].disable();
    }
    /**
     * Función que invoca el servicio para consultar al API los tipos de documentos
     */
    getTipoDocumentos() {
        // Si existen los parametricos de tipo documento
        const listTipoDocumentoStorage = this.parametricosService.getDataKeyParametricosStorage('TipoDocumento');
        if (listTipoDocumentoStorage !== undefined) {
            // Llena el listado de tipos documento con lo registrado en el storage
            this.listTipoDocumento = listTipoDocumentoStorage;
        }
        else {
            this.showLoading = true;
            this.parametricosService.getParametricosDefault('TipoDocumento').subscribe((response) => {
                this.listTipoDocumento = response.map(function (element) {
                    return { id: element.id, nombre: element.nombre, sigla: element.sigla, principal: element.principal };
                });
                setTimeout(() => { this.showLoading = false; }, 300);
            });
        }
    }
    /**
     * Función que invoca el servicio para consultar al API el listado generos
     */
    getGeneros() {
        // Consulta si existen los parametricos de Genero
        const listGeneroStorage = this.parametricosService.getDataKeyParametricosStorage('Genero');
        if (listGeneroStorage !== undefined) {
            // Llena el listado de generos con lo registrado en el storage
            this.listGeneros = listGeneroStorage;
        }
        else {
            this.showLoading = true;
            this.parametricosService.getParametricosDefault('Genero').subscribe((response) => {
                this.listGeneros = response.map(function (element) {
                    return { id: element.id, nombre: element.nombre };
                });
                // Consume servicio para añadir parametrico en el storage
                this.parametricosService.addParametricoSessionStorage('Genero', this.listGeneros);
                setTimeout(() => { this.showLoading = false; }, 300);
            });
        }
    }
    /**
     * Función que invoca el servicio para consultar al API el listado de paises
     */
    getPaises() {
        // Consulta si existen los parametricos de Paises
        const listPaisStorage = this.parametricosService.getDataKeyParametricosStorage('Pais');
        if (listPaisStorage !== undefined) {
            // Llena el listado de Paises con lo registrado en el storage
            this.listPaises = listPaisStorage;
            // Si no hay país seleccionado entonces por defecto deja Colombia
            if (this.f['paisResidenciaId'].value == null) {
                const paisColombia = this.listPaises.find(element => element.nombre.toLocaleLowerCase() == 'colombia');
                this.f['paisResidenciaId'].setValue(paisColombia.id);
                this.f['paisResidenciaId'].updateValueAndValidity();
                setTimeout(() => {
                    // Consulta los prestadores
                    this.getPrestadores(this.f['paisResidenciaId'].value);
                }, 500);
            }
        }
        else {
            this.showLoading = true;
            this.parametricosService.getParametricosDefault('Pais').subscribe((response) => {
                this.listPaises = response.map(function (element) {
                    return { id: element.id, nombre: element.nombre.toUpperCase() };
                });
                // Consume servicio para añadir parametrico en el storage
                this.parametricosService.addParametricoSessionStorage('Pais', this.listPaises);
                setTimeout(() => {
                    this.showLoading = false;
                    // Si no hay país seleccionado entonces por defecto deja Colombia
                    if (this.f['paisResidenciaId'].value == null) {
                        const paisColombia = this.listPaises.find(element => element.nombre.toLocaleLowerCase() == 'colombia');
                        this.f['paisResidenciaId'].setValue(paisColombia.id);
                        this.f['paisResidenciaId'].updateValueAndValidity();
                        // Consulta los prestadores
                        this.getPrestadores(this.f['paisResidenciaId'].value);
                    }
                }, 300);
            });
        }
    }
    /**
     * Función que invoca el servicio para consultar al API el listado de departamentos
     */
    getDepartamentos() {
        // Consulta si existen los parametricos de Departamentos
        const listDepartamentoStorage = this.parametricosService.getDataKeyParametricosStorage('Departamento');
        if (listDepartamentoStorage !== undefined) {
            this.listDepartamentos = listDepartamentoStorage;
        }
        else {
            this.showLoading = true;
            this.parametricosService.getParametricosDefault('Departamento').subscribe((response) => {
                this.listDepartamentos = response.map(function (element) {
                    return { id: element.id, nombre: element.nombre };
                });
                // Consume servicio para añadir parametrico en el storage
                this.parametricosService.addParametricoSessionStorage('Departamento', this.listDepartamentos);
                setTimeout(() => { this.showLoading = false; }, 300);
            });
        }
    }
    /**
     * Función que invoca el servicio para consultar al API el listado de preguntas de seguridad
     */
    getPreguntasSeguridad() {
        // Consulta si existen los parametricos de Preguntas de seguridad
        const listPreguntaSeguridadStorage = this.parametricosService.getDataKeyParametricosStorage('PreguntaSeguridad');
        if (listPreguntaSeguridadStorage !== undefined) {
            // Llena el listado de Preguntas de Seguridad con lo registrado en el storage
            this.listPreguntasSeguridad = listPreguntaSeguridadStorage;
        }
        else {
            this.showLoading = true;
            this.parametricosService.getParametricosDefault('PreguntaSeguridad').subscribe((response) => {
                this.listPreguntasSeguridad = response.map(function (element) {
                    return { id: element.id, nombre: element.nombre };
                });
                // Consume servicio para añadir parametrico en el storage
                this.parametricosService.addParametricoSessionStorage('PreguntaSeguridad', this.listPreguntasSeguridad);
                setTimeout(() => { this.showLoading = false; }, 300);
            });
        }
    }
    /**
     * Función que invoca el servicio para consultar al API el listado de prestadores de preferencia
     */
    getPrestadores(pais) {
        const paisColombia = this.listPaises.find(element => element.nombre.toLocaleLowerCase() == 'colombia');
        // Consulta si existen los parametricos de Prestadores
        const listPrestadorStorage = this.prestadorService.getPrestadoresStorage;
        if (listPrestadorStorage.length !== 0) {
            // Llena el listado de Prestadores con lo registrado en el storage pero según el pais
            if (pais !== paisColombia.id) {
                this.listPrestadoresPreferencia = listPrestadorStorage.filter(prest => prest.coberturaNacional === true);
            }
        }
        else {
            this.showLoading = true;
            this.prestadorService.getPrestadoresByDepto(0).subscribe((response) => {
                // Carga los prestadores pero según el pais
                if (pais !== paisColombia.id) {
                    this.listPrestadoresPreferencia = response.filter(prest => prest.coberturaNacional === true);
                }
                // Consume servicio para añadir parametrico en el storage
                this.prestadorService.setPrestadoresStorage(response);
                setTimeout(() => { this.showLoading = false; }, 1000);
            });
        }
    }
    /**
     * Función que invoca el servicio para consultar al API o storage el listado de puntos de atencion
     */
    getPuntosAtencion() {
        // Consulta si existen los parametricos de Puntos de atencion
        const listPuntoAtencionStorage = this.prestadorService.getPuntosAtencionStorage;
        if (listPuntoAtencionStorage.length === 0) {
            this.showLoading = true;
            this.prestadorService.getPuntosAtencionByPrestador('00000000-0000-0000-0000-000000000000').subscribe((response) => {
                const responsePuntosAtencion = response;
                // Consume servicio para añadir parametrico en el storage
                this.prestadorService.setPuntosAtencionStorage(responsePuntosAtencion);
                setTimeout(() => { this.showLoading = false; }, 1000);
            });
        }
    }
    /**
     * Función que invoca el servicio para consultar al API o storage el listado de Municipios
     */
    getMunicipios() {
        // Consulta si existen los parametricos de Municipios
        const listMunicipioStorage = this.parametricosService.getDataKeyParametricosStorage('Municipio');
        if (listMunicipioStorage === undefined) {
            this.showLoading = true;
            this.parametricosService.getParametricoById('Municipio', 'departamentoID', '0').subscribe((response) => {
                const responseMunicipios = response.map(function (element) {
                    return { id: element.id, nombre: element.nombre, departamentoId: element.departamentoId };
                });
                // Consume servicio para añadir parametrico en el storage
                this.parametricosService.addParametricoSessionStorage('Municipio', responseMunicipios);
                this.showLoading = false;
                setTimeout(() => { this.showLoading = false; }, 1000);
            });
        }
    }
    /**
     * Función que controla el evento de cambio sobre el campo pais para realizar algunas validaciones
     * @param e event
     */
    changePais(e) {
        const paisSeleccionado = this.listPaises.find(element => element.id == e.target.value);
        this.f['departamentoId'].clearValidators();
        this.f['municipioId'].clearValidators();
        this.f['telefono'].clearValidators();
        // Valida el pais seleccionado
        // Si es Colombia entonces muestra los campos departamento y municipio (deben ser requeridos)
        if (paisSeleccionado.nombre.toLocaleLowerCase() == 'colombia') {
            this.f['departamentoId'].addValidators(_angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required);
            this.f['municipioId'].addValidators(_angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required);
            this.f['telefono'].addValidators([_angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.minLength(10), _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.maxLength(10), this.validateTelefono.bind(this)]);
            this.countMinDigit = 10; // Setea la cantidad de dígitos mínimos para el campo telefono en caso de ser Colombia
            this.showDepartamento = true;
            this.showMunicipio = true;
        }
        else {
            this.f['departamentoId'].setValue('');
            this.f['municipioId'].setValue('');
            this.f['telefono'].addValidators([_angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.minLength(7), _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.maxLength(10), this.validateTelefono.bind(this)]);
            this.countMinDigit = 7; // Setea la cantidad de dígitos mínimos para el campo telefono
            this.showDepartamento = false;
            this.showMunicipio = false;
            // Al no existir departamento entonces filtra el listado de prestadores con respecto a cobertura nacional
            const listPrestadorStorage = this.prestadorService.getPrestadoresStorage;
            this.listPrestadoresPreferencia = listPrestadorStorage.filter(prest => prest.coberturaNacional === true);
        }
        this.f['departamentoId'].updateValueAndValidity();
        this.f['municipioId'].updateValueAndValidity();
        this.f['telefono'].updateValueAndValidity();
    }
    /**
     * Función que controla el evento de cambio sobre el campo departamento y lanza la petición para consultar los municipios
     * @param e event
     */
    changeDepartamento(e) {
        this.showLoading = true;
        const depto = e == null ? this.f['departamentoId'].value : e.target.value;
        // Filtra el listado de municipios con respecto al departamento
        const listMunicipioStorage = this.parametricosService.getDataKeyParametricosStorage('Municipio');
        this.listMunicipios = listMunicipioStorage.filter(muni => muni.departamentoId == depto);
        // Filtra el listado de prestadores con respecto al departamento
        const listPrestadorStorage = this.prestadorService.getPrestadoresStorage;
        this.listPrestadoresPreferencia = listPrestadorStorage.filter(prest => prest.departamentoId == depto);
        this.showLoading = false;
        // Vacia value de municipio y prestador solo si no es change del campo
        if (e !== null) {
            this.f['municipioId'].setValue('');
            this.f['municipioId'].updateValueAndValidity();
            this.f['prestadorPreferenciaId'].setValue('');
            this.f['prestadorPreferenciaId'].updateValueAndValidity();
        }
    }
    /**
     * Función que controla el evento de cambio sobre el campo prestador de preferencia y lanza la petición para consultar los puntos de atención relacionados
     * @param e event
     */
    changePrestador(e) {
        this.showLoading = true;
        const prestador = e == null ? this.f['prestadorPreferenciaId'].value : e.target.value;
        // Filtra el listado de puntos de atencion con respecto al prestador de preferencia
        const listPuntoAtencionStorage = this.prestadorService.getPuntosAtencionStorage;
        this.listPuntosAtencion = listPuntoAtencionStorage.filter(punto => punto.prestadorId == prestador);
        this.showLoading = false;
        // Vacia value de puntos de atencion solo si no viene de cambiar el prestador
        if (e !== null) {
            this.f['puntoAtencionId'].setValue('');
            this.f['puntoAtencionId'].updateValueAndValidity();
        }
    }
    isWeekend(date) {
        const d = new Date(date.year, date.month - 1, date.day);
        return d.getDay() === 0 || d.getDay() === 6;
    }
    isDisabled(date, current) {
        return date.month !== current.month;
    }
    /**
     * Función del submit del formulario continuar con el proceso al siguiente paso
     */
    saveAction() {
        this.submitted = true;
        // Valida si el formuario ya contiene los campos requeridos
        if (this.basicDataForm.valid) {
            this.basicDataForm.disable();
            let formDataSend = this.basicDataForm.value;
            // Debe ir al siguiente paso
            setTimeout(() => {
                this.showLoading = false;
                this.registerService.putRegisterData(this.basicDataForm.value, 'register');
                this.registerService.changeShowAddNotifications();
            }, 1000);
        }
        else {
            const modalRef = this.modalService.open(_modal_validation_modal_validation_component__WEBPACK_IMPORTED_MODULE_2__.ModalValidationComponent).result.then((result) => { });
        }
    }
    // Getter para fácil acceso a los controles de formulario
    get f() {
        return this.basicDataForm.controls;
    }
    // Funciones getter para validaciones de la contraseña
    get passwordValid() {
        return this.basicDataForm.controls["password"].errors === null;
    }
    get requiredValid() {
        return !this.basicDataForm.controls["password"].hasError("required");
    }
    get minLengthValid() {
        return !this.basicDataForm.controls["password"].hasError("minlength");
    }
    get maxLengthValid() {
        return !this.basicDataForm.controls["password"].hasError("maxlength");
    }
    get requiresDigitValid() {
        return !this.basicDataForm.controls["password"].hasError("requiresDigit");
    }
    get requiresUppercaseValid() {
        return !this.basicDataForm.controls["password"].hasError("requiresUppercase");
    }
    get requiresLowercaseValid() {
        return !this.basicDataForm.controls["password"].hasError("requiresLowercase");
    }
    get requiresSpecialCharsValid() {
        return !this.basicDataForm.controls["password"].hasError("requiresSpecialChars");
    }
    /**
     * Función que se encarga de hacer el toggle de show de un campo tipo password
     * @param controlP string que identifica el control o campo de contraseña
     */
    toggleShowPassword(controlP) {
        if (controlP == 'password') {
            this.showPassword = !this.showPassword;
        }
        if (controlP == 'confirmPassword') {
            this.showPasswordConfirm = !this.showPasswordConfirm;
        }
    }
    validateOnlyNumberInput(evt) {
        const code = (evt.which) ? evt.which : evt.keyCode;
        const number = evt.target.value;
        let out = '';
        const filtro = '1234567890'; //Caracteres validos
        if (code != 8) { // backspace.
            //Recorrer el texto y verificar si el caracter se encuentra en la lista de validos
            for (var i = 0; i < number.length; i++) {
                if (filtro.indexOf(number.charAt(i)) != -1) {
                    //Se añaden a la salida los caracteres validos
                    out += number.charAt(i);
                }
            }
            this.f['telefono'].setValue(out);
        }
    }
    /**
     * Función que valida sobre un input (control) que sólo sean letras
     */
    validateOnlyLetters(evt, control) {
        var regex = new RegExp("^[a-zA-Z ]+$");
        if (!regex.test(evt.target.value)) {
            this.f[control].setValue(evt.target.value.substr(0, evt.target.value.length - 1));
        }
    }
    /**
     * Función que realiza algunas validaciones custom sobre el campo telefono
     * Si el país de residencia seleccionado es colombia:
     * - El primer número digitado debe ser 6 o 3.
     * - Siempre de 10 digitos
     * Si el país de residencia es diferente a Colombia no se restringe el ingreso.
     * - Solo restringir a mínimo 7 y máximo 10 digitos
     */
    validateTelefono(control) {
        if (control.value !== null) {
            const pais = this.f['paisResidenciaId'].value;
            // Valida si el campo pais tiene algún valor y el listado de paises está lleno
            if (pais != null && this.listPaises.length > 0) {
                const paisSeleccionado = this.listPaises.find(element => element.id == pais);
                const firstDigit = control.value.substr(0, 1);
                if (paisSeleccionado.nombre.toLocaleLowerCase() == 'colombia' && firstDigit != '6' && firstDigit != '3') {
                    return { firstDigit: true };
                }
            }
        }
        return null;
    }
    get telefonoRequired() {
        return this.f['telefono'].hasError("required");
    }
    get telefonoMinLength() {
        return this.f['telefono'].hasError("minlength");
    }
    get telefonoMaxLength() {
        return this.f['telefono'].hasError("maxlength");
    }
    get firstDigitValid() {
        return this.f['telefono'].hasError("firstDigit");
    }
    toggleCheckbox(e, control) {
        if (!e.target.checked) {
            this.f[control].setValue('');
        }
    }
    /**
     * Función que restringe el pegado de información en el campo Confrimacion contraseña
     */
    onPasteConfirmPassword(event) {
        event.preventDefault();
    }
    /**
     * Función que controla el evento lost focus del campo contraseña para validar el de confirmar contraseña
     */
    lostFocusValidateConfirmPassword(event) {
        this.f['confirmPassword'].updateValueAndValidity();
    }
}
BasicDataComponent.ɵfac = function BasicDataComponent_Factory(t) { return new (t || BasicDataComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵdirectiveInject"](_angular_forms__WEBPACK_IMPORTED_MODULE_9__.FormBuilder), _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵdirectiveInject"](_services_parametricos_service__WEBPACK_IMPORTED_MODULE_4__.ParametricosService), _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵdirectiveInject"](_services_ciudadano_service__WEBPACK_IMPORTED_MODULE_5__.CiudadanoService), _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵdirectiveInject"](_services_register_service__WEBPACK_IMPORTED_MODULE_6__.RegisterService), _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵdirectiveInject"](_services_prestador_service__WEBPACK_IMPORTED_MODULE_7__.PrestadorService), _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵdirectiveInject"](_ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_10__.NgbModal)); };
BasicDataComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵdefineComponent"]({ type: BasicDataComponent, selectors: [["app-basic-data"]], features: [_angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵProvidersFeature"]([_services_custom_datepicker_i18n_service__WEBPACK_IMPORTED_MODULE_1__.I18n, { provide: _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_10__.NgbDatepickerI18n, useClass: _services_custom_datepicker_i18n_service__WEBPACK_IMPORTED_MODULE_1__.CustomDatepickerI18nService }])], decls: 190, vars: 133, consts: [["novalidate", "", "autocomplete", "off", 3, "formGroup", "ngSubmit"], ["class", "clearfix cargando", 4, "ngIf"], [1, "row"], [1, "col-md-6", "mb-2"], ["class", "text-danger", 4, "ngIf"], [1, "form-group-no-border"], ["placeholder", "", "formControlName", "tipoDocumentoId", 1, "form-select", 3, "ngClass"], [3, "value", 4, "ngFor", "ngForOf"], ["class", "invalid-feedback", 4, "ngIf"], [1, "form-group"], ["type", "text", "placeholder", "", "formControlName", "numeroDocumento", 1, "form-control", 3, "ngClass"], [1, "col-md-12", "mb-2"], ["type", "email", "placeholder", "", "formControlName", "correoElectronico", 1, "form-control", 3, "ngClass"], [1, "border-dark", "mt-2", 2, "border-style", "dotted"], [1, "input-group"], ["placeholder", "", "formControlName", "password", 1, "form-control", 3, "type", "ngClass", "focusout"], [1, "input-group-append"], ["role", "button", 1, "glyphicon", "glyphicon-info", "input-group-text", 2, "height", "100%", 3, "click"], ["aria-hidden", "true"], ["placeholder", "", "formControlName", "confirmPassword", 1, "form-control", 3, "type", "ngClass", "paste"], ["type", "text", "placeholder", "", "formControlName", "primerNombre", 1, "form-control", 3, "ngClass", "keyup"], ["type", "text", "placeholder", "", "formControlName", "segundoNombre", 1, "form-control", 3, "ngClass", "keyup"], ["type", "text", "placeholder", "", "formControlName", "primerApellido", 1, "form-control", 3, "ngClass", "keyup"], ["type", "text", "placeholder", "", "formControlName", "segundoApellido", 1, "form-control", 3, "ngClass", "keyup"], [1, "input-group", "date"], ["placeholder", "dd/mm/yyyy", "formControlName", "fechaNacimiento", "ngbDatepicker", "", 1, "form-control", 3, "ngModel", "minDate", "maxDate", "ngClass", "ngModelChange", "click"], ["d", "ngbDatepicker"], ["role", "button", 1, "input-group-append", 3, "click"], [1, "glyphicon", "glyphicon-calendar", "input-group-text", 2, "height", "100%"], ["aria-hidden", "true", 1, "fa", "fa-calendar"], ["placeholder", "", "formControlName", "generoId", 1, "form-select", 3, "ngClass"], ["type", "text", "placeholder", "", "formControlName", "direccionResidencia", 1, "form-control", 3, "ngClass"], ["placeholder", "", "formControlName", "paisResidenciaId", 1, "form-select", 3, "ngClass", "change"], ["class", "col-md-6 mb-2", 4, "ngIf"], ["type", "text", "placeholder", "", "formControlName", "telefono", 1, "form-control", 3, "ngClass", "keyup"], ["placeholder", "", "formControlName", "prestadorPreferenciaId", 1, "form-select", 3, "ngClass", "change"], ["role", "button", "placement", "right", "ngbPopover", "Seg\u00FAn la sentencia 473 del 2019 si no ha cotizado al menos un a\u00F1o en caja de compensaci\u00F3n familiar dentro de los \u00FAltimos 3 a\u00F1os, sus servicios con la caja de compensaci\u00F3n podr\u00EDan estar limitados", "popoverTitle", "Informaci\u00F3n", 1, "glyphicon", "glyphicon-info", "input-group-text", 2, "height", "100%"], ["aria-hidden", "true", 1, "fa", "fa-info", "text-danger"], ["placeholder", "", "formControlName", "puntoAtencionId", 1, "form-select", 3, "ngClass"], [1, "navbar", "navbar-expand-lg", "head-navigation", "mt-4", "mb-2"], [1, "container"], [1, "navbar-brand"], ["placeholder", "", "formControlName", "preguntaSeguridadId", 1, "form-select", 3, "ngClass"], ["type", "text", "placeholder", "", "formControlName", "preguntaSeguridadRespuesta", 1, "form-control", 3, "ngClass"], [1, "container-fluid"], ["href", "../../../../assets/docs/T\u00C9RMINOS Y CONDICIONES 201601_V_1.0-POTENCIAL_EMPLEADOR.pdf", "target", "_blank", 1, "btn", "d-flex", "pt-0", "pb-0", "ps-0", "pe-0"], [1, "text-light", 2, "font-size", "22px", 3, "icon"], [1, "form-check", "form-switch"], [1, "form-check-label"], ["type", "checkbox", "value", "1", "formControlName", "terminosCondiciones", 1, "form-check-input", 3, "change"], [1, "form-check-sign"], ["type", "checkbox", "value", "1", "formControlName", "tratamientoDatosPersonales", 1, "form-check-input", 3, "change"], [1, "col-3", "ms-auto"], ["type", "submit", 1, "btn", "btn-primary-form"], [1, "clearfix", "cargando"], ["role", "status", 1, "spinner-border", "float-end"], [1, "visually-hidden"], [1, "text-danger"], [3, "value"], [1, "invalid-feedback"], ["class", "mt-3", 4, "ngIf"], [1, "mt-3"], [3, "ngClass"], [4, "ngIf"], ["placeholder", "", "formControlName", "departamentoId", 1, "form-select", 3, "ngClass", "change"], ["placeholder", "", "formControlName", "municipioId", 1, "form-select", 3, "ngClass"]], template: function BasicDataComponent_Template(rf, ctx) { if (rf & 1) {
        const _r75 = _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵgetCurrentView"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](0, "form", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵlistener"]("ngSubmit", function BasicDataComponent_Template_form_ngSubmit_0_listener() { return ctx.saveAction(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](1, BasicDataComponent_div_1_Template, 4, 0, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](2, "div", 2)(3, "div", 3)(4, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](5, BasicDataComponent_span_5_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](6, " Tipo de documento ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](7, "div", 5)(8, "select", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](9, BasicDataComponent_option_9_Template, 2, 2, "option", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](10, BasicDataComponent_div_10_Template, 2, 0, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](11, "div", 3)(12, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](13, BasicDataComponent_span_13_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](14, " N\u00FAmero de documento ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](15, "div", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelement"](16, "input", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](17, BasicDataComponent_div_17_Template, 2, 0, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](18, "div", 11)(19, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](20, BasicDataComponent_span_20_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](21, " Correo electr\u00F3nico ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](22, "div", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelement"](23, "input", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](24, BasicDataComponent_div_24_Template, 2, 0, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelement"](25, "hr", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](26, "div", 3)(27, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](28, BasicDataComponent_span_28_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](29, " Contrase\u00F1a ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](30, "div", 5)(31, "div", 14)(32, "input", 15);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵlistener"]("focusout", function BasicDataComponent_Template_input_focusout_32_listener($event) { return ctx.lostFocusValidateConfirmPassword($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](33, "div", 16)(34, "span", 17);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵlistener"]("click", function BasicDataComponent_Template_span_click_34_listener() { return ctx.toggleShowPassword("password"); });
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelement"](35, "i", 18);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](36, BasicDataComponent_div_36_Template, 3, 2, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](37, "div", 3)(38, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](39, BasicDataComponent_span_39_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](40, " Confirmar contrase\u00F1a ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](41, "div", 5)(42, "div", 14)(43, "input", 19);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵlistener"]("paste", function BasicDataComponent_Template_input_paste_43_listener($event) { return ctx.onPasteConfirmPassword($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](44, "div", 16)(45, "span", 17);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵlistener"]("click", function BasicDataComponent_Template_span_click_45_listener() { return ctx.toggleShowPassword("confirmPassword"); });
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelement"](46, "i", 18);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](47, BasicDataComponent_div_47_Template, 4, 3, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](48, "div", 3)(49, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](50, BasicDataComponent_span_50_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](51, " Primer nombre ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](52, "div", 9)(53, "input", 20);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵlistener"]("keyup", function BasicDataComponent_Template_input_keyup_53_listener($event) { return ctx.validateOnlyLetters($event, "primerNombre"); });
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](54, BasicDataComponent_div_54_Template, 2, 0, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](55, "div", 3)(56, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](57, BasicDataComponent_span_57_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](58, " Segundo nombre ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](59, "div", 9)(60, "input", 21);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵlistener"]("keyup", function BasicDataComponent_Template_input_keyup_60_listener($event) { return ctx.validateOnlyLetters($event, "segundoNombre"); });
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](61, BasicDataComponent_div_61_Template, 2, 0, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](62, "div", 3)(63, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](64, BasicDataComponent_span_64_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](65, " Primer apellido ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](66, "div", 9)(67, "input", 22);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵlistener"]("keyup", function BasicDataComponent_Template_input_keyup_67_listener($event) { return ctx.validateOnlyLetters($event, "primerApellido"); });
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](68, BasicDataComponent_div_68_Template, 2, 0, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](69, "div", 3)(70, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](71, BasicDataComponent_span_71_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](72, " Segundo apellido ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](73, "div", 9)(74, "input", 23);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵlistener"]("keyup", function BasicDataComponent_Template_input_keyup_74_listener($event) { return ctx.validateOnlyLetters($event, "segundoApellido"); });
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](75, BasicDataComponent_div_75_Template, 2, 0, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](76, "div", 3)(77, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](78, BasicDataComponent_span_78_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](79, " Fecha de nacimiento ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](80, "div", 9)(81, "div", 24)(82, "input", 25, 26);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵlistener"]("ngModelChange", function BasicDataComponent_Template_input_ngModelChange_82_listener($event) { return ctx.model = $event; })("click", function BasicDataComponent_Template_input_click_82_listener() { _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵrestoreView"](_r75); const _r21 = _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵreference"](83); return _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵresetView"](_r21.toggle()); });
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](84, "div", 27);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵlistener"]("click", function BasicDataComponent_Template_div_click_84_listener() { _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵrestoreView"](_r75); const _r21 = _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵreference"](83); return _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵresetView"](_r21.toggle()); });
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](85, "span", 28);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelement"](86, "i", 29);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](87, BasicDataComponent_div_87_Template, 2, 0, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](88, "div", 3)(89, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](90, BasicDataComponent_span_90_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](91, " G\u00E9nero ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](92, "div", 9)(93, "select", 30);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](94, BasicDataComponent_option_94_Template, 2, 2, "option", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](95, BasicDataComponent_div_95_Template, 2, 0, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](96, "div", 3)(97, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](98, BasicDataComponent_span_98_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](99, " Direcci\u00F3n de residencia ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](100, "div", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelement"](101, "input", 31);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](102, BasicDataComponent_div_102_Template, 2, 0, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](103, "div", 3)(104, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](105, BasicDataComponent_span_105_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](106, " Pa\u00EDs de residencia ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](107, "div", 9)(108, "select", 32);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵlistener"]("change", function BasicDataComponent_Template_select_change_108_listener($event) { return ctx.changePais($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](109, BasicDataComponent_option_109_Template, 2, 2, "option", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](110, BasicDataComponent_div_110_Template, 2, 0, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](111, BasicDataComponent_div_111_Template, 8, 7, "div", 33);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](112, BasicDataComponent_div_112_Template, 8, 7, "div", 33);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](113, "div", 3)(114, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](115, BasicDataComponent_span_115_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](116, " Tel\u00E9fono ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](117, "div", 9)(118, "input", 34);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵlistener"]("keyup", function BasicDataComponent_Template_input_keyup_118_listener($event) { return ctx.validateOnlyNumberInput($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](119, BasicDataComponent_div_119_Template, 5, 4, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](120, "div", 3)(121, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](122, BasicDataComponent_span_122_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](123, " Prestador de preferencia ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](124, "div", 9)(125, "div", 14)(126, "select", 35);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵlistener"]("change", function BasicDataComponent_Template_select_change_126_listener($event) { return ctx.changePrestador($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](127, BasicDataComponent_option_127_Template, 2, 2, "option", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](128, "div", 16)(129, "span", 36);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelement"](130, "i", 37);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](131, BasicDataComponent_div_131_Template, 2, 0, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](132, "div", 3)(133, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](134, BasicDataComponent_span_134_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](135, " Punto de atenci\u00F3n ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](136, "div", 9)(137, "select", 38);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](138, BasicDataComponent_option_138_Template, 2, 2, "option", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](139, BasicDataComponent_div_139_Template, 2, 0, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](140, "nav", 39)(141, "div", 40)(142, "span", 41);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](143, "En caso de olvidar usuario o contrase\u00F1a");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](144, "div", 3)(145, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](146, BasicDataComponent_span_146_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](147, " Pregunta de seguridad ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](148, "div", 9)(149, "select", 42);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](150, BasicDataComponent_option_150_Template, 2, 2, "option", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](151, BasicDataComponent_div_151_Template, 2, 0, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](152, "div", 3)(153, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](154, BasicDataComponent_span_154_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](155, " Respuesta ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](156, "div", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelement"](157, "input", 43);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](158, BasicDataComponent_div_158_Template, 2, 0, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](159, "nav", 39)(160, "div", 44)(161, "span", 41);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](162, "T\u00E9rminos y condiciones");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](163, "a", 45);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelement"](164, "fa-icon", 46);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](165, "div", 11)(166, "div", 47)(167, "label", 48)(168, "input", 49);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵlistener"]("change", function BasicDataComponent_Template_input_change_168_listener($event) { return ctx.toggleCheckbox($event, "terminosCondiciones"); });
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](169, BasicDataComponent_span_169_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](170, " Al crear una cuenta aceptas nuestros t\u00E9rminos y condiciones ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelement"](171, "span", 50);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](172, BasicDataComponent_div_172_Template, 2, 0, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](173, "nav", 39)(174, "div", 40)(175, "span", 41);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](176, "Tratamiento de datos");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](177, "div", 11)(178, "div", 47)(179, "label", 48)(180, "input", 51);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵlistener"]("change", function BasicDataComponent_Template_input_change_180_listener($event) { return ctx.toggleCheckbox($event, "tratamientoDatosPersonales"); });
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](181, BasicDataComponent_span_181_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](182, " Acepto haber le\u00EDdo y conocer la pol\u00EDtica de tratamiento de datos personales ");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelement"](183, "span", 50);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtemplate"](184, BasicDataComponent_div_184_Template, 2, 0, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelement"](185, "br");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementStart"](186, "div", 2)(187, "div", 52)(188, "button", 53);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵtext"](189, "CONTINUAR");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵelementEnd"]()()()();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("formGroup", ctx.basicDataForm);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.showLoading);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["tipoDocumentoId"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](78, _c1, (ctx.f["tipoDocumentoId"].dirty || ctx.submitted) && !ctx.f["tipoDocumentoId"].errors, (ctx.f["tipoDocumentoId"].dirty || ctx.submitted) && ctx.f["tipoDocumentoId"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngForOf", ctx.listTipoDocumento);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["tipoDocumentoId"].dirty || ctx.submitted) && ctx.f["tipoDocumentoId"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["numeroDocumento"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](81, _c1, (ctx.f["numeroDocumento"].dirty || ctx.submitted) && !ctx.f["numeroDocumento"].errors, (ctx.f["numeroDocumento"].dirty || ctx.submitted) && ctx.f["numeroDocumento"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["numeroDocumento"].dirty || ctx.submitted) && ctx.f["numeroDocumento"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["correoElectronico"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](84, _c1, (ctx.f["correoElectronico"].dirty || ctx.submitted) && !ctx.f["correoElectronico"].errors, (ctx.f["correoElectronico"].dirty || ctx.submitted) && ctx.f["correoElectronico"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["correoElectronico"].dirty || ctx.submitted) && ctx.f["correoElectronico"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["password"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("type", ctx.showPassword ? "text" : "password")("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](87, _c1, (ctx.f["password"].dirty || ctx.submitted) && !ctx.f["password"].errors, (ctx.f["password"].dirty || ctx.submitted) && ctx.f["password"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵclassMap"](ctx.showPassword ? "fa fa-eye-slash" : "fa fa-eye");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["password"].dirty || ctx.submitted) && ctx.f["password"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["confirmPassword"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("type", ctx.showPasswordConfirm ? "text" : "password")("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](90, _c1, (ctx.f["confirmPassword"].dirty || ctx.submitted) && !ctx.f["confirmPassword"].errors, (ctx.f["confirmPassword"].dirty || ctx.submitted) && ctx.f["confirmPassword"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵclassMap"](ctx.showPasswordConfirm ? "fa fa-eye-slash" : "fa fa-eye");
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["confirmPassword"].dirty || ctx.submitted) && ctx.f["confirmPassword"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["primerNombre"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](93, _c1, (ctx.f["primerNombre"].dirty || ctx.submitted) && !ctx.f["primerNombre"].errors, (ctx.f["primerNombre"].dirty || ctx.submitted) && ctx.f["primerNombre"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["primerNombre"].dirty || ctx.submitted) && ctx.f["primerNombre"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["segundoNombre"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](96, _c1, (ctx.f["segundoNombre"].dirty || ctx.submitted) && !ctx.f["segundoNombre"].errors, (ctx.f["segundoNombre"].dirty || ctx.submitted) && ctx.f["segundoNombre"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["segundoNombre"].dirty || ctx.submitted) && ctx.f["segundoNombre"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["primerApellido"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](99, _c1, (ctx.f["primerApellido"].dirty || ctx.submitted) && !ctx.f["primerApellido"].errors, (ctx.f["primerApellido"].dirty || ctx.submitted) && ctx.f["primerApellido"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["primerApellido"].dirty || ctx.submitted) && ctx.f["primerApellido"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["segundoApellido"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](102, _c1, (ctx.f["segundoApellido"].dirty || ctx.submitted) && !ctx.f["segundoApellido"].errors, (ctx.f["segundoApellido"].dirty || ctx.submitted) && ctx.f["segundoApellido"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["segundoApellido"].dirty || ctx.submitted) && ctx.f["segundoApellido"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["fechaNacimiento"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngModel", ctx.model)("minDate", ctx.minDate)("maxDate", ctx.maxDate)("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](105, _c1, (ctx.f["fechaNacimiento"].dirty || ctx.submitted) && !ctx.f["fechaNacimiento"].errors, (ctx.f["fechaNacimiento"].dirty || ctx.submitted) && ctx.f["fechaNacimiento"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](5);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["fechaNacimiento"].dirty || ctx.submitted) && ctx.f["fechaNacimiento"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["generoId"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](108, _c1, (ctx.f["generoId"].dirty || ctx.submitted) && !ctx.f["generoId"].errors, (ctx.f["generoId"].dirty || ctx.submitted) && ctx.f["generoId"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngForOf", ctx.listGeneros);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["generoId"].dirty || ctx.submitted) && ctx.f["generoId"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["direccionResidencia"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](111, _c1, (ctx.f["direccionResidencia"].dirty || ctx.submitted) && !ctx.f["direccionResidencia"].errors, (ctx.f["direccionResidencia"].dirty || ctx.submitted) && ctx.f["direccionResidencia"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["direccionResidencia"].dirty || ctx.submitted) && ctx.f["direccionResidencia"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["paisResidenciaId"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](114, _c1, (ctx.f["paisResidenciaId"].dirty || ctx.submitted) && !ctx.f["paisResidenciaId"].errors, (ctx.f["paisResidenciaId"].dirty || ctx.submitted) && ctx.f["paisResidenciaId"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngForOf", ctx.listPaises);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["paisResidenciaId"].dirty || ctx.submitted) && ctx.f["paisResidenciaId"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.showDepartamento);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.showMunicipio);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["telefono"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](117, _c1, (ctx.f["telefono"].dirty || ctx.submitted) && !ctx.f["telefono"].errors, (ctx.f["telefono"].dirty || ctx.submitted) && ctx.f["telefono"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["telefono"].dirty || ctx.submitted) && ctx.f["telefono"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["prestadorPreferenciaId"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](120, _c1, (ctx.f["prestadorPreferenciaId"].dirty || ctx.submitted) && !ctx.f["prestadorPreferenciaId"].errors, (ctx.f["prestadorPreferenciaId"].dirty || ctx.submitted) && ctx.f["prestadorPreferenciaId"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngForOf", ctx.listPrestadoresPreferencia);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["prestadorPreferenciaId"].dirty || ctx.submitted) && ctx.f["prestadorPreferenciaId"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["puntoAtencionId"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](123, _c1, (ctx.f["puntoAtencionId"].dirty || ctx.submitted) && !ctx.f["puntoAtencionId"].errors, (ctx.f["puntoAtencionId"].dirty || ctx.submitted) && ctx.f["puntoAtencionId"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngForOf", ctx.listPuntosAtencion);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["puntoAtencionId"].dirty || ctx.submitted) && ctx.f["puntoAtencionId"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](7);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["preguntaSeguridadId"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](126, _c1, (ctx.f["preguntaSeguridadId"].dirty || ctx.submitted) && !ctx.f["preguntaSeguridadId"].errors, (ctx.f["preguntaSeguridadId"].dirty || ctx.submitted) && ctx.f["preguntaSeguridadId"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngForOf", ctx.listPreguntasSeguridad);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["preguntaSeguridadId"].dirty || ctx.submitted) && ctx.f["preguntaSeguridadId"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["preguntaSeguridadRespuesta"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction2"](129, _c1, (ctx.f["preguntaSeguridadRespuesta"].dirty || ctx.submitted) && !ctx.f["preguntaSeguridadRespuesta"].errors, (ctx.f["preguntaSeguridadRespuesta"].dirty || ctx.submitted) && ctx.f["preguntaSeguridadRespuesta"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["preguntaSeguridadRespuesta"].dirty || ctx.submitted) && ctx.f["preguntaSeguridadRespuesta"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](6);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("icon", _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵpureFunction0"](132, _c2));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](5);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["terminosCondiciones"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["terminosCondiciones"].dirty || ctx.submitted) && ctx.f["terminosCondiciones"].invalid);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](9);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", ctx.f["tratamientoDatosPersonales"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵproperty"]("ngIf", (ctx.f["tratamientoDatosPersonales"].dirty || ctx.submitted) && ctx.f["tratamientoDatosPersonales"].errors);
    } }, dependencies: [_angular_common__WEBPACK_IMPORTED_MODULE_11__.NgClass, _angular_common__WEBPACK_IMPORTED_MODULE_11__.NgForOf, _angular_common__WEBPACK_IMPORTED_MODULE_11__.NgIf, _fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_12__.FaIconComponent, _angular_forms__WEBPACK_IMPORTED_MODULE_9__["ɵNgNoValidate"], _angular_forms__WEBPACK_IMPORTED_MODULE_9__.NgSelectOption, _angular_forms__WEBPACK_IMPORTED_MODULE_9__["ɵNgSelectMultipleOption"], _angular_forms__WEBPACK_IMPORTED_MODULE_9__.DefaultValueAccessor, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.CheckboxControlValueAccessor, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.SelectControlValueAccessor, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.NgControlStatus, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.NgControlStatusGroup, _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_10__.NgbInputDatepicker, _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_10__.NgbNavbar, _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_10__.NgbPopover, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.FormGroupDirective, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.FormControlName], styles: [".cargando[_ngcontent-%COMP%] {\n  position: absolute;\n  top: 0;\n  right: 0;\n}\n\n.invalid-feedback[_ngcontent-%COMP%] {\n  display: block;\n}\n\n.form-select[_ngcontent-%COMP%] {\n  cursor: pointer;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbImJhc2ljLWRhdGEuY29tcG9uZW50LmNzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtFQUNFLGtCQUFrQjtFQUNsQixNQUFNO0VBQ04sUUFBUTtBQUNWOztBQUVBO0VBQ0UsY0FBYztBQUNoQjs7QUFFQTtFQUNFLGVBQWU7QUFDakIiLCJmaWxlIjoiYmFzaWMtZGF0YS5jb21wb25lbnQuY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLmNhcmdhbmRvIHtcbiAgcG9zaXRpb246IGFic29sdXRlO1xuICB0b3A6IDA7XG4gIHJpZ2h0OiAwO1xufVxuXG4uaW52YWxpZC1mZWVkYmFjayB7XG4gIGRpc3BsYXk6IGJsb2NrO1xufVxuXG4uZm9ybS1zZWxlY3Qge1xuICBjdXJzb3I6IHBvaW50ZXI7XG59XG4iXX0= */"] });


/***/ }),

/***/ 6178:
/*!************************************************************************************!*\
  !*** ./src/app/components/register/modal-validation/modal-validation.component.ts ***!
  \************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "ModalValidationComponent": () => (/* binding */ ModalValidationComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ 4534);



class ModalValidationComponent {
    constructor(activeModal) {
        this.activeModal = activeModal;
    }
    ngOnInit() {
    }
}
ModalValidationComponent.ɵfac = function ModalValidationComponent_Factory(t) { return new (t || ModalValidationComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdirectiveInject"](_ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_1__.NgbActiveModal)); };
ModalValidationComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: ModalValidationComponent, selectors: [["app-modal-validation"]], decls: 9, vars: 0, consts: [[1, "modal-header"], [1, "modal-title", "text-center"], [1, "modal-body"], [1, "modal-footer"], ["type", "button", 1, "btn", "btn-danger", 3, "click"]], template: function ModalValidationComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div", 0)(1, "h5", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](2, "Notificaci\u00F3n");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](3, "div", 2)(4, "p");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](5, "Existen errores en la informaci\u00F3n ingresada. Por favor verifique y ajuste la informaci\u00F3n para continuar!!");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](6, "div", 3)(7, "button", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵlistener"]("click", function ModalValidationComponent_Template_button_click_7_listener() { return ctx.activeModal.close("close"); });
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](8, "Cerrar");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()();
    } }, styles: ["\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJtb2RhbC12YWxpZGF0aW9uLmNvbXBvbmVudC5jc3MifQ== */"] });


/***/ }),

/***/ 9581:
/*!**********************************************************************************************!*\
  !*** ./src/app/components/register/notifications/modal-response/modal-response.component.ts ***!
  \**********************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "ModalResponseComponent": () => (/* binding */ ModalResponseComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ 4534);



class ModalResponseComponent {
    constructor(activeModal) {
        this.activeModal = activeModal;
    }
    ngOnInit() {
    }
}
ModalResponseComponent.ɵfac = function ModalResponseComponent_Factory(t) { return new (t || ModalResponseComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdirectiveInject"](_ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_1__.NgbActiveModal)); };
ModalResponseComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: ModalResponseComponent, selectors: [["app-modal-response"]], decls: 9, vars: 0, consts: [[1, "modal-header"], [1, "modal-title", "text-center"], [1, "modal-body"], [1, "modal-footer"], ["type", "button", 1, "btn", "btn-success", 3, "click"]], template: function ModalResponseComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div", 0)(1, "h5", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](2, "Notificaci\u00F3n");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](3, "div", 2)(4, "p");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](5, "Se guard\u00F3 con \u00E9xito!!");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](6, "div", 3)(7, "button", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵlistener"]("click", function ModalResponseComponent_Template_button_click_7_listener() { return ctx.activeModal.close("close"); });
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](8, "Cerrar");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()();
    } }, styles: ["\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJtb2RhbC1yZXNwb25zZS5jb21wb25lbnQuY3NzIn0= */"] });


/***/ }),

/***/ 3151:
/*!******************************************************************************!*\
  !*** ./src/app/components/register/notifications/notifications.component.ts ***!
  \******************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "NgbdModalContent": () => (/* binding */ NgbdModalContent),
/* harmony export */   "NotificationsComponent": () => (/* binding */ NotificationsComponent)
/* harmony export */ });
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! @angular/forms */ 2508);
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../../../environments/environment */ 2340);
/* harmony import */ var _model_ciudadano__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../../model/ciudadano */ 5604);
/* harmony import */ var _modal_response_modal_response_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./modal-response/modal-response.component */ 9581);
/* harmony import */ var _modal_validation_modal_validation_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../modal-validation/modal-validation.component */ 6178);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ 4534);
/* harmony import */ var _services_parametricos_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../../services/parametricos.service */ 7192);
/* harmony import */ var _services_ciudadano_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../../../services/ciudadano.service */ 6295);
/* harmony import */ var _services_register_service__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../../../services/register.service */ 1032);
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! @angular/router */ 124);
/* harmony import */ var ngx_captcha__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ngx-captcha */ 7796);
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! @angular/common */ 4666);

















const _c0 = ["checkAll"];
const _c1 = ["captchaElem"];
function NotificationsComponent_div_1_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](0, "div", 12)(1, "div", 13)(2, "span", 14);
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtext"](3, "Loading...");
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]()()();
} }
function NotificationsComponent_div_4_Template(rf, ctx) { if (rf & 1) {
    const _r7 = _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵgetCurrentView"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](0, "div", 15)(1, "label")(2, "input", 16, 17);
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵlistener"]("change", function NotificationsComponent_div_4_Template_input_change_2_listener($event) { _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵrestoreView"](_r7); const ctx_r6 = _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵnextContext"](); return _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵresetView"](ctx_r6.onCheckboxChange($event)); });
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtext"](4, " Todos ");
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]()();
} if (rf & 2) {
    const ctx_r1 = _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵproperty"]("checked", ctx_r1.selectedAll);
} }
function NotificationsComponent_div_6_Template(rf, ctx) { if (rf & 1) {
    const _r10 = _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵgetCurrentView"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](0, "div", 15)(1, "label")(2, "input", 18);
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵlistener"]("change", function NotificationsComponent_div_6_Template_input_change_2_listener($event) { _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵrestoreView"](_r10); const ctx_r9 = _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵnextContext"](); return _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵresetView"](ctx_r9.onCheckboxChange($event)); });
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtext"](3);
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]()();
} if (rf & 2) {
    const medio_r8 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵproperty"]("value", medio_r8.id)("checked", medio_r8.checked);
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtextInterpolate1"](" ", medio_r8.nombre, " ");
} }
function NotificationsComponent_div_7_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](0, "div", 19);
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtext"](1, " * Medios de Notificaci\u00F3n requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]();
} }
class NgbdModalContent {
    constructor(activeModal) {
        this.activeModal = activeModal;
    }
}
NgbdModalContent.ɵfac = function NgbdModalContent_Factory(t) { return new (t || NgbdModalContent)(_angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdirectiveInject"](_ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_8__.NgbActiveModal)); };
NgbdModalContent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdefineComponent"]({ type: NgbdModalContent, selectors: [["app-modal-content"]], inputs: { name: "name" }, decls: 13, vars: 0, consts: [[1, "modal-header"], [1, "modal-title", "text-center"], [1, "modal-body"], [1, "modal-footer"], [1, "left-side"], ["type", "button", 1, "btn", "btn-success", 3, "click"], [1, "divider"], [1, "right-side"], ["type", "button", 1, "btn", "btn-danger", 3, "click"]], template: function NgbdModalContent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](0, "div", 0)(1, "h5", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtext"](2, "Registro de Buscador");
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](3, "div", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtext"](4, " \u00BF Seguro que desea registrar los datos en sistema? ");
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](5, "div", 3)(6, "div", 4)(7, "button", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵlistener"]("click", function NgbdModalContent_Template_button_click_7_listener() { return ctx.activeModal.close(true); });
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtext"](8, "ACEPTAR");
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelement"](9, "div", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](10, "div", 7)(11, "button", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵlistener"]("click", function NgbdModalContent_Template_button_click_11_listener() { return ctx.activeModal.close(false); });
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtext"](12, "CANCELAR");
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]()()();
    } }, encapsulation: 2 });
class NotificationsComponent {
    constructor(formBuilder, parametricosService, ciudadanoService, registerService, modalService, router, reCaptchaV3Service) {
        this.formBuilder = formBuilder;
        this.parametricosService = parametricosService;
        this.ciudadanoService = ciudadanoService;
        this.registerService = registerService;
        this.modalService = modalService;
        this.router = router;
        this.reCaptchaV3Service = reCaptchaV3Service;
        this.submitted = false;
        this.showLoading = false;
        this.showMsg = false;
        this.listMediosNotificacion = [];
        this.notificationsSelected = [];
        this.selectedAll = false;
        this.siteKey = _environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.recaptcha.siteKey;
        this.registerForm = this.formBuilder.group({
            tipoDocumentoId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            numeroDocumento: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            correoElectronico: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            password: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required]],
            confirmPassword: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required]],
            primerNombre: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            segundoNombre: [null],
            primerApellido: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            segundoApellido: [null],
            fechaNacimiento: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            generoId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            telefono: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            direccionResidencia: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            paisResidenciaId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            departamentoId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            municipioId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            prestadorPreferenciaId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            puntoAtencionId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            preguntaSeguridadId: [null],
            preguntaSeguridadRespuesta: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            terminosCondiciones: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            tratamientoDatosPersonales: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required],
            tipoNotificacion: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.Validators.required]
        });
    }
    ngOnInit() {
        window.scrollTo(0, 0); // Envia el scroll arriba pues llega de datos básicos que tiene arta información habia abajo
        // Convoca función para consultar los parametricos para el formulario
        this.getMediosNotificacion();
        // Valida si ya hay un proceso de registro creado
        const dataRegister = this.registerService.getRegisterData();
        if (dataRegister) {
            this.registerForm.patchValue(dataRegister);
        }
    }
    /**
     * Función que invoca el servicio para consultar al API los medios de notificacion
     */
    getMediosNotificacion() {
        this.showLoading = true;
        this.parametricosService.getParametricosDefault('TipoNotificacion').subscribe((response) => {
            this.listMediosNotificacion = response.map(function (element) {
                return { id: element.id, nombre: element.nombre, checked: false };
            });
            setTimeout(() => { this.showLoading = false; }, 500);
        });
    }
    /**
     * Función del submit del formulario para realizar el llamado al servicio y enviar a guardar el ciudadano
     */
    saveAction() {
        this.submitted = true;
        // Valida si el formuario ya contiene los campos requeridos
        if (this.registerForm.valid) {
            // Valida el captcha
            this.reCaptchaV3Service.execute(this.siteKey, 'registro', (token) => {
                console.log('Token reCaptcha registro: ', token);
                this.registerForm.disable();
                let formDataSend = this.registerForm.value;
                const fNacimiento = this.f['fechaNacimiento'].value;
                const telefono = this.f['telefono'].value;
                // Convierte a string el telefono
                formDataSend.telefono = telefono.toString();
                // Convierte a string la fecha de nacimiento
                formDataSend.fechaNacimiento = this.convertSringDate(fNacimiento);
                // Envia true o false en los terminos y tratamiento
                // formDataSend.terminosCondiciones = this.f['terminosCondiciones'].value === '1' ? true : false;
                // formDataSend.tratamientoDatosPersonales = this.f['tratamientoDatosPersonales'].value === '1' ? true : false;
                // Asegura que el tipo doc, tipo notificacion, genero y pregunta id sean numeros
                formDataSend.tipoDocumentoId = +this.f['tipoDocumentoId'].value;
                formDataSend.generoId = +this.f['generoId'].value;
                formDataSend.preguntaSeguridadId = +this.f['preguntaSeguridadId'].value;
                // Muestra un modal de confirmación
                const modalRef = this.modalService.open(NgbdModalContent).result.then((result) => {
                    if (result) {
                        this.showLoading = true;
                        this.ciudadanoService.saveDataCiudadano(formDataSend).subscribe((response) => {
                            console.log(response);
                            this.showLoading = false;
                            this.showMsg = true;
                            // Muestra modal para el guardado exitoso
                            const modalRef = this.modalService.open(_modal_response_modal_response_component__WEBPACK_IMPORTED_MODULE_2__.ModalResponseComponent).result.then((resulModal) => {
                                if (resulModal == 'close') {
                                    // Hace reset de la data en el servicio para luego redirigirle al login
                                    this.registerService.resetData();
                                    this.router.navigate(['/login']);
                                }
                            });
                        }, (error) => {
                            console.log(error);
                            this.showLoading = false;
                        });
                    }
                    else {
                        this.submitted = false;
                        this.registerForm.enable();
                    }
                }, (reason) => {
                    console.log(reason);
                });
            }, {
                useGlobalDomain: false
            }, (error) => console.log(error));
        }
        else {
            const modalRef = this.modalService.open(_modal_validation_modal_validation_component__WEBPACK_IMPORTED_MODULE_3__.ModalValidationComponent).result.then((result) => { });
        }
    }
    // Getter para fácil acceso a los controles de formulario
    get f() {
        return this.registerForm.controls;
    }
    convertSringDate(date) {
        const month = date.month < 10 ? '0' + date.month : date.month;
        const day = date.day < 10 ? '0' + date.day : date.day;
        return date.year + '-' + month + '-' + day;
    }
    /**
     * Función que controla el change de los check de tipos de notificación
     * Si selecciona check todos entoces marca todos los del listado
     */
    onCheckboxChange(e) {
        if (e.target.checked) {
            // Valida si marcó "todos"
            if (e.target.value == 'todos') {
                this.selectedAll = true;
                // Vacía el arreglo
                this.notificationsSelected = [];
                // Recorre el listado para ir agregando al arreglo
                for (const medio in this.listMediosNotificacion) {
                    if (Object.prototype.hasOwnProperty.call(this.listMediosNotificacion, medio)) {
                        const element = this.listMediosNotificacion[medio];
                        this.notificationsSelected.push(+element.id);
                        this.listMediosNotificacion[medio]['checked'] = true;
                    }
                }
            }
            else {
                const notificacionExistente = this.notificationsSelected.find(medio => medio === +e.target.value);
                // Si no marcó todos entonce es porque agrega normal al arreglo cada check, sólo si no existe antes en el arreglo
                if (!notificacionExistente) {
                    this.notificationsSelected.push(+e.target.value);
                    this.listMediosNotificacion[this.listMediosNotificacion.findIndex(medio => medio.id == e.target.value)]['checked'] = true;
                }
                // Valida si todos los check están seleccionados para entonces hacer checked en todos
                if (this.validaAllChecked) {
                    this.selectedAll = true;
                }
            }
        }
        else {
            this.selectedAll = false; // Desmarca el check de todos
            // Valida si Quitó el checked de 'todos'
            if (e.target.value == 'todos') {
                this.notificationsSelected = []; // Vacia completamente las notificaciones seleccionadas
                // Hace un map del arreglo para agregarle a todos el checked false
                this.listMediosNotificacion = this.listMediosNotificacion.map((medio) => {
                    medio.checked = false;
                    return medio;
                });
            }
            else {
                this.notificationsSelected.splice(this.notificationsSelected.findIndex(element => element == e.target.value), 1);
                this.listMediosNotificacion[this.listMediosNotificacion.findIndex(element => element.id == e.target.value)]['checked'] = false;
            }
        }
        // Agrega al formulario el listado seleccionado
        this.f['tipoNotificacion'].setValue(this.notificationsSelected);
    }
    get validaAllChecked() {
        const noSelected = this.listMediosNotificacion.find(e => e.checked == false);
        return noSelected == null;
    }
}
NotificationsComponent.ɵfac = function NotificationsComponent_Factory(t) { return new (t || NotificationsComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdirectiveInject"](_angular_forms__WEBPACK_IMPORTED_MODULE_9__.FormBuilder), _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdirectiveInject"](_services_parametricos_service__WEBPACK_IMPORTED_MODULE_4__.ParametricosService), _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdirectiveInject"](_services_ciudadano_service__WEBPACK_IMPORTED_MODULE_5__.CiudadanoService), _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdirectiveInject"](_services_register_service__WEBPACK_IMPORTED_MODULE_6__.RegisterService), _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdirectiveInject"](_ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_8__.NgbModal), _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdirectiveInject"](_angular_router__WEBPACK_IMPORTED_MODULE_10__.Router), _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdirectiveInject"](ngx_captcha__WEBPACK_IMPORTED_MODULE_11__.ReCaptchaV3Service)); };
NotificationsComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdefineComponent"]({ type: NotificationsComponent, selectors: [["app-notifications"]], viewQuery: function NotificationsComponent_Query(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵviewQuery"](_c0, 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵviewQuery"](_c1, 5);
    } if (rf & 2) {
        let _t;
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵqueryRefresh"](_t = _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵloadQuery"]()) && (ctx.checkAll = _t.first);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵqueryRefresh"](_t = _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵloadQuery"]()) && (ctx.captchaElem = _t.first);
    } }, decls: 15, vars: 6, consts: [["novalidate", "", "autocomplete", "off", 3, "formGroup", "ngSubmit"], ["class", "clearfix cargando", 4, "ngIf"], [1, "row"], [1, "col-md-12"], ["class", "form-check form-switch", 4, "ngIf"], [1, "border-dark", "mt-2", 2, "border-style", "dotted"], ["class", "form-check form-switch", 4, "ngFor", "ngForOf"], ["class", "invalid-feedback", 4, "ngIf"], [3, "siteKey"], ["captchaElem", ""], [1, "col-3", "ms-auto"], ["type", "submit", 1, "btn", "btn-primary-form"], [1, "clearfix", "cargando"], ["role", "status", 1, "spinner-border", "float-end"], [1, "visually-hidden"], [1, "form-check", "form-switch"], ["type", "checkbox", "value", "todos", 1, "form-check-input", 3, "checked", "change"], ["checkAll", ""], ["type", "checkbox", 1, "form-check-input", 3, "value", "checked", "change"], [1, "invalid-feedback"]], template: function NotificationsComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](0, "form", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵlistener"]("ngSubmit", function NotificationsComponent_Template_form_ngSubmit_0_listener() { return ctx.saveAction(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtemplate"](1, NotificationsComponent_div_1_Template, 4, 0, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](2, "div", 2)(3, "div", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtemplate"](4, NotificationsComponent_div_4_Template, 5, 1, "div", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelement"](5, "hr", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtemplate"](6, NotificationsComponent_div_6_Template, 4, 3, "div", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtemplate"](7, NotificationsComponent_div_7_Template, 2, 0, "div", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelement"](8, "br");
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](9, "div", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelement"](10, "ngx-invisible-recaptcha", 8, 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](12, "div", 10)(13, "button", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtext"](14, "CREAR CUENTA");
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]()()()();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵproperty"]("formGroup", ctx.registerForm);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵproperty"]("ngIf", ctx.showLoading);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵproperty"]("ngIf", ctx.listMediosNotificacion.length > 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵadvance"](2);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵproperty"]("ngForOf", ctx.listMediosNotificacion);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵproperty"]("ngIf", (ctx.f["tipoNotificacion"].dirty || ctx.submitted) && ctx.f["tipoNotificacion"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵproperty"]("siteKey", ctx.siteKey);
    } }, dependencies: [_angular_common__WEBPACK_IMPORTED_MODULE_12__.NgForOf, _angular_common__WEBPACK_IMPORTED_MODULE_12__.NgIf, _angular_forms__WEBPACK_IMPORTED_MODULE_9__["ɵNgNoValidate"], _angular_forms__WEBPACK_IMPORTED_MODULE_9__.NgControlStatusGroup, ngx_captcha__WEBPACK_IMPORTED_MODULE_11__.InvisibleReCaptchaComponent, _angular_forms__WEBPACK_IMPORTED_MODULE_9__.FormGroupDirective], styles: [".cargando[_ngcontent-%COMP%] {\n  position: absolute;\n  top: 0;\n  right: 0;\n}\n\n.invalid-feedback[_ngcontent-%COMP%] {\n  display: block;\n}\n\n.form-select[_ngcontent-%COMP%] {\n  cursor: pointer;\n}\n\n.multi-custom[_ngcontent-%COMP%] {\n  font-family: inherit;\n  font-size: inherit;\n  z-index: 1;\n  outline: none;\n  display: grid;\n  grid-template-areas: \"select\";\n  align-items: center;\n  position: relative;\n  border: 1px solid var(--select-border);\n  border-radius: 0.25em;\n  padding: 0.25em 0.5em;\n  cursor: pointer;\n  line-height: 1.1;\n  background: linear-gradient(to bottom, #ffffff 0%, #e5e5e5 100%);\n  height: 120px;\n}\n\n.multi-custom[_ngcontent-%COMP%]::after {\n  grid-area: select;\n  content: \"\";\n  justify-self: end;\n  width: 0.8em;\n  height: 0.5em;\n  background-color: var(--select-arrow);\n  clip-path: polygon(100% 0%, 0 0%, 50% 100%);\n}\n\n.option-multiselect[_ngcontent-%COMP%] {\n  align-items: center;\n  cursor: pointer;\n  display: flex;\n  flex-wrap: wrap;\n  position: relative;\n}\n\n.option-multiselect.selected[_ngcontent-%COMP%] {\n  background-color: #eee;\n}\n\n.option-multiselect.focused[_ngcontent-%COMP%] {\n  background-color: #ccc;\n}\n\n.option-multiselect.disabled[_ngcontent-%COMP%] {\n  cursor: default;\n  opacity: 0.5;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIm5vdGlmaWNhdGlvbnMuY29tcG9uZW50LmNzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtFQUNFLGtCQUFrQjtFQUNsQixNQUFNO0VBQ04sUUFBUTtBQUNWOztBQUVBO0VBQ0UsY0FBYztBQUNoQjs7QUFFQTtFQUNFLGVBQWU7QUFDakI7O0FBRUE7RUFDRSxvQkFBb0I7RUFDcEIsa0JBQWtCO0VBQ2xCLFVBQVU7RUFDVixhQUFhO0VBQ2IsYUFBYTtFQUNiLDZCQUE2QjtFQUM3QixtQkFBbUI7RUFDbkIsa0JBQWtCO0VBQ2xCLHNDQUFzQztFQUN0QyxxQkFBcUI7RUFDckIscUJBQXFCO0VBQ3JCLGVBQWU7RUFDZixnQkFBZ0I7RUFDaEIsZ0VBQWdFO0VBQ2hFLGFBQWE7QUFDZjs7QUFFQTtFQUNFLGlCQUFpQjtFQUNqQixXQUFXO0VBQ1gsaUJBQWlCO0VBQ2pCLFlBQVk7RUFDWixhQUFhO0VBQ2IscUNBQXFDO0VBQ3JDLDJDQUEyQztBQUM3Qzs7QUFFQTtFQUNFLG1CQUFtQjtFQUNuQixlQUFlO0VBQ2YsYUFBYTtFQUNiLGVBQWU7RUFDZixrQkFBa0I7QUFDcEI7O0FBQ0E7RUFDRSxzQkFBc0I7QUFDeEI7O0FBQ0E7RUFDRSxzQkFBc0I7QUFDeEI7O0FBQ0E7RUFDRSxlQUFlO0VBQ2YsWUFBWTtBQUNkIiwiZmlsZSI6Im5vdGlmaWNhdGlvbnMuY29tcG9uZW50LmNzcyIsInNvdXJjZXNDb250ZW50IjpbIi5jYXJnYW5kbyB7XG4gIHBvc2l0aW9uOiBhYnNvbHV0ZTtcbiAgdG9wOiAwO1xuICByaWdodDogMDtcbn1cblxuLmludmFsaWQtZmVlZGJhY2sge1xuICBkaXNwbGF5OiBibG9jaztcbn1cblxuLmZvcm0tc2VsZWN0IHtcbiAgY3Vyc29yOiBwb2ludGVyO1xufVxuXG4ubXVsdGktY3VzdG9tIHtcbiAgZm9udC1mYW1pbHk6IGluaGVyaXQ7XG4gIGZvbnQtc2l6ZTogaW5oZXJpdDtcbiAgei1pbmRleDogMTtcbiAgb3V0bGluZTogbm9uZTtcbiAgZGlzcGxheTogZ3JpZDtcbiAgZ3JpZC10ZW1wbGF0ZS1hcmVhczogXCJzZWxlY3RcIjtcbiAgYWxpZ24taXRlbXM6IGNlbnRlcjtcbiAgcG9zaXRpb246IHJlbGF0aXZlO1xuICBib3JkZXI6IDFweCBzb2xpZCB2YXIoLS1zZWxlY3QtYm9yZGVyKTtcbiAgYm9yZGVyLXJhZGl1czogMC4yNWVtO1xuICBwYWRkaW5nOiAwLjI1ZW0gMC41ZW07XG4gIGN1cnNvcjogcG9pbnRlcjtcbiAgbGluZS1oZWlnaHQ6IDEuMTtcbiAgYmFja2dyb3VuZDogbGluZWFyLWdyYWRpZW50KHRvIGJvdHRvbSwgI2ZmZmZmZiAwJSwgI2U1ZTVlNSAxMDAlKTtcbiAgaGVpZ2h0OiAxMjBweDtcbn1cblxuLm11bHRpLWN1c3RvbTo6YWZ0ZXIge1xuICBncmlkLWFyZWE6IHNlbGVjdDtcbiAgY29udGVudDogXCJcIjtcbiAganVzdGlmeS1zZWxmOiBlbmQ7XG4gIHdpZHRoOiAwLjhlbTtcbiAgaGVpZ2h0OiAwLjVlbTtcbiAgYmFja2dyb3VuZC1jb2xvcjogdmFyKC0tc2VsZWN0LWFycm93KTtcbiAgY2xpcC1wYXRoOiBwb2x5Z29uKDEwMCUgMCUsIDAgMCUsIDUwJSAxMDAlKTtcbn1cblxuLm9wdGlvbi1tdWx0aXNlbGVjdCB7XG4gIGFsaWduLWl0ZW1zOiBjZW50ZXI7XG4gIGN1cnNvcjogcG9pbnRlcjtcbiAgZGlzcGxheTogZmxleDtcbiAgZmxleC13cmFwOiB3cmFwO1xuICBwb3NpdGlvbjogcmVsYXRpdmU7XG59XG4ub3B0aW9uLW11bHRpc2VsZWN0LnNlbGVjdGVkIHtcbiAgYmFja2dyb3VuZC1jb2xvcjogI2VlZTtcbn1cbi5vcHRpb24tbXVsdGlzZWxlY3QuZm9jdXNlZCB7XG4gIGJhY2tncm91bmQtY29sb3I6ICNjY2M7XG59XG4ub3B0aW9uLW11bHRpc2VsZWN0LmRpc2FibGVkIHtcbiAgY3Vyc29yOiBkZWZhdWx0O1xuICBvcGFjaXR5OiAwLjU7XG59XG4iXX0= */"] });


/***/ }),

/***/ 3412:
/*!***********************************************************!*\
  !*** ./src/app/components/register/register.component.ts ***!
  \***********************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "RegisterComponent": () => (/* binding */ RegisterComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @angular/forms */ 2508);
/* harmony import */ var _services_register_service__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../services/register.service */ 1032);
/* harmony import */ var _services_header_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../services/header.service */ 6690);
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ 4534);
/* harmony import */ var _shared_components_header_header_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../shared/components/header/header.component */ 6290);
/* harmony import */ var _shared_components_footer_footer_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../shared/components/footer/footer.component */ 6526);
/* harmony import */ var _validate_validate_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./validate/validate.component */ 6497);
/* harmony import */ var _basic_data_basic_data_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./basic-data/basic-data.component */ 2230);
/* harmony import */ var _notifications_notifications_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./notifications/notifications.component */ 3151);











function RegisterComponent_ng_template_11_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelement"](0, "app-validate");
} }
function RegisterComponent_ng_template_15_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelement"](0, "app-basic-data");
} }
function RegisterComponent_ng_template_19_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelement"](0, "app-notifications");
} }
class RegisterComponent {
    constructor(formBuilder, registerService, headerService) {
        this.formBuilder = formBuilder;
        this.registerService = registerService;
        this.headerService = headerService;
        this.active = 1;
        this.showBasicData = false;
        this.showAddNotifications = false;
    }
    ngOnInit() {
        setTimeout(() => {
            this.headerService.setTitle("Registro del Buscador");
        }, 900);
        this.registerService.change.subscribe((showBasicDataS) => {
            this.showBasicData = showBasicDataS;
            this.active = 2;
        });
        this.registerService.changeNoti.subscribe((showAddNotificationS) => {
            this.showAddNotifications = showAddNotificationS;
            this.active = 3;
        });
    }
}
RegisterComponent.ɵfac = function RegisterComponent_Factory(t) { return new (t || RegisterComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdirectiveInject"](_angular_forms__WEBPACK_IMPORTED_MODULE_8__.FormBuilder), _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdirectiveInject"](_services_register_service__WEBPACK_IMPORTED_MODULE_0__.RegisterService), _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdirectiveInject"](_services_header_service__WEBPACK_IMPORTED_MODULE_1__.HeaderService)); };
RegisterComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdefineComponent"]({ type: RegisterComponent, selectors: [["app-register"]], hostVars: 2, hostBindings: function RegisterComponent_HostBindings(rf, ctx) { if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵclassProp"]("is-open", ctx.showBasicData);
    } }, decls: 22, vars: 7, consts: [[1, "section"], [1, "container"], [1, "row", "justify-content-center"], [1, "col-lg-8", "col-sm-12", "mr-auto", "ml-auto"], [1, "card", 2, "padding", "40px"], ["ngbNav", "", 1, "nav-tabs", "justify-content-center", "Futura_Std_Bold", 3, "activeId", "activeIdChange"], ["nav", "ngbNav"], [3, "ngbNavItem"], ["ngbNavLink", ""], ["ngbNavContent", ""], [3, "ngbNavItem", "disabled"], [1, "mt-2", 3, "ngbNavOutlet"]], template: function RegisterComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelement"](0, "app-header");
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](1, "div", 0)(2, "div", 1)(3, "div", 2)(4, "div", 3)(5, "div", 4)(6, "ul", 5, 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵlistener"]("activeIdChange", function RegisterComponent_Template_ul_activeIdChange_6_listener($event) { return ctx.active = $event; });
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](8, "li", 7)(9, "a", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtext"](10, "Registro");
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtemplate"](11, RegisterComponent_ng_template_11_Template, 1, 0, "ng-template", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](12, "li", 10)(13, "a", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtext"](14, "Datos B\u00E1sicos");
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtemplate"](15, RegisterComponent_ng_template_15_Template, 1, 0, "ng-template", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementStart"](16, "li", 10)(17, "a", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtext"](18, "Medios de Notificaci\u00F3n");
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵtemplate"](19, RegisterComponent_ng_template_19_Template, 1, 0, "ng-template", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelement"](20, "div", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelementEnd"]()()()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵelement"](21, "app-footer");
    } if (rf & 2) {
        const _r0 = _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵreference"](7);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵadvance"](6);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵproperty"]("activeId", ctx.active);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵadvance"](2);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵproperty"]("ngbNavItem", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵproperty"]("ngbNavItem", 2)("disabled", !ctx.showBasicData);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵproperty"]("ngbNavItem", 3)("disabled", !ctx.showAddNotifications);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵproperty"]("ngbNavOutlet", _r0);
    } }, dependencies: [_ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_9__.NgbNavContent, _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_9__.NgbNav, _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_9__.NgbNavItem, _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_9__.NgbNavLink, _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_9__.NgbNavOutlet, _shared_components_header_header_component__WEBPACK_IMPORTED_MODULE_2__.HeaderComponent, _shared_components_footer_footer_component__WEBPACK_IMPORTED_MODULE_3__.FooterComponent, _validate_validate_component__WEBPACK_IMPORTED_MODULE_4__.ValidateComponent, _basic_data_basic_data_component__WEBPACK_IMPORTED_MODULE_5__.BasicDataComponent, _notifications_notifications_component__WEBPACK_IMPORTED_MODULE_6__.NotificationsComponent], styles: ["\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJyZWdpc3Rlci5jb21wb25lbnQuY3NzIn0= */"] });


/***/ }),

/***/ 6436:
/*!********************************************************!*\
  !*** ./src/app/components/register/register.module.ts ***!
  \********************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "LAZY_ROUTES": () => (/* binding */ LAZY_ROUTES),
/* harmony export */   "RegisterModule": () => (/* binding */ RegisterModule)
/* harmony export */ });
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! @angular/common */ 4666);
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! @angular/platform-browser */ 4497);
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! @angular/forms */ 2508);
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ 4534);
/* harmony import */ var ng_recaptcha__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ng-recaptcha */ 9191);
/* harmony import */ var ngx_captcha__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! ngx-captcha */ 7796);
/* harmony import */ var _fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! @fortawesome/angular-fontawesome */ 9200);
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../../environments/environment */ 2340);
/* harmony import */ var _register_component__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./register.component */ 3412);
/* harmony import */ var _validate_validate_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./validate/validate.component */ 6497);
/* harmony import */ var _basic_data_basic_data_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./basic-data/basic-data.component */ 2230);
/* harmony import */ var _notifications_notifications_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./notifications/notifications.component */ 3151);
/* harmony import */ var _shared_components_header_header_module__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../../shared/components/header/header.module */ 3778);
/* harmony import */ var _shared_components_footer_footer_module__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../../shared/components/footer/footer.module */ 2735);
/* harmony import */ var _shared_components_header_header_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ../../shared/components/header/header.component */ 6290);
/* harmony import */ var _notifications_modal_response_modal_response_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./notifications/modal-response/modal-response.component */ 9581);
/* harmony import */ var _modal_validation_modal_validation_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./modal-validation/modal-validation.component */ 6178);
/* harmony import */ var _shared_date_format__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ../../shared/date-format */ 5307);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! @angular/core */ 2560);



















const LAZY_ROUTES = [
    {
        path: '',
        component: _validate_validate_component__WEBPACK_IMPORTED_MODULE_2__.ValidateComponent,
        children: [
            {
                path: 'validate',
                component: _validate_validate_component__WEBPACK_IMPORTED_MODULE_2__.ValidateComponent
            },
            {
                path: 'notifications',
                component: _notifications_notifications_component__WEBPACK_IMPORTED_MODULE_4__.NotificationsComponent
            },
            {
                path: 'header',
                component: _shared_components_header_header_component__WEBPACK_IMPORTED_MODULE_7__.HeaderComponent
            }
        ]
    }
];
class RegisterModule {
}
RegisterModule.ɵfac = function RegisterModule_Factory(t) { return new (t || RegisterModule)(); };
RegisterModule.ɵmod = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_11__["ɵɵdefineNgModule"]({ type: RegisterModule });
RegisterModule.ɵinj = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_11__["ɵɵdefineInjector"]({ providers: [
        { provide: _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_12__.NgbDateParserFormatter, useClass: _shared_date_format__WEBPACK_IMPORTED_MODULE_10__.NgbDateCustomParserFormatter },
        {
            provide: ng_recaptcha__WEBPACK_IMPORTED_MODULE_13__.RECAPTCHA_V3_SITE_KEY,
            useValue: _environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.recaptcha.siteKey,
        }
    ], imports: [_angular_common__WEBPACK_IMPORTED_MODULE_14__.CommonModule,
        _fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_15__.FontAwesomeModule,
        _angular_forms__WEBPACK_IMPORTED_MODULE_16__.FormsModule,
        _angular_platform_browser__WEBPACK_IMPORTED_MODULE_17__.BrowserModule,
        _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_12__.NgbPaginationModule,
        _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_12__.NgbAlertModule,
        _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_12__.NgbModule,
        ngx_captcha__WEBPACK_IMPORTED_MODULE_18__.NgxCaptchaModule,
        _angular_forms__WEBPACK_IMPORTED_MODULE_16__.ReactiveFormsModule,
        ng_recaptcha__WEBPACK_IMPORTED_MODULE_13__.RecaptchaV3Module,
        _shared_components_header_header_module__WEBPACK_IMPORTED_MODULE_5__.HeaderModule,
        _shared_components_footer_footer_module__WEBPACK_IMPORTED_MODULE_6__.FooterModule] });
(function () { (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_11__["ɵɵsetNgModuleScope"](RegisterModule, { declarations: [_register_component__WEBPACK_IMPORTED_MODULE_1__.RegisterComponent,
        _validate_validate_component__WEBPACK_IMPORTED_MODULE_2__.ValidateComponent,
        _basic_data_basic_data_component__WEBPACK_IMPORTED_MODULE_3__.BasicDataComponent,
        _notifications_notifications_component__WEBPACK_IMPORTED_MODULE_4__.NotificationsComponent,
        _notifications_modal_response_modal_response_component__WEBPACK_IMPORTED_MODULE_8__.ModalResponseComponent,
        _modal_validation_modal_validation_component__WEBPACK_IMPORTED_MODULE_9__.ModalValidationComponent], imports: [_angular_common__WEBPACK_IMPORTED_MODULE_14__.CommonModule,
        _fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_15__.FontAwesomeModule,
        _angular_forms__WEBPACK_IMPORTED_MODULE_16__.FormsModule,
        _angular_platform_browser__WEBPACK_IMPORTED_MODULE_17__.BrowserModule,
        _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_12__.NgbPaginationModule,
        _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_12__.NgbAlertModule,
        _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_12__.NgbModule,
        ngx_captcha__WEBPACK_IMPORTED_MODULE_18__.NgxCaptchaModule,
        _angular_forms__WEBPACK_IMPORTED_MODULE_16__.ReactiveFormsModule,
        ng_recaptcha__WEBPACK_IMPORTED_MODULE_13__.RecaptchaV3Module,
        _shared_components_header_header_module__WEBPACK_IMPORTED_MODULE_5__.HeaderModule,
        _shared_components_footer_footer_module__WEBPACK_IMPORTED_MODULE_6__.FooterModule] }); })();


/***/ }),

/***/ 6497:
/*!********************************************************************!*\
  !*** ./src/app/components/register/validate/validate.component.ts ***!
  \********************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "NgbdModalContent": () => (/* binding */ NgbdModalContent),
/* harmony export */   "ValidateComponent": () => (/* binding */ ValidateComponent)
/* harmony export */ });
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/forms */ 2508);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ 4534);
/* harmony import */ var _services_parametricos_service__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../../services/parametricos.service */ 7192);
/* harmony import */ var _services_ciudadano_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../../services/ciudadano.service */ 6295);
/* harmony import */ var _services_register_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../services/register.service */ 1032);
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @angular/router */ 124);
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/common */ 4666);










function ValidateComponent_div_1_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](0, "div", 15)(1, "div", 16)(2, "span", 17);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtext"](3, "Loading...");
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]()()();
} }
function ValidateComponent_span_5_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](0, "span", 18);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
} }
function ValidateComponent_option_9_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](0, "option", 19);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
} if (rf & 2) {
    const tipo_r8 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("value", tipo_r8.id);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtextInterpolate"](tipo_r8.nombre);
} }
function ValidateComponent_div_10_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](0, "div", 20);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtext"](1, " * Tipo de documento requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
} }
function ValidateComponent_span_13_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](0, "span", 18);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
} }
function ValidateComponent_div_17_span_1_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](0, "span", 18);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtext"](1, " * N\u00FAmero de documento requerido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
} }
function ValidateComponent_div_17_span_2_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](0, "span", 18);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtext"](1, " * Excede la longitud m\u00E1xima ");
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
} }
function ValidateComponent_div_17_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](0, "div", 20);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtemplate"](1, ValidateComponent_div_17_span_1_Template, 2, 0, "span", 4);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtemplate"](2, ValidateComponent_div_17_span_2_Template, 2, 0, "span", 4);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
} if (rf & 2) {
    const ctx_r5 = _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("ngIf", ctx_r5.requiredNumDoc);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("ngIf", ctx_r5.maxLengthValidNumDoc);
} }
function ValidateComponent_span_20_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](0, "span", 18);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtext"](1, "*");
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
} }
function ValidateComponent_div_24_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](0, "div", 20);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtext"](1, " * Digite un correo electr\u00F3nico v\u00E1lido ");
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
} }
const _c0 = function (a0, a1) { return { "is-valid": a0, "is-invalid": a1 }; };
class NgbdModalContent {
    constructor(activeModal) {
        this.activeModal = activeModal;
    }
}
NgbdModalContent.ɵfac = function NgbdModalContent_Factory(t) { return new (t || NgbdModalContent)(_angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdirectiveInject"](_ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_4__.NgbActiveModal)); };
NgbdModalContent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdefineComponent"]({ type: NgbdModalContent, selectors: [["app-modal-content"]], inputs: { name: "name" }, decls: 13, vars: 0, consts: [[1, "modal-header"], [1, "modal-title", "text-center"], [1, "modal-body"], [1, "modal-footer"], [1, "left-side"], [1, "divider"], [1, "right-side"], ["type", "button", 1, "btn", "btn-danger", 3, "click"]], template: function NgbdModalContent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](0, "div", 0)(1, "h5", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtext"](2, "Registro de Buscador");
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](3, "div", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtext"](4, " Su tipo y n\u00FAmero de identificaci\u00F3n ya se encuentra registrado en el Servicio P\u00FAblico de Empleo. ");
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelement"](5, "br");
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtext"](6, " Por favor inicie sesi\u00F3n, si no recuerda su usuario o contrase\u00F1a, reestablezca su contrase\u00F1a. ");
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](7, "div", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelement"](8, "div", 4)(9, "div", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](10, "div", 6)(11, "button", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵlistener"]("click", function NgbdModalContent_Template_button_click_11_listener() { return ctx.activeModal.close("close"); });
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtext"](12, "CERRAR");
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]()()();
    } }, encapsulation: 2 });
class ValidateComponent {
    constructor(formBuilder, parametricosService, ciudadanoService, registerService, router, modalService) {
        this.formBuilder = formBuilder;
        this.parametricosService = parametricosService;
        this.ciudadanoService = ciudadanoService;
        this.registerService = registerService;
        this.router = router;
        this.modalService = modalService;
        this.submitted = false;
        this.showLoading = false;
        this.listTipoDocumento = [];
        //Inicia el formulario
        this.validateForm = this.formBuilder.group({
            TipoDocumentoId: ['', _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required],
            NumeroDocumento: ['', [_angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.pattern("^[0-9]*$"), _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.maxLength(10)]],
            CorreoElectronico: ['', [_angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.email]]
        });
    }
    ngOnInit() {
        // Convoca función para consultar los parametricos para el formulario
        this.getTipoDocumentos(this.parametricosService.getParametricosSessionStorage);
        // Valida si ya hay un proceso de validación creado
        const dataValidate = this.registerService.getValidateData();
        if (dataValidate) {
            this.validateForm.patchValue(dataValidate);
        }
    }
    /**
     * Función que invoca el servicio para consultar al API los tipos de documentos
     */
    getTipoDocumentos(parametricosSession) {
        // Si existen los parametricos de tipo documento
        const listTipoDocumentoStorage = this.parametricosService.getDataKeyParametricosStorage('TipoDocumento');
        if (listTipoDocumentoStorage !== undefined) {
            // Llena el listado de tipos documento con lo registrado en el storage
            this.listTipoDocumento = listTipoDocumentoStorage;
            this.listTipoDocumento = listTipoDocumentoStorage.filter(tipoDoc => tipoDoc.principal === true);
        }
        else {
            this.showLoading = true;
            this.parametricosService.getParametricosDefault('TipoDocumento').subscribe((response) => {
                this.listTipoDocumento = response.map(function (element) {
                    return { id: element.id, nombre: element.nombre, sigla: element.sigla, principal: element.principal };
                });
                this.listTipoDocumento = this.listTipoDocumento.filter(tipoDoc => tipoDoc.principal === true);
                // Consume servicio para añadir parametrico en el storage
                this.parametricosService.addParametricoSessionStorage('TipoDocumento', this.listTipoDocumento);
                setTimeout(() => {
                    this.showLoading = false;
                }, 1000);
            });
        }
    }
    /**
     * Función que setea validaciones sobre el número documento dependiendo del tipo de documento
     */
    validaNumeroDocumento(e) {
        const tipo = e.target.value;
        this.f['NumeroDocumento'].clearValidators();
        switch (tipo) {
            case '1': // CC
            case '2': // TI
                this.f['NumeroDocumento'].addValidators([_angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.pattern("^[0-9]*$"), _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.maxLength(10)]);
                break;
            case '3': // DNI
                this.f['NumeroDocumento'].addValidators([_angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.pattern("^[0-9]*$"), _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.maxLength(20)]);
                break;
            default:
                this.f['NumeroDocumento'].addValidators([_angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.required, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.Validators.pattern("^[0-9]*$")]);
                break;
        }
        this.f['NumeroDocumento'].updateValueAndValidity();
    }
    get requiredNumDoc() {
        return this.f["NumeroDocumento"].hasError("required");
    }
    get maxLengthValidNumDoc() {
        return this.f["NumeroDocumento"].hasError("maxlength");
    }
    /**
     * Función del submit del formulario para realizar el llamado al servicio y validar si el tipo documento con el número documento existen en el sistema
     */
    validateAction() {
        this.submitted = true;
        // Valida si el formuario ya contiene los campos requeridos
        if (this.validateForm.valid) {
            this.showLoading = true;
            const tipo = this.validateForm.value.TipoDocumentoId;
            const numero = this.validateForm.value.NumeroDocumento;
            this.ciudadanoService.validateCiudadano(tipo, numero).subscribe((response) => {
                // Valida en la respuesta si existe el ciudadano o no
                if (response.existe) {
                    const modalRef = this.modalService.open(NgbdModalContent).result.then((result) => {
                        if (result == 'close') {
                            setTimeout(() => {
                                this.router.navigate(['/login']);
                            }, 500);
                        }
                    });
                    this.showLoading = false;
                }
                else {
                    // Debe ir al siguiente paso
                    setTimeout(() => {
                        this.showLoading = false;
                        this.registerService.putRegisterData(this.validateForm.value, 'validate');
                        this.registerService.changeShowBasicData();
                    }, 1000);
                }
            }, (err) => {
                console.log(err);
            });
        }
    }
    // Getter para fácil acceso a los controles de formulario
    get f() {
        return this.validateForm.controls;
    }
    validateOnlyNumberInput(evt) {
        const code = (evt.which) ? evt.which : evt.keyCode;
        const number = evt.target.value;
        let out = '';
        const filtro = '1234567890'; //Caracteres validos
        if (code != 8) { // backspace.
            //Recorrer el texto y verificar si el caracter se encuentra en la lista de validos
            for (var i = 0; i < number.length; i++) {
                if (filtro.indexOf(number.charAt(i)) != -1) {
                    if (i == 0) {
                        if (number.charAt(i) != 0) {
                            //Se añaden a la salida los caracteres validos
                            out += number.charAt(i);
                        }
                    }
                    else {
                        //Se añaden a la salida los caracteres validos
                        out += number.charAt(i);
                    }
                }
            }
            this.f['NumeroDocumento'].setValue(out);
        }
    }
}
ValidateComponent.ɵfac = function ValidateComponent_Factory(t) { return new (t || ValidateComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdirectiveInject"](_angular_forms__WEBPACK_IMPORTED_MODULE_5__.FormBuilder), _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdirectiveInject"](_services_parametricos_service__WEBPACK_IMPORTED_MODULE_0__.ParametricosService), _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdirectiveInject"](_services_ciudadano_service__WEBPACK_IMPORTED_MODULE_1__.CiudadanoService), _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdirectiveInject"](_services_register_service__WEBPACK_IMPORTED_MODULE_2__.RegisterService), _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdirectiveInject"](_angular_router__WEBPACK_IMPORTED_MODULE_6__.Router), _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdirectiveInject"](_ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_4__.NgbModal)); };
ValidateComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdefineComponent"]({ type: ValidateComponent, selectors: [["app-validate"]], decls: 30, vars: 22, consts: [[3, "formGroup", "ngSubmit"], ["class", "clearfix cargando", 4, "ngIf"], [1, "row"], [1, "col-md-6"], ["class", "text-danger", 4, "ngIf"], [1, "form-group", "form-group-no-border"], ["placeholder", "", "formControlName", "TipoDocumentoId", 1, "form-select", 3, "ngClass", "change"], [3, "value", 4, "ngFor", "ngForOf"], ["class", "invalid-feedback", 4, "ngIf"], [1, "form-group"], ["type", "text", "placeholder", "", "formControlName", "NumeroDocumento", 1, "form-control", 3, "ngClass", "keyup"], [1, "col-md-12"], ["type", "email", "placeholder", "", "formControlName", "CorreoElectronico", 1, "form-control", 3, "ngClass"], [1, "col-2", "ms-auto", "me-3"], ["type", "submit", 1, "btn", "btn-primary-form", 3, "disabled"], [1, "clearfix", "cargando"], ["role", "status", 1, "spinner-border", "float-end"], [1, "visually-hidden"], [1, "text-danger"], [3, "value"], [1, "invalid-feedback"]], template: function ValidateComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](0, "form", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵlistener"]("ngSubmit", function ValidateComponent_Template_form_ngSubmit_0_listener() { return ctx.validateAction(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtemplate"](1, ValidateComponent_div_1_Template, 4, 0, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](2, "div", 2)(3, "div", 3)(4, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtemplate"](5, ValidateComponent_span_5_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtext"](6, " Tipo de documento");
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](7, "div", 5)(8, "select", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵlistener"]("change", function ValidateComponent_Template_select_change_8_listener($event) { return ctx.validaNumeroDocumento($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtemplate"](9, ValidateComponent_option_9_Template, 2, 2, "option", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtemplate"](10, ValidateComponent_div_10_Template, 2, 0, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](11, "div", 3)(12, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtemplate"](13, ValidateComponent_span_13_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtext"](14, " N\u00FAmero de documento");
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](15, "div", 9)(16, "input", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵlistener"]("keyup", function ValidateComponent_Template_input_keyup_16_listener($event) { return ctx.validateOnlyNumberInput($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtemplate"](17, ValidateComponent_div_17_Template, 3, 2, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](18, "div", 11)(19, "label");
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtemplate"](20, ValidateComponent_span_20_Template, 2, 0, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtext"](21, " Correo electr\u00F3nico");
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](22, "div", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelement"](23, "input", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtemplate"](24, ValidateComponent_div_24_Template, 2, 0, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelement"](25, "br");
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](26, "div", 2)(27, "div", 13)(28, "button", 14);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtext"](29, "CONTINUAR");
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]()()()();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("formGroup", ctx.validateForm);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("ngIf", ctx.showLoading);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("ngIf", ctx.f["TipoDocumentoId"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵpureFunction2"](13, _c0, (ctx.f["TipoDocumentoId"].dirty || ctx.submitted) && !ctx.f["TipoDocumentoId"].errors, (ctx.f["TipoDocumentoId"].dirty || ctx.submitted) && ctx.f["TipoDocumentoId"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("ngForOf", ctx.listTipoDocumento);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("ngIf", (ctx.f["TipoDocumentoId"].dirty || ctx.submitted) && ctx.f["TipoDocumentoId"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("ngIf", ctx.f["NumeroDocumento"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵpureFunction2"](16, _c0, (ctx.f["NumeroDocumento"].dirty || ctx.submitted) && !ctx.f["NumeroDocumento"].errors, (ctx.f["NumeroDocumento"].dirty || ctx.submitted) && ctx.f["NumeroDocumento"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("ngIf", (ctx.f["NumeroDocumento"].dirty || ctx.submitted) && ctx.f["NumeroDocumento"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("ngIf", ctx.f["CorreoElectronico"].hasError("required"));
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵpureFunction2"](19, _c0, (ctx.f["CorreoElectronico"].dirty || ctx.submitted) && !ctx.f["CorreoElectronico"].errors, (ctx.f["CorreoElectronico"].dirty || ctx.submitted) && ctx.f["CorreoElectronico"].errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("ngIf", (ctx.f["CorreoElectronico"].dirty || ctx.submitted) && ctx.f["CorreoElectronico"].errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("disabled", !ctx.validateForm.valid);
    } }, dependencies: [_angular_common__WEBPACK_IMPORTED_MODULE_7__.NgClass, _angular_common__WEBPACK_IMPORTED_MODULE_7__.NgForOf, _angular_common__WEBPACK_IMPORTED_MODULE_7__.NgIf, _angular_forms__WEBPACK_IMPORTED_MODULE_5__["ɵNgNoValidate"], _angular_forms__WEBPACK_IMPORTED_MODULE_5__.NgSelectOption, _angular_forms__WEBPACK_IMPORTED_MODULE_5__["ɵNgSelectMultipleOption"], _angular_forms__WEBPACK_IMPORTED_MODULE_5__.DefaultValueAccessor, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.SelectControlValueAccessor, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.NgControlStatus, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.NgControlStatusGroup, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.FormGroupDirective, _angular_forms__WEBPACK_IMPORTED_MODULE_5__.FormControlName], styles: [".cargando[_ngcontent-%COMP%] {\n  position: absolute;\n  top: 0;\n  right: 0;\n}\n\n.invalid-feedback[_ngcontent-%COMP%] {\n  display: block;\n}\n\n.form-select[_ngcontent-%COMP%] {\n  cursor: pointer;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInZhbGlkYXRlLmNvbXBvbmVudC5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDRSxrQkFBa0I7RUFDbEIsTUFBTTtFQUNOLFFBQVE7QUFDVjs7QUFFQTtFQUNFLGNBQWM7QUFDaEI7O0FBRUE7RUFDRSxlQUFlO0FBQ2pCIiwiZmlsZSI6InZhbGlkYXRlLmNvbXBvbmVudC5jc3MiLCJzb3VyY2VzQ29udGVudCI6WyIuY2FyZ2FuZG8ge1xuICBwb3NpdGlvbjogYWJzb2x1dGU7XG4gIHRvcDogMDtcbiAgcmlnaHQ6IDA7XG59XG5cbi5pbnZhbGlkLWZlZWRiYWNrIHtcbiAgZGlzcGxheTogYmxvY2s7XG59XG5cbi5mb3JtLXNlbGVjdCB7XG4gIGN1cnNvcjogcG9pbnRlcjtcbn1cbiJdfQ== */"] });


/***/ }),

/***/ 5604:
/*!************************************!*\
  !*** ./src/app/model/ciudadano.ts ***!
  \************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);



/***/ }),

/***/ 6295:
/*!***********************************************!*\
  !*** ./src/app/services/ciudadano.service.ts ***!
  \***********************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CiudadanoService": () => (/* binding */ CiudadanoService)
/* harmony export */ });
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../environments/environment */ 2340);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ 8987);





class CiudadanoService {
    constructor(http) {
        this.http = http;
    }
    validateCiudadano(tipo, num) {
        const url = `${_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.urlAPI}/Ciudadano/existe?TipoDocumentoId=${tipo}&NumeroDocumento=${num}`;
        return this.http.get(url);
    }
    saveDataCiudadano(ciudadano) {
        const url = `${_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.urlAPI}/Ciudadano`;
        return this.http.post(url, ciudadano);
    }
}
CiudadanoService.ɵfac = function CiudadanoService_Factory(t) { return new (t || CiudadanoService)(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵinject"](_angular_common_http__WEBPACK_IMPORTED_MODULE_2__.HttpClient)); };
CiudadanoService.ɵprov = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineInjectable"]({ token: CiudadanoService, factory: CiudadanoService.ɵfac, providedIn: 'root' });


/***/ }),

/***/ 5154:
/*!************************************************************!*\
  !*** ./src/app/services/custom-datepicker-i18n.service.ts ***!
  \************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CustomDatepickerI18nService": () => (/* binding */ CustomDatepickerI18nService),
/* harmony export */   "I18n": () => (/* binding */ I18n)
/* harmony export */ });
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ 4534);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 2560);


const I18N_VALUES = {
    'es': {
        weekdays: ['L', 'M', 'M', 'J', 'V', 'S', 'D'],
        months: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
    }
};
class I18n {
    constructor() {
        this.language = 'es';
    }
}
I18n.ɵfac = function I18n_Factory(t) { return new (t || I18n)(); };
I18n.ɵprov = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineInjectable"]({ token: I18n, factory: I18n.ɵfac });
class CustomDatepickerI18nService extends _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_1__.NgbDatepickerI18n {
    constructor(_i18n) {
        super();
        this._i18n = _i18n;
    }
    getWeekdayShortName(weekday) {
        return I18N_VALUES[this._i18n.language].weekdays[weekday - 1];
    }
    getMonthShortName(month) {
        return I18N_VALUES[this._i18n.language].months[month - 1];
    }
    getMonthFullName(month) {
        return this.getMonthShortName(month);
    }
    getDayAriaLabel(date) {
        return `${date.day}-${date.month}-${date.year}`;
    }
    getWeekdayLabel(weekday, width) {
        return I18N_VALUES[this._i18n.language].weekdays[weekday - 1];
    }
}
CustomDatepickerI18nService.ɵfac = function CustomDatepickerI18nService_Factory(t) { return new (t || CustomDatepickerI18nService)(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵinject"](I18n)); };
CustomDatepickerI18nService.ɵprov = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineInjectable"]({ token: CustomDatepickerI18nService, factory: CustomDatepickerI18nService.ɵfac, providedIn: 'root' });


/***/ }),

/***/ 543:
/*!****************************************!*\
  !*** ./src/app/services/cv.service.ts ***!
  \****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CvService": () => (/* binding */ CvService)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common/http */ 8987);



class CvService {
    constructor(http) {
        this.http = http;
    }
    get getCiudadano() {
        const itemSession = sessionStorage.getItem('Ciudadano');
        if (itemSession) {
            return JSON.parse(itemSession);
        }
        else {
            return null;
        }
    }
    /**
     * Función que setea o guarda la información del cuidadano luego del login
     */
    setCiudadano(data) {
        sessionStorage.setItem('Ciudadano', JSON.stringify(data));
    }
    resetCiudadano() {
        sessionStorage.removeItem('Ciudadano');
    }
}
CvService.ɵfac = function CvService_Factory(t) { return new (t || CvService)(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵinject"](_angular_common_http__WEBPACK_IMPORTED_MODULE_1__.HttpClient)); };
CvService.ɵprov = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineInjectable"]({ token: CvService, factory: CvService.ɵfac, providedIn: 'root' });


/***/ }),

/***/ 6690:
/*!********************************************!*\
  !*** ./src/app/services/header.service.ts ***!
  \********************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "HeaderService": () => (/* binding */ HeaderService)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 2560);


class HeaderService {
    constructor() {
        this.title = "";
        this.changeTitle = new _angular_core__WEBPACK_IMPORTED_MODULE_0__.EventEmitter();
    }
    setTitle(titleStr) {
        this.title = titleStr;
        console.log(this.title);
        this.changeTitle.emit(this.title);
    }
    getTitle() {
        return this.title;
    }
}
HeaderService.ɵfac = function HeaderService_Factory(t) { return new (t || HeaderService)(); };
HeaderService.ɵprov = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineInjectable"]({ token: HeaderService, factory: HeaderService.ɵfac, providedIn: 'root' });


/***/ }),

/***/ 4120:
/*!*******************************************!*\
  !*** ./src/app/services/login.service.ts ***!
  \*******************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "LoginService": () => (/* binding */ LoginService)
/* harmony export */ });
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../environments/environment */ 2340);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ 8987);





class LoginService {
    constructor(http) {
        this.http = http;
    }
    /**
     * Funcion que consulta si existe y toda la información de un ciudadano por tipo y documento
     */
    getCiudadanoByTipoNumero(tipo, numero) {
        const url = `${_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.urlAPI}/Ciudadano?TipoDocumentoId=${tipo}&NumeroDocumento=${numero}`;
        return this.http.get(url);
    }
}
LoginService.ɵfac = function LoginService_Factory(t) { return new (t || LoginService)(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵinject"](_angular_common_http__WEBPACK_IMPORTED_MODULE_2__.HttpClient)); };
LoginService.ɵprov = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineInjectable"]({ token: LoginService, factory: LoginService.ɵfac, providedIn: 'root' });


/***/ }),

/***/ 7192:
/*!**************************************************!*\
  !*** ./src/app/services/parametricos.service.ts ***!
  \**************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "PARAMETRICOS": () => (/* binding */ PARAMETRICOS),
/* harmony export */   "PARAMETRICOS_FILTROS": () => (/* binding */ PARAMETRICOS_FILTROS),
/* harmony export */   "ParametricosService": () => (/* binding */ ParametricosService)
/* harmony export */ });
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! rxjs */ 833);
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../environments/environment */ 2340);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common/http */ 8987);





var PARAMETRICOS;
(function (PARAMETRICOS) {
    PARAMETRICOS["MODALIDAD_TRABAJO"] = "ModalidadTrabajo";
    PARAMETRICOS["SECTOR_ECONOMICO"] = "SectorEconomico";
    PARAMETRICOS["SUB_SECTOR_ECONOMICO"] = "SubsectorEconomico";
    PARAMETRICOS["DEPARTAMENTOS"] = "Departamento";
    PARAMETRICOS["MUNICIPIO"] = "Municipio";
    PARAMETRICOS["CATEGORIA_LICENCIA"] = "CategoriaLicencia";
    PARAMETRICOS["AREA_EMPRESA"] = "AreaEmpresa";
    PARAMETRICOS["MOTIVO_EXCEPCIONALIDAD"] = "MotivoExepcionalidad";
    PARAMETRICOS["DISCAPACIDAD"] = "Discapacidad";
    PARAMETRICOS["NIVEL_EDUCATIVO"] = "NivelEducativo";
    PARAMETRICOS["NIVEL_DOMINIO_IDIOMA"] = "NivelDominioIdioma";
    PARAMETRICOS["IDIOMA"] = "Idioma";
    PARAMETRICOS["TIPO_CONTRATO"] = "TipoContrato";
    PARAMETRICOS["JORNADA_LABORAL"] = "JornadaLaboral";
    PARAMETRICOS["TIPO_SALARIO"] = "TipoSalario";
    PARAMETRICOS["PERIODICIDAD_SALARIAL"] = "PeriodicidadSalarial";
})(PARAMETRICOS || (PARAMETRICOS = {}));
var PARAMETRICOS_FILTROS;
(function (PARAMETRICOS_FILTROS) {
    PARAMETRICOS_FILTROS["MUNICIPIO__DEPARTAMENTO_ID"] = "departamentoID";
    PARAMETRICOS_FILTROS["SUB_SECTOR_ECONOMICO__SECTOR_ECONOMICO_ID"] = "sectorEconomicoID";
})(PARAMETRICOS_FILTROS || (PARAMETRICOS_FILTROS = {}));
class ParametricosService {
    constructor(http) {
        this.http = http;
    }
    /**
     * Funcion que consulta algún parametrico y devuelve un arreglo con los valores
     */
    getParametricosDefault(tipo) {
        const url = `${_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.urlAPI}/parametrico/${tipo}`;
        return this.http.get(url);
    }
    /**
     * Funcion que consume API para consultar los municipios por un departamento
     */
    getMunicipiosByDepto(tipo, deptoId) {
        const url = `${_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.urlAPI}/parametrico/${tipo}?depratmentoID=${deptoId}`;
        return this.http.get(url);
    }
    /**
     * Funcion que consume API para consultar algún parmétrico que dependa de otro valor (un solo valor)
     */
    getParametricoById(tipo, tipoValue, value) {
        const url = `${_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.urlAPI}/parametrico/${tipo}?${tipoValue}=${value}`;
        return this.http.get(url);
    }
    /**
     * Funcion que consume API para consultar los puntos de atención por un prestador de preferencia
     */
    getPuntosAtencionByPrestador(tipo, prestadorId) {
        const url = `${_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.urlAPI}/parametrico/${tipo}?prestadorID=${prestadorId}`;
        return this.http.get(url);
    }
    /**
     * Función que agrega paramétrico al session storage
     */
    addParametricoSessionStorage(keyInObject, value) {
        // Valida si existe la variable Parametricos en el session storage
        let parametricos = this.getParametricosSessionStorage;
        if (parametricos !== null) {
            parametricos[keyInObject] = value;
        }
        sessionStorage.setItem('Parametricos', JSON.stringify(parametricos));
    }
    get getParametricosSessionStorage() {
        let parametricos = {};
        const itemSession = sessionStorage.getItem('Parametricos');
        if (itemSession) {
            parametricos = JSON.parse(itemSession);
        }
        return parametricos;
    }
    /**
     * Funcion que devuelve la data de un parametrico del session storage
     */
    getDataKeyParametricosStorage(key) {
        const parametricos = this.getParametricosSessionStorage;
        return parametricos[key];
    }
    /**
     * Gestiona la entrega general de parametricos controlando el almacenamiento en Storage
     * @example
     * ´´´ts
     * this.serviceParametricos.getParametricos(PARAMETRICOS.DEPARTAMENTOS).pipe(...).subscribe(...);
     * this.serviceParametricos.getParametricos(PARAMETRICOS.MUNICIPIO,'departamentoID','0').pipe(...).subscribe(...);
     * ´´´
     */
    getParametricos(TIPO_PARAMETRICO, tipoValue, value) {
        return new rxjs__WEBPACK_IMPORTED_MODULE_1__.Observable((subscriber) => {
            try {
                const storageKey = `${TIPO_PARAMETRICO}_${tipoValue}_${value}`;
                const dataParametricosStorage = this.getDataKeyParametricosStorage(storageKey);
                let listDataParamentricos;
                if (dataParametricosStorage !== undefined) {
                    listDataParamentricos = dataParametricosStorage;
                    subscriber.next(listDataParamentricos);
                    subscriber.complete();
                }
                else {
                    let $getparametrico;
                    if (tipoValue && value) {
                        $getparametrico = this.getParametricoById(TIPO_PARAMETRICO, tipoValue, value);
                    }
                    else {
                        $getparametrico = this.getParametricosDefault(TIPO_PARAMETRICO);
                    }
                    $getparametrico.subscribe((response) => {
                        listDataParamentricos = response;
                        this.addParametricoSessionStorage(storageKey, listDataParamentricos);
                        subscriber.next(listDataParamentricos);
                        subscriber.complete();
                    });
                }
            }
            catch (error) {
                subscriber.error(error);
            }
        });
    }
}
ParametricosService.ɵfac = function ParametricosService_Factory(t) { return new (t || ParametricosService)(_angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵinject"](_angular_common_http__WEBPACK_IMPORTED_MODULE_3__.HttpClient)); };
ParametricosService.ɵprov = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵdefineInjectable"]({ token: ParametricosService, factory: ParametricosService.ɵfac, providedIn: 'root' });


/***/ }),

/***/ 8486:
/*!***********************************************!*\
  !*** ./src/app/services/prestador.service.ts ***!
  \***********************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "PrestadorService": () => (/* binding */ PrestadorService)
/* harmony export */ });
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../environments/environment */ 2340);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ 8987);





class PrestadorService {
    constructor(http) {
        this.http = http;
    }
    /**
     * Funcion que consulta los prestadores al API
     */
    getPrestadoresByDepto(depto) {
        const url = `${_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.urlAPI}/Prestador/lista/${depto}`;
        return this.http.get(url);
    }
    /**
     * Funcion que consulta los puntos de atencion del API
     */
    getPuntosAtencionByPrestador(punto) {
        const url = `${_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.urlAPI}/PuntoAtencion/lista/${punto}`;
        return this.http.get(url);
    }
    /**
     * Función que agrega los prestadores al storage
     */
    setPrestadoresStorage(prestadores) {
        sessionStorage.setItem('Prestadores', JSON.stringify(prestadores));
    }
    /**
     * Función que devuelve el listado de prestadores almacenados en storage
     */
    get getPrestadoresStorage() {
        let prestadores = [];
        const prestadorSession = sessionStorage.getItem('Prestadores');
        if (prestadorSession) {
            prestadores = JSON.parse(prestadorSession);
        }
        return prestadores;
    }
    /**
     * Función que agrega los prestadores al storage
     */
    setPuntosAtencionStorage(puntos) {
        sessionStorage.setItem('PuntosAtencion', JSON.stringify(puntos));
    }
    /**
     * Función que devuelve el listado de prestadores almacenados en storage
     */
    get getPuntosAtencionStorage() {
        let puntos = [];
        const puntosSession = sessionStorage.getItem('PuntosAtencion');
        if (puntosSession) {
            puntos = JSON.parse(puntosSession);
        }
        return puntos;
    }
}
PrestadorService.ɵfac = function PrestadorService_Factory(t) { return new (t || PrestadorService)(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵinject"](_angular_common_http__WEBPACK_IMPORTED_MODULE_2__.HttpClient)); };
PrestadorService.ɵprov = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineInjectable"]({ token: PrestadorService, factory: PrestadorService.ɵfac, providedIn: 'root' });


/***/ }),

/***/ 1032:
/*!**********************************************!*\
  !*** ./src/app/services/register.service.ts ***!
  \**********************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "RegisterService": () => (/* binding */ RegisterService)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 2560);


class RegisterService {
    constructor() {
        this.showBasicData = false;
        this.showAddNotifications = false;
        this.change = new _angular_core__WEBPACK_IMPORTED_MODULE_0__.EventEmitter();
        this.changeNoti = new _angular_core__WEBPACK_IMPORTED_MODULE_0__.EventEmitter();
    }
    changeShowBasicData() {
        this.showBasicData = true;
        this.change.emit(this.showBasicData);
    }
    changeShowAddNotifications() {
        this.showAddNotifications = true;
        this.changeNoti.emit(this.showAddNotifications);
    }
    getRegisterData() {
        return this.registerData;
    }
    getValidateData() {
        return this.validateData;
    }
    /**
     * Función que se encarga de agregar la información que se registró en los formularios y poderla pasar entre componentes
     */
    putRegisterData(data, type) {
        // Valida si hay algo en data
        if (data) {
            // En caso de la variable estar undefined entonces la inicializa con toda la data
            switch (type) {
                case 'validate':
                    if (this.validateData == undefined) {
                        this.validateData = data;
                    }
                    else {
                        for (const key in data) {
                            if (Object.prototype.hasOwnProperty.call(data, key)) {
                                this.validateData[key] = data[key];
                            }
                        }
                    }
                    break;
                case 'register':
                    if (this.registerData == undefined) {
                        this.registerData = data;
                    }
                    else {
                        for (const key in data) {
                            if (Object.prototype.hasOwnProperty.call(data, key)) {
                                this.registerData[key] = data[key];
                            }
                        }
                    }
                    break;
            }
        }
    }
    /**
     * Función que hace un reset de la data, tanto register como validate
     */
    resetData() {
        this.validateData = undefined;
        this.registerData = undefined;
    }
}
RegisterService.ɵfac = function RegisterService_Factory(t) { return new (t || RegisterService)(); };
RegisterService.ɵprov = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineInjectable"]({ token: RegisterService, factory: RegisterService.ɵfac, providedIn: 'root' });


/***/ }),

/***/ 796:
/*!********************************************************************************************!*\
  !*** ./src/app/shared/components/disability-navigation/disability-navigation.component.ts ***!
  \********************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "DisabilityNavigationComponent": () => (/* binding */ DisabilityNavigationComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var _fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @fortawesome/angular-fontawesome */ 9200);


const _c0 = function () { return ["fas", "font"]; };
const _c1 = function () { return ["fas", "sign-language"]; };
class DisabilityNavigationComponent {
    constructor() { }
    ngOnInit() {
    }
}
DisabilityNavigationComponent.ɵfac = function DisabilityNavigationComponent_Factory(t) { return new (t || DisabilityNavigationComponent)(); };
DisabilityNavigationComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: DisabilityNavigationComponent, selectors: [["app-disability-navigation"]], decls: 14, vars: 6, consts: [[1, "content-disability", "ms-auto"], [1, "btn"], [1, "fa", "fa-solid", "fa-adjust"], [3, "icon"]], template: function DisabilityNavigationComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "nav", 0)(1, "ul")(2, "li")(3, "button", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](4, "i", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](5, "li")(6, "button", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](7, "fa-icon", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](8, "li")(9, "button", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](10, "fa-icon", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](11, "li")(12, "button", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](13, "fa-icon", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()()()();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](7);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("icon", _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵpureFunction0"](3, _c0));
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("icon", _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵpureFunction0"](4, _c0));
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("icon", _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵpureFunction0"](5, _c1));
    } }, dependencies: [_fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_1__.FaIconComponent], styles: [".content-disability[_ngcontent-%COMP%] {\n  float: right;\n  width: 58px;\n  height: 191px;\n}\n\n.content-disability[_ngcontent-%COMP%]   ul[_ngcontent-%COMP%] {\n  list-style: none;\n  overflow: hidden;\n  position: fixed;\n  z-index: 99;\n  padding: 10px;\n  background: #595a5c 0% 0% no-repeat padding-box;\n  border-radius: 7px;\n  opacity: 1;\n}\n\n.content-disability[_ngcontent-%COMP%]   ul[_ngcontent-%COMP%]   li[_ngcontent-%COMP%] {\n  background-color: #ffffff;\n  border-radius: 5px 0px 0px 5px;\n  opacity: 1;\n}\n\n.content-disability[_ngcontent-%COMP%]   ul[_ngcontent-%COMP%]   li[_ngcontent-%COMP%]   button[_ngcontent-%COMP%] {\n  display: flex;\n  background-color: #fff;\n  opacity: 1;\n  width: 24px;\n  height: 24px;\n  margin-bottom: 10px;\n  align-items: center;\n  justify-content: center;\n}\n\n.content-disability[_ngcontent-%COMP%]   ul[_ngcontent-%COMP%]   li[_ngcontent-%COMP%]   button[_ngcontent-%COMP%]:hover {\n  color: #dd2d2b;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbImRpc2FiaWxpdHktbmF2aWdhdGlvbi5jb21wb25lbnQuY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0UsWUFBWTtFQUNaLFdBQVc7RUFDWCxhQUFhO0FBQ2Y7O0FBRUE7RUFDRSxnQkFBZ0I7RUFDaEIsZ0JBQWdCO0VBQ2hCLGVBQWU7RUFDZixXQUFXO0VBQ1gsYUFBYTtFQUNiLCtDQUErQztFQUMvQyxrQkFBa0I7RUFDbEIsVUFBVTtBQUNaOztBQUNBO0VBQ0UseUJBQXlCO0VBQ3pCLDhCQUE4QjtFQUM5QixVQUFVO0FBQ1o7O0FBQ0E7RUFDRSxhQUFhO0VBQ2Isc0JBQXNCO0VBQ3RCLFVBQVU7RUFDVixXQUFXO0VBQ1gsWUFBWTtFQUNaLG1CQUFtQjtFQUNuQixtQkFBbUI7RUFDbkIsdUJBQXVCO0FBQ3pCOztBQUNBO0VBQ0UsY0FBYztBQUNoQiIsImZpbGUiOiJkaXNhYmlsaXR5LW5hdmlnYXRpb24uY29tcG9uZW50LmNzcyIsInNvdXJjZXNDb250ZW50IjpbIi5jb250ZW50LWRpc2FiaWxpdHkge1xuICBmbG9hdDogcmlnaHQ7XG4gIHdpZHRoOiA1OHB4O1xuICBoZWlnaHQ6IDE5MXB4O1xufVxuXG4uY29udGVudC1kaXNhYmlsaXR5IHVsIHtcbiAgbGlzdC1zdHlsZTogbm9uZTtcbiAgb3ZlcmZsb3c6IGhpZGRlbjtcbiAgcG9zaXRpb246IGZpeGVkO1xuICB6LWluZGV4OiA5OTtcbiAgcGFkZGluZzogMTBweDtcbiAgYmFja2dyb3VuZDogIzU5NWE1YyAwJSAwJSBuby1yZXBlYXQgcGFkZGluZy1ib3g7XG4gIGJvcmRlci1yYWRpdXM6IDdweDtcbiAgb3BhY2l0eTogMTtcbn1cbi5jb250ZW50LWRpc2FiaWxpdHkgdWwgbGkge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjZmZmZmZmO1xuICBib3JkZXItcmFkaXVzOiA1cHggMHB4IDBweCA1cHg7XG4gIG9wYWNpdHk6IDE7XG59XG4uY29udGVudC1kaXNhYmlsaXR5IHVsIGxpIGJ1dHRvbiB7XG4gIGRpc3BsYXk6IGZsZXg7XG4gIGJhY2tncm91bmQtY29sb3I6ICNmZmY7XG4gIG9wYWNpdHk6IDE7XG4gIHdpZHRoOiAyNHB4O1xuICBoZWlnaHQ6IDI0cHg7XG4gIG1hcmdpbi1ib3R0b206IDEwcHg7XG4gIGFsaWduLWl0ZW1zOiBjZW50ZXI7XG4gIGp1c3RpZnktY29udGVudDogY2VudGVyO1xufVxuLmNvbnRlbnQtZGlzYWJpbGl0eSB1bCBsaSBidXR0b246aG92ZXIge1xuICBjb2xvcjogI2RkMmQyYjtcbn1cbiJdfQ== */"] });


/***/ }),

/***/ 4632:
/*!*****************************************************************************************!*\
  !*** ./src/app/shared/components/disability-navigation/disability-navigation.module.ts ***!
  \*****************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "DisabilityNavigationModule": () => (/* binding */ DisabilityNavigationModule)
/* harmony export */ });
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ 4666);
/* harmony import */ var _fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @fortawesome/angular-fontawesome */ 9200);
/* harmony import */ var _disability_navigation_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./disability-navigation.component */ 796);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ 2560);




class DisabilityNavigationModule {
}
DisabilityNavigationModule.ɵfac = function DisabilityNavigationModule_Factory(t) { return new (t || DisabilityNavigationModule)(); };
DisabilityNavigationModule.ɵmod = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineNgModule"]({ type: DisabilityNavigationModule });
DisabilityNavigationModule.ɵinj = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineInjector"]({ imports: [_angular_common__WEBPACK_IMPORTED_MODULE_2__.CommonModule,
        _fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_3__.FontAwesomeModule] });
(function () { (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵsetNgModuleScope"](DisabilityNavigationModule, { declarations: [_disability_navigation_component__WEBPACK_IMPORTED_MODULE_0__.DisabilityNavigationComponent], imports: [_angular_common__WEBPACK_IMPORTED_MODULE_2__.CommonModule,
        _fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_3__.FontAwesomeModule], exports: [_disability_navigation_component__WEBPACK_IMPORTED_MODULE_0__.DisabilityNavigationComponent] }); })();


/***/ }),

/***/ 6526:
/*!**************************************************************!*\
  !*** ./src/app/shared/components/footer/footer.component.ts ***!
  \**************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "FooterComponent": () => (/* binding */ FooterComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 2560);

class FooterComponent {
    constructor() { }
    ngOnInit() {
    }
}
FooterComponent.ɵfac = function FooterComponent_Factory(t) { return new (t || FooterComponent)(); };
FooterComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: FooterComponent, selectors: [["app-footer"]], decls: 119, vars: 0, consts: [["id", "footer", "aria-label", "Informaci\u00F3n de contacto", 1, "footer-hover-links-light", "mt-5"], [1, "container", "container-xl"], [1, "row"], [1, "col-lg-2"], ["src", "../../../../assets/img/logo-spe.png", "alt", "Servicio P\u00FAblico de Empleo", 1, "img-fluid", "mx-auto", "d-block", 2, "max-height", "127px"], [1, "col-lg-4", "ml-auto", "mb-4", "mb-lg-0"], [1, "font-weight-semibold", "text-1", "mb-3"], [1, "mb-2"], [1, "text-light"], ["href", "tel:+5717560009"], [1, "col-lg-3", "mb-4", "mb-lg-0"], ["href", "#", "title", "Ingresar Atenci\u00F3n al Ciudadano"], ["href", "#", "title", "Ingresar a cont\u00E1ctenos"], ["href", "https://centroderelevo.gov.co/632/w3-channel.html", "target", "_blank", "title", "Clic para ingresar a la p\u00E1gina Centro de Relevo"], [2, "font-family", "arial,helvetica,sans-serif"], [1, "col-lg-3"], [1, "he_footer"], [1, "container"], [1, "col-xl-2", "col-lg-3", "split", "screen-lg", "logos"], [1, "logo"], [1, "d-none"], ["href", "https://www.gov.co", "target", "_blank"], ["src", "../../../../assets/img/logo_gov-footer.png", "alt", "Logo GOV.CO"], [1, "logo_co"], ["href", "https://www.colombia.co", "target", "_blank"], ["src", "../../../../assets/img/logo_co_footer.png", "alt", "Logo .CO"], [1, "col-xl-6", "col-lg-5", "split"], [1, "text-3", "fw-bold"], [1, "he_footer_redes"], ["href", "https://twitter.com/ServiciodEmpleo", "target", "_blank", "role", "button"], ["aria-hidden", "true", 1, "fa", "fa-twitter", "fa-circulo"], [1, "fa_text", "text-light"], ["href", "https://www.instagram.com/servicioempleocol/", "target", "_blank", "role", "button"], ["aria-hidden", "true", 1, "fa", "fa-instagram", "fa-circulo"], ["href", "https://www.facebook.com/SPEColombia", "target", "_blank", "role", "button"], ["aria-hidden", "true", 1, "fa", "fa-facebook", "fa-circulo"], [1, "col-lg-4", "no-split"], ["aria-hidden", "true", 1, "fa", "fa-phone"], ["href", "https://www.serviciodeempleo.gov.co/spe/media/documents/pdf/Politica-de-Seguridad-y-Privacidad-de-la-Informacion-Final-Publicada.pdf", "target", "_blank", "role", "button"], [1, "col-lg-2", "no-split", "split-top", "screen-md-sm", "logos_movil"], ["href", "https://www.gov.co"], ["src", "../../../../assets/img/logo_gov-footer.png", "alt", "logo GOV.CO", 1, "img-fluid"], ["href", "https://www.colombia.co"], ["src", "../../../../assets/img/logo_co_footer.png", "alt", "logo .CO"]], template: function FooterComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "footer", 0)(1, "div", 1)(2, "div", 2)(3, "div", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](4, "img", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](5, "div", 5)(6, "h2", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](7, " Unidad Administrativa Especial del Servicio P\u00FAblico de Empleo ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](8, "ul")(9, "li", 7)(10, "strong", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](11, "Direcci\u00F3n:");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](12, " Carrera 69 # 25 B - 44 Piso 7, Bogot\u00E1 D.C.");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](13, "li", 7)(14, "strong", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](15, "PBX:");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](16, "\u00A0(");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](17, "a", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](18, "+57) 601 7560009 Opci\u00F3n 1.");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](19, "li", 7)(20, "strong", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](21, "Correspondencia:");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](22, " Lunes a Viernes 8:00 am a 4:00 pm\u00A0en jornada continua.");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](23, "div", 10)(24, "h2", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](25, " Atenci\u00F3n al Ciudadano ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](26, "ul")(27, "li", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](28, "En Bogot\u00E1: (+57) 601 7560009 Opci\u00F3n 1.");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](29, "li", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](30, "Lunes - Viernes de 8:00\u00A0am - 4:00 pm.\u00A0en jornada continua.");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](31, "li", 7)(32, "a", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](33, "PQRSD ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](34, "| ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](35, "a", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](36, " Escr\u00EDbenos");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](37, "li", 7)(38, "a", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](39, "Centro de Relevo");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](40, "\u00A0");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](41, "li", 7)(42, "strong", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](43, "Correo:\u00A0");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](44, "strong")(45, "span", 14);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](46, "atencionalciudadano@serviciodeempleo.gov.co");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](47, "\u00A0");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](48, "li", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](49, "notificacionesjudiciales@serviciodeempleo.gov.co");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](50, "div", 15);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](51, "div", 16)(52, "div", 17)(53, "div", 2)(54, "div", 18)(55, "div", 19)(56, "h2", 20);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](57, "GOV.CO");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](58, "a", 21);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](59, "img", 22);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](60, "div", 23)(61, "a", 24);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](62, "img", 25);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](63, "div", 26)(64, "h3", 27);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](65, "Unidad Administrativa Especial del Servicio P\u00FAblico de Empleo ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](66, "p", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](67, " Direcci\u00F3n: Carrera 69 # 25 B - 44 Piso 7, Bogot\u00E1 D.C.");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](68, "br")(69, "br");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](70, " Horario de Atenci\u00F3n: Lunes a Viernes de 8:00 a.m. a 4:00 p.m. en jornada continua ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](71, "ul", 28)(72, "a", 29)(73, "li");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](74, "i", 30);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](75, "div", 31);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](76, "Twitter");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](77, "a", 32)(78, "li");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](79, "i", 33);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](80, "div", 31);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](81, "Instagram");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](82, "a", 34)(83, "li");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](84, "i", 35);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](85, "div", 31);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](86, "Facebook");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()()()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](87, "div", 36)(88, "h3", 27);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](89, "i", 37);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](90, " Contacto");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](91, "p", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](92, " Atenci\u00F3n al Ciudadano ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](93, "br");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](94, " Direcci\u00F3n: Carrera 69 # 25 B - 44 Piso 7, Bogot\u00E1 D.C. ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](95, "br");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](96, " PBX: (+57) 601 7560009 Opci\u00F3n 1. ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](97, "br");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](98, " En Bogot\u00E1: 601 7560009 Opci\u00F3n 1. ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](99, "br");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](100, " Horario de Atenci\u00F3n: Lunes a Viernes de 8:00 a.m. a 4:00 p.m. en jornada continua. ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](101, "br");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](102, " PQRSDF | Escr\u00EDbenos ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](103, "br");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](104, " Correspondencia: Lunes a Viernes de 8:00 a.m. a 4:00 p.m. en jornada continua. ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](105, "br");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](106, " Correo:\u00A0atencionalciudadano@serviciodeempleo.gov.co\u00A0");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](107, "br");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](108, " notificacionesjudiciales@serviciodeempleo.gov.co ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](109, "br");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](110, "a", 38);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](111, "Pol\u00EDtica de seguridad de la informaci\u00F3n");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](112, "div", 39)(113, "div", 19)(114, "a", 40);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](115, "img", 41);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](116, "div", 23)(117, "a", 42);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](118, "img", 43);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]()()()()()()();
    } }, styles: ["#footer[_ngcontent-%COMP%] {\n  background: #252733;\n  margin-top: 50px;\n}\n#footer[_ngcontent-%COMP%]   h1[_ngcontent-%COMP%], #footer[_ngcontent-%COMP%]   h2[_ngcontent-%COMP%], #footer[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%], #footer[_ngcontent-%COMP%]   h4[_ngcontent-%COMP%], #footer[_ngcontent-%COMP%]   h5[_ngcontent-%COMP%] {\n  color: #fff;\n}\n#footer[_ngcontent-%COMP%]   .logo[_ngcontent-%COMP%]   img[_ngcontent-%COMP%] {\n  max-width: 100%;\n}\n#footer[_ngcontent-%COMP%]    > .container[_ngcontent-%COMP%]    > .row[_ngcontent-%COMP%] {\n  padding-top: 32px;\n  padding-top: 2rem;\n}\n#footer[_ngcontent-%COMP%]   li[_ngcontent-%COMP%], #footer[_ngcontent-%COMP%]   li[_ngcontent-%COMP%]   a[_ngcontent-%COMP%] {\n  color: #999 !important;\n}\n.container-xl[_ngcontent-%COMP%] {\n  width: 100%;\n  max-width: 1440px;\n}\n.container-xl[_ngcontent-%COMP%]   ul[_ngcontent-%COMP%] {\n  font-size: 14px;\n}\n.he_footer[_ngcontent-%COMP%] {\n  background: #3366cc 0% 0% no-repeat padding-box;\n  padding: 35px;\n  font: Regular 12px/14px Montserrat;\n  letter-spacing: 0;\n  color: #ffffff;\n  opacity: 1;\n  font-size: 12px;\n}\n.he_footer[_ngcontent-%COMP%]   .split[_ngcontent-%COMP%], .he_footer[_ngcontent-%COMP%]   .no-split[_ngcontent-%COMP%] {\n  padding: 15px 25px;\n}\n.he_footer[_ngcontent-%COMP%]   .logos[_ngcontent-%COMP%] {\n  text-align: center;\n}\n.he_footer[_ngcontent-%COMP%]   .split[_ngcontent-%COMP%] {\n  border-right: 1px solid #ffffff;\n}\n.he_footer[_ngcontent-%COMP%]   .split-top[_ngcontent-%COMP%] {\n  border-top: 1px solid #ffffff;\n}\n.he_footer[_ngcontent-%COMP%]   .logos_movil[_ngcontent-%COMP%]   .logo[_ngcontent-%COMP%] {\n  float: left;\n}\n.he_footer[_ngcontent-%COMP%]   .logo[_ngcontent-%COMP%] {\n  margin-top: 10px;\n  margin-bottom: 20px;\n}\n.he_footer[_ngcontent-%COMP%]   .logo[_ngcontent-%COMP%]   img[_ngcontent-%COMP%] {\n  height: 30px;\n}\n.he_footer[_ngcontent-%COMP%]   .logos_movil[_ngcontent-%COMP%]   .logo_co[_ngcontent-%COMP%] {\n  float: right;\n}\n.he_footer_redes[_ngcontent-%COMP%] {\n  margin: 0;\n  padding: 0;\n  display: flex;\n  justify-content: center;\n}\n.he_footer[_ngcontent-%COMP%]   p[_ngcontent-%COMP%] {\n  margin: 0;\n}\n.he_footer[_ngcontent-%COMP%]   ul.he_footer_redes[_ngcontent-%COMP%]   li[_ngcontent-%COMP%] {\n  float: left;\n  margin: 35px 11px 0px 11px;\n  height: 50px;\n  overflow: hidden;\n  list-style: none;\n}\n.he_footer[_ngcontent-%COMP%]   ul.he_footer_redes[_ngcontent-%COMP%]   li[_ngcontent-%COMP%]   .fa_text[_ngcontent-%COMP%] {\n  float: right;\n  padding-top: 7px;\n}\n.text-1[_ngcontent-%COMP%] {\n  font-size: 12.8px !important;\n  font-size: 0.8rem !important;\n}\n.text-3[_ngcontent-%COMP%] {\n  font-size: 16px !important;\n  font-size: 1rem !important;\n}\n.font-weight-semibold[_ngcontent-%COMP%] {\n  font-weight: 600 !important;\n}\n@media only screen and (min-width: 992px) {\n  .screen-sm[_ngcontent-%COMP%] {\n    display: none;\n  }\n  .screen-md[_ngcontent-%COMP%] {\n    display: none;\n  }\n  .screen-lg[_ngcontent-%COMP%] {\n    display: block;\n  }\n  .screen-md-sm[_ngcontent-%COMP%] {\n    display: none;\n  }\n}\n@media only screen and (max-width: 991px) {\n  .screen-sm[_ngcontent-%COMP%] {\n    display: none;\n  }\n  .screen-md[_ngcontent-%COMP%] {\n    display: block;\n  }\n  .screen-lg[_ngcontent-%COMP%] {\n    display: none;\n  }\n  .screen-md-sm[_ngcontent-%COMP%] {\n    display: block;\n  }\n  .he_menu[_ngcontent-%COMP%]   .nav-link[_ngcontent-%COMP%] {\n    padding: 0px 5px;\n  }\n  .he_footer[_ngcontent-%COMP%]   .split[_ngcontent-%COMP%] {\n    border-right: none;\n  }\n  .he_footer[_ngcontent-%COMP%]   .split[_ngcontent-%COMP%] {\n    border-bottom: 1px solid #ffffff;\n  }\n  .he_footer[_ngcontent-%COMP%]   .split[_ngcontent-%COMP%], .he_footer[_ngcontent-%COMP%]   .no-split[_ngcontent-%COMP%] {\n    padding: 25px;\n  }\n}\n@media only screen and (max-width: 768px) {\n  .screen-sm[_ngcontent-%COMP%] {\n    display: block;\n  }\n  .screen-md[_ngcontent-%COMP%] {\n    display: none;\n  }\n  .screen-lg[_ngcontent-%COMP%] {\n    display: none;\n  }\n  .screen-md-sm[_ngcontent-%COMP%] {\n    display: block;\n  }\n  .he_menu[_ngcontent-%COMP%]   .nav[_ngcontent-%COMP%] {\n    display: none;\n  }\n  .he_footer[_ngcontent-%COMP%]   ul.he_footer_redes[_ngcontent-%COMP%]   li[_ngcontent-%COMP%] {\n    margin: 35px 10px 0px 10px;\n  }\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbImZvb3Rlci5jb21wb25lbnQuY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0UsbUJBQW1CO0VBQ25CLGdCQUFnQjtBQUNsQjtBQUNBOzs7OztFQUtFLFdBQVc7QUFDYjtBQUNBO0VBQ0UsZUFBZTtBQUNqQjtBQUNBO0VBQ0UsaUJBQWlCO0VBQ2pCLGlCQUFpQjtBQUNuQjtBQUNBOztFQUVFLHNCQUFzQjtBQUN4QjtBQUVBO0VBQ0UsV0FBVztFQUNYLGlCQUFpQjtBQUNuQjtBQUNBO0VBQ0UsZUFBZTtBQUNqQjtBQUNBO0VBQ0UsK0NBQStDO0VBQy9DLGFBQWE7RUFDYixrQ0FBa0M7RUFDbEMsaUJBQWlCO0VBQ2pCLGNBQWM7RUFDZCxVQUFVO0VBQ1YsZUFBZTtBQUNqQjtBQUNBOztFQUVFLGtCQUFrQjtBQUNwQjtBQUVBO0VBQ0Usa0JBQWtCO0FBQ3BCO0FBQ0E7RUFDRSwrQkFBK0I7QUFDakM7QUFDQTtFQUNFLDZCQUE2QjtBQUMvQjtBQUVBO0VBQ0UsV0FBVztBQUNiO0FBQ0E7RUFDRSxnQkFBZ0I7RUFDaEIsbUJBQW1CO0FBQ3JCO0FBQ0E7RUFDRSxZQUFZO0FBQ2Q7QUFDQTtFQUNFLFlBQVk7QUFDZDtBQUVBO0VBQ0UsU0FBUztFQUNULFVBQVU7RUFDVixhQUFhO0VBQ2IsdUJBQXVCO0FBQ3pCO0FBQ0E7RUFDRSxTQUFTO0FBQ1g7QUFDQTtFQUNFLFdBQVc7RUFDWCwwQkFBMEI7RUFDMUIsWUFBWTtFQUNaLGdCQUFnQjtFQUNoQixnQkFBZ0I7QUFDbEI7QUFDQTtFQUNFLFlBQVk7RUFDWixnQkFBZ0I7QUFDbEI7QUFFQTtFQUNFLDRCQUE0QjtFQUM1Qiw0QkFBNEI7QUFDOUI7QUFDQTtFQUNFLDBCQUEwQjtFQUMxQiwwQkFBMEI7QUFDNUI7QUFDQTtFQUNFLDJCQUEyQjtBQUM3QjtBQUVBO0VBQ0U7SUFDRSxhQUFhO0VBQ2Y7RUFDQTtJQUNFLGFBQWE7RUFDZjtFQUNBO0lBQ0UsY0FBYztFQUNoQjtFQUNBO0lBQ0UsYUFBYTtFQUNmO0FBQ0Y7QUFFQTtFQUNFO0lBQ0UsYUFBYTtFQUNmO0VBQ0E7SUFDRSxjQUFjO0VBQ2hCO0VBQ0E7SUFDRSxhQUFhO0VBQ2Y7RUFDQTtJQUNFLGNBQWM7RUFDaEI7RUFDQTtJQUNFLGdCQUFnQjtFQUNsQjtFQUNBO0lBQ0Usa0JBQWtCO0VBQ3BCO0VBQ0E7SUFDRSxnQ0FBZ0M7RUFDbEM7RUFDQTs7SUFFRSxhQUFhO0VBQ2Y7QUFDRjtBQUVBO0VBQ0U7SUFDRSxjQUFjO0VBQ2hCO0VBQ0E7SUFDRSxhQUFhO0VBQ2Y7RUFDQTtJQUNFLGFBQWE7RUFDZjtFQUNBO0lBQ0UsY0FBYztFQUNoQjtFQUNBO0lBQ0UsYUFBYTtFQUNmO0VBQ0E7SUFDRSwwQkFBMEI7RUFDNUI7QUFDRiIsImZpbGUiOiJmb290ZXIuY29tcG9uZW50LmNzcyIsInNvdXJjZXNDb250ZW50IjpbIiNmb290ZXIge1xuICBiYWNrZ3JvdW5kOiAjMjUyNzMzO1xuICBtYXJnaW4tdG9wOiA1MHB4O1xufVxuI2Zvb3RlciBoMSxcbiNmb290ZXIgaDIsXG4jZm9vdGVyIGgzLFxuI2Zvb3RlciBoNCxcbiNmb290ZXIgaDUge1xuICBjb2xvcjogI2ZmZjtcbn1cbiNmb290ZXIgLmxvZ28gaW1nIHtcbiAgbWF4LXdpZHRoOiAxMDAlO1xufVxuI2Zvb3RlciA+IC5jb250YWluZXIgPiAucm93IHtcbiAgcGFkZGluZy10b3A6IDMycHg7XG4gIHBhZGRpbmctdG9wOiAycmVtO1xufVxuI2Zvb3RlciBsaSxcbiNmb290ZXIgbGkgYSB7XG4gIGNvbG9yOiAjOTk5ICFpbXBvcnRhbnQ7XG59XG5cbi5jb250YWluZXIteGwge1xuICB3aWR0aDogMTAwJTtcbiAgbWF4LXdpZHRoOiAxNDQwcHg7XG59XG4uY29udGFpbmVyLXhsIHVsIHtcbiAgZm9udC1zaXplOiAxNHB4O1xufVxuLmhlX2Zvb3RlciB7XG4gIGJhY2tncm91bmQ6ICMzMzY2Y2MgMCUgMCUgbm8tcmVwZWF0IHBhZGRpbmctYm94O1xuICBwYWRkaW5nOiAzNXB4O1xuICBmb250OiBSZWd1bGFyIDEycHgvMTRweCBNb250c2VycmF0O1xuICBsZXR0ZXItc3BhY2luZzogMDtcbiAgY29sb3I6ICNmZmZmZmY7XG4gIG9wYWNpdHk6IDE7XG4gIGZvbnQtc2l6ZTogMTJweDtcbn1cbi5oZV9mb290ZXIgLnNwbGl0LFxuLmhlX2Zvb3RlciAubm8tc3BsaXQge1xuICBwYWRkaW5nOiAxNXB4IDI1cHg7XG59XG5cbi5oZV9mb290ZXIgLmxvZ29zIHtcbiAgdGV4dC1hbGlnbjogY2VudGVyO1xufVxuLmhlX2Zvb3RlciAuc3BsaXQge1xuICBib3JkZXItcmlnaHQ6IDFweCBzb2xpZCAjZmZmZmZmO1xufVxuLmhlX2Zvb3RlciAuc3BsaXQtdG9wIHtcbiAgYm9yZGVyLXRvcDogMXB4IHNvbGlkICNmZmZmZmY7XG59XG5cbi5oZV9mb290ZXIgLmxvZ29zX21vdmlsIC5sb2dvIHtcbiAgZmxvYXQ6IGxlZnQ7XG59XG4uaGVfZm9vdGVyIC5sb2dvIHtcbiAgbWFyZ2luLXRvcDogMTBweDtcbiAgbWFyZ2luLWJvdHRvbTogMjBweDtcbn1cbi5oZV9mb290ZXIgLmxvZ28gaW1nIHtcbiAgaGVpZ2h0OiAzMHB4O1xufVxuLmhlX2Zvb3RlciAubG9nb3NfbW92aWwgLmxvZ29fY28ge1xuICBmbG9hdDogcmlnaHQ7XG59XG5cbi5oZV9mb290ZXJfcmVkZXMge1xuICBtYXJnaW46IDA7XG4gIHBhZGRpbmc6IDA7XG4gIGRpc3BsYXk6IGZsZXg7XG4gIGp1c3RpZnktY29udGVudDogY2VudGVyO1xufVxuLmhlX2Zvb3RlciBwIHtcbiAgbWFyZ2luOiAwO1xufVxuLmhlX2Zvb3RlciB1bC5oZV9mb290ZXJfcmVkZXMgbGkge1xuICBmbG9hdDogbGVmdDtcbiAgbWFyZ2luOiAzNXB4IDExcHggMHB4IDExcHg7XG4gIGhlaWdodDogNTBweDtcbiAgb3ZlcmZsb3c6IGhpZGRlbjtcbiAgbGlzdC1zdHlsZTogbm9uZTtcbn1cbi5oZV9mb290ZXIgdWwuaGVfZm9vdGVyX3JlZGVzIGxpIC5mYV90ZXh0IHtcbiAgZmxvYXQ6IHJpZ2h0O1xuICBwYWRkaW5nLXRvcDogN3B4O1xufVxuXG4udGV4dC0xIHtcbiAgZm9udC1zaXplOiAxMi44cHggIWltcG9ydGFudDtcbiAgZm9udC1zaXplOiAwLjhyZW0gIWltcG9ydGFudDtcbn1cbi50ZXh0LTMge1xuICBmb250LXNpemU6IDE2cHggIWltcG9ydGFudDtcbiAgZm9udC1zaXplOiAxcmVtICFpbXBvcnRhbnQ7XG59XG4uZm9udC13ZWlnaHQtc2VtaWJvbGQge1xuICBmb250LXdlaWdodDogNjAwICFpbXBvcnRhbnQ7XG59XG5cbkBtZWRpYSBvbmx5IHNjcmVlbiBhbmQgKG1pbi13aWR0aDogOTkycHgpIHtcbiAgLnNjcmVlbi1zbSB7XG4gICAgZGlzcGxheTogbm9uZTtcbiAgfVxuICAuc2NyZWVuLW1kIHtcbiAgICBkaXNwbGF5OiBub25lO1xuICB9XG4gIC5zY3JlZW4tbGcge1xuICAgIGRpc3BsYXk6IGJsb2NrO1xuICB9XG4gIC5zY3JlZW4tbWQtc20ge1xuICAgIGRpc3BsYXk6IG5vbmU7XG4gIH1cbn1cblxuQG1lZGlhIG9ubHkgc2NyZWVuIGFuZCAobWF4LXdpZHRoOiA5OTFweCkge1xuICAuc2NyZWVuLXNtIHtcbiAgICBkaXNwbGF5OiBub25lO1xuICB9XG4gIC5zY3JlZW4tbWQge1xuICAgIGRpc3BsYXk6IGJsb2NrO1xuICB9XG4gIC5zY3JlZW4tbGcge1xuICAgIGRpc3BsYXk6IG5vbmU7XG4gIH1cbiAgLnNjcmVlbi1tZC1zbSB7XG4gICAgZGlzcGxheTogYmxvY2s7XG4gIH1cbiAgLmhlX21lbnUgLm5hdi1saW5rIHtcbiAgICBwYWRkaW5nOiAwcHggNXB4O1xuICB9XG4gIC5oZV9mb290ZXIgLnNwbGl0IHtcbiAgICBib3JkZXItcmlnaHQ6IG5vbmU7XG4gIH1cbiAgLmhlX2Zvb3RlciAuc3BsaXQge1xuICAgIGJvcmRlci1ib3R0b206IDFweCBzb2xpZCAjZmZmZmZmO1xuICB9XG4gIC5oZV9mb290ZXIgLnNwbGl0LFxuICAuaGVfZm9vdGVyIC5uby1zcGxpdCB7XG4gICAgcGFkZGluZzogMjVweDtcbiAgfVxufVxuXG5AbWVkaWEgb25seSBzY3JlZW4gYW5kIChtYXgtd2lkdGg6IDc2OHB4KSB7XG4gIC5zY3JlZW4tc20ge1xuICAgIGRpc3BsYXk6IGJsb2NrO1xuICB9XG4gIC5zY3JlZW4tbWQge1xuICAgIGRpc3BsYXk6IG5vbmU7XG4gIH1cbiAgLnNjcmVlbi1sZyB7XG4gICAgZGlzcGxheTogbm9uZTtcbiAgfVxuICAuc2NyZWVuLW1kLXNtIHtcbiAgICBkaXNwbGF5OiBibG9jaztcbiAgfVxuICAuaGVfbWVudSAubmF2IHtcbiAgICBkaXNwbGF5OiBub25lO1xuICB9XG4gIC5oZV9mb290ZXIgdWwuaGVfZm9vdGVyX3JlZGVzIGxpIHtcbiAgICBtYXJnaW46IDM1cHggMTBweCAwcHggMTBweDtcbiAgfVxufVxuIl19 */"] });


/***/ }),

/***/ 2735:
/*!***********************************************************!*\
  !*** ./src/app/shared/components/footer/footer.module.ts ***!
  \***********************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "FooterModule": () => (/* binding */ FooterModule)
/* harmony export */ });
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ 4666);
/* harmony import */ var _footer_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./footer.component */ 6526);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ 2560);



class FooterModule {
}
FooterModule.ɵfac = function FooterModule_Factory(t) { return new (t || FooterModule)(); };
FooterModule.ɵmod = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineNgModule"]({ type: FooterModule });
FooterModule.ɵinj = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineInjector"]({ imports: [_angular_common__WEBPACK_IMPORTED_MODULE_2__.CommonModule] });
(function () { (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵsetNgModuleScope"](FooterModule, { declarations: [_footer_component__WEBPACK_IMPORTED_MODULE_0__.FooterComponent], imports: [_angular_common__WEBPACK_IMPORTED_MODULE_2__.CommonModule], exports: [_footer_component__WEBPACK_IMPORTED_MODULE_0__.FooterComponent] }); })();


/***/ }),

/***/ 6290:
/*!**************************************************************!*\
  !*** ./src/app/shared/components/header/header.component.ts ***!
  \**************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "HeaderComponent": () => (/* binding */ HeaderComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var _services_header_service__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../../services/header.service */ 6690);


class HeaderComponent {
    constructor(headerService) {
        this.headerService = headerService;
        this.title = '';
    }
    ngOnInit() {
        this.headerService.changeTitle.subscribe((title) => {
            this.title = title;
        });
    }
}
HeaderComponent.ɵfac = function HeaderComponent_Factory(t) { return new (t || HeaderComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdirectiveInject"](_services_header_service__WEBPACK_IMPORTED_MODULE_0__.HeaderService)); };
HeaderComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineComponent"]({ type: HeaderComponent, selectors: [["app-header"]], hostVars: 2, hostBindings: function HeaderComponent_HostBindings(rf, ctx) { if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵclassProp"]("is-open", ctx.title);
    } }, decls: 5, vars: 1, consts: [[1, "content-header", "d-flex", "justify-content-between", "align-items-end", "ps-5", "pe-5"], ["src", "../../../../assets/img/logo-full-spe.png", "alt", "logo servicio p\u00FAblico de empleo", 1, "logo-spe", "img-fluid"], [1, "Futura_Std_Bold"], ["src", "../../../../assets/img/logo-full-mt.png", "alt", "logo ministerio del trabajo", 1, "logo-mt", "img-fluid", "mb-4"]], template: function HeaderComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "header", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](1, "img", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](2, "h1", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](4, "img", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtextInterpolate"](ctx.title);
    } }, styles: [".content-header[_ngcontent-%COMP%] {\n  border-bottom: 3px solid #595a5c;\n}\n.content-header[_ngcontent-%COMP%]   h1[_ngcontent-%COMP%] {\n  font-size: 4vw;\n  letter-spacing: 0px;\n  color: #707070;\n  opacity: 1;\n}\n.logo-spe[_ngcontent-%COMP%] {\n  max-height: 130px;\n  object-fit: cover;\n  object-position: bottom;\n}\n.logo-mt[_ngcontent-%COMP%] {\n  max-height: 70px;\n  object-fit: cover;\n  object-position: bottom;\n}\n@media only screen and (min-width: 900px) {\n  .content-header[_ngcontent-%COMP%]   h1[_ngcontent-%COMP%] {\n    font-size: 44px;\n  }\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbImhlYWRlci5jb21wb25lbnQuY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0UsZ0NBQWdDO0FBQ2xDO0FBQ0E7RUFDRSxjQUFjO0VBQ2QsbUJBQW1CO0VBQ25CLGNBQWM7RUFDZCxVQUFVO0FBQ1o7QUFDQTtFQUNFLGlCQUFpQjtFQUNqQixpQkFBaUI7RUFDakIsdUJBQXVCO0FBQ3pCO0FBQ0E7RUFDRSxnQkFBZ0I7RUFDaEIsaUJBQWlCO0VBQ2pCLHVCQUF1QjtBQUN6QjtBQUVBO0VBQ0U7SUFDRSxlQUFlO0VBQ2pCO0FBQ0YiLCJmaWxlIjoiaGVhZGVyLmNvbXBvbmVudC5jc3MiLCJzb3VyY2VzQ29udGVudCI6WyIuY29udGVudC1oZWFkZXIge1xuICBib3JkZXItYm90dG9tOiAzcHggc29saWQgIzU5NWE1Yztcbn1cbi5jb250ZW50LWhlYWRlciBoMSB7XG4gIGZvbnQtc2l6ZTogNHZ3O1xuICBsZXR0ZXItc3BhY2luZzogMHB4O1xuICBjb2xvcjogIzcwNzA3MDtcbiAgb3BhY2l0eTogMTtcbn1cbi5sb2dvLXNwZSB7XG4gIG1heC1oZWlnaHQ6IDEzMHB4O1xuICBvYmplY3QtZml0OiBjb3ZlcjtcbiAgb2JqZWN0LXBvc2l0aW9uOiBib3R0b207XG59XG4ubG9nby1tdCB7XG4gIG1heC1oZWlnaHQ6IDcwcHg7XG4gIG9iamVjdC1maXQ6IGNvdmVyO1xuICBvYmplY3QtcG9zaXRpb246IGJvdHRvbTtcbn1cblxuQG1lZGlhIG9ubHkgc2NyZWVuIGFuZCAobWluLXdpZHRoOiA5MDBweCkge1xuICAuY29udGVudC1oZWFkZXIgaDEge1xuICAgIGZvbnQtc2l6ZTogNDRweDtcbiAgfVxufVxuIl19 */"] });


/***/ }),

/***/ 3778:
/*!***********************************************************!*\
  !*** ./src/app/shared/components/header/header.module.ts ***!
  \***********************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "HeaderModule": () => (/* binding */ HeaderModule)
/* harmony export */ });
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ 4666);
/* harmony import */ var _header_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./header.component */ 6290);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ 2560);



class HeaderModule {
}
HeaderModule.ɵfac = function HeaderModule_Factory(t) { return new (t || HeaderModule)(); };
HeaderModule.ɵmod = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineNgModule"]({ type: HeaderModule });
HeaderModule.ɵinj = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineInjector"]({ imports: [_angular_common__WEBPACK_IMPORTED_MODULE_2__.CommonModule] });
(function () { (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵsetNgModuleScope"](HeaderModule, { declarations: [_header_component__WEBPACK_IMPORTED_MODULE_0__.HeaderComponent], imports: [_angular_common__WEBPACK_IMPORTED_MODULE_2__.CommonModule], exports: [_header_component__WEBPACK_IMPORTED_MODULE_0__.HeaderComponent] }); })();


/***/ }),

/***/ 5307:
/*!***************************************!*\
  !*** ./src/app/shared/date-format.ts ***!
  \***************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "NgbDateCustomParserFormatter": () => (/* binding */ NgbDateCustomParserFormatter)
/* harmony export */ });
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ 4534);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ 2560);


class NgbDateCustomParserFormatter extends _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_0__.NgbDateParserFormatter {
    constructor() {
        super(...arguments);
        this.DELIMITER = '/';
    }
    parse(value) {
        if (value) {
            let date = value.split(this.DELIMITER);
            return {
                day: parseInt(date[0], 10),
                month: parseInt(date[1], 10),
                year: parseInt(date[2], 10)
            };
        }
        return null;
    }
    format(date) {
        return date ? date.day + this.DELIMITER + date.month + this.DELIMITER + date.year : '';
    }
}
NgbDateCustomParserFormatter.ɵfac = /*@__PURE__*/ function () { let ɵNgbDateCustomParserFormatter_BaseFactory; return function NgbDateCustomParserFormatter_Factory(t) { return (ɵNgbDateCustomParserFormatter_BaseFactory || (ɵNgbDateCustomParserFormatter_BaseFactory = _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵgetInheritedFactory"](NgbDateCustomParserFormatter)))(t || NgbDateCustomParserFormatter); }; }();
NgbDateCustomParserFormatter.ɵprov = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineInjectable"]({ token: NgbDateCustomParserFormatter, factory: NgbDateCustomParserFormatter.ɵfac });


/***/ }),

/***/ 7531:
/*!***********************************************!*\
  !*** ./src/app/shared/password-validators.ts ***!
  \***********************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "PasswordValidators": () => (/* binding */ PasswordValidators)
/* harmony export */ });
class PasswordValidators {
    constructor() { }
    static patternValidator(regex, error) {
        return (control) => {
            if (!control.value) {
                // if the control value is empty return no error.
                return null;
            }
            // test the value of the control against the regexp supplied.
            const valid = regex.test(control.value);
            // if true, return no error, otherwise return the error object passed in the second parameter.
            return valid ? null : error;
        };
    }
    static MatchValidator(control) {
        const password = control.get('password').value; // get password from our password form control
        const confirmPassword = control.get('confirmPassword').value; // get password from our confirmPassword form control
        // if the confirmPassword value is null or empty, don't return an error.
        if (!confirmPassword?.length) {
            return null;
        }
        // if the confirmPassword length is < 8, set the minLength error.
        if (confirmPassword.length < 8) {
            control.get('confirmPassword').setErrors({ minLength: true });
        }
        else {
            // compare the passwords and see if they match.
            if (password !== confirmPassword) {
                control.get("confirmPassword").setErrors({ mismatch: true });
            }
            else {
                // if passwords match, don't return an error.
                return null;
            }
        }
        return null;
    }
}


/***/ }),

/***/ 2340:
/*!*****************************************!*\
  !*** ./src/environments/environment.ts ***!
  \*****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "environment": () => (/* binding */ environment)
/* harmony export */ });
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
const urlAPI = "/api";
const environment = {
    production: false,
    recaptcha: {
        // siteKey: '6LfBHAAjAAAAAHNKBrGq9B4SCjRsjC_uMF5kBVQf',
        siteKey: '6LfZY1gjAAAAAHHIdN3-28jbibhHbWuHp7ICV0Lt',
    },
    urlAPI,
    syncfusion_lincense: "ORg4AjUWIQA/Gnt2VVhjQlFaclhJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxRd0djUX5adXFXQWleU0c="
};
/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/plugins/zone-error';  // Included with Angular CLI.


/***/ }),

/***/ 4431:
/*!*********************!*\
  !*** ./src/main.ts ***!
  \*********************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/platform-browser */ 4497);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ 2560);
/* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./app/app.module */ 6747);
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./environments/environment */ 2340);
/* harmony import */ var _syncfusion_ej2_base__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @syncfusion/ej2-base */ 699);





(0,_syncfusion_ej2_base__WEBPACK_IMPORTED_MODULE_2__.registerLicense)(_environments_environment__WEBPACK_IMPORTED_MODULE_1__.environment.syncfusion_lincense);
if (_environments_environment__WEBPACK_IMPORTED_MODULE_1__.environment.production) {
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_3__.enableProdMode)();
}
_angular_platform_browser__WEBPACK_IMPORTED_MODULE_4__.platformBrowser().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_0__.AppModule)
    .catch(err => console.error(err));


/***/ })

},
/******/ __webpack_require__ => { // webpackRuntimeModules
/******/ var __webpack_exec__ = (moduleId) => (__webpack_require__(__webpack_require__.s = moduleId))
/******/ __webpack_require__.O(0, ["vendor"], () => (__webpack_exec__(1211), __webpack_exec__(4431)));
/******/ var __webpack_exports__ = __webpack_require__.O();
/******/ }
]);
//# sourceMappingURL=main.js.map