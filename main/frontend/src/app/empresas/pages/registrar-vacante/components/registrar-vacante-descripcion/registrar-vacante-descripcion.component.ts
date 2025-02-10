import { Component, OnInit, ViewChild } from '@angular/core';
import { FormArray, FormControl, FormGroup, Validators } from '@angular/forms';
import { ModalDismissReasons, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { merge, Observable, retry } from 'rxjs';
import { cloneIdioma, Idioma, newIdioma } from 'src/app/empresas/domain/dtos/idioma';
import { RegistrarVacanteService } from 'src/app/empresas/use-cases/registrar-vacante.service';
import { PARAMETRICOS, PARAMETRICOS_FILTROS } from 'src/app/services/parametricos.service';
import { DataManager,Query,ODataV4Adaptor,WebApiAdaptor  } from '@syncfusion/ej2-data';
import { ChangeEventArgs, FilteringEventArgs, MultiSelectComponent, TaggingEventArgs } from '@syncfusion/ej2-angular-dropdowns';
import { EmitType } from '@syncfusion/ej2-base';
import { ParametersType } from '@ngrx/store/src/models';
import { Parametrico } from 'src/app/model/parametricos';
import { clearTranslations } from '@angular/localize';
@Component({
  selector: 'registrar-vacante-descripcion',
  templateUrl: './registrar-vacante-descripcion.component.html',
  styleUrls: ['./registrar-vacante-descripcion.component.css']
})
export class RegistrarVacanteDescripcionComponent implements OnInit {
  public PARAMETRICOS = PARAMETRICOS;
  public PARAMETRICOS_FILTROS = PARAMETRICOS_FILTROS;
  public denominacionesRelacionadasControl = new FormControl<string>("");
  public conocimientosCompetenciasControl = new FormControl<string>("");
  public habilidadesDestrezasControl = new FormControl<string>("");
  constructor(public srv: RegistrarVacanteService, private modalService: NgbModal) { }

  public dataBuscarCUOCDenominacion: DataManager = new DataManager({
    url: '/api/Parametrico/filtro/CUOCDenominacion',
    adaptor: new WebApiAdaptor  ,
    crossDomain: true
  });

  public dataBuscarCUOCConocimiento: DataManager = new DataManager({
    url: '/api/Parametrico/filtro/CUOCConocimiento',
    adaptor: new WebApiAdaptor  ,
    crossDomain: true
  });

  public dataBuscarCUOCDestreza: DataManager = new DataManager({
    url: '/api/Parametrico/filtro/CUOCDestreza',
    adaptor: new WebApiAdaptor  ,
    crossDomain: true
  });

  @ViewChild('multiselectdestreza')
  public multiselectdestreza!: MultiSelectComponent;
  @ViewChild('multiselectconocimientos')
  public multiselectconocimientos!: MultiSelectComponent;

 
  
  

  public idiomaForm = newIdioma()

  

  ngOnInit(): void {
  
    

    this.modificarCamposyValidaciones();

    this.denominacionesRelacionadasControl.setValue(this.srv.getArrayControl("denominacionesRelacionadas").value)
    this.srv.$recalcularOcupaciones.next(this.srv.getArrayControl("denominacionesRelacionadas").value);
    this.conocimientosCompetenciasControl.setValue(this.srv.getArrayControl("conocimientosCompetencias").value)
    this.habilidadesDestrezasControl.setValue(this.srv.getArrayControl("habilidadesDestrezas").value)
    this.srv.onVacanteCargadaParaEditar.subscribe(cargo =>{
      this.denominacionesRelacionadasControl.setValue(this.srv.getArrayControl("denominacionesRelacionadas").value)
      this.srv.$recalcularOcupaciones.next(this.srv.getArrayControl("denominacionesRelacionadas").value);
      this.conocimientosCompetenciasControl.setValue(this.srv.getArrayControl("conocimientosCompetencias").value)
      this.habilidadesDestrezasControl.setValue(this.srv.getArrayControl("habilidadesDestrezas").value);  
    
    })
  }
  closeResult="";
  open(content: any) {
    this.idiomaForm.reset();
    this.modalService
      .open(content, { ariaLabelledBy: 'modal-basic-title' })
      .result.then(
        (result) => {
          console.log(result)
          let idiomasArr = this.srv.registrarForm.controls["idiomas"] as FormArray<FormGroup<Idioma>>
          console.log("Guardando Idioma");
          if(this.idiomaForm.valid){
            let nuevoIdioma = cloneIdioma(this.idiomaForm);
            idiomasArr.push(nuevoIdioma);
            this.idiomaForm.reset()
          }
          this.closeResult = `Closed with: ${result}`;

        },
        (reason) => {
          this.idiomaForm.reset()
          this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
        }
      );
  }

  public eliminarIdioma(idiomaId: number | null | undefined){
    let idiomasArr = this.srv.registrarForm.controls["idiomas"] as FormArray<FormGroup<Idioma>>;
    let index = idiomasArr.controls.findIndex((control)=> control.value.idiomaId == idiomaId);
    idiomasArr.removeAt(index);
  }
  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return `with: ${reason}`;
    }
  }

  public traducirNivel(idNivel:number|string){
    switch (idNivel) {
      case 1: return "Bajo"
      case "1": return "Bajo"
      case 2: return "Medio"
      case "2": return "Medio"
      case 3: return "Alto"
      case "3": return "Alto"
      default: return idNivel
    }
  }




  // private enableOrDisableField(enable:boolean|string, control:FormControl){
  //   console.log(control)
  //   if(enable == true){
  //     control.addValidators([Validators.required])
  //     control.enable()
  //   }else{
  //     control.setValue(null);
  //     control.removeValidators([Validators.required])
  //     control.disable()
  //     control.markAsPristine()
  //     control.markAsUntouched()
  //   }
  // }


  
  public modificarCamposyValidaciones(){


    let requiereExperienciaGeneral             = this.srv.getFormControl("requiereExperienciaGeneral");
    let requiereExperienciaEspecifica           = this.srv.getFormControl("requiereExperienciaEspecifica");
    let requiereCapacitacionEspecifica          = this.srv.getFormControl("requiereCapacitacionEspecifica");
    let requiereCertificacionEspecifica          = this.srv.getFormControl("requiereCertificacionEspecifica");


    let tiempoExperiencia                      = this.srv.getFormControl("tiempoExperiencia");
    let descripcionExperienciaEspecifica        = this.srv.getFormControl("descripcionExperienciaEspecifica");
    let descripcionCapacitacionEspecifica       = this.srv.getFormControl("descripcionCapacitacionEspecifica");
    let descripcionCertificacionEspecifica       = this.srv.getFormControl("descripcionCertificacionEspecifica");

    
  
    
    


    this.srv.enableOrDisableField(requiereExperienciaGeneral.value,    tiempoExperiencia);
    this.srv.enableOrDisableField(requiereExperienciaEspecifica.value,  descripcionExperienciaEspecifica);
    this.srv.enableOrDisableField(requiereCapacitacionEspecifica.value, descripcionCapacitacionEspecifica);
    this.srv.enableOrDisableField(requiereCertificacionEspecifica.value, descripcionCertificacionEspecifica);
    
    

  requiereExperienciaGeneral.valueChanges.subscribe(value => {
    this.srv.enableOrDisableField(value,tiempoExperiencia);
    });

  requiereExperienciaEspecifica.valueChanges.subscribe(value => {
    this.srv.enableOrDisableField(value,descripcionExperienciaEspecifica);
  });

  requiereCapacitacionEspecifica.valueChanges.subscribe(value => {
    this.srv.enableOrDisableField(value,descripcionCapacitacionEspecifica);
  });

  requiereCertificacionEspecifica.valueChanges.subscribe(value => {
    this.srv.enableOrDisableField(value,descripcionCertificacionEspecifica);
  });
 


  
 
  }





