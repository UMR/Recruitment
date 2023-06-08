import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './auth.guard';

import { DefaultLayoutComponent } from './containers';
import { LoginComponent } from './login/login.component';

const routes: Routes = [
    {
        path: '',
        component: DefaultLayoutComponent,
        canActivate: [AuthGuard],
        children: [
            {
                path: 'dashboard',
                loadChildren: () =>import('./dashboard/dashboard.module').then((m) => m.DashboardModule)
            },
            //////////// --------------------------   recruiter menu portion ------------------------///////
            {
                path: 'recruiter/manage-recruiter',
                loadChildren: () => import('./pages/recruiter/manage-recruiter/manage-recruiter.module').then((m) => m.ManageRecruiterModule)
            },
            {
                path: 'recruiter/manage-role',
                loadChildren: () => import('./pages/recruiter/manage-role/manage-role.module').then((m) => m.ManageRoleModule)
            },
            //////////// --------------------------   information menu portion ------------------------///////
            {
                path: 'information/agency',
                loadChildren: () => import('./pages/information/agency/agency.module').then((m) => m.AgencyModule)
            },
            {
                path: 'information/email-types',
                loadChildren: () => import('./pages/information/email-type/email-type.module').then((m) => m.EmailTypeModule)
            },
        ]
    },
    {
        path: 'login',
        component: LoginComponent,
    },
    {
        path: 'page-not-found',
        loadChildren: () =>
            import('./page-not-found/page-not-found.module').then((m) => m.PageNotFoundModule)
    },
    { path: '**', redirectTo: 'page-not-found' }
];

@NgModule({
    imports: [
        RouterModule.forRoot(routes, {
            scrollPositionRestoration: 'top',
            anchorScrolling: 'enabled',
            initialNavigation: 'enabledBlocking'
        })
    ],
    exports: [RouterModule]
})
export class AppRoutingModule {
}
