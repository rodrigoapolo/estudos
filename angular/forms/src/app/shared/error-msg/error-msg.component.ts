import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl, FormControl } from '@angular/forms';
import { FormValidations } from '../services/form-validations';

@Component({
  selector: 'app-error-msg',
  templateUrl: './error-msg.component.html',
  styleUrls: ['./error-msg.component.scss']
})
export class ErrorMsgComponent implements OnInit {

  // @Input() msgErro!: string;
  // @Input() mostrarErro!: boolean;

  @Input() control!: AbstractControl;
  @Input() label!: string;

  constructor() { }

  ngOnInit(): void {

  }

  get errorMessage(){

    for(const propertyName in this.control.errors){
      if(this.control.errors.hasOwnProperty(propertyName) &&
        this.control.touched){
          return FormValidations.getErrorMsg(this.label, propertyName, this.control.errors[propertyName])
        }
    }

    return null;
  }

}
