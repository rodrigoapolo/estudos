import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-curso',
  templateUrl: './input-property.component.html',
  styleUrls: ['./input-property.component.css'],
  // inputs: ['nomeDoCurso:nome']
})
export class InputPropertyComponent implements OnInit {

  @Input('nome') nomeDocurso: string = '';
  constructor() { }

  ngOnInit(): void {
  }

}
