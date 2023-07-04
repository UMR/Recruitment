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
    public isSubmitted: boolean = false;
    public addEditTitle: string | undefined;

    constructor(private formBuilder: FormBuilder, private messageService: MessageService, private confirmationService: ConfirmationService,
        private visaTypeService: VisaTypeService) {        
    }

    ngOnInit(): void {
        this.createFormGroup();
        this.getVisaTypes();
    }

    createFormGroup() {
        this.formGroup = this.formBuilder.group({
            visaType: ['', [Validators.required, Validators.maxLength(256)]]
        });
    }

    get f() {
        return this.formGroup.controls;
    }

    onAdd(): void {
        this.addEditTitle = 'Add';
        this.id = 0;
        this.clearFields(false, true); 
    }

    onEdit(model: VisaTypeModel) {
        this.addEditTitle = 'Edit';
        this.id = model.id;
        this.formGroup.patchValue({
            visaType: model.visaType,
        });
        this.visibleDialog = true;
    }

    onClear() {
        this.clearFields(false, true);
    }

    onCancel() {
        this.clearFields(false, false);
    }    

    onSave(): void {
        this.isSubmitted = true;
        const model: any = {
            id: this.id,
            visaType: this.formGroup.controls['visaType'].value ? this.formGroup.controls['visaType'].value.trim() : null,
        };
        if (this.formGroup.valid) {
            if (this.id === 0) {
                this.visaTypeService.create(model).subscribe({
                    next: (res) => {
                        if (res.status === 200) {
                            if ((res.body as any).success) {
                                this.clearFields(false, false);
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
                this.visaTypeService.update(this.id, model).subscribe({
                    next: (res) => {
                        if (res.status === 200) {
                            if ((res.body as any).success) {                                
                                this.clearFields(false, false);
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

    onDelete(model: VisaTypeModel) {
        this.confirmationService.confirm({
            message: `Are you sure you want to delete ${model.visaType} Visa Type?`,
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.visaTypeService.delete(model.id).subscribe({
                    next: (res) => {
                        if (res.status === 200) {
                            if ((res.body as any).success) {
                                this.clearFields(false, false);
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

    clearFields(isSubmitted: boolean, visibleDialog: boolean) {        
        this.isSubmitted = isSubmitted;
        this.visibleDialog = visibleDialog;        
        this.formGroup.reset();
    }

    getVisaTypes() {
        this.visaTypeService.getAll().subscribe({
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
