import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistrarVacacanteDetalleContratacionComponent } from './registrar-vacacante-detalle-contratacion.component';

describe('RegistrarVacacanteDetalleContratacionComponent', () => {
  let component: RegistrarVacacanteDetalleContratacionComponent;
  let fixture: ComponentFixture<RegistrarVacacanteDetalleContratacionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegistrarVacacanteDetalleContratacionComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RegistrarVacacanteDetalleContratacionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
