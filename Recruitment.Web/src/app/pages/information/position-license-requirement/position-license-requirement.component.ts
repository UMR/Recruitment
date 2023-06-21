import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ConfirmationService, MessageService } from 'primeng/api';

import { PositionLicenseRequirementModel } from '../../../common/models/position-license-requirement.model';
import { PositionLicenseRequirementService } from './position-license-requirement.service';

@Component({
    selector: 'app-position-license-requirement',
    templateUrl: './position-license-requirement.component.html',
    styleUrls: ['./position-license-requirement.component.scss']
})
export class PositionLicenseRequirementComponent {
    public id: number = 0;
    public positionLicenseRequirements: PositionLicenseRequirementModel[] = [];
    public formGroup!: FormGroup;
    public visibleDialog: boolean = false;

    constructor(private formBuilder: FormBuilder, private messageService: MessageService, private confirmationService: ConfirmationService,
        private positionLicenseRequirementService: PositionLicenseRequirementService) { }

    ngOnInit(): void {
        this.createFormGroup();
        this.getPositionLicenseRequirements();
    }

    createFormGroup() {
        this.formGroup = this.formBuilder.group({
            name: ['', [Validators.required, Validators.maxLength(200)]]
        });
    }

    get f() {
        return this.formGroup.controls;
    }

    onAdd(): void {
        this.id = 0;
        this.formGroup.reset();
        this.visibleDialog = true;
    }

    onEdit(model: PositionLicenseRequirementModel) {
        this.id = model.positionLicenseRequirementId;
        this.formGroup.patchValue({
            name: model.positionLicenseRequirementName,
        });
        this.visibleDialog = true;
    }

    onCancel() {
        this.visibleDialog = false;
    }

    onDelete(model: PositionLicenseRequirementModel) {
        this.confirmationService.confirm({
            message: `Are you sure you want to delete ${model.positionLicenseRequirementName} Position License Requirement?`,
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.positionLicenseRequirementService.delete(model.positionLicenseRequirementId).subscribe({
                    next: (res) => {
                        if (res.status === 200) {
                            if ((res.body as any).success) {
                                this.getPositionLicenseRequirements();
                                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Delete Successfull', life: 3000 });
                            } else {
                                this.messageService.add({ severity: 'error', summary: 'Error', detail: res.body.errors[0], life: 3000 });
                            }
                        }
                    },
                    error: (err) => {
                        this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Delete Failed', life: 3000 });
                    },
                    complete: () => {
                    }
                });
            }
        });
    }

    onClear() {
        this.formGroup.reset();
    }

    onSave(): void {

        const model: any = {
            positionLicenseRequirementId: this.id,
            positionLicenseRequirementName: this.formGroup.controls['name'].value ? this.formGroup.controls['name'].value.trim() : null,
        };

        if (this.formGroup.valid) {
            if (this.id === 0) {
                this.positionLicenseRequirementService.create(model).subscribe({
                    next: (res) => {
                        if (res.status === 200) {
                            if ((res.body as any).success) {                                
                                this.visibleDialog = false;
                                this.getPositionLicenseRequirements();
                                this.messageService.add({ severity: 'success', summary: 'Successful', detail: (res.body as any).message, life: 3000 });
                            } else {
                                this.messageService.add({ severity: 'error', summary: 'Error', detail: (res.body as any).errors[0], life: 3000 });
                            }
                        }
                    },
                    error: (err) => {
                        this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Creating Failed', life: 3000 });
                    }
                });
            } else {
                this.positionLicenseRequirementService.update(this.id, model).subscribe({
                    next: (res) => {
                        if (res.status === 200) {
                            if ((res.body as any).success) {
                                this.id = 0;
                                this.visibleDialog = false;
                                this.getPositionLicenseRequirements();                                
                                this.messageService.add({ severity: 'success', summary: 'Successful', detail: (res.body as any).message, life: 3000 });
                            } else {
                                this.messageService.add({ severity: 'error', summary: 'Error', detail: (res.body as any).errors[0], life: 3000 });
                            }
                        }
                    },
                    error: (err) => {
                        this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Updating Failed', life: 3000 });
                    }
                });
            }
        }
    }

    getPositionLicenseRequirements() {
        this.positionLicenseRequirementService.getAll().subscribe({
            next: (res) => {
                if (res.status === 200) {
                    this.positionLicenseRequirements = res.body;
                }
            },
            error: (err) => {
                this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Failed to get Position License Requirement', life: 3000 });
            }
        });
    }
}
