import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { HeaderService } from 'src/app/services/header.service';

/**
 * @todo: Sacar esta enumeración de aquí
 */
export enum ACCION_VACANTE{
  NUEVA = "NUEVA",
  EN_PROCESO = "EN_PROCESO",
  COPIA = "COPIA"
}
@Component({
  selector: 'app-seleccionar-tipo-registro-vacante',
  templateUrl: './seleccionar-tipo-registro-vacante.component.html',
  styleUrls: ['./seleccionar-tipo-registro-vacante.component.scss']
})
export class SeleccionarTipoRegistroVacanteComponent implements OnInit {
  public ACCION_VACANTE = ACCION_VACANTE;
  public accionVacanteControl = new FormControl(
    ACCION_VACANTE.NUEVA,[Validators.required]
  );
  constructor(public headerService:HeaderService, private router: Router) { }

  ngOnInit(): void {
    this.headerService.changeTitle.emit("Registrar Vacante");
  }
  routerLink="/empresas/registrar-vacante"
  public navegar(){
    if(this.accionVacanteControl.value == ACCION_VACANTE.NUEVA){
      this.router.navigate(["/empresas/registrar-vacante"]);
    }else{
      this.router.navigate(["/empresas/listado-vacantes",this.accionVacanteControl.value]);
    }
  }
}
