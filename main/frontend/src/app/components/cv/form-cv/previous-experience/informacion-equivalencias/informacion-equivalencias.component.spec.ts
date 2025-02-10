import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InformacionEquivalenciasComponent } from './informacion-equivalencias.component';

describe('InformacionEquivalenciasComponent', () => {
  let component: InformacionEquivalenciasComponent;
  let fixture: ComponentFixture<InformacionEquivalenciasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InformacionEquivalenciasComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InformacionEquivalenciasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
