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
                loadChildren: () => import('./dashboard/dashboard.module').then((m) => m.DashboardModule)
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
            {
                path: 'recruiter/manage-profile',
                loadChildren: () => import('./pages/recruiter/manage-profile/manage-profile.module').then((m) => m.ManageProfileModule)
            },
            {
                path: 'recruiter/change-password',
                loadChildren: () => import('./pages/recruiter/change-password/change-password.module').then((m) => m.ChangePasswordModule)
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
            {
                path: 'information/institution-type',
                loadChildren: () => import('./pages/information/institution-type/institution-type.module').then((m) => m.InstitutionTypeModule)
            },
            {
                path: 'information/contact-information',
                loadChildren: () => import('./pages/information/contact-info/contact-info.module').then((m) => m.ContactInfoModule)
            },
            {
                path: 'information/position-license-requirement',
                loadChildren: () => import('./pages/information/position-license-requirement/position-license-requirement.module').then((m) => m.PositionLicenseRequirementModule)
            },
            {
                path: 'information/group-information',
                loadChildren: () => import('./pages/information/group/group.module').then((m) => m.GroupModule)
            },
            {
                path: 'information/special-word',
                loadChildren: () => import('./pages/information/special-word/special-word.module').then((m) => m.SpecialWordModule)
            },
            {
                path: 'information/upper-case-word',
                loadChildren: () => import('./pages/information/upper-case-word/upper-case-word.module').then((m) => m.UpperCaseWordModule)
            },
            {
                path: 'information/applicant-type',
                loadChildren: () => import('./pages/information/applicant-type/applicant-type.module').then((m) => m.ApplicantTypeModule)
            },
            {
                path: 'information/lower-case-word',
                loadChildren: () => import('./pages/information/lower-case-word/lower-case-word.module').then((m) => m.LowerCaseWordModule)
            },
            {
                path: 'information/visa-type',
                loadChildren: () => import('./pages/information/visa-type/visa-type.module').then((m) => m.VisaTypeModule)
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
