import { ConfigurationSettingsItem } from "./configuration-settings-item.model";
import { ConfigurationSettingsOptionsSection } from "./configuration-settings-options-section.model";

export interface ConfigurationSettings {
    columns: Array<ConfigurationSettingsItem>;
    options: Array<ConfigurationSettingsOptionsSection>;
}
