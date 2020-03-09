import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule, Routes } from '@angular/router';
import { MatMomentDateModule } from '@angular/material-moment-adapter';
import { MatButtonModule, MatIconModule } from '@angular/material';
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
import { RecruitmentProcessListComponent } from './main/recruitment-process/recruitment-process-list/recruitment-process-list.component';
import { RecruitmentProcessCreateComponent } from './main/recruitment-process/recruitment-process-create/recruitment-process-create.component';
import { RecruitmentProcessEditComponent } from './main/recruitment-process/recruitment-process-edit/recruitment-process-edit.component';

const appRoutes: Routes = [
    {
        path        : 'auth',
        loadChildren: './main/authentication/authentication.module#AuthenticationModule'
    },
    {
        path        : 'processes',
        loadChildren: './main/copasst-module/copasst.module#CopasstModule'
    },
    {
        path      : '**',
        redirectTo: 'processes'
    }

];

@NgModule({
    declarations: [
        AppComponent,
        RecruitmentProcessListComponent,
        RecruitmentProcessCreateComponent,
        RecruitmentProcessEditComponent,
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

        // Fuse modules
        FuseModule.forRoot(fuseConfig),
        FuseProgressBarModule,
        FuseSharedModule,
        FuseSidebarModule,
        FuseThemeOptionsModule,

        // App modules
        LayoutModule,
        SampleModule
    ],
    bootstrap   : [
        AppComponent
    ],
    providers: [
        CanActivateAuthGuard,
        AuthenticationService,
        GeneralHttpService,
        { provide: HTTP_INTERCEPTORS, useClass: CustomHttpInterceptor, multi: true}
    ]
})
export class AppModule
{
}
