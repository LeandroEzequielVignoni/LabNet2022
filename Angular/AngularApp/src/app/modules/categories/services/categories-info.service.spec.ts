import { TestBed } from '@angular/core/testing';

import { CategoriesInfoService } from './categories-info.service';

describe('CategoriesInfoService', () => {
  let service: CategoriesInfoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CategoriesInfoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
