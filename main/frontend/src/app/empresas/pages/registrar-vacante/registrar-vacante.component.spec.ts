import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistrarVacanteComponent } from './registrar-vacante.component';

describe('RegistrarVacanteComponent', () => {
  let component: RegistrarVacanteComponent;
  let fixture: ComponentFixture<RegistrarVacanteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegistrarVacanteComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RegistrarVacanteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
