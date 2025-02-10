import { EventEmitter, Injectable, Output } from '@angular/core';
import { of, Observable } from "rxjs";
import {
  HttpClient,
  HttpHeaders,
  HttpErrorResponse,
  HttpResponse,
} from "@angular/common/http";

import { environment } from "../../environments/environment";
import { Ciudadano, CreateRequest } from "../model/ciudadano";

@Injectable({
  providedIn: 'root'
})
export class RegisterService {

  showBasicData: boolean = false;
  showAddNotifications: boolean = false;
  validateData: any | undefined;
  registerData: any | undefined;

  @Output() change: EventEmitter<boolean> = new EventEmitter();
  @Output() changeNoti: EventEmitter<boolean> = new EventEmitter();
  @Output() disableTab: EventEmitter<number[]> = new EventEmitter();

  constructor() { }

  public changeShowBasicData() {
    this.showBasicData = true;
    this.change.emit(this.showBasicData);
  }

  public changeShowAddNotifications() {
    this.showAddNotifications = true;
    this.changeNoti.emit(this.showAddNotifications);
  }

  public disableTabsByTab(tabs: number[]) {
    this.disableTab.emit(tabs);
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
  putRegisterData(data: any, type: string) {
    // Valida si hay algo en data
    if (data) {
      // En caso de la variable estar undefined entonces la inicializa con toda la data
      switch (type) {
        case 'validate':
          if (this.validateData == undefined) {
            this.validateData = data;
          } else {
            for (const key in data) {
              if (Object.prototype.hasOwnProperty.call(data, key)) {
                this.validateData[key] = data[key];
              }
            }
          }
          break;
        case 'register':
          if (this.registerData == undefined) {
            this.registerData = data
          } else {
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

  getListNombresCamposForm(): any {
    return {
      "password": "Contraseña", confirmPassword: "Confirmar contraseña", primerNombre: "Primer nombre", segundoNombre: "Segundo nombre",
      primerApellido: "Primer apellido", segundoApellido: "Segundo apellido", fechaNacimiento: "Fecha de nacimiento", sexoId: "Sexo",
      telefono: "Teléfono celular", otroTelefono: "Teléfono fijo", direccionResidencia: "Dirección de residencia", paisResidenciaId: "País de residencia",
      departamentoResidenciaId: "Departamento", municipioResidenciaId: "Municipio", prestadorPreferenciaId: "Prestador de preferencia", puntoAtencionId: "Punto de atención",
      perteneceARural: "Pertenece a", preguntaSeguridadId: "Pregunta de seguridad", preguntaSeguridadRespuesta: "Respuesta", terminosCondiciones: "Términos y condiciones", tratamientoDatosPersonales: "Tratamiento de datos",
      viaPrincipalId: "Vía principal", viaPrincipal: "Número vía principal", viaGeneradora: "Vía generadora", viaGeneradoraPlaca: "Vía generadora placa", tipoNotificacion: "Medio de notificación",
      estado: "Estado", ciudad: "Ciudad", fechaExpedicionDocumento: "Fecha de expedición del documento",localidadComunaId:"Localidad/Comuna",barrioResidencia:" Barrio de residencia"
    };
  }

  /**
   * Funcion que se encarga de convertir un objeto fecha a strind de acuerdo al formato de guardado del API
   */
  public convertSringDate(date: any): string | any {
    if (date !== '' && date !== undefined && date !== null) {
      const month = date.month < 10 ? '0' + date.month : date.month;
      const day = date.day < 10 ? '0' + date.day : date.day;
      return date.year + '-' + month + '-' + day;
    } else {
      return null;
    }
  }
  /**
   * Función que se encarga de convertir una fecha string a objeto para ser mostado en los campos de fecha
   */
  public convertStringToDate(dateStrFull: string | null | undefined) {
    if (dateStrFull !== '' && dateStrFull !== null && dateStrFull !== undefined) {
      // Format 2014-12-25T00:00:00
      const date = new Date(dateStrFull);
      return { year: date.getFullYear(), month: date.getMonth() + 1, day: date.getDate() };
    }
    return undefined;
  }

}
