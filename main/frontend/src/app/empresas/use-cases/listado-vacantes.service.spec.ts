import { TestBed } from '@angular/core/testing';

import { ListadoVacantesService } from './listado-vacantes.service';

describe('ListadoVacantesService', () => {
  let service: ListadoVacantesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ListadoVacantesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
