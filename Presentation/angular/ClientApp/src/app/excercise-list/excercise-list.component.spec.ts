import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ExcerciseListComponent } from './excercise-list.component';

describe('ExcerciseListComponent', () => {
  let component: ExcerciseListComponent;
  let fixture: ComponentFixture<ExcerciseListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ExcerciseListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ExcerciseListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
