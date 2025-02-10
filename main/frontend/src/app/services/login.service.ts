import { Injectable } from '@angular/core';
import { of, Observable } from "rxjs";
import {
  HttpClient,
  HttpHeaders,
  HttpErrorResponse,
  HttpResponse,
} from "@angular/common/http";

import { environment } from "../../environments/environment";
import { CiudadanoGet } from "../model/ciudadano";

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(private http: HttpClient) { }

  /**
   * Funcion que consulta si existe y toda la información de un ciudadano por tipo y documento
   */
  public getCiudadanoByTipoNumero(tipo: string, numero: string): Observable<CiudadanoGet> {
    const url = `${environment.urlCiudadano}/Ciudadano?TipoDocumentoId=${tipo}&NumeroDocumento=${numero}`;
    return this.http.get<CiudadanoGet>(url);
  }
}
