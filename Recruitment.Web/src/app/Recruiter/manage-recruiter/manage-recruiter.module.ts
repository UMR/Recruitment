import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ManageRecruiterComponent } from './manage-recruiter.component';
import { ManageRecruiterRoutingModule } from './manage-recruiter-routing.module';



@NgModule({
    declarations: [
        ManageRecruiterComponent
    ],
    imports: [
        CommonModule,
        ManageRecruiterRoutingModule
    ]
})
export class ManageRecruiterModule { }
