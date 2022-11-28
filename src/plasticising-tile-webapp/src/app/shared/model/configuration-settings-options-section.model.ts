import { ConfigurationSettingsItem } from "./configuration-settings-item.model";

export interface ConfigurationSettingsOptionsSection {
    title: string;
    options: Array<ConfigurationSettingsItem>;
}