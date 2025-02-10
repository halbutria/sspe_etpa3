export interface Empresa {
    id:              number;
    tipoDocumentoId: number;
    numeroDocumento: string;
    razonSocial:     string;
    sedes:           Sede[];
}

export interface Sede {
    id:        number;
    empresaId: number;
    direccion: string;
    telefono:  string;
    usuarios:  Usuario[];
}

export interface Usuario {
    id:                string;
    tipoDocumentoId:   number;
    numeroDocumento:   string;
    primerNombre:      string;
    segundoNombre:     string;
    primerApellido:    string;
    segundoApellido:   string;
    correoElectronico: string;
}


