import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { PlasticisingTileConfigureRequestDto } from '@app/api/models';
import { PlasticisingTileConfigurationService } from '@app/api/services';
import { ChartComponent } from '@app/shared/components/chart/chart.component';
import { ConfigurationHeaderComponent } from '@app/shared/components/configuration-header/configuration-header.component';
import { ConfigurationSettingsComponent } from '@app/shared/components/configuration-settings/configuration-settings.component';
import { PlasticisingTileConfigurationSettings } from '@app/shared/model/plasticising-tile-configuration-settings.model';
import { environment } from '@env';

@Component({
  selector: 'plasticising-tile-configuration',
  templateUrl: './plasticising-tile-configuration.component.html',
  styleUrls: ['./plasticising-tile-configuration.component.scss'],
})
export class PlasticisingTileConfigurationComponent implements AfterViewInit {
  
  @ViewChild(ChartComponent) 
  chartComponent: ChartComponent = {} as ChartComponent;
  
  @ViewChild(ConfigurationHeaderComponent) 
  headerComponent: ConfigurationHeaderComponent = {} as ConfigurationHeaderComponent;

  @ViewChild(ConfigurationSettingsComponent) 
  settingsComponent: ConfigurationSettingsComponent = {} as ConfigurationSettingsComponent;

  emptyChartMessage = environment.emptyChartMessage
    .replace('{0}', environment.minimumAggregations.toString())
    .replace('{1}', environment.minimumColumns.toString());

  constructor(private service: PlasticisingTileConfigurationService) {}

  ngAfterViewInit(): void {
    this.chartComponent.emptyMessage = this.emptyChartMessage;

    this.service
      .getConfiguration$Json()
      .subscribe(dto => {
        this.settingsComponent.settings = new PlasticisingTileConfigurationSettings(dto);
      });
  }

  onDateTimeRangeFilterChanged() {
    this.refreshChart();
  }

  onSettingsChanged() {
    this.refreshChart();
  }    

  // TODO refactor function
  refreshChart() {
    const settings = this.settingsComponent.settings;
    const selectedAggregations = settings.options[0].options.filter(o => o.isSelected).map(o => o.key);
    const selectedColumnKeys = settings.columns.filter(c => c.isSelected).map(c => c.key);

    if (selectedAggregations.length >= environment.minimumAggregations && selectedColumnKeys.length >= environment.minimumColumns) {

      const requestBody = {
        dateTimeRangeFilter: {
          dateTimeFrom: this.headerComponent.dateTimeRangeFilter.dateTimeFrom,
          dateTimeTo: this.headerComponent.dateTimeRangeFilter.dateTimeTo,
        },
        selectedAggregations,
        selectedColumnKeys
      } as PlasticisingTileConfigureRequestDto;
      
      this.service.getTileByConfiguration$Json({body: requestBody})
        .subscribe(dto => {
          const chartOptions = environment.polarChartOptions as Highcharts.Options;
  
          (chartOptions.xAxis as Highcharts.XAxisOptions).categories = selectedColumnKeys;
          chartOptions.series = dto.series?.map(s => ({ 
            name: s.name,
            data: s.dataPoints
          } as Highcharts.SeriesLineOptions));
  
          this.chartComponent.chartOptions = chartOptions;
          this.chartComponent.updateFlag = true;

          this.chartComponent.emptyMessage = undefined;
        }); 
    } else {
      this.chartComponent.emptyMessage = this.emptyChartMessage;
    }    
  }
}
