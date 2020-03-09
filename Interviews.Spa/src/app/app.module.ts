import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule, Routes } from '@angular/router';
import { MatMomentDateModule } from '@angular/material-moment-adapter';
import { MatButtonModule, MatIconModule, MatDialogModule, MatSnackBarModule } from '@angular/material';
import { TranslateModule } from '@ngx-translate/core';
import 'hammerjs';

import { FuseModule } from '@fuse/fuse.module';
import { FuseSharedModule } from '@fuse/shared.module';
import { FuseProgressBarModule, FuseSidebarModule, FuseThemeOptionsModule } from '@fuse/components';

import { fuseConfig } from 'app/fuse-config';

import { AppComponent } from 'app/app.component';
import { LayoutModule } from 'app/layout/layout.module';
import { SampleModule } from 'app/main/sample/sample.module';
import { CanActivateAuthGuard } from './services/auth-guard';
import { AuthenticationService } from './services/auth-service';
import { GeneralHttpService } from './services/general-http-service';
import { CustomHttpInterceptor } from './services/custom-http-interceptor';
import { YesNoModalComponent } from './main/shared-modals/yes-no-modal/yes-no-modal.component';
import { ErrorToastMessageComponent } from './main/shared-modals/error-toast-message/error-toast-message.component';
import { SuccessToastMessageComponent } from './main/shared-modals/success-toast-message/success-toast-message.component';
import { UserOfficeService } from './services/user-office.service';
import { FileSelectDirective, FileUploadModule } from 'ng2-file-upload';
import { MyPymeSharedModule } from './main/my-pyme-shared/my-pyme-shared.module';


const appRoutes: Routes = [
    {
        path        : 'auth',
        loadChildren: './main/authentication/authentication.module#AuthenticationModule'
    },
    {
        path        : 'copasst',
        loadChildren: './main/copasst-module/copasst.module#CopasstModule'
    },
    {
        path        : 'heading',
        loadChildren: './main/heading-module/heading.module#HeadingModule'
    },
    {
        path        : 'parafiscal',
        loadChildren: './main/parafiscal-module/parafiscal.module#ParafiscalModule'
    },
    {
        path        : 'budget',
        loadChildren: './main/budget-module/budget.module#BudgetModule'
    },
    {
        path        : 'cocola',
        loadChildren: './main/cocola-module/cocola.module#CocolaModule'
    },
    {
        path        : 'lawmatrix',
        loadChildren: './main/lawmatrix-module/lawmatrix.module#LawMatrixModule'
    },
    {
        path        : 'training',
        loadChildren: './main/training-module/training.module#TrainingModule'
    },
    {
        path        : 'documentstructure',
        loadChildren: './main/documentstructure-module/documentstructure.module#DocumentStructureModule'
    },
    {
        path        : 'position',
        loadChildren: './main/position-module/position.module#PositionModule'
    },
    {
        path        : 'user',
        loadChildren: './main/user-module/user.module#UserModule'
    },
    {
        path        : 'employee',
        loadChildren: './main/employee-module/employee.module#EmployeeModule'
    },
    {
        path        : 'skill',
        loadChildren: './main/skill-module/skill.module#SkillModule'
    },
    {
        path        : 'organization-office',
        loadChildren: './main/organization-office-module/organization-office.module#OrganizationOfficeModule'
    },
    {
        path        : 'participation-mechanism',
        loadChildren: './main/participation-mechanism-module/participation-mechanism.module#ParticipationmechanismModule'
    },
    {
        path        : 'communication-plan',
        loadChildren: './main/communication-plan-module/communication-plan.module#CommunicationPlanModule'
    },
    {
        path        : 'communication-aspect',
        loadChildren: './main/communication-aspect-module/communication-aspect.module#CommunicationAspectModule'
    },   
    {
        path        : 'environment-measure',
        loadChildren: './main/environment-measure-module/environment-measure.module#EnvironmentMeasureModule'
    },
    {
        path        : 'medical-evaluation',
        loadChildren: './main/medical-evaluation-module/medical-evaluation.module#MedicalEvaluationModule'
    },
    {     
        path        : 'evaluation-rate',
        loadChildren: './main/evaluation-rate-module/evaluation-rate.module#EvaluationRateModule'
    },
    {
        path        : 'personal-protection-element',
        loadChildren: './main/personal-protection-module/personal-protection.module#PersonalProtectionModuleModule'
    },
    {
        path      : '**',
        redirectTo: 'sample'
    }   
];

@NgModule({
    declarations: [
        AppComponent,
        YesNoModalComponent,
        ErrorToastMessageComponent,
        SuccessToastMessageComponent
    ],
    imports     : [
        BrowserModule,
        BrowserAnimationsModule,
        HttpClientModule,
        RouterModule.forRoot(appRoutes),

        TranslateModule.forRoot(),

        // Material moment date module
        MatMomentDateModule,

        // Material
        MatButtonModule,
        MatIconModule,
        MatDialogModule,
        MatSnackBarModule,
        // Fuse modules
        FuseModule.forRoot(fuseConfig),
        FuseProgressBarModule,
        FuseSharedModule,
        FuseSidebarModule,
        FuseThemeOptionsModule,

        // MyPymeSharedModule,
        FileUploadModule,

        // App modules
        LayoutModule,
        SampleModule
    ],
    bootstrap   : [
        AppComponent
    ],
    entryComponents: [
        YesNoModalComponent, 
        ErrorToastMessageComponent,
        SuccessToastMessageComponent
    ],
    providers: [
        CanActivateAuthGuard,
        AuthenticationService,
        UserOfficeService,
        GeneralHttpService,
        { provide: HTTP_INTERCEPTORS, useClass: CustomHttpInterceptor, multi: true}
    ]
})
export class AppModule
{
}
