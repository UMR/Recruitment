import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PostCodeRoutingModule } from './post-code-routing.module';
import { PostCodeComponent } from './post-code.component';


@NgModule({
    declarations: [PostCodeComponent],
  imports: [
    CommonModule,
    PostCodeRoutingModule
  ]
})
export class PostCodeModule { }
