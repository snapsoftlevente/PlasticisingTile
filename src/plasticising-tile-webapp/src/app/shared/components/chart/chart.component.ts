import { Component, OnInit } from '@angular/core';
import * as Highcharts from 'highcharts';
import more from 'highcharts/highcharts-more';
more(Highcharts);

@Component({
  selector: 'chart',
  templateUrl: './chart.component.html',
  styleUrls: ['./chart.component.scss'],
})
export class ChartComponent implements OnInit {
  Highcharts: typeof Highcharts = Highcharts;

  chartOptions: Highcharts.Options = {  
    chart: {
      polar: true,
      type: 'line'
    },
    title: {
      text: 'Compare plasticising molding machines'
    },
    pane: {
      startAngle: 0
    },
    xAxis: {
      tickmarkPlacement: 'on',
      lineWidth: 0,
      categories: ['cx300_Plasticising_Linearity', 'px050_Plasticising_Linearity', 'px080_Plasticising_Linearity', 'px120_Plasticising_Linearity', 'px160_Plasticising_Linearity', 'px200_Plasticising_Linearity'],
    },
    yAxis: {
      gridLineInterpolation: 'polygon',
      lineWidth: 0,
      min: 0
    },
    series: [{
      type: 'line',
      name: 'Average',
      data: [88.5, 90.1, 86.5, 91.1, 89.2, 90.7]
    },{
      type: 'line',
      name: 'Maximum',
      data: [89.5, 92.1, 88.3, 93.8, 90.0, 91.9]
    }],
  };
  
  constructor() {}

  ngOnInit(): void {}
}
