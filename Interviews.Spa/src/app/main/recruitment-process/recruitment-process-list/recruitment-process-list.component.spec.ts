import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RecruitmentProcessListComponent } from './recruitment-process-list.component';

describe('RecruitmentProcessListComponent', () => {
  let component: RecruitmentProcessListComponent;
  let fixture: ComponentFixture<RecruitmentProcessListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RecruitmentProcessListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RecruitmentProcessListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
