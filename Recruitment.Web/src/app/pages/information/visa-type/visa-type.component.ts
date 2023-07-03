import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ConfirmationService, MessageService } from 'primeng/api';

import { VisaTypeService } from '../../../common/service/visa-type.service';
import { VisaTypeModel } from '../../../common/models/visa-type.model';

@Component({
  selector: 'app-visa-type',
  templateUrl: './visa-type.component.html',
  styleUrls: ['./visa-type.component.scss']
})
export class VisaTypeComponent {
    public id: number = 0;
    public visaTypes: VisaTypeModel[] = [];
    public formGroup!: FormGroup;
    public visibleDialog: boolean = false;

    constructor(private formBuilder: FormBuilder, private messageService: MessageService, private confirmationService: ConfirmationService,
        private upperCaseWordService: VisaTypeService) { }

    ngOnInit(): void {
        this.createFormGroup();
        this.getVisaTypes();
    }

    createFormGroup() {
        this.formGroup = this.formBuilder.group({
            visaTypeName: ['', [Validators.required, Validators.maxLength(256)]]
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

    onEdit(model: VisaTypeModel) {
        this.id = model.id;
        this.formGroup.patchValue({
            word: model.visaTypeName,
        });
        this.visibleDialog = true;
    }

    onCancel() {
        this.visibleDialog = false;
    }

    onDelete(model: VisaTypeModel) {
        this.confirmationService.confirm({
            message: `Are you sure you want to delete ${model.visaTypeName} Special Word?`,
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.upperCaseWordService.delete(model.id).subscribe({
                    next: (res) => {
                        if (res.status === 200) {
                            if ((res.body as any).success) {
                                this.getVisaTypes();
                                this.messageService.add({ severity: 'success', summary: 'Successful', detail: (res.body as any).message, life: 3000 });
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
            id: this.id,
            word: this.formGroup.controls['visaTypeName'].value ? this.formGroup.controls['visaTypeName'].value.trim() : null,
        };

        if (this.formGroup.valid) {
            if (this.id === 0) {
                this.upperCaseWordService.create(model).subscribe({
                    next: (res) => {
                        if (res.status === 200) {
                            if ((res.body as any).success) {
                                this.visibleDialog = false;
                                this.getVisaTypes();
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
                this.upperCaseWordService.update(this.id, model).subscribe({
                    next: (res) => {
                        if (res.status === 200) {
                            if ((res.body as any).success) {
                                this.id = 0;
                                this.visibleDialog = false;
                                this.getVisaTypes();
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

    getVisaTypes() {
        this.upperCaseWordService.getAll().subscribe({
            next: (res) => {
                if (res.status === 200) {
                    this.visaTypes = res.body;
                }
            },
            error: (err) => {
                this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Failed to get Visa Type', life: 3000 });
            }
        });
    }
}
