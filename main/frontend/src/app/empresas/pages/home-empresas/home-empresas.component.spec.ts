import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeEmpresasComponent } from './home-empresas.component';

describe('HomeEmpresasComponent', () => {
  let component: HomeEmpresasComponent;
  let fixture: ComponentFixture<HomeEmpresasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HomeEmpresasComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HomeEmpresasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
