import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LowerCaseWordRoutingModule } from './lower-case-word-routing.module';
import { LowerCaseWordComponent } from './lower-case-word.component';


@NgModule({
    declarations: [LowerCaseWordComponent],
  imports: [
    CommonModule,
    LowerCaseWordRoutingModule
  ]
})
export class LowerCaseWordModule { }
