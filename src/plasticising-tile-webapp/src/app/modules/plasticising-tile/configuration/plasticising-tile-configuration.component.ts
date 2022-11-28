import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { PlasticisingTileConfigurationService } from '@app/api/services';
import { ChartComponent } from '@app/shared/components/chart/chart.component';
import { ConfigurationHeaderComponent } from '@app/shared/components/configuration-header/configuration-header.component';
import { ConfigurationSettingsComponent } from '@app/shared/components/configuration-settings/configuration-settings.component';
import { PlasticisingTileConfigurationSettings } from '@app/shared/model/plasticising-tile-configuration-settings.model';

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

  constructor(private service: PlasticisingTileConfigurationService) {}

  ngAfterViewInit(): void {
    this.service
      .getConfiguration$Json()
      .subscribe(dto => {
        this.settingsComponent.settings = new PlasticisingTileConfigurationSettings(dto);
      });
  }
}
