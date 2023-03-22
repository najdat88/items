import { TestBed } from '@angular/core/testing';
import { ItemsService } from './services/items.service';
import { RestService } from '@abp/ng.core';

describe('ItemsService', () => {
  let service: ItemsService;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(ItemsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
