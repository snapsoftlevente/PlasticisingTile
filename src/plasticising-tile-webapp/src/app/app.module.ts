import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatButtonModule } from '@angular/material/button';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatDividerModule } from '@angular/material/divider';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';
import { MatNativeDateModule } from '@angular/material/core';
import { MatToolbarModule } from '@angular/material/toolbar';
import { HeaderComponent } from './header/header.component';
import { TileConfigurationComponent } from './tile-configuration/tile-configuration.component';
import { ConfigurationHeaderComponent } from './tile-configuration/configuration-header/configuration-header.component';
import { ConfigurationSettingsComponent } from './tile-configuration/configuration-settings/configuration-settings.component';
import { ConfigurationChartComponent } from './tile-configuration/configuration-chart/configuration-chart.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    TileConfigurationComponent,
    ConfigurationHeaderComponent,
    ConfigurationSettingsComponent,
    ConfigurationChartComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatDatepickerModule,
    MatDividerModule,
    MatFormFieldModule,
    MatIconModule,
    MatNativeDateModule,
    MatToolbarModule,
  ],
  providers: [MatDatepickerModule, MatNativeDateModule],
  bootstrap: [AppComponent],
})
export class AppModule {}
