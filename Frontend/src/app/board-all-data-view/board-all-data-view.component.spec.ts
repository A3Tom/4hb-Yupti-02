import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BoardAllDataViewComponent } from './board-all-data-view.component';

describe('BoardAllDataViewComponent', () => {
  let component: BoardAllDataViewComponent;
  let fixture: ComponentFixture<BoardAllDataViewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BoardAllDataViewComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BoardAllDataViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
