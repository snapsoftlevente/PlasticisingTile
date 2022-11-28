import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { DateTimeRangeFilter } from '@app/shared/model/date-time-range-filter.model';
import { environment } from '@env';

@Component({
  selector: 'configuration-header',
  templateUrl: './configuration-header.component.html',
  styleUrls: ['./configuration-header.component.scss'],
})
export class ConfigurationHeaderComponent {
  @Output() dateTimeRangeFilterChanged = new EventEmitter<DateTimeRangeFilter>();
  dateTimeRangeFilter: DateTimeRangeFilter = environment.defaultDateTimeRangeFilter;
  dateChanged = () => this.dateTimeRangeFilterChanged.emit(this.dateTimeRangeFilter);
}
