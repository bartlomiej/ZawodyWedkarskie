/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { KoloWedkarskieComponent } from './KoloWedkarskie.component';

describe('KoloWedkarskieComponent', () => {
  let component: KoloWedkarskieComponent;
  let fixture: ComponentFixture<KoloWedkarskieComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ KoloWedkarskieComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(KoloWedkarskieComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
