import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'filtroArray'
})
export class FiltroArrayPipe implements PipeTransform {

  transform(value: unknown, ...args: unknown[]): any[] { // ⬅️ Retorno tipado como array
    if (!Array.isArray(value)) return []; // ⬅️ Retornar um array vazio se não for um array

    if (value.length === 0 || !args || args.length === 0 || args[0] === '') {
      return value;
    }

    let filter = args[0]?.toString().toLocaleLowerCase(); // ⬅️ Pegando apenas o primeiro argumento

    return value.filter(v =>
      v.toString().toLocaleLowerCase().includes(filter) // ⬅️ `includes()` é mais moderno que `indexOf()`
    );
  }
}

