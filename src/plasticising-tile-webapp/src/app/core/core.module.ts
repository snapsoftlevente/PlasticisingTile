import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FilterFunctionPipe } from './pipes/filter-function.pipe';

@NgModule({
  imports: [HttpClientModule],
  declarations: [FilterFunctionPipe],
  exports: [FilterFunctionPipe],
  providers: []
})
export class CoreModule {
  constructor() {
  }
}
