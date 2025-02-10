import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalFormDescripcionVacanteComponent } from './modal-form-descripcion-vacante.component';

describe('ModalFormDescripcionVacanteComponent', () => {
  let component: ModalFormDescripcionVacanteComponent;
  let fixture: ComponentFixture<ModalFormDescripcionVacanteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ModalFormDescripcionVacanteComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ModalFormDescripcionVacanteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
