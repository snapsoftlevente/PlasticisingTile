import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TileConfigurationComponent } from './tile-configuration.component';

describe('TileConfigurationComponent', () => {
  let component: TileConfigurationComponent;
  let fixture: ComponentFixture<TileConfigurationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TileConfigurationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TileConfigurationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