public OnChangeDenominaciones(e: ChangeEventArgs,campo:MultiSelectComponent,servicio: Observable<Parametrico[]>){
  campo.selectAll(false);
  servicio.subscribe((data:Parametrico[])=>{
    data.forEach((i,v)=>{
      campo.addItem( { nombre: i.nombre, id:i.id });
    });   
  });
}



public onFilteringDenominacion: EmitType<Parametrico> =  (e: FilteringEventArgs,data:DataManager) => {
  // load overall data when search key empty.
  if(e.text == '') e.updateData(data);
  else{
    if (e.text.length < 3) { return; }
    let query: Query = new Query();//
    query.addParams("Busqueda", e.text);
    e.updateData(data, query);
  }
};

public onFilteringHijoEnabled(nombrePadre:string) {
  const valorLength = this.srv.getFormControl(nombrePadre).value?.length;
  return (valorLength>0)?true:false;
} 

public onFilteringHijo: EmitType<Parametrico> =  (nombrePadre:string,e: FilteringEventArgs,data:DataManager) => {
  const valor = this.srv.getFormControl(nombrePadre).value;  
  // load overall data when search key empty.
  if(e.text == '') e.updateData(data);
  else{
    if (e.text.length < 3) { return; }
    let query: Query = new Query();//
    query.addParams("Busqueda", e.text);
    valor.forEach((v:string,i:number)=>{
      query.addParams(`padreId[${i}]`,v);
    });
    e.updateData(data, query);
  }
};

public ocupacionChange(nombrePadre:string,campo:MultiSelectComponent,data: DataManager): void {
  
  const valor = this.srv.getFormControl(nombrePadre).value;  

  if(valor.length == 0){    
    campo?.setProperties({enabled:false,values:[],query:''});
    campo?.selectAll(false);
    campo?.refresh();
  }else{
    let query: Query = new Query();
    valor.forEach((v:string,i:number)=>{
      query.addParams(`padreId[${i}]`,v);
    });
    campo?.setProperties({enabled:true,values:data,query:query});
  }    
}


public validarIdiomaDuplicada(){  
  let idiomaId = Number(this.idiomaForm.get('idiomaId')?.value);
  const existe= this.srv.getArrayControl('idiomas').value.find((x:any)=> x.idiomaId==idiomaId) ;
  return (existe === undefined )?false:true;
}


public formularioModalIdiomaInvalido(){
  if(this.validarIdiomaDuplicada() || this.idiomaForm.invalid){
    return true;
  }
  return false;
}

}
