export interface ParametricosAdmin {
  id: number;
  hu: string;
  name: string;
  category: string;
  parametrico: string;
  parametrico_list?: string;
  fields: Field[];
  component?: string;
}

export interface Field {
  name: string;
  label: string;
  type: string;
  required?: boolean;
  association?: string;
  col?: number;
  msgValidation?: string;
  options?: Option[];
  hide_list?: boolean;
  hide_edit?: boolean;
}

export interface Option {
  value: string | number | boolean;
  label: string;
}

export interface Variable {
  codigo: string;
  variable: string;
}
