import { Component, OnInit } from '@angular/core';
import { Validators } from '@angular/forms';
import { delay } from 'rxjs';
import { RegistrarVacanteService } from 'src/app/empresas/use-cases/registrar-vacante.service';
/**
 * @todo: exportar esta enumeracion
 */
enum TIPO_SALARIO{
 A_CONVENIR=1,
 DEFINIDO=2,
 RANGO=3
}
@Component({
  selector: 'registrar-vacacante-detalle-contratacion',
  templateUrl: './registrar-vacacante-detalle-contratacion.component.html',
  styleUrls: ['./registrar-vacacante-detalle-contratacion.component.css']
})
export class RegistrarVacacanteDetalleContratacionComponent implements OnInit {

  constructor(public srv:RegistrarVacanteService) { }
  public TIPO_SALARIO = TIPO_SALARIO;
  minimoSalario: number = 1;
  SALARIO_MIN_MENSUAL = 1160000; // Define el salario mínimo mensual


  public get tipoSalarioSeleccionado(){
    try {
      return this.srv.registrarForm.get("tipoSalarioId")?.value||TIPO_SALARIO.A_CONVENIR
    } catch (error) {
        return TIPO_SALARIO.A_CONVENIR
    }
  }
  public get adjuntarViedo(){
    try {
      return this.srv.registrarForm.get("videoUrl")?.value||null
    } catch (error) {
        return null
    }
  }


  ngOnInit(): void {
    this.ajustarValoresYValidaciones();
    this.getSalario();
  }



  private ajustarValoresYValidaciones(){
    let tipoSalarioId = this.srv.getFormControl("tipoSalarioId");
    let periodicidadSalarialId = this.srv.getFormControl("periodicidadSalarialId");
    let rangoSalarialInicial = this.srv.getFormControl("rangoSalarialInicial");
    let rangoSalarialFinal = this.srv.getFormControl("rangoSalarialFinal");

    let compensacionAdicional = this.srv.getFormControl("compensacionAdicional");
    let descripcionCompensacionAdicional = this.srv.getFormControl("descripcionCompensacionAdicional");

    let tieneVideoAdjunto = this.srv.getFormControl("tieneVideoAdjunto");
    let videoUrl = this.srv.getFormControl("videoUrl");
    let videoDescripcion = this.srv.getFormControl("videoDescripcion");






    /**
     * ---------------------------------------------------
     * tieneVideoAdjunto
     * ---------------------------------------------------
     */

    tieneVideoAdjunto.valueChanges.subscribe(tieneVideoAdjunto =>{
      if(tieneVideoAdjunto==true){
        videoUrl.setValidators([Validators.required,Validators.pattern(/https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)/)])
        videoDescripcion.setValidators([Validators.required,Validators.minLength(10),Validators.maxLength(500)])
        videoUrl.markAsPristine();
        videoUrl.markAsUntouched();
        videoDescripcion.markAsPristine();
        videoDescripcion.markAsUntouched();

      }else{
        //-------------------------------------
        videoUrl.setValue(null)
        videoUrl.clearValidators();
        //--------------------------------------
        videoDescripcion.setValue(null)
        videoDescripcion.clearValidators();
        //---------------------------------------
      }
      videoUrl.updateValueAndValidity();
      videoDescripcion.updateValueAndValidity();
    })


    /**
     * ---------------------------------------------------
     * compensacionAdicional
     * ---------------------------------------------------
     */

    if(compensacionAdicional.value == false || compensacionAdicional.value == null){

      descripcionCompensacionAdicional.disable()
    }

    compensacionAdicional.valueChanges.subscribe(compensacionAdicionalValue =>{
      if(compensacionAdicional.value == false){
        descripcionCompensacionAdicional.disable()
        descripcionCompensacionAdicional.setValue(null)
        descripcionCompensacionAdicional.clearValidators();

      }else{

        descripcionCompensacionAdicional.enable()
        descripcionCompensacionAdicional.setValidators([Validators.required,Validators.minLength(5), Validators.maxLength(500)]);
      }
      descripcionCompensacionAdicional.markAsPristine();
      descripcionCompensacionAdicional.markAsUntouched();
      descripcionCompensacionAdicional.updateValueAndValidity();
    });

