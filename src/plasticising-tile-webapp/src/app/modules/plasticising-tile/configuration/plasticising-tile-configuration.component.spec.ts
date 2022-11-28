import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PlasticisingTileConfigurationComponent } from './plasticising-tile-configuration.component';

describe('TileConfigurationComponent', () => {
  let component: PlasticisingTileConfigurationComponent;
  let fixture: ComponentFixture<PlasticisingTileConfigurationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PlasticisingTileConfigurationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PlasticisingTileConfigurationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
