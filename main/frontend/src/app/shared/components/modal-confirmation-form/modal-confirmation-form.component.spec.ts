import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalConfirmationFormComponent } from './modal-confirmation-form.component';

describe('ModalConfirmationFormComponent', () => {
  let component: ModalConfirmationFormComponent;
  let fixture: ComponentFixture<ModalConfirmationFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ModalConfirmationFormComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ModalConfirmationFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
