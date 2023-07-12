import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AssignRecruiterRoleRoutingModule } from './assign-recruiter-role-routing.module';
import { AssignRecruiterRoleComponent } from './assign-recruiter-role.component';


@NgModule({
  declarations: [
    AssignRecruiterRoleComponent
  ],
  imports: [
    CommonModule,
    AssignRecruiterRoleRoutingModule
  ]
})
export class AssignRecruiterRoleModule { }
