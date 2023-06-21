import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { SpecialWordComponent } from './special-word.component';

const routes: Routes = [
    {
        path: '',
        component: SpecialWordComponent,
        data: {
            title: $localize`Information / Position License Requirement`
        }
    }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SpecialWordRoutingModule { }
