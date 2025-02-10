import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CriteriosMatchComponent } from './criterios-match.component';

describe('CriteriosMatchComponent', () => {
  let component: CriteriosMatchComponent;
  let fixture: ComponentFixture<CriteriosMatchComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CriteriosMatchComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CriteriosMatchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
