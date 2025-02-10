import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistrarVacanteDescripcionComponent } from './registrar-vacante-descripcion.component';

describe('RegistrarVacanteDescripcionComponent', () => {
  let component: RegistrarVacanteDescripcionComponent;
  let fixture: ComponentFixture<RegistrarVacanteDescripcionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegistrarVacanteDescripcionComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RegistrarVacanteDescripcionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
