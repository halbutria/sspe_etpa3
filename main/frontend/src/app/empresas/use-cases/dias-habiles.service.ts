import { Injectable } from "@angular/core";

@Injectable()
export class diasHabilesService {


calculaEntrega(diaPedido:Date , diasPactados: number , festivos: any) {
    // diaPropuesto: almacena el mismo valor de diaPedido, en caso que diasPactados = 0, la función 
    // devolverá el valor de diaPedido (para mi tiene lógica)
    let diaPropuesto = new Date(diaPedido.getFullYear(), diaPedido.getMonth(), diaPedido.getDate());

    // iniciamos un contador en 1 para calcular la fecha de diaPropuesto.
    let i = 1;
    
    // El siguiente bucle se ejecutará hasta que se consuman los diasPactados
    while (diasPactados > 0 ) {
        // En cada iteración asumimos que el día no es festivo
        let festivo = false;
        // incrementamos en 1 el diaPropuesto para efectuar las verificaciones
        diaPropuesto = new Date(diaPedido.getFullYear(), diaPedido.getMonth(), diaPedido.getDate() + i);
        // Nótese que usamos formato ISO y solo incrementamos el día, dejando el mes y el año iguales
        // Alguien preguntará: ¿Y que pasa si la fecha es, digamos, 31 de Enero y le aumentamos 1 día?
        // Pues la respuesta lógica es que daría 32 de Enero, lo cual no es una fecha válida.
        // Sin embargo, JavaScript es un poco mas atento que nosotros y simplemente realiza la aritmética
        // necesaria para convertir el 32 de Enero en 01 de Febrero, y así nos salva el pellejo.
        // Véase bien que usamos los métodos getFullYear(), getMonth() y getDate().
        // Esto funciona siempre y cuando hagamos la construcción del objeto Date de esta manera.
        // Ya irá alguno de avispado y pondrá: fecha = new Date('2019-01-32'); lo cual le dará 'fecha inválida'
        // Alguien un poco mas versado puede aclarar este asunto, pero no es el objetivo en este momento.

        if (diaPropuesto.getDay() > 0 && diaPropuesto.getDay() < 6) {
            // Aquí hemos usado el método getDay() del objeto Date, este método devuelve un valor entero entre 0 y 6,
            // donde 0: Domingo, 1: Lunes, ... , 6: Sabado.
            // Los días laborables van del 1 al 5 (ambos inclusive)
            
            // Si el día es laborable debemos entonces verificar si es festivo
            
            // Aquí es importante que entendamos lo siguiente:
            //  * Por cada iteración debemos obtener el mes en el que estamos comprobando el festivo
            //  * Vamos a comparar el día propuesto con el Array de festivos, usando el mes correspondiente

            let m = diaPropuesto.getMonth();
            let dia = diaPropuesto.getDate();

            // Felizmente para nosotros el método getMonth() devuelve un entero entre 0 y 11, que se
            // corresponde con cada mes del año, y digo felizmente, porque los índices de nuestro Array
            // van de 0 a 11 también.

            for (let d in festivos[m]) {
                if (dia === festivos[m][d]) {
                    festivo = true;
                    //Aquí no hay mucho que aclarar, si es festivo ya no sigo comprobando el resto del mes.
                    break;
                }
            } // Fin bucle for

            if (!festivo) {
                // Si las condiciones son: Laborable y No Festivo, descuento el diaPactado.
                diasPactados--;
            }
        }

        // Por último, debemos incrementar el número de días que sumaremos al diaPropuesto
        // en cada iteración
        i++;
    } // Fin de bucle while

    // Devolvemos el resultado
    return diaPropuesto;

} 
 
cantidadDiasHabiles(){
    let festivos = [[1],[],[20],[2,6,7,9],[1,22],[12,19],[3,20],[7,21],[],[16],[6,13],[8,25]];
    let hoy = new Date(Date.now());
    let cantidadDias = 4;
    let diaEntrega = this.calculaEntrega(hoy,cantidadDias, festivos);
    let resta = diaEntrega.getTime() - hoy.getTime();
    let candidadDias = Math.round(resta/ (1000*60*60*24));
    return candidadDias;
}

}