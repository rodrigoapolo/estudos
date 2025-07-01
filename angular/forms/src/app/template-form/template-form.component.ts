import { Component, OnInit } from '@angular/core';
import { NgForm, NgModel } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { ConsultaCepService } from '../shared/services/consulta-cep.service';

@Component({
  selector: 'app-template-form',
  templateUrl: './template-form.component.html',
  styleUrls: ['./template-form.component.scss']
})
export class TemplateFormComponent implements OnInit {

  usuario = {
    nome: null,
    email: null
  }

  onSubmit(form: NgForm, ) {
    this.Http.post('https://httpbin.org/post', JSON.stringify(form.value))
      .subscribe(dados => {
        console.log(dados);
        form.form.reset();
      })

  }

  constructor(
    private Http: HttpClient,
    private cepService: ConsultaCepService
  ) { }

  ngOnInit(): void {
  }

  consultarCEP(cep: string, form: NgForm) {
    var cep = cep.replace(/\D/g, '');

    if(cep != null && cep !== ''){
      this.cepService.consultarCEP(cep)
        ?.subscribe(dados => {
            this.popularDadosForm(dados, form);
          });
    }
  }

  popularDadosForm(dados: any, form: NgForm) {

    form.form.patchValue({
      endereco: {
        cep: dados.cep,
        numero: "",
        complemento: dados.complemento,
        rua: dados.logradouro,
        bairro: dados.bairro,
        cidade: dados.localidade,
        estado: dados.uf
      }
    })
  }

  resetaDadosForm(form: NgForm) {
    form.form.patchValue({
      endereco: {
        numero: null,
        complemento: null,
        rua: null,
        bairro: null,
        cidade: null,
        estado: null
      }
    })
  }

}