    /**
     * ---------------------------------------------------
     * tipoSalarioId
     * ---------------------------------------------------
     */
    tipoSalarioId.valueChanges.subscribe(tipoSalarioId => {

      periodicidadSalarialId.setValue(null);
      rangoSalarialInicial.setValue(null);
      rangoSalarialFinal.setValue(null);

      periodicidadSalarialId.markAsPristine();
      periodicidadSalarialId.markAsUntouched();

      rangoSalarialInicial.markAsPristine();
      rangoSalarialInicial.markAsUntouched();

      rangoSalarialFinal.markAsPristine();
      rangoSalarialFinal.markAsUntouched();



      switch (tipoSalarioId) {
            case TIPO_SALARIO.A_CONVENIR:
              periodicidadSalarialId.clearValidators();
              rangoSalarialInicial.clearValidators();
              rangoSalarialFinal.clearValidators();
              break;

            case TIPO_SALARIO.DEFINIDO:
              periodicidadSalarialId.setValidators([Validators.required]);
              rangoSalarialInicial.setValidators([Validators.required,Validators.min(1)]);
              rangoSalarialFinal.clearValidators();
              break;

            case TIPO_SALARIO.RANGO:
              periodicidadSalarialId.setValidators([Validators.required]);
              rangoSalarialInicial.setValidators([Validators.required,Validators.min(1)]);
              rangoSalarialFinal.setValidators([Validators.required,Validators.min(2)]);

              break;
          }

          periodicidadSalarialId.updateValueAndValidity();
          rangoSalarialInicial.updateValueAndValidity();
          rangoSalarialFinal.updateValueAndValidity();
    });

    rangoSalarialInicial.valueChanges.subscribe((_) =>{
      if(tipoSalarioId.value == TIPO_SALARIO.RANGO){
        let valorInicialOcero = rangoSalarialInicial.value <0?0:rangoSalarialInicial.value;
        rangoSalarialFinal.setValidators([Validators.required, Validators.required,Validators.min(valorInicialOcero + 1)]);
        rangoSalarialFinal.updateValueAndValidity();
      }
    });

    /**
     * ---------------------------------------------------
     * xxxxxxxxxxx
     * ---------------------------------------------------
     */

    /**
     * Se suscribe al cambio de periodicidad para manipular algunas validaciones
     */
    periodicidadSalarialId.valueChanges.subscribe(periodicidad => {
      let rangoSalarialInicial = this.srv.getFormControl("rangoSalarialInicial");
      // Si la periodicidad es diferente a día id 1 entonces el campo salario solo permite valores iguales o superiores a salario mínimo mensual
      if (periodicidad != 1 && periodicidad !== null) {
        rangoSalarialInicial.setValidators([Validators.required, Validators.min(this.SALARIO_MIN_MENSUAL)]);
        this.minimoSalario = this.SALARIO_MIN_MENSUAL;
      } else if (periodicidad == 1 && periodicidad !== null) {
        const salarioDiario = Math.round(this.SALARIO_MIN_MENSUAL / 30);
        rangoSalarialInicial.setValidators([Validators.required, Validators.min(salarioDiario)]);
        this.minimoSalario = salarioDiario;
      }
      rangoSalarialInicial.updateValueAndValidity();
    });

  }

  private getSalario() {
    this.srv.$salarioMensual.subscribe(salario => {
      this.SALARIO_MIN_MENSUAL = salario.valorInicial;
    });
  }

  get formatSinimoSalario() {
    const nf = new Intl.NumberFormat("es-CO");
    return nf.format(this.minimoSalario);
  }

}
