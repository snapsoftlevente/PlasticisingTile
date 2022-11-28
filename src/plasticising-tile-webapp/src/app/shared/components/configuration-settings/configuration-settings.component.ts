import { Component, EventEmitter, Output } from '@angular/core';
import { ConfigurationSettingsItem } from '@app/shared/model/configuration-settings-item.model';
import { ConfigurationSettings } from '@shared/model/configuration-settings.model';

@Component({
  selector: 'configuration-settings',
  templateUrl: './configuration-settings.component.html',
  styleUrls: ['./configuration-settings.component.scss'],
})
export class ConfigurationSettingsComponent {
  @Output() settingsChanged = new EventEmitter<ConfigurationSettings>();
  
  searchTerm: any;
  settings: ConfigurationSettings = {} as ConfigurationSettings;

  constructor() {}

  searchMatch = (item: ConfigurationSettingsItem): boolean => !this.searchTerm || item.label.includes(this.searchTerm);
  showHeader = (): boolean => this.settings.columns && this.settings.columns.some(c => c.isSelected) && this.settings.columns.some(c => !c.isSelected);

  isSelected = (item: ConfigurationSettingsItem): boolean => item.isSelected;
  isUnselected = (item: ConfigurationSettingsItem): boolean => !item.isSelected;

  toggleItemSelected(item: ConfigurationSettingsItem) {
    item.isSelected = !item.isSelected;
    this.settingsChanged.emit(this.settings);
  }

  optionChanged() {
    this.settingsChanged.emit(this.settings);
  }
}
