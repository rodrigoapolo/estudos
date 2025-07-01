import { FormArray, FormControl, FormGroup, Validators } from "@angular/forms";

export class FormValidations {
  static requiredMinCheckbox(min = 1): Validators {
    const validator = (formArray: FormArray) => {
      // const values = formArray.controls;
      // let totalCheced = 0;
      // for(let i = 0; i < values.length; i++){
      //   if(values[i].value){
      //     totalCheced += 1;
      //   }
      // }

      const totalCheced = formArray.controls
        .map(v => v.value)
        .reduce((total, current) => current ? total + current : total, 0);

      return totalCheced >= min ? null : { required: true };
    }
    return validator;
  }

  static cepValidator(control: FormControl) {
    const cep = control.value;
    if (cep && cep !== '') {
      var validacep = /^[0-9]{8}$/;
      return validacep.test(cep) ? null : { cepInvalido: true };
    }
    return null;
  }

  static equalsTo(otherField: string) {
    const validator = (formControl: FormControl) => {
      if(otherField == null){
        throw new Error('É necessário informa um campo.');
      }

      if(!formControl.root || !(<FormGroup> formControl.root).controls){
        return null;
      }

      const field = (<FormGroup> formControl.root).get(otherField);
      if(!field){
        throw new Error('É necessário informa um válido.')
      }

      if(field.value !== formControl.value){
        return { equalsTo: otherField }
      }

      return null;
    }
    return validator;
  }

  static getErrorMsg(fieldName: string, validatorName: string, validatorValue?: any ){
    const config: { [key: string]: string } = {
      'required':`${fieldName} é obrigatório`,
      'minlength':`${fieldName} precisa ter no mínimo ${validatorValue.requiredLength} caracteres.`,
      'maxlength':`${fieldName} precisa ter no máximo ${validatorValue.requiredLength} caracteres.`,
      'cepInvalido':`CEP inválido.`,
    };

    return config[validatorName];
  }
}
