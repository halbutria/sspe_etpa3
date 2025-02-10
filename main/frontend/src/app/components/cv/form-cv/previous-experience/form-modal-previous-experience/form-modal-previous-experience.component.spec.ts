import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormModalPreviousExperienceComponent } from './form-modal-previous-experience.component';

describe('FormModalPreviousExperienceComponent', () => {
  let component: FormModalPreviousExperienceComponent;
  let fixture: ComponentFixture<FormModalPreviousExperienceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormModalPreviousExperienceComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FormModalPreviousExperienceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
