import { Component, OnInit } from '@angular/core';
import { filter, map } from 'rxjs/operators';
import { PlasticisingTileAggregationEnum } from 'src/app/api/models';
import { PlasticisingTileConfigurationService } from 'src/app/api/services';

@Component({
  selector: 'configuration-settings',
  templateUrl: './configuration-settings.component.html',
  styleUrls: ['./configuration-settings.component.scss'],
})
export class ConfigurationSettingsComponent implements OnInit {
  availableAggregations: Map<string, string> = 
    new Map<string, string>((Object.keys(PlasticisingTileAggregationEnum) as Array<keyof typeof PlasticisingTileAggregationEnum>)
    .map(k => [PlasticisingTileAggregationEnum[k], k ]));
  availableColumns: Map<string, string> = new Map<string, string>();

  constructor(private service: PlasticisingTileConfigurationService) {}

  ngOnInit(): void {
    this.service
      .getConfiguration$Json()
      .pipe(map(configuration => configuration.availableColumns))
      .subscribe(columns => {
        this.availableColumns = new Map(columns?.filter(ac => ac.key && ac.name).map(ac => [ac.key!, ac.name!]));
      });
  }
}
