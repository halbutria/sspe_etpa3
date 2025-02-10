import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalValidationFormComponent } from './modal-validation-form.component';

describe('ModalResponseComponent', () => {
  let component: ModalValidationFormComponent;
  let fixture: ComponentFixture<ModalValidationFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ModalValidationFormComponent]
    })
      .compileComponents();

    fixture = TestBed.createComponent(ModalValidationFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
