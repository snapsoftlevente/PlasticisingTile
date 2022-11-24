/* tslint:disable */
/* eslint-disable */
import { DateTimeRangeFilterDto } from './date-time-range-filter-dto';
import { PlasticisingTileAggregationEnum } from './plasticising-tile-aggregation-enum';
export interface PlasticisingTileConfigureRequestDto {
  dateTimeRangeFilter?: DateTimeRangeFilterDto;
  selectedAggregations?: null | Array<PlasticisingTileAggregationEnum>;
  selectedColumnKeys?: null | Array<string>;
}
