import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { PostCodeComponent } from './post-code.component';

const routes: Routes = [
    {
        path: '',
        component: PostCodeComponent,
        data: {
            title: $localize`Information / Post Code Information`
        }
    }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PostCodeRoutingModule { }
