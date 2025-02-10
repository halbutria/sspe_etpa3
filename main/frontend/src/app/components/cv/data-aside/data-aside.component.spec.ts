import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DataAsideComponent } from './data-aside.component';

describe('DataAsideComponent', () => {
  let component: DataAsideComponent;
  let fixture: ComponentFixture<DataAsideComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DataAsideComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DataAsideComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
