import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AssignRecruiterRoleRoutingModule } from './assign-recruiter-role-routing.module';
import { AssignRecruiterRoleComponent } from './assign-recruiter-role.component';
import { CardModule } from 'primeng/card';
import { DropdownModule } from 'primeng/dropdown';
import { FormsModule } from '@angular/forms';
import { TableModule } from 'primeng/table';
import { ButtonModule } from 'primeng/button';


@NgModule({
    declarations: [
        AssignRecruiterRoleComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        CardModule,
        TableModule,
        DropdownModule,
        ButtonModule,
        AssignRecruiterRoleRoutingModule
    ]
})
export class AssignRecruiterRoleModule { }
