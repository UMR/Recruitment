import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SpecialWordRoutingModule } from './special-word-routing.module';
import { SpecialWordComponent } from './special-word.component';


@NgModule({
    declarations: [SpecialWordComponent],
  imports: [
    CommonModule,
    SpecialWordRoutingModule
  ]
})
export class SpecialWordModule { }
