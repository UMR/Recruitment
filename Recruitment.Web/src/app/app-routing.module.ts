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
            {
                path: 'manage-recruiter',
                loadChildren: () => import('./recruiter/manage-recruiter/manage-recruiter.module').then((m) => m.ManageRecruiterModule)
            },
            {
                path: 'manage-role',
                loadChildren: () => import('./recruiter/manage-role/manage-role.module').then((m) => m.ManageRoleModule)
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
