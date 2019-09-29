import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ActorsViewComponent } from './actors-view.component';

describe('ActorsViewComponent', () => {
  let component: ActorsViewComponent;
  let fixture: ComponentFixture<ActorsViewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ActorsViewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ActorsViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
