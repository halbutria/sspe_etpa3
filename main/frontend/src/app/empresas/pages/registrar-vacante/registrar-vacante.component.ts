import { Component, OnInit } from '@angular/core';
import { ValidationErrors } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { NgbNavChangeEvent } from '@ng-bootstrap/ng-bootstrap';
import { HeaderService } from 'src/app/services/header.service';
import { ModalConfirmationFormComponent } from 'src/app/shared/components/modal-confirmation-form/modal-confirmation-form.component';
import { ModalConfirmationVacanteFormComponent } from 'src/app/shared/components/modal-confirmation-vacante-form/modal-confirmation-vacante-form.component';
import { ModalErrorFormComponent } from 'src/app/shared/components/modal-error-form/modal-error-form.component';
import { ESTADO_VACANTE } from '../../domain/dtos/estado-vacante';
import { VacanteControlPro } from '../../domain/dtos/vacante';
import { RegistrarVacanteService } from '../../use-cases/registrar-vacante.service';
import { ACCION_VACANTE } from '../seleccionar-tipo-registro-vacante/seleccionar-tipo-registro-vacante.component';

@Component({
  selector: 'app-registrar-vacante',
  templateUrl: './registrar-vacante.component.html',
  styleUrls: ['./registrar-vacante.component.scss'],
})
export class RegistrarVacanteComponent implements OnInit {
  public disabled = true;
  public tab_activo: number = 1;
  private errores_formulario:VacanteControlPro[] = [];



  constructor(public headerService: HeaderService,public srv:RegistrarVacanteService, private route: ActivatedRoute) {}
  //develop tools

  opacity = .5;
  posLeft=true;
  // -----------------
  ngOnInit(): void {
    // reset formulario
    this.srv.resetForm();

    this.srv.$recalcularOcupaciones.next(this.srv.getArrayControl("denominacionesRelacionadas").value);
    setTimeout(() => {
      this.headerService.changeTitle.emit('Registrar Vacante');
    }, 1000);

    this.route.params.subscribe(params =>{
      if(params["accion"]==ACCION_VACANTE.EN_PROCESO){
        let vacanteId = params["vacanteId"];
        this.srv.cargarVacante(vacanteId)
      }else if (params["accion"]==ACCION_VACANTE.COPIA){
        let vacanteId = params["vacanteId"];
        this.srv.cargarVacante(vacanteId,true)
      }
    });

    this.srv.registrarForm.valueChanges.subscribe((_)=>{
      this.getErrorForm();
    });

  }

  public onTabChange($event: NgbNavChangeEvent) {

  }

  public navegarAnteriorTab(){
    if(this.tab_activo >1) {
      this.tab_activo = this.tab_activo - 1
    }
  }
  public navegarSiguienteTab(){
    if(this.tab_activo < 3) {
      this.tab_activo = this.tab_activo + 1
    }
  }

  public enProceso() {
      const control = this.srv.getFormControl("nombre");
      if(!control.invalid){
        this.srv.getFormControl("estadoId").setValue(ESTADO_VACANTE.EN_PROCESO);
        this.srv.guardar();
      }else{
        this.srv.modalopen(ModalErrorFormComponent,"Ingresa el nombre de la vacante.");
        control.markAsDirty();
        control.markAsTouched();
      }
  }

  public registrar() {
    if(this.srv.registrarForm.valid){
      console.log(this.srv.getFormControl("id"));
      this.srv.getFormControl("estadoId").setValue(ESTADO_VACANTE.REGISTRADA);
      const confirmacion =  this.srv.modalopen(ModalConfirmationFormComponent,this.mensajeRegistro());
      confirmacion.result.then((result) => {
        const subsectorEconomicoId = this.srv.getFormControl("subsectorEconomicoId").value
        if(result && subsectorEconomicoId == 1){
          const confirmacionHidro =  this.srv.modalopen(ModalConfirmationVacanteFormComponent,`¿Desea registrar la vacante automáticamente con el o los demás prestadores autorizados del municipio o del área de influcencia?<p> </p> <ul><li>AGENCIA DE DESARROLLO LOCAL DE  ITAGÛI-ADELI</li><li>ALCALDÍA DE BARBOSA</li><li>ALCALDÍA DE BELLO</li><li>ALCALDÍA DE CALDAS</li><li>ALCALDÍA DE ENVIGADO</li><li>ALCALDÍA DE GIRARDOTA</li><li>ALCALDÍA DE ITAGÜÍ</li><li>ALCALDÍA DE LA ESTRELLA</li><li>ALCALDÍA DE MEDELLÍN</li><li>ALCALDÍA DE SABANETA</li><li>CAJA DE COMPENSACIÓN FAMILIAR CAMACOL- COMFAMILIAR CAMACOL</li><li>CAJA DE COMPENSACIÓN FAMILIAR COMFENALCO ANTIOQUIA</li><li>CAJA DE COMPENSACIÓN FAMILIAR DE ANTIOQUIA -COMFAMA</li><li>MUNICIPIO DE RIONEGRO</li></ul>`);
          confirmacionHidro.result.then(
            (result)=>{
              if(result != null){
                const registroVacanteDemasPrestadores = this.srv.getFormControl("registroVacanteDemasPrestadores").setValue(result);
                this.srv.guardar();
              }           
          })
        }else if(result){
          this.srv.guardar();
        }
      });
    }else{

      this.getErrorForm();
      const informacionGeneralError = this.erroresPorNAvList('informacionGeneral','Información General');
      const informacionDescripcionVacante = this.erroresPorNAvList('descripcionVacante','Descripción Vacante');
      const detalleContratacionVacante = this.erroresPorNAvList('detalleContratacion','Detalle Contratación');
      const noconfiglError = this.erroresPorNAvList('','');
      
      this.srv.modalopen(ModalErrorFormComponent,`Hay campos pendientes por completar.<br> ${informacionGeneralError}${informacionDescripcionVacante}${detalleContratacionVacante}${noconfiglError}`);

      for( let formControlName in this.srv.registrarForm.controls){
        let control =this.srv.getFormControl(formControlName);
        control.markAsDirty();
        control.markAsTouched();
      }
    }
  }

  public getErrorForm(){
    this.errores_formulario = [];
    console.log(this.srv.registrarForm.errors,"this.srv.registrarFormthis.srv.registrarFormthis.srv.registrarForm");
    Object.keys(this.srv.registrarForm.controls).forEach(key => {
      const controlErrors = this.srv.registrarForm.get(key)?.errors;
      if (controlErrors != null) {
        Object.keys(controlErrors).forEach(keyError => {        
         this.errores_formulario.push(this.srv.formControlInfo(key));
         this.srv.formControlInfo(key);
        });
      }
    });
  }

  public erroresPorNAvList(navKey:string,navName:string){
    let li = this.errores_formulario.filter(x=>x.nameNav===navKey).map((v,i)=> `<li class="list-group-item">${v['name']}</li>`).join('');
    return (li!=='')?`<ul class="list-group"> <li class="list-group-item list-group-item-danger" aria-current="true">${navName}</li>${li}</ul>`:'';
  }

  public erroresPorNAvLength(navName:string):number{
    return this.errores_formulario.filter(x=>x.nameNav===navName).length;
  }


  public mensajeRegistro(){
    const id = this.srv.getFormControl("id").value;
    const mensaje=(id==null)?"del registro":"de la modificación";
    return `Señor usuario esta seguro ${mensaje} de la vacante ${ this.srv.getFormControl("nombre").value}?`;
  }

}
