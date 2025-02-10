import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistrarVacanteInformacionGeneralComponent } from './registrar-vacante-informacion-general.component';

describe('RegistrarVacanteInformacionGeneralComponent', () => {
  let component: RegistrarVacanteInformacionGeneralComponent;
  let fixture: ComponentFixture<RegistrarVacanteInformacionGeneralComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegistrarVacanteInformacionGeneralComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RegistrarVacanteInformacionGeneralComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
