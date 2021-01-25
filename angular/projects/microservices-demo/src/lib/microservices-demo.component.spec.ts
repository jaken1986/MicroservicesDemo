import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { MicroservicesDemoComponent } from './microservices-demo.component';

describe('MicroservicesDemoComponent', () => {
  let component: MicroservicesDemoComponent;
  let fixture: ComponentFixture<MicroservicesDemoComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ MicroservicesDemoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MicroservicesDemoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
