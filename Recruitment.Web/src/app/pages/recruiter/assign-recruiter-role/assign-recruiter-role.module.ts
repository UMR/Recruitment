import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AssignRecruiterRoleRoutingModule } from './assign-recruiter-role-routing.module';
import { AssignRecruiterRoleComponent } from './assign-recruiter-role.component';
import { CardModule } from 'primeng/card';
import { DropdownModule } from 'primeng/dropdown';
import { FormsModule } from '@angular/forms';
import { TableModule } from 'primeng/table';


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
    AssignRecruiterRoleRoutingModule
  ]
})
export class AssignRecruiterRoleModule { }
