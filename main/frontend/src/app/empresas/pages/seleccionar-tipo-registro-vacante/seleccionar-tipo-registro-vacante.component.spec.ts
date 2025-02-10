import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SeleccionarTipoRegistroVacanteComponent } from './seleccionar-tipo-registro-vacante.component';

describe('SeleccionarTipoRegistroVacanteComponent', () => {
  let component: SeleccionarTipoRegistroVacanteComponent;
  let fixture: ComponentFixture<SeleccionarTipoRegistroVacanteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SeleccionarTipoRegistroVacanteComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SeleccionarTipoRegistroVacanteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
