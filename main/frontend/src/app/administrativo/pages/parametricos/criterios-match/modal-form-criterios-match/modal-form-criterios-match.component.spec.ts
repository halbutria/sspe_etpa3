import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalFormCriteriosMatchComponent } from './modal-form-criterios-match.component';

describe('ModalFormCriteriosMatchComponent', () => {
  let component: ModalFormCriteriosMatchComponent;
  let fixture: ComponentFixture<ModalFormCriteriosMatchComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ModalFormCriteriosMatchComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ModalFormCriteriosMatchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
