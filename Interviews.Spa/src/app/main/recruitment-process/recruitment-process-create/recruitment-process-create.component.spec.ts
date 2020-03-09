import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RecruitmentProcessCreateComponent } from './recruitment-process-create.component';

describe('RecruitmentProcessCreateComponent', () => {
  let component: RecruitmentProcessCreateComponent;
  let fixture: ComponentFixture<RecruitmentProcessCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RecruitmentProcessCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RecruitmentProcessCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
