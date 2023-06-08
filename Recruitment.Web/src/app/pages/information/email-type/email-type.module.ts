import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { EmailTypeRoutingModule } from './email-type-routing.module';
import { EmailTypeComponent } from './email-type.component';


@NgModule({
  declarations: [
    EmailTypeComponent
  ],
  imports: [
    CommonModule,
    EmailTypeRoutingModule
  ]
})
export class EmailTypeModule { }
