import { ModuleWithProviders, NgModule } from '@angular/core';
import { MICROSERVICES_DEMO_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class MicroservicesDemoConfigModule {
  static forRoot(): ModuleWithProviders<MicroservicesDemoConfigModule> {
    return {
      ngModule: MicroservicesDemoConfigModule,
      providers: [MICROSERVICES_DEMO_ROUTE_PROVIDERS],
    };
  }
}
