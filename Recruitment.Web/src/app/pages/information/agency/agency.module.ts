import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AgencyRoutingModule } from './agency-routing.module';
import { AgencyComponent } from './agency.component';
import { ToastModule } from 'primeng/toast';
import { TableModule } from 'primeng/table';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { ConfirmationService, MessageService } from 'primeng/api';


@NgModule({
    declarations: [
        AgencyComponent
    ],
    imports: [
        CommonModule,
        AgencyRoutingModule,
        TableModule,
        ToastModule,
        ConfirmDialogModule
    ],
    providers: [ConfirmationService, MessageService]
})
export class AgencyModule { }
