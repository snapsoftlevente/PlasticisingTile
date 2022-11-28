import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PlasticisingTileConfigurationComponent } from './configuration/plasticising-tile-configuration.component';

export const routes: Routes = [
  {
    path: '',
    redirectTo: 'configuration',
    pathMatch: 'full'
  },
  {
    path: 'configuration',
    component: PlasticisingTileConfigurationComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PlasticisingTileRoutingModule {}
