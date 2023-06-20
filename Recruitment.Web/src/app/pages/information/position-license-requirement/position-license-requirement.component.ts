import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ConfirmationService, MessageService } from 'primeng/api';

import { PositionLicenseRequirementService } from './position-license-requirement.service';

@Component({
  selector: 'app-position-license-requirement',
  templateUrl: './position-license-requirement.component.html',
  styleUrls: ['./position-license-requirement.component.scss']
})
export class PositionLicenseRequirementComponent {
    public id: number = 0;
    public positionLicenseRequirements: any[] = [];
    public formGroup!: FormGroup;
    public visibleDialog: boolean = false;

    constructor(private formBuilder: FormBuilder, private messageService: MessageService, private confirmationService: ConfirmationService,
        private positionLicenseRequirementService: PositionLicenseRequirementService) { }

    ngOnInit(): void {
        this.createFormGroup();
        this.getEmailTypes();
    }

    createFormGroup() {
        this.formGroup = this.formBuilder.group({
            name: ['', Validators.required]            
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

    onEdit(emailType: any) {
        this.id = emailType.id;
        this.formGroup.patchValue({
            emailType: emailType.type,            
        });
        this.visibleDialog = true;
    }

    onCancel() {
        this.visibleDialog = false;
    }

    onDelete(emailType: any) {
        //this.confirmationService.confirm({
        //    message: 'Are you sure you want to delete ' + emailType.type + ' email type?',
        //    header: 'Confirm',
        //    icon: 'pi pi-exclamation-triangle',
        //    accept: () => {
        //        this.positionLicenseRequirementService.delete(emailType.id).subscribe({
        //            next: (res) => {
        //                console.log(res);
        //                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Delete Successfull', life: 3000 });
        //                this.visibleDialog = false;
        //            },
        //            error: (err) => {
        //                this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Delete Failed', life: 3000 });
        //            },
        //            complete: () => {
        //            }
        //        });
        //    }
        //});
    }

    onClear() {
        this.formGroup.reset();
    }

    onSave(): void {
        const model = {
            id: this.id,
            type: this.formGroup.controls['name'].value ? this.formGroup.controls['name'].value.trim() : null,            
        };

        //if (this.formGroup.valid) {

        //    if (this.id === 0) {
        //        this.positionLicenseRequirementService.add(model).subscribe({
        //            next: (res) => {
        //                if (res.status === 200) {
        //                    if ((res.body as any).success) {
        //                        this.messageService.add({ severity: 'success', summary: 'Successful', detail: res.body.message, life: 3000 });
        //                        this.visibleDialog = false;
        //                    } else if (!(res.body as any).success) {
        //                        this.messageService.add({ severity: 'error', summary: 'Error', detail: res.body.errors[0], life: 3000 });
        //                    }
        //                }
        //            },
        //            error: (err) => {
        //                this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Created Failed', life: 3000 });
        //            },
        //            complete: () => {
        //                this.id = 0;
        //                this.getEmailTypes();
        //            }
        //        });
        //    } else {
        //        this.positionLicenseRequirementService.update(this.id, model).subscribe({
        //            next: (res) => {
        //                if (res.status === 200) {
        //                    if ((res.body as any).success) {
        //                        this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Update Successfull', life: 3000 });
        //                        this.visibleDialog = false;
        //                    } else if (!(res.body as any).success) {
        //                        this.messageService.add({ severity: 'error', summary: 'Error', detail: (res.body as any).errors[0], life: 3000 });
        //                    }
        //                }
        //            },
        //            error: (err) => {
        //                this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Update Failed', life: 3000 });
        //            },
        //            complete: () => {
        //                this.id = 0;
        //                this.getEmailTypes();
        //            }
        //        });
        //    }
        //}
    }

    getEmailTypes() {
        this.positionLicenseRequirementService.getAll().subscribe({
            next: (res) => {
                this.positionLicenseRequirements = res.body;
            },
            error: (err) => {
                this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Failed to get Email Type', life: 3000 });
            }
        });
    }
}
