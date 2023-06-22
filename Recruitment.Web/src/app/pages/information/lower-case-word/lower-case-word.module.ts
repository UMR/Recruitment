import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { LowerCaseWordRoutingModule } from './lower-case-word-routing.module';
import { LowerCaseWordComponent } from './lower-case-word.component';


import { TableModule } from 'primeng/table';
import { ToastModule } from 'primeng/toast';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { DialogModule } from 'primeng/dialog';
import { ConfirmationService, MessageService } from 'primeng/api';


@NgModule({
    declarations: [LowerCaseWordComponent],
    imports: [
        CommonModule,
        LowerCaseWordRoutingModule,
        FormsModule,
        ReactiveFormsModule,
        TableModule,
        ToastModule,
        ConfirmDialogModule,
        DialogModule
    ],
    providers: [ConfirmationService, MessageService ]
})
export class LowerCaseWordModule { }
