import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DisabilityNavigationComponent } from './disability-navigation.component';

describe('DisabilityNavigationComponent', () => {
  let component: DisabilityNavigationComponent;
  let fixture: ComponentFixture<DisabilityNavigationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DisabilityNavigationComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DisabilityNavigationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
