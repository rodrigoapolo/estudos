import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { DropdownService } from '../shared/services/Dropdown.service';
import { EstadosBr } from '../shared/models/estados-br';
import { ConsultaCepService } from '../shared/services/consulta-cep.service';
import { distinctUntilChanged, empty, map, Observable, switchMap, tap } from 'rxjs';
import { FormValidations } from '../shared/services/form-validations';
import { VerificaEmailService } from './services/verifica-email.service';
import { BaseFormComponent } from '../shared/base-form/base-form.component';
import { Cidade } from '../shared/models/cidade';


@Component({
  selector: 'app-data-form',
  templateUrl: './data-form.component.html',
  styleUrls: ['./data-form.component.scss']
})
export class DataFormComponent extends BaseFormComponent implements OnInit {
  // formulario: FormGroup;
  estados: EstadosBr[] = [];
  cidades: Cidade[] = [];
  // estados: Observable<EstadosBr[]>;
  cargos: any[];
  tecnologias: any[];
  newsletterOp: any[];
  frameworks = ['Angula', 'React', 'Vue', 'Sencha'];

  constructor(
    private formBuilder: FormBuilder,
    private http: HttpClient,
    private dropdownService: DropdownService,
    private cepService: ConsultaCepService,
    private verificaEmailService: VerificaEmailService
  ) {
    super();
    this.formulario = this.formBuilder.group({
      nome: [null, [Validators.required, Validators.minLength(3), Validators.maxLength(20)]],
      email: [null, [Validators.required, Validators.email], [this.validarEmail.bind(this)]],
      confirmarEmail: [null, [FormValidations.equalsTo('email'),Validators.required, Validators.email]],
      endereco: this.formBuilder.group({
        cep: [null, [Validators.required, FormValidations.cepValidator]],
        numero: [null, [Validators.required]],
        complemento: [null],
        rua: [null, [Validators.required]],
        bairro: [null, [Validators.required]],
        cidade: [null, [Validators.required]],
        estado: [null, [Validators.required]],
      }),
      cargo: [null],
      tecnologias: [null],
      newsletter: ['s',  [Validators.required]],
      termos: [null, [Validators.pattern('true'), Validators.required]],
      frameworks: this.buildFrameworks()
    });

    this.formulario.get('endereco.cep')?.statusChanges
      .pipe(
        distinctUntilChanged(),
        switchMap(status => status === 'VALID' ? this.cepService.consultarCEP( this.formulario.get('endereco.cep')?.value)
        : empty())
      )
      .subscribe(dados => dados ? this.popularDadosForm(dados) : {});

    this.formulario.get('endereco.estado')?.valueChanges
      .pipe(
        tap(estado => console.log('Novo estado: ', estado)),
        map(estado => this.estados.filter(e => e.sigla === estado)),
        map(estados => estados && estados.length > 0 ? estados[0].id : null),
        switchMap((estadoId: number | null) =>
          estadoId !== null ? this.dropdownService.getCidades(estadoId)
          : empty()),
          tap(console.log)
      )
      .subscribe(cidades => this.cidades = cidades);
    //this.dropdownService.getCidades(8).subscribe(console.log);
    this.dropdownService.getEstadosBr()
      .subscribe(dados => this.estados = dados);
    this.cargos = this.dropdownService.getCargos();
    this.tecnologias = this.dropdownService.getTecnologias();
    this.newsletterOp = this.dropdownService.getNewsLetter();
  }

  buildFrameworks(){

    const values = this.frameworks.map(v =>  new FormControl(false))

    return this.formBuilder.array(values, FormValidations.requiredMinCheckbox(1));
  }

  // ngOnInit(): void {
    // this.formulario = new FormGroup({
    //   nome: new FormControl(null),
    //   email: new FormControl(null),
    //   endereco: new FormGroup({
    //     cep: new FormControl(null)
    //   })
    // });

    // this.verificaEmailService.verificarEmail('email@email.com').subscribe();
  // }

  override submit(): void {

    let valueSubmit = Object.assign({}, this.formulario.value);

    valueSubmit = Object.assign(valueSubmit, {
      frameworks: valueSubmit.frameworks
      .map((v: boolean, i: number) => v ? this.frameworks[i] : null)
      .filter((v: string | null) => v !== null)
    });

    console.log(valueSubmit);

    this.http.post('https://httpbin.org/post', JSON.stringify(this.formulario.value))
      .subscribe(dados => {
        console.log(dados);
        this.resetar();
      },
        (error: any) => alert('erro'))

  }



  verificaEmailInvalido() {
    let campoEmail = this.formulario.get('email');
    if (campoEmail?.errors) {
      return campoEmail.errors['email'] && campoEmail.touched;
    }
  }

  verificaRequired(campo: string) {
    const control = this.formulario.get(campo);
    return control ? control.hasError('required') &&
    (!control.valid && (control.touched || control.dirty)) : false;
  }



  consultarCEP() {
    let cep = this.formulario.get('endereco.cep')?.value;

    if(cep != null && cep !== ''){
      this.cepService.consultarCEP(cep)
        ?.subscribe(dados => {
            this.popularDadosForm(dados);
          });
    }
  }

  popularDadosForm(dados: any) {
    this.formulario.patchValue({
      endereco: {
        numero: "",
        complemento: dados.complemento,
        rua: dados.logradouro,
        bairro: dados.bairro,
        cidade: dados.localidade,
        estado: dados.uf
      }
    })

    // this.formulario.get('nome')?.setValue('Rodrigo');
  }

  resetaDadosForm() {
    this.formulario.patchValue({
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

  setarCargo(){
    const cargo = {nome: 'Dev', nivel: 'Pleno', desc: 'Dev Pl'};
    this.formulario.get('cargo')?.setValue(cargo);
  }

  compararCargos(obj1: any, obj2: any){
    return obj1 && obj2 ? (obj1.nome === obj2.nome && obj1.nivel === obj2.nivel) : obj1 === obj2;
  }

  setarTecnologias(){
    this.formulario.get('tecnologias')?.setValue(['java', 'javascript', 'php'])
  }

  get frameworksFormArray() {
    return this.formulario.get('frameworks') as import('@angular/forms').FormArray;
  }

  validarEmail(formControl: FormControl){
    return this.verificaEmailService.verificarEmail(formControl.value)
      .pipe(map(emailExise => emailExise ? { emailInvalido: true } : null));
  }
}
