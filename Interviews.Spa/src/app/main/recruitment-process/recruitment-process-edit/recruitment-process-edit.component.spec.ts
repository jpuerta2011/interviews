import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RecruitmentProcessEditComponent } from './recruitment-process-edit.component';

describe('RecruitmentProcessEditComponent', () => {
  let component: RecruitmentProcessEditComponent;
  let fixture: ComponentFixture<RecruitmentProcessEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RecruitmentProcessEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RecruitmentProcessEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
