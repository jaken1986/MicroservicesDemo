import { Component, OnInit } from '@angular/core';
import { MicroservicesDemoService } from '../services/microservices-demo.service';

@Component({
  selector: 'lib-microservices-demo',
  template: ` <p>microservices-demo works!</p> `,
  styles: [],
})
export class MicroservicesDemoComponent implements OnInit {
  constructor(private service: MicroservicesDemoService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
