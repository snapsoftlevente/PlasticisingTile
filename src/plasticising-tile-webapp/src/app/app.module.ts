import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { ApiModule } from '@api/api.module';
import { CoreModule } from '@core/core.module';
import { SharedModule } from '@shared/shared.module';

import { AppComponent } from './app.component';
import { ContentLayoutComponent } from './layout/content-layout/content-layout.component';
import { HeaderComponent } from './layout/header/header.component';

import { environment } from '@env';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    ContentLayoutComponent,
  ],
  imports: [
    AppRoutingModule,
    BrowserModule,
    BrowserAnimationsModule,
    ApiModule.forRoot({ rootUrl: environment.apiRootUrl }),
    CoreModule,
    SharedModule
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
