import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GroupingListComponent } from './grouping-list.component';

describe('GroupingListComponent', () => {
  let component: GroupingListComponent;
  let fixture: ComponentFixture<GroupingListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GroupingListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GroupingListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
