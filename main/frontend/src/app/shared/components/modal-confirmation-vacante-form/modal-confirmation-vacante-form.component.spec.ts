import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalConfirmationVacanteFormComponent } from './modal-confirmation-vacante-form.component';

describe('ModalConfirmationVacanteFormComponent', () => {
  let component: ModalConfirmationVacanteFormComponent;
  let fixture: ComponentFixture<ModalConfirmationVacanteFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ModalConfirmationVacanteFormComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ModalConfirmationVacanteFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
