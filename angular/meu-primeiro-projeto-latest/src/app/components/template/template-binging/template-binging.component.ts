import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-template-binging',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './template-binging.component.html',
  styleUrl: './template-binging.component.scss'
})
export class TemplateBingingComponent {
  public name: string = 'Dener Troquatte';
  public age: number = 32;
  public condition = this.age > 1 ? 'teste' : "Teste2";
  public isDisabled: boolean = false;
  public srcValue: string = "https://www.google.com/images/branding/googlelogo/2x/googlelogo_light_color_272x92dp.png";
  public isTextDecoration = this.age >= 32 ? 'underline' : 'none';;
  constructor(){
    setTimeout(() =>{
      this.name = "Rodrigo Apolo";
    },3000);
  }
  // public sum(val1: number, val2: number): number {
  //   return val1 + val2;
  // }

  public sum(): number {
    return this.age++;
  }

  public sub(): number {
    return this.age--;
  }

  public onKeyDown(event: Event){
    return console.log(event);
  }

  public onMouseMove(event: MouseEvent){
    return console.log({
      clietx: event.clientX,
      cliety: event.clientY,
    });
  }
}
