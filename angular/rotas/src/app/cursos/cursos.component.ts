import { Component, OnInit } from '@angular/core';
import { CursosService } from './cursos.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-cursos',
  templateUrl: './cursos.component.html',
  styleUrls: ['./cursos.component.css']
})
export class CursosComponent implements OnInit {

  cursos: any[] = [];
  pagina: number = 1;
  inscricao: Subscription = new Subscription;

  constructor(
    private cursosService: CursosService,
    private route: ActivatedRoute,
    private router: Router
  ) {
    
   }

  ngOnInit(): void {
    this.cursos = this.cursosService.getCursos();
    this.inscricao = this.route.queryParams.subscribe(params => {
      this.pagina = params['pagina'];
    });
  }

  ngOnDestroy(): void {
    this.inscricao.unsubscribe();
  }

  proximaPagina(){
    // this.pagina++; 
    this.router.navigate(['/cursos'], {queryParams: {'pagina': ++this.pagina}});
  }

}
