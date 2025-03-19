import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MeuPrimerio2Component } from './meu-primerio2/meu-primerio2.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, MeuPrimerio2Component],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'primeiro-projeto';
}
