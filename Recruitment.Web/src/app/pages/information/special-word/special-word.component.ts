import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ConfirmationService, MessageService } from 'primeng/api';

import { SpecialWordService } from '../../../common/service/special-word.service';

@Component({
  selector: 'app-special-word',
  templateUrl: './special-word.component.html',
  styleUrls: ['./special-word.component.scss']
})
export class SpecialWordComponent {

    public id: number = 0;
    public specialWords: any[] = [];
    public formGroup!: FormGroup;
    public visibleDialog: boolean = false;

    constructor(private formBuilder: FormBuilder, private messageService: MessageService, private confirmationService: ConfirmationService,
        private specialWordService: SpecialWordService) { }

    ngOnInit(): void {
        this.createFormGroup();
        this.getSpecialWords();
    }

    createFormGroup() {
        this.formGroup = this.formBuilder.group({
            word: ['', [Validators.required, Validators.maxLength(256)]]
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

    onEdit(model: any) {
        this.id = model.positionLicenseRequirementId;
        this.formGroup.patchValue({
            name: model.positionLicenseRequirementName,
        });
        this.visibleDialog = true;
    }

    onCancel() {
        this.visibleDialog = false;
    }

    onDelete(model: any) {
        this.confirmationService.confirm({
            message: `Are you sure you want to delete ${model.positionLicenseRequirementName} Position License Requirement?`,
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.specialWordService.delete(model.positionLicenseRequirementId).subscribe({
                    next: (res) => {
                        if (res.status === 200) {
                            if ((res.body as any).success) {
                                this.getSpecialWords();
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
            positionLicenseRequirementId: this.id,
            positionLicenseRequirementName: this.formGroup.controls['name'].value ? this.formGroup.controls['name'].value.trim() : null,
        };

        if (this.formGroup.valid) {
            if (this.id === 0) {
                this.specialWordService.create(model).subscribe({
                    next: (res) => {
                        if (res.status === 200) {
                            if ((res.body as any).success) {
                                this.visibleDialog = false;
                                this.getSpecialWords();
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
                this.specialWordService.update(this.id, model).subscribe({
                    next: (res) => {
                        if (res.status === 200) {
                            if ((res.body as any).success) {
                                this.id = 0;
                                this.visibleDialog = false;
                                this.getSpecialWords();
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

    getSpecialWords() {
        this.specialWordService.getAll().subscribe({
            next: (res) => {
                if (res.status === 200) {
                    this.specialWords = res.body;
                }
            },
            error: (err) => {
                this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Failed to get Special Word', life: 3000 });
            }
        });
    }

}
