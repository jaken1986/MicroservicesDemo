import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { MicroservicesDemoComponent } from './components/microservices-demo.component';
import { MicroservicesDemoRoutingModule } from './microservices-demo-routing.module';

@NgModule({
  declarations: [MicroservicesDemoComponent],
  imports: [CoreModule, ThemeSharedModule, MicroservicesDemoRoutingModule],
  exports: [MicroservicesDemoComponent],
})
export class MicroservicesDemoModule {
  static forChild(): ModuleWithProviders<MicroservicesDemoModule> {
    return {
      ngModule: MicroservicesDemoModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<MicroservicesDemoModule> {
    return new LazyModuleFactory(MicroservicesDemoModule.forChild());
  }
}
