import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalFormNoFormalEducationComponent } from './modal-form-no-formal-education.component';

describe('ModalFormNoFormalEducationComponent', () => {
  let component: ModalFormNoFormalEducationComponent;
  let fixture: ComponentFixture<ModalFormNoFormalEducationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ModalFormNoFormalEducationComponent]
    })
      .compileComponents();

    fixture = TestBed.createComponent(ModalFormNoFormalEducationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
