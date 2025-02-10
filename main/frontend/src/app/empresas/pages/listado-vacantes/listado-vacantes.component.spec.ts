import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListadoVacantesComponent } from './listado-vacantes.component';

describe('ListadoVacantesComponent', () => {
  let component: ListadoVacantesComponent;
  let fixture: ComponentFixture<ListadoVacantesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListadoVacantesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListadoVacantesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
