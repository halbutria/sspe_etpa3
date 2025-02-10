import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ListadoVacantesService, Paginacion, VacanteDetalle, VacanteLista } from '../../use-cases/listado-vacantes.service';
import { environment } from 'src/environments/environment';
import { catchError, map, throwError } from 'rxjs';
import { PARAMETRICOS, ParametricosService, PARAMETRICOS_FILTROS } from '../../../services/parametricos.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { VacanteDetalleListaComponent } from './components/vacante-detalle-lista/vacante-detalle-lista.component';
import { HeaderService } from 'src/app/services/header.service';
import { ModalNotificacionComponent } from './components/modal-notificacion/modal-notificacion.component';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-listado-vacantes',
  templateUrl: './listado-vacantes.component.html',
  styleUrls: ['./listado-vacantes.component.scss'],
  providers: [
    ListadoVacantesService
  ]
})
export class ListadoVacantesComponent implements OnInit {

  public PARAMETRICOS = PARAMETRICOS;
  public PARAMETRICOS_FILTROS = PARAMETRICOS_FILTROS;
  public cargando: boolean = true;
  public error: boolean = false;
  public vacantes: VacanteLista[] = [];
  public sedeId:number = 4;
  public estadoId?: number;
  public accion?: string;

  constructor(
    private route: ActivatedRoute,
    public parametricosSrv: ParametricosService, 
    public service: ListadoVacantesService, 
    private modalService: NgbModal,
    public http: HttpClient,
    public headerService:HeaderService) { }
    
  public cargarTabla(SedeId:number,EstadoId?:number) {
    this.cargando = true;
    this.service.consultarListadoVacantes(this.service.paginacion.PaginaActual, this.service.paginacion.RegistrosPorPagina,SedeId,EstadoId)
      .subscribe(
        (data) => {
          this.service.paginacion = <Paginacion>JSON.parse(data.headers.get('x-paginacion') ?? "");
          this.vacantes = <VacanteLista[]>data.body;
          this.error = false;
          console.log(this.service.paginacion);
        }, () => {
          // error
          this.cargando = false;
          this.error = true;
        },
        () => {
          this.cargando = false
          console.log(this.cargando);
        }
      );
  }

  ngOnInit(): void {
    this.accion = this.route.snapshot.params['ACCION_VACANTE'];
    if(this.accion == 'EN_PROCESO'){
     this.estadoId = 1;
    }
    this.headerService.changeTitle.emit('Consultar Vacantes');
    this.cargarTabla(this.sedeId,this.estadoId);
  }

  public IrPagina(pagina: number) {
    this.service.paginacion.PaginaActual = pagina
    this.cargarTabla(this.sedeId,this.estadoId);
  }

  open(VacanteSeleccionada:VacanteLista) {
    
    this.modalService.open(ModalNotificacionComponent, {
      size: 'sm',centered: true, backdrop: 'static', animation: true
    });
    

    this.service.consultarVacante(VacanteSeleccionada.id??"").subscribe(
      (data)=>{
        console.log(data);
        this.modalService.dismissAll()
        const modalRef= this.modalService.open(VacanteDetalleListaComponent, {
          size: 'xl', backdrop: 'static', animation: true
        });
        modalRef.componentInstance.fromParent = {VacanteSeleccionada,VacanteDetalle:data};
          modalRef.result.then((result) => {
            console.log(result);
          }, (reason) => {
          });
      },
      (error)=>{
        this.modalService.dismissAll();
        const modalRef= this.modalService.open(ModalNotificacionComponent, {
          centered: true , animation: true
        });
        modalRef.componentInstance.fromParent = {Tipo:"error",Mensaje:"Error al consultar detalle de vacante"};
          modalRef.result.then((result) => {
            console.log(result);
          }, (reason) => {
          });
      },
      ()=>{}
    )

    
   

    // .result.then((result) => {
    //   // this.closeResult = `Closed with: ${result}`;
    // }, (reason) => {
    //   // this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    // });
  }

}




// export interface Ubicacion {
//   Departamento: string;
//   Municipio: string;
//   localidadComuna: number;
//   numeroPuestos: number;
// }

// export interface Estado {
//   id: number;
//   Nombre: string;
// }

// export interface Empresa {
//   id: number;
//   RazonSocial: string;
// }

// export interface requestVacante {
//   id: string;
//   Nombre: string;
//   FechaVencimientoVacante: Date;
//   FechaLimiteEnvioHv: Date;
//   Ubicaciones: Ubicacion[];
//   PuestosRequeridos: number;
//   Estado: Estado;
//   Empresa: string;
//   ResponsableCorreo: string;
// }


