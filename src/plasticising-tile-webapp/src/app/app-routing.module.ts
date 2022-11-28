import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ContentLayoutComponent } from './layout/content-layout/content-layout.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: '/plasticising-tile',
    pathMatch: 'full'
  },
  {
    path: '',
    component: ContentLayoutComponent,
    children: [
      {
        path: 'plasticising-tile',
        loadChildren: () =>
          import('@modules/plasticising-tile/plasticising-tile.module').then(m => m.PlasticisingTileModule)
      }
    ]
  },
  // Fallback when no prior routes is matched
  { path: '**', redirectTo: '/plasticising-tile', pathMatch: 'full' }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, {
      useHash: true,
      relativeLinkResolution: 'legacy'
    })
  ],
  exports: [RouterModule],
  providers: []
})
export class AppRoutingModule {}
