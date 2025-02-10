import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormalEducationComponent } from './formal-education.component';

describe('FormalEducationComponent', () => {
  let component: FormalEducationComponent;
  let fixture: ComponentFixture<FormalEducationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormalEducationComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FormalEducationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
