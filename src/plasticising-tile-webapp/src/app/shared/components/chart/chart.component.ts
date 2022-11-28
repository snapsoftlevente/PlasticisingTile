import { Component } from '@angular/core';
import * as Highcharts from 'highcharts';
import more from 'highcharts/highcharts-more';

more(Highcharts);

@Component({
  selector: 'chart',
  templateUrl: './chart.component.html',
  styleUrls: ['./chart.component.scss'],
})
export class ChartComponent {
  Highcharts: typeof Highcharts = Highcharts;
  chartOptions: Highcharts.Options = {};
  updateFlag: boolean = false;
  emptyMessage?: string;
}
