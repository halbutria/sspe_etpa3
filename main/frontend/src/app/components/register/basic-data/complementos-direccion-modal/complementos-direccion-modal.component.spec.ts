import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComplementosDireccionModalComponent } from './complementos-direccion-modal.component';

describe('ComplementosDireccionModalComponent', () => {
  let component: ComplementosDireccionModalComponent;
  let fixture: ComponentFixture<ComplementosDireccionModalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ComplementosDireccionModalComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ComplementosDireccionModalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
