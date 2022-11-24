/* tslint:disable */
/* eslint-disable */
import { DatasourceColumnDto } from './datasource-column-dto';
import { DateTimeRangeFilterDto } from './date-time-range-filter-dto';
import { PlasticisingTileAggregationEnum } from './plasticising-tile-aggregation-enum';
export interface PlasticisingTileConfigurationDto {
  availableColumns?: null | Array<DatasourceColumnDto>;
  dateTimeRangeFilter?: DateTimeRangeFilterDto;
  selectedAggregations?: null | Array<PlasticisingTileAggregationEnum>;
  selectedColumns?: null | Array<DatasourceColumnDto>;
}
