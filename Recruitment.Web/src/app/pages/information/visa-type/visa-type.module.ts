import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { VisaTypeRoutingModule } from './visa-type-routing.module';
import { VisaTypeComponent } from './visa-type.component';

import { TableModule } from 'primeng/table';
import { ToastModule } from 'primeng/toast';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { DialogModule } from 'primeng/dialog';
import { ConfirmationService, MessageService } from 'primeng/api';



@NgModule({
    declarations: [VisaTypeComponent],
    imports: [
        CommonModule,
        VisaTypeRoutingModule,
        FormsModule,
        ReactiveFormsModule,
        TableModule,
        ToastModule,
        ConfirmDialogModule,
        DialogModule
    ],
    providers: [ConfirmationService, MessageService]
})
export class VisaTypeModule { }
