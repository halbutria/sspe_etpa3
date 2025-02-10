export interface Prestador {
  id:                string;
  nombre:            string;
  codigo:            string;
  departamentoId:    number;
  coberturaNacional: boolean;
}

export interface PuntoAtencion {
  id:          string;
  prestadorId: string;
  nombre:      string;
}
