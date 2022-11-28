import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PlasticisingTileRoutingModule } from './plasticising-tile.routing';
import { SharedModule } from '@app/shared/shared.module';

import { PlasticisingTileConfigurationComponent } from './configuration/plasticising-tile-configuration.component';

@NgModule({
  declarations: [
    PlasticisingTileConfigurationComponent
  ],
  imports: [
    CommonModule,
    PlasticisingTileRoutingModule,
    SharedModule
  ]
})
export class PlasticisingTileModule { }
