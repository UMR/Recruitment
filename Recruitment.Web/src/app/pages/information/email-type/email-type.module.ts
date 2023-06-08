import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { EmailTypeRoutingModule } from './email-type-routing.module';
import { EmailTypeComponent } from './email-type.component';

import { TableModule } from 'primeng/table';
import { ToastModule } from 'primeng/toast';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { DialogModule } from 'primeng/dialog';
import { CheckboxModule } from 'primeng/checkbox';

@NgModule({
  declarations: [
    EmailTypeComponent
  ],
  imports: [
    CommonModule,
      EmailTypeRoutingModule,
      TableModule,
      ToastModule,
      ConfirmDialogModule,
      CheckboxModule,
      FormsModule,
      DialogModule
  ]
})
export class EmailTypeModule { }
