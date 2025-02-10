import { Injectable } from '@angular/core';
import { of, Observable } from "rxjs";
import {
  HttpClient,
  HttpHeaders,
  HttpErrorResponse,
  HttpResponse,
  HttpUrlEncodingCodec,
} from "@angular/common/http";

import { environment } from "../../environments/environment";
import { Ciudadano, CreateRequest } from "../model/ciudadano";

@Injectable({
  providedIn: 'root'
})
export class CiudadanoService {

  constructor(private http: HttpClient) { }

  public validateCiudadano(tipo: string, num: string): Observable<any> {
    const url = `${environment.urlCiudadano}/Ciudadano/existe?TipoDocumentoId=${tipo}&NumeroDocumento=${num}`;
    return this.http.get<any>(url);
  }

  public validateCiudadanoRegistro(tipo: string, num: string, email: string): Observable<any> {
    const codec = new HttpUrlEncodingCodec();
    const url = `${environment.urlCiudadano}/VerificarCuenta?TipoDocumentoId=${tipo}&NumeroDocumento=${num}&email=${codec.encodeValue(email)}`;
    return this.http.get<any>(url);
  }

  public validatePin(tipo: string, num: string, email: string, key: number, pin: number): Observable<any> {
    const codec = new HttpUrlEncodingCodec();
    const url = `${environment.urlCiudadano}/VerificarCuenta/verificarPin?TipoDocumentoId=${tipo}&NumeroDocumento=${num}&email=${codec.encodeValue(email)}&key=${key}&pin=${pin}`;
    return this.http.get<any>(url);
  }

  public saveDataCiudadano(ciudadano: CreateRequest): Observable<Ciudadano> {
    const url = `${environment.urlCiudadano}/Ciudadano`;
    return this.http.post<Ciudadano>(url, ciudadano);
  }

  public putSaveCiudadano(ciudadano: CreateRequest): Observable<Ciudadano> {
    const url = `${environment.urlCiudadano}/Ciudadano`;
    return this.http.put<Ciudadano>(url, ciudadano);
  }
}
