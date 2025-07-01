import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';
import { EstadosBr } from '../models/estados-br';
import { Cidade } from '../models/cidade';

@Injectable({
  providedIn: 'root'
})
export class DropdownService {

  constructor(private http: HttpClient) { }

  getEstadosBr(): Observable<EstadosBr[]> {
    return this.http.get<EstadosBr[]>('assets/dados/estadosbr.json');
  }

  getCidades(idEstado: number){
    return this.http.get<Cidade[]>('assets/dados/cidades.json')
    .pipe(
        map((cidades: Cidade[]) => cidades.filter(c => c.estado == idEstado))
      );
  }

  getCargos(){
    return[
      {nome: 'Dev', nivel: 'Junior', desc: 'Dev Jr'},
      {nome: 'Dev', nivel: 'Pleno', desc: 'Dev Pl'},
      {nome: 'Dev', nivel: 'Senior', desc: 'Dev Sr'}
    ];
  }

  getTecnologias(){
    return [
      {nome: 'java', desc: 'Java'},
      {nome: 'javascript', desc: 'JavaScript'},
      {nome: 'php', desc: 'php'},
      {nome: 'ruby', desc: 'Ruby'}
    ];
  }

  getNewsLetter(){
    return [
      { valor: 's', desc: 'Sim'},
      { valor: 'n', desc: 'Não'},
    ];
  }
}
