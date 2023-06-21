import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ApplicantTypeRoutingModule } from './applicant-type-routing.module';
import { ApplicantTypeComponent } from './applicant-type.component';


@NgModule({
  declarations: [
    ApplicantTypeComponent
  ],
  imports: [
    CommonModule,
    ApplicantTypeRoutingModule
  ]
})
export class ApplicantTypeModule { }
