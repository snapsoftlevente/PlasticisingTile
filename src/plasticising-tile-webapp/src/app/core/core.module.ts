import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FilterFunctionPipe } from './pipes/filter-function.pipe';
import { ArraySortPipe } from './pipes/sort.pipe';

@NgModule({
  imports: [HttpClientModule],
  declarations: [ArraySortPipe, FilterFunctionPipe],
  exports: [ArraySortPipe, FilterFunctionPipe],
  providers: []
})
export class CoreModule {
  constructor() {
  }
}
