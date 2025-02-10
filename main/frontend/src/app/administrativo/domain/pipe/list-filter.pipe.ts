import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'listFilter'
})
export class ListFilterPipe implements PipeTransform {
  transform(list: any[], filterText: string, column: string = 'nombre'): any[] {
    if (!list || !filterText) {
      return list || [];
    }

    return list.filter(item => {
      // Verificamos si la propiedad 'column' existe en el objeto
      if (item.hasOwnProperty(column)) {
        const columnValue = item[column];

        // Verificamos si la propiedad es una cadena antes de llamar a toLowerCase()
        if (typeof columnValue === 'string') {
          return columnValue.toLowerCase().includes(filterText.toLowerCase());
        }
      }

      // Si no es una cadena o la propiedad no existe, no la filtramos
      return true;
    });
  }
}
