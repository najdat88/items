import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { ItemsComponent } from './components/items.component';
import { ItemsRoutingModule } from './items-routing.module';

@NgModule({
  declarations: [ItemsComponent],
  imports: [CoreModule, ThemeSharedModule, ItemsRoutingModule],
  exports: [ItemsComponent],
})
export class ItemsModule {
  static forChild(): ModuleWithProviders<ItemsModule> {
    return {
      ngModule: ItemsModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<ItemsModule> {
    return new LazyModuleFactory(ItemsModule.forChild());
  }
}
