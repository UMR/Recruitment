import { Component, ElementRef, Renderer2 } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ConfirmationService, MessageService } from 'primeng/api';

import { UpperCaseWordService } from '../../../common/service/upper-case-word.service';
import { UpperCaseWordModel } from '../../../common/models/upper-case-word.model';

@Component({
    selector: 'app-upper-case-word',
    templateUrl: './upper-case-word.component.html',
    styleUrls: ['./upper-case-word.component.scss']
})
export class UpperCaseWordComponent {
    public id: number = 0;
    public upperCaseWords: UpperCaseWordModel[] = [];
    public formGroup!: FormGroup;
    public visibleDialog: boolean = false;
    public isSubmitted: boolean = false;
    public addEditTitle: string | undefined;

    constructor(private formBuilder: FormBuilder, private messageService: MessageService, private confirmationService: ConfirmationService, private renderer: Renderer2, private el: ElementRef,
        private upperCaseWordService: UpperCaseWordService) { }

    ngOnInit(): void {
        this.createFormGroup();
        this.getUpperCaseWords();
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
        this.addEditTitle = 'Add';
        this.id = 0;
        this.clearFields(false, true);
    }

    onEdit(model: UpperCaseWordModel) {
        this.addEditTitle = 'Edit';
        this.id = model.id;
        this.formGroup.patchValue({
            word: model.word,
        });
        this.visibleDialog = true;
    }

    onClear() {
        this.clearFields(false, true);
        this.renderer.selectRootElement('#word').focus();
    }

    onCancel() {
        this.clearFields(false, false);
    }

    onSave() {
        this.isSubmitted = true;
        const model: any = {
            id: this.id,
            word: this.formGroup.controls['word'].value ? this.formGroup.controls['word'].value.trim() : null,
        };
        if (this.formGroup.valid) {
            if (this.id === 0) {
                this.upperCaseWordService.create(model).subscribe({
                    next: (res) => {
                        if (res.status === 200) {
                            if ((res.body as any).success) {
                                this.clearFields(false, false);
                                this.getUpperCaseWords();
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
                                this.clearFields(false, false);
                                this.getUpperCaseWords();
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
        } else {
            for (const key of Object.keys(this.formGroup.controls)) {
                if (this.formGroup.controls[key].invalid) {
                    const invalidControl = this.el.nativeElement.querySelector('[formcontrolname="' + key + '"]');
                    invalidControl.focus();
                    break;
                }
            }
        }
    }

    onDelete(model: UpperCaseWordModel) {
        this.confirmationService.confirm({
            message: `Are you sure you want to delete ${model.word} Special Word?`,
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.upperCaseWordService.delete(model.id).subscribe({
                    next: (res) => {
                        if (res.status === 200) {
                            if ((res.body as any).success) {
                                this.clearFields(false, false);
                                this.getUpperCaseWords();
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

    getUpperCaseWords() {
        this.upperCaseWordService.getAll().subscribe({
            next: (res) => {
                if (res.status === 200) {
                    this.upperCaseWords = res.body;
                }
            },
            error: (err) => {
                this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Failed to get Special Word', life: 3000 });
            }
        });
    }
}
