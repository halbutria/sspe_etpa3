import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalFormWorkingInformationComponent } from './modal-form-working-information.component';

describe('ModalFormWorkingInformationComponent', () => {
  let component: ModalFormWorkingInformationComponent;
  let fixture: ComponentFixture<ModalFormWorkingInformationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ModalFormWorkingInformationComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ModalFormWorkingInformationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
