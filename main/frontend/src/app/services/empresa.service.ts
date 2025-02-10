import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Empresa, Sede } from './empresa';

@Injectable({
  providedIn: 'root'
})
export class EmpresaService {

  constructor(private http:HttpClient) { }

  public getEmpresaByEmpresaID(empresaId:number): Observable<Empresa> {
    const url = `${environment.urlAPI}/Empresa?Id=${empresaId}`;
    return this.http.get<Empresa>(url);
  }

  public getEmpresaSedeBySedeID(sedeId:number){
    const url = `${environment.urlAPI}/EmpresaSede/${sedeId}`;
    return this.http.get<Sede>(url);
  }
}
