import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DescripcionVacanteComponent } from './descripcion-vacante.component';

describe('DescripcionVacanteComponent', () => {
  let component: DescripcionVacanteComponent;
  let fixture: ComponentFixture<DescripcionVacanteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DescripcionVacanteComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DescripcionVacanteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
