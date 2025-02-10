import { FormControl, FormGroup, Validators } from '@angular/forms';

export interface Idioma {
  idiomaId: FormControl<number|null>;
  nivelConversacionalId: FormControl<number|null>;
  nivelLecturaId: FormControl<number|null>;
  nivelEscrituraId: FormControl<number|null>;
  nivelEscuchaId: FormControl<number|null>;
}

export function newIdioma() {
  return new FormGroup<Idioma>({
    idiomaId: new FormControl<number | null>(null,[Validators.required]),
    nivelConversacionalId: new FormControl<number | null>(null,[Validators.required]),
    nivelLecturaId: new FormControl<number | null>(null,[Validators.required]),
    nivelEscrituraId: new FormControl<number | null>(null,[Validators.required]),
    nivelEscuchaId: new FormControl<number | null>(null,[Validators.required]),
  });
}

export function cloneIdioma(idiomaViejo:FormGroup<Idioma>):FormGroup<Idioma>{
  let idiomaNuevo = newIdioma();
  idiomaNuevo.get("idiomaId")?.setValue(idiomaViejo.get("idiomaId")?.value??0);
  idiomaNuevo.get("nivelConversacionalId")?.setValue(idiomaViejo.get("nivelConversacionalId")?.value??0);
  idiomaNuevo.get("nivelLecturaId")?.setValue(idiomaViejo.get("nivelLecturaId")?.value??0);
  idiomaNuevo.get("nivelEscrituraId")?.setValue(idiomaViejo.get("nivelEscrituraId")?.value??0);
  idiomaNuevo.get("nivelEscuchaId")?.setValue(idiomaViejo.get("nivelEscuchaId")?.value??0);

  return idiomaNuevo;
}


