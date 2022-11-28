import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { HighchartsChartModule } from 'highcharts-angular';
import { MaterialModule } from './material.module';

import { ConfigurationHeaderComponent } from './components/configuration-header/configuration-header.component';
import { ConfigurationSettingsComponent } from './components/configuration-settings/configuration-settings.component';
import { ChartComponent } from './components/chart/chart.component';

@NgModule({
  imports: [
    CommonModule,
    HighchartsChartModule,
    MaterialModule,
    RouterModule
  ],
  declarations: [
    ConfigurationHeaderComponent,
    ConfigurationSettingsComponent,
    ChartComponent
  ],
  exports: [
    CommonModule,
    RouterModule,
    MaterialModule,
    ConfigurationHeaderComponent,
    ConfigurationSettingsComponent,
    ChartComponent
  ]
})
export class SharedModule {}
