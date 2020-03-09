import { Component, OnInit, ViewChild } from '@angular/core';
import { MatTableDataSource, MatPaginator, MatSort, MatDialog, MatSnackBar } from '@angular/material';
import { RecruiterProcess } from 'app/models/recruiter-process.model';
import { GeneralHttpService } from 'app/services/general-http-service';
import { FuseProgressBarService } from '@fuse/components/progress-bar/progress-bar.service';
import { Router } from '@angular/router';
import { ErrorToastMessageComponent } from 'app/main/shared-modals/error-toast-message/error-toast-message.component';
import { RecruitmentProcessCreateComponent } from '../recruitment-process-create/recruitment-process-create.component';

@Component({
  selector: 'app-recruitment-process-list',
  templateUrl: './recruitment-process-list.component.html',
  styleUrls: ['./recruitment-process-list.component.scss']
})
export class RecruitmentProcessListComponent implements OnInit {

  displayedColumns: string[] = ['description', 'technology', 'edit-action'];
  dataSource: MatTableDataSource<RecruiterProcess>;

  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  constructor(
    private readonly generalHttpService: GeneralHttpService,
    private readonly fuseProgressBarService: FuseProgressBarService,
    private readonly router: Router,
    private readonly dialog: MatDialog,
    private readonly snackBar: MatSnackBar
  ) { }

  ngOnInit(): void {
    this.dataSource = new MatTableDataSource();
    this.loadProcesses();
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  loadProcesses(): void {
    this.fuseProgressBarService.show();
    this.generalHttpService.getAll<RecruiterProcess[]>('RecruitmentProcesses')
      .subscribe(
        results => {
          console.log(results);
          this.dataSource.data = results;
          this.fuseProgressBarService.hide();
        },
        errorResult => {
          console.log(errorResult);
          this.fuseProgressBarService.hide();
          this.snackBar.openFromComponent(ErrorToastMessageComponent, {
            verticalPosition: ErrorToastMessageComponent.verticalPosition,
            horizontalPosition: ErrorToastMessageComponent.horizontalPosition,
            data: errorResult.error
          });
        }
      );
  }

  onRecruitmentProcessEdit(selectedItem: RecruiterProcess): void {
    this.router.navigate(['processes/edit/' + selectedItem.recruiterProcessId]);
  }

  applyFilter(filterValue: string): void {
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  addRecruitmentProcess() {
    const addProcessDialog = this.dialog.open(RecruitmentProcessCreateComponent, {
      width: "600px"
    });

    addProcessDialog.afterClosed()
      .subscribe((result: RecruiterProcess) => {
        if (!result) {
          return;
        }

        this.generalHttpService.post('RecruitmentProcesses', result)
        .subscribe((response: any) => {
          this.router.navigate([`edit/${response.data}`]);
        },
        errorResult => {
          this.snackBar.openFromComponent(ErrorToastMessageComponent, {
            verticalPosition: ErrorToastMessageComponent.verticalPosition,
            horizontalPosition: ErrorToastMessageComponent.horizontalPosition,
            data: errorResult.message
          });
        });
      });
  }

}
