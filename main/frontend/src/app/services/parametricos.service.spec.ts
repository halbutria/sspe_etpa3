import { TestBed } from '@angular/core/testing';

import { ParametricosService } from './parametricos.service';

describe('ParametricosService', () => {
  let service: ParametricosService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ParametricosService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
