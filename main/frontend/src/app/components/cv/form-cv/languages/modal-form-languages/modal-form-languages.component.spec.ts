import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalFormLanguagesComponent } from './modal-form-languages.component';

describe('ModalFormLanguagesComponent', () => {
  let component: ModalFormLanguagesComponent;
  let fixture: ComponentFixture<ModalFormLanguagesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ModalFormLanguagesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ModalFormLanguagesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
