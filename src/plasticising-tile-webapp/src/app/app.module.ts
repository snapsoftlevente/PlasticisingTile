import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CdkAccordionModule } from '@angular/cdk/accordion';
import { HighchartsChartModule } from 'highcharts-angular';
import { HttpClientModule } from '@angular/common/http';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatDividerModule } from '@angular/material/divider';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
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
    CdkAccordionModule,
    HighchartsChartModule,
    HttpClientModule,
    MatButtonModule,
    MatCardModule,
    MatCheckboxModule,
    MatDatepickerModule,
    MatDividerModule,
    MatFormFieldModule,
    MatIconModule,
    MatInputModule,
    MatNativeDateModule,
    MatToolbarModule,
  ],
  providers: [MatDatepickerModule, MatNativeDateModule],
  bootstrap: [AppComponent],
})
export class AppModule {}
