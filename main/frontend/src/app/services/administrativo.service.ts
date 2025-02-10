import { EventEmitter, Injectable, Output } from '@angular/core';
import { of, Observable, map, BehaviorSubject } from "rxjs";

import {
  HttpClient,
  HttpHeaders,
  HttpErrorResponse,
  HttpResponse,
} from "@angular/common/http";

import { environment } from "../../environments/environment";
import { Parametrico } from 'src/app/model/parametricos';
import { ParametricosAdmin } from "src/app/administrativo/domain/dto/parametricos-admin";
import { PARAMETRICOS, ParametricosService, PARAMETRICOS_FILTROS } from 'src/app/services/parametricos.service';

@Injectable({
  providedIn: 'root'
})
export class AdministrativoService {

  // Behavior subject que almacena el parametrico y proporciona un metodo para actualizarlo
  private parametricoSubject = new BehaviorSubject<ParametricosAdmin | null>(null);
  private currentParametrico: ParametricosAdmin | null = null;

  constructor(
    private http: HttpClient,
    public parametricosService: ParametricosService
  ) {
  }

  public getCurrentParametrico(): ParametricosAdmin | null {
    return this.currentParametrico;
  }

  /**
   * Función que proporciona la forma para actualizar el valor
   */
  public getParametrico$() {
    return this.parametricoSubject.asObservable();
  }

  /**
   * Función que se encarga de actualizar el parametrico actual sobre los componentes
   */
  public updateParametrico(newParametrico: ParametricosAdmin) {
    this.parametricoSubject.next(newParametrico);
    this.currentParametrico = newParametrico;
  }

  /**
   * Función que se encarga de consumir el API para crear un registro sobre un parametrico
   * @param id
   * @param parametricoStr
   * @returns
   */
  public saveNewParametrico(parametricoForm: Parametrico, parametricoStr: string | undefined): Observable<any> {
    const url = `${environment.urlParametrico}/parametrico/${parametricoStr}`;
    return this.http.post<Parametrico>(url, parametricoForm);
  }

  /**
   * Función que se encarga de consumir el API para editar un registro sobre un parametrico
   * @param id
   * @param parametricoStr
   * @returns
   */
  public saveEditParametrico(parametricoForm: Parametrico, parametricoStr: string | undefined): Observable<any> {
    const url = `${environment.urlParametrico}/parametrico/${parametricoStr}`;
    return this.http.put<Parametrico>(url, parametricoForm);
  }

  /**
   * Función que se encarga de consumir el API para eliminar un registro en un parametrico
   * @param id
   * @param parametricoStr
   * @returns
   */
  public deleteParametrico(id: string, parametricoStr: string | undefined): Observable<any> {
    const url = `${environment.urlParametrico}/parametrico/${parametricoStr}/${id}`;
    return this.http.delete(url);
  }

  /**
   * Función que consulta al API para obtener niveles educativos por institucion
   */
  public getNivelByInstitucion(institucionId: any): Observable<any> {
    const url = `${environment.urlParametrico}/parametrico/ObtenerNivelesEducativosPorInstitucion/${institucionId}`;
    return this.http.get(url);
  }

  /**
   * Función que consulta al API para obtener las instituciones por un nivel educativo
   */
  public getInstitucionesByNivel(nivelEducativoId: number): Observable<Parametrico[]> {
    const url = `${environment.urlParametrico}/parametrico/ObtenerInstitucionesPorNivelEducativo/${nivelEducativoId}`;
    return this.http.get<Parametrico[]>(url);
  }

  /**
   * Función que consume el API para eliminar la asociación de instituciones y niveles educativos
   */
  public deleteAsociacionInstitucionesNiveles(nivelEducativoId: string | number, institucionId: string | number): Observable<any> {
    const url = `${environment.urlParametrico}/parametrico/EliminarAsociacionInstitucionNivelEducativo/${nivelEducativoId}/${institucionId}`;
    return this.http.delete<any>(url);
  }

  /**
   * Función que consume el API para asociar una institución y nivel educativo
   */
  public associateInstitucionNivelEducativo(nivelEducativoId: string | number, institucionId: string | number): Observable<any> {
    const url = `${environment.urlParametrico}/parametrico/AsociarInstitucionNivelEducativo`;
    return this.http.post<any>(url, { institucionId, nivelEducativoId });
  }

}
