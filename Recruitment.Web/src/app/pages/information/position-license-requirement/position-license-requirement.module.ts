import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { PositionLicenseRequirementRoutingModule } from './position-license-requirement-routing.module';
import { PositionLicenseRequirementComponent } from './position-license-requirement.component';

import { TableModule } from 'primeng/table';
import { ToastModule } from 'primeng/toast';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { DialogModule } from 'primeng/dialog';
import { ConfirmationService, MessageService } from 'primeng/api';


@NgModule({
    declarations: [
        PositionLicenseRequirementComponent
    ],
    imports: [
        CommonModule,
        PositionLicenseRequirementRoutingModule,
        FormsModule,
        ReactiveFormsModule,
        TableModule,
        ToastModule,
        ConfirmDialogModule,        
        DialogModule
    ],
    providers: [ConfirmationService, MessageService]
})
export class PositionLicenseRequirementModule { }
