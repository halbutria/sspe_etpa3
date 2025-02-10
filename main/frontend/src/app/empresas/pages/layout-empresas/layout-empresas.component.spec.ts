import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LayoutEmpresasComponent } from './layout-empresas.component';

describe('LayoutEmpresasComponent', () => {
  let component: LayoutEmpresasComponent;
  let fixture: ComponentFixture<LayoutEmpresasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LayoutEmpresasComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LayoutEmpresasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
