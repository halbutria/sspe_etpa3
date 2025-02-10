import { Component, Input, OnInit } from '@angular/core';
import { NgbActiveModal, NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { VacanteDetalle, VacanteLista } from 'src/app/empresas/use-cases/listado-vacantes.service';
import { ParametricosService, PARAMETRICOS_FILTROS,PARAMETRICOS  } from 'src/app/services/parametricos.service';
@Component({
  selector: 'app-vacante-detalle-lista',
  templateUrl: './vacante-detalle-lista.component.html',
  styleUrls: ['./vacante-detalle-lista.component.scss']
})
export class VacanteDetalleListaComponent implements OnInit {
  public VacanteSeleccionada!:VacanteLista;
  public VacanteDetalle!:VacanteDetalle;
  public PARAMETRICOS = PARAMETRICOS;
  public PARAMETRICOS_FILTROS = PARAMETRICOS_FILTROS;
  public SinInformacion = 'Sin información';
  public NombreVacante = "Sin Nombre"

  @Input() fromParent: any;
  
  constructor(
    public modalActiveService: NgbActiveModal,
    public parametricosSrv: ParametricosService, 
    ) { }

  ngOnInit(): void {
    this.VacanteSeleccionada = <VacanteLista>this.fromParent["VacanteSeleccionada"];
    this.VacanteDetalle = <VacanteDetalle>this.fromParent["VacanteDetalle"];
    this.NombreVacante = (this.VacanteSeleccionada.nombre == null || this.VacanteSeleccionada.nombre.length === 0 )?this.NombreVacante:this.VacanteSeleccionada.nombre;

   console.log(this.VacanteSeleccionada,this.VacanteDetalle);
    // let y= this.VacanteSeleccionada.fechaLimiteEnvioHv.getMonth();
    // console.log(y,this.fromParent,"perrito");
  }


  closeModal() {
    this.modalActiveService.close(null);
  }
}
