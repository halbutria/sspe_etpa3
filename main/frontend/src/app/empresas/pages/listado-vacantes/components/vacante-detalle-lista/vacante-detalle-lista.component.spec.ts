import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VacanteDetalleListaComponent } from './vacante-detalle-lista.component';

describe('VacanteDetalleListaComponent', () => {
  let component: VacanteDetalleListaComponent;
  let fixture: ComponentFixture<VacanteDetalleListaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VacanteDetalleListaComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(VacanteDetalleListaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
