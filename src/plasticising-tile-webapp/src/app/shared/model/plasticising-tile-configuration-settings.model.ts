import { PlasticisingTileConfigurationDto } from "@app/api/models/plasticising-tile-configuration-dto";
import { ConfigurationSettings } from "./configuration-settings.model";
import { ConfigurationSettingsItem } from "./configuration-settings-item.model";
import { ConfigurationSettingsOptionsSection } from "./configuration-settings-options-section.model";

export class PlasticisingTileConfigurationSettings implements ConfigurationSettings {   
    columns: Array<ConfigurationSettingsItem> = new Array<ConfigurationSettingsItem>();
    options: Array<ConfigurationSettingsOptionsSection> = new Array<ConfigurationSettingsOptionsSection>();

    constructor(dto: PlasticisingTileConfigurationDto) {  
        if (dto.availableColumns && dto.availableColumns.length)
        {
            this.columns = dto.availableColumns
                .filter(ac => ac.key && ac.name)
                .map(ac => ({ 
                    key: ac.key!, 
                    label: ac.name!, 
                    isSelected: dto.selectedColumns?.some(sc => sc.key === ac.key) 
                } as ConfigurationSettingsItem));
        }    

        if (dto.availableAggregations && dto.availableAggregations.length)
        {
            this.options.push({
                title: "Aggregations",
                options: dto.availableAggregations
                    .map(aa => ({ 
                        key: aa, 
                        label: aa[0].toUpperCase() + aa.slice(1).toLowerCase(), // capitalize first letter
                        isSelected: dto.selectedAggregations?.includes(aa) 
                    } as ConfigurationSettingsItem))
            } as ConfigurationSettingsOptionsSection);
        }
    }
}
