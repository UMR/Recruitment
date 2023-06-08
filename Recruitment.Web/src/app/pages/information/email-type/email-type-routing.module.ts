import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmailTypeComponent } from './email-type.component';

const routes: Routes = [
    {
        path: '',
        component: EmailTypeComponent,
        data: {
            title: $localize`Information / EmailTypes`
        }
    }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class EmailTypeRoutingModule { }
