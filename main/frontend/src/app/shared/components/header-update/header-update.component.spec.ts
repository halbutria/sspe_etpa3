import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HeaderUpdateComponent } from './header-update.component';

describe('HeaderUpdateComponent', () => {
  let component: HeaderUpdateComponent;
  let fixture: ComponentFixture<HeaderUpdateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HeaderUpdateComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HeaderUpdateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
