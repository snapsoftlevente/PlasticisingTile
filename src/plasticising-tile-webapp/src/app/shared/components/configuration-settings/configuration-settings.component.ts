import { Component } from '@angular/core';
import { ConfigurationSettingsItem } from '@app/shared/model/configuration-settings-item.model';
import { ConfigurationSettings } from '@shared/model/configuration-settings.model';

@Component({
  selector: 'configuration-settings',
  templateUrl: './configuration-settings.component.html',
  styleUrls: ['./configuration-settings.component.scss'],
})
export class ConfigurationSettingsComponent {
  settings: ConfigurationSettings = {} as ConfigurationSettings;

  constructor() {}

  isSelected = (item: ConfigurationSettingsItem): boolean => item.isSelected;
  isUnselected = (item: ConfigurationSettingsItem): boolean => !item.isSelected;

  showHeader = (): boolean => this.settings.columns 
    && this.settings.columns.some(c => c.isSelected) 
    && this.settings.columns.some(c => !c.isSelected);

  toggleItemSelected = (item: ConfigurationSettingsItem) => item.isSelected = !item.isSelected;
}
