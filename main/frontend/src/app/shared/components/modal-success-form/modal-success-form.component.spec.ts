import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalSuccessFormComponent } from './modal-success-form.component';

describe('ModalSuccessFormComponent', () => {
  let component: ModalSuccessFormComponent;
  let fixture: ComponentFixture<ModalSuccessFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ModalSuccessFormComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ModalSuccessFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
