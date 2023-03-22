import { ModuleWithProviders, NgModule } from '@angular/core';
import { ITEMS_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class ItemsConfigModule {
  static forRoot(): ModuleWithProviders<ItemsConfigModule> {
    return {
      ngModule: ItemsConfigModule,
      providers: [ITEMS_ROUTE_PROVIDERS],
    };
  }
}
