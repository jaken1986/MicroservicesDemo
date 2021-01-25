import { TestBed } from '@angular/core/testing';

import { MicroservicesDemoService } from './microservices-demo.service';

describe('MicroservicesDemoService', () => {
  let service: MicroservicesDemoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MicroservicesDemoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
