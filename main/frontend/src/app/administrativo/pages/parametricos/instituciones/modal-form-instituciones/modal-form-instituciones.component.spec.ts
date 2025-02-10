import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalFormInstitucionesComponent } from './modal-form-instituciones.component';

describe('ModalFormInstitucionesComponent', () => {
  let component: ModalFormInstitucionesComponent;
  let fixture: ComponentFixture<ModalFormInstitucionesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ModalFormInstitucionesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ModalFormInstitucionesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
