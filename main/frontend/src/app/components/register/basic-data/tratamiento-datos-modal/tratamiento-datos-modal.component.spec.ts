import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TratamientoDatosModalComponent } from './tratamiento-datos-modal.component';

describe('TratamientoDatosModalComponent', () => {
  let component: TratamientoDatosModalComponent;
  let fixture: ComponentFixture<TratamientoDatosModalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TratamientoDatosModalComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TratamientoDatosModalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
