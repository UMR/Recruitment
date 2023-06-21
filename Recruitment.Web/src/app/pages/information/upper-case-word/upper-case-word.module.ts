import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UpperCaseWordRoutingModule } from './upper-case-word-routing.module';
import { UpperCaseWordComponent } from './upper-case-word.component';


@NgModule({
    declarations: [UpperCaseWordComponent],
  imports: [
    CommonModule,
    UpperCaseWordRoutingModule
  ]
})
export class UpperCaseWordModule { }
