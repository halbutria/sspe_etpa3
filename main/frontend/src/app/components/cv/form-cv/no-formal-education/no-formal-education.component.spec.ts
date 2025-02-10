import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NoInformalEducationComponent } from './no-informal-education.component';

describe('NoInformalEducationComponent', () => {
  let component: NoInformalEducationComponent;
  let fixture: ComponentFixture<NoInformalEducationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NoInformalEducationComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NoInformalEducationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
