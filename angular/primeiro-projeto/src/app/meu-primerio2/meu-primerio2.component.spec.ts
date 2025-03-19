import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MeuPrimerio2Component } from './meu-primerio2.component';

describe('MeuPrimerio2Component', () => {
  let component: MeuPrimerio2Component;
  let fixture: ComponentFixture<MeuPrimerio2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MeuPrimerio2Component]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MeuPrimerio2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
