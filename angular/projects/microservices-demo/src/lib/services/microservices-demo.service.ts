import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class MicroservicesDemoService {
  apiName = 'MicroservicesDemo';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/MicroservicesDemo/sample' },
      { apiName: this.apiName }
    );
  }
}
