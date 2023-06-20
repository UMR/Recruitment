import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ManageRecruiterComponent } from './manage-recruiter.component';
import { ManageRecruiterRoutingModule } from './manage-recruiter-routing.module';


import { ToastModule } from 'primeng/toast';
import { TableModule } from 'primeng/table';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { ConfirmationService, MessageService } from 'primeng/api';
import { CheckboxModule } from 'primeng/checkbox';
import { FormsModule } from '@angular/forms';
import { DialogModule } from 'primeng/dialog';
import { InputMaskModule } from 'primeng/inputmask';
import { InputTextareaModule } from 'primeng/inputtextarea';
import { KeyFilterModule } from 'primeng/keyfilter';



@NgModule({
    declarations: [
        ManageRecruiterComponent
    ],
    imports: [
        CommonModule,
        ManageRecruiterRoutingModule,
        TableModule,
        ToastModule,
        ConfirmDialogModule,
        CheckboxModule,
        FormsModule,
        DialogModule,
        InputMaskModule,
        InputTextareaModule,
        KeyFilterModule
    ],
    providers: [ConfirmationService, MessageService]
})
export class ManageRecruiterModule { }
