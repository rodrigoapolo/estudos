import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

//componentes
import { NewComponent } from './components/new-component/new-component.component';
import { TemplateBingingComponent } from './components/template/template-binging/template-binging.component';
import { TemplateVariablesComponent } from './components/template/template-variables/template-variables.component';
import { TemplateControlFlowComponent } from './components/template/template-control-flow/template-control-flow.component';
import { ComponentsComponent } from "./components/components.component";
import { TemplateDeferrableViewsComponent } from './components/template/template-deferrable-views/template-deferrable-views.component';
import { SignalsComponent } from './components/template/signals/signals.component';
import { PaiOuMaeComponent } from './components/comunicaco-entre-components/pai-ou-mae/pai-ou-mae.component';


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    CommonModule,
    RouterOutlet,
    NewComponent,
    TemplateBingingComponent,
    TemplateVariablesComponent,
    TemplateControlFlowComponent,
    ComponentsComponent,
    TemplateDeferrableViewsComponent,
    SignalsComponent,
    PaiOuMaeComponent
  ],
  styles: [`
  h1{
    color: red;
  }`],
  template: `
  <h1>Curso de Angular</h1>
  <!-- <router-outlet /> -->
  <!-- <app-new-component/> -->
  <!-- <app-template-binging/>
  <app-template-variables/> -->
  <!-- <app-template-control-flow/> -->
  <!-- <app-template-deferrable-views/> -->
  <!-- <app-signals/> -->
  <app-pai-ou-mae/>
  `,

})
export class AppComponent {
  title = 'meu-primeiro-projeto-latest';
}
//<router-outlet />