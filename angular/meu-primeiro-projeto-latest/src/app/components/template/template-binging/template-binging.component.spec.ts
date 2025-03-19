import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TemplateBingingComponent } from './template-binging.component';

describe('TemplateBingingComponent', () => {
  let component: TemplateBingingComponent;
  let fixture: ComponentFixture<TemplateBingingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TemplateBingingComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TemplateBingingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
