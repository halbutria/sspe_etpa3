import { Injectable } from '@angular/core';
import { of, Observable, Subscriber } from "rxjs";
import {
  HttpClient,
  HttpHeaders,
  HttpErrorResponse,
  HttpResponse,
} from "@angular/common/http";

import { environment } from "../../environments/environment";
import { Prestador, PuntoAtencion } from "../model/prestador";

@Injectable({
  providedIn: 'root'
})
export class PrestadorService {

  constructor(private http: HttpClient) { }

  /**
   * Funcion que consulta los prestadores al API
   */
  public getPrestadoresByDepto(depto: number): Observable<Prestador[]> {
    const url = `${environment.urlPrestador}/Prestador/lista/${depto}`;
    return this.http.get<Prestador[]>(url);
  }

  /**
   * Funcion que consulta los puntos de atencion del API
   */
  public getPuntosAtencionByPrestador(punto: string): Observable<PuntoAtencion[]> {
    const url = `${environment.urlPrestador}/PuntoAtencion/lista/${punto}`;
    return this.http.get<PuntoAtencion[]>(url);
  }

  /**
   * Función que agrega los prestadores al storage
   */
  public setPrestadoresStorage(prestadores: Prestador[]) {
    sessionStorage.setItem('Prestadores', JSON.stringify(prestadores));
  }

  /**
   * Función que devuelve el listado de prestadores almacenados en storage
   * Y si no existe entonces los consulta del API
   */
  get getPrestadores() {
    return new Observable(
      (subscriber: Subscriber<Prestador[]>) => {
        try {
          let listPrestadores: Prestador[];
          const prestadoresStorage = this.getPrestadoresStorage;
          if (prestadoresStorage.length > 0) {
            listPrestadores = prestadoresStorage;
            subscriber.next(listPrestadores);
            subscriber.complete();
          } else {
            this.getPrestadoresByDepto(0).subscribe(
              (response) => {
                listPrestadores = response;
                this.setPrestadoresStorage(listPrestadores);
                subscriber.next(listPrestadores);
                subscriber.complete();
              }
            );
          }
        } catch (error) {
          subscriber.error(error);
        }
      }
    );
  }

  get getPrestadoresStorage() {
    let prestadores: Prestador[] = [];
    const prestadorSession = sessionStorage.getItem('Prestadores');
    if (prestadorSession) {
      prestadores = JSON.parse(prestadorSession);
    }
    return prestadores;
  }

  /**
   * Función que agrega los prestadores al storage
   */
  public setPuntosAtencionStorage(puntos: PuntoAtencion[]) {
    sessionStorage.setItem('PuntosAtencion', JSON.stringify(puntos));
  }

  /**
   * Función que devuelve el listado de prestadores almacenados en storage
   */
  get getPuntosAtencionStorage() {
    let puntos: PuntoAtencion[] = [];
    const puntosSession = sessionStorage.getItem('PuntosAtencion');
    if (puntosSession) {
      puntos = JSON.parse(puntosSession);
    }
    return puntos;
  }
}

