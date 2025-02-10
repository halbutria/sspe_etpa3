import { FormControl, FormGroup, Validators } from "@angular/forms";

export interface UbicacionVacante{
  departamentoID: FormControl<number|null>;
  municipioID: FormControl<number|null>;
  localidadComunaId: FormControl<number|null>;
  numeroPuestos: FormControl<number|null>;
}


export function newUbicacionVacante():FormGroup<UbicacionVacante>{
 return  new FormGroup<UbicacionVacante>({
    departamentoID: new FormControl<number | null>(null,[Validators.required]),
    municipioID: new FormControl<number | null>(null,[Validators.required]),
    localidadComunaId: new FormControl<number | null>(0),
    numeroPuestos:  new FormControl<number|null>(null),
    // numeroPuestos:  new FormControl<number|null>(null,[Validators.required,Validators.pattern('[0-9]*'), Validators.min(1),Validators.max(9999)]),
  });
}

export function cloneUbicacionVacante(ubicacionVieja:FormGroup<UbicacionVacante>):FormGroup<UbicacionVacante>{
  let ubicacionNueva = newUbicacionVacante();
  ubicacionNueva.get("departamentoID")?.setValue(ubicacionVieja.get("departamentoID")?.value??0);
  ubicacionNueva.get("municipioID")?.setValue(ubicacionVieja.get("municipioID")?.value??0);
  ubicacionNueva.get("localidadComunaId")?.setValue(ubicacionVieja.get("localidadComunaId")?.value??0);
  ubicacionNueva.get("numeroPuestos")?.setValue(ubicacionVieja.get("numeroPuestos")?.value??0);
  return ubicacionNueva;
}
