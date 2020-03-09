import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RecruitmentProcessListComponent } from './recruitment-process-list/recruitment-process-list.component';
import { RecruitmentProcessCreateComponent } from './recruitment-process-create/recruitment-process-create.component';
import { RecruitmentProcessEditComponent } from './recruitment-process-edit/recruitment-process-edit.component';
import { Routes } from '@angular/router';
import { CanActivateAuthGuard } from 'app/services/auth-guard';
import { MatFormFieldModule, MatTableModule, MatIconModule, MatButtonModule, MatPaginatorModule, MatSortModule } from '@angular/material';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

const routes: Routes =  [
  {
    path      : '',
    component : RecruitmentProcessListComponent,
    canActivate: [CanActivateAuthGuard]
  },
  {
    path      : 'processes/edit/:id',
    component : RecruitmentProcessEditComponent,
    canActivate: [CanActivateAuthGuard]
  }
];

@NgModule({
  declarations: [RecruitmentProcessListComponent, RecruitmentProcessCreateComponent, RecruitmentProcessEditComponent],
  imports: [
    CommonModule,
    MatFormFieldModule,
    ReactiveFormsModule,
    FormsModule,
    MatTableModule,
    MatIconModule,
    MatButtonModule,
    MatPaginatorModule,
    MatSortModule
  ],
  entryComponents: [
    RecruitmentProcessCreateComponent
  ]
})
export class RecruitmentProcessModule { }
