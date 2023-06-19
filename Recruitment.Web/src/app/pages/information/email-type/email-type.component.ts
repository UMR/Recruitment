import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ConfirmationService, MessageService } from 'primeng/api';
import { EmailTypeService } from './email-type.service';

@Component({
    selector: 'app-email-type',
    templateUrl: './email-type.component.html',
    styleUrls: ['./email-type.component.scss']
})
export class EmailTypeComponent implements OnInit {

    public id: number = 0;
    public emailTypes: any[] = [];    
    public formGroup!: FormGroup;    
    public visibleDialog: boolean = false;

    constructor(private formBuilder: FormBuilder, private messageService: MessageService, private confirmationService: ConfirmationService,
        private emailTypeService: EmailTypeService) { }

    ngOnInit(): void {
        this.createFormGroup();
        this.getEmailTypes();
    }

    createFormGroup() {
        this.formGroup = this.formBuilder.group({
            emailType: ['', Validators.required],
            isPersonal: [''],
            isOfficial: ['']
        });
    }

    get f() {
        return this.formGroup.controls;
    }    

    onAdd(): void {
        this.id = 0;
        this.formGroup.patchValue({
            emailType: '',
            isPersonal: '',
            isOfficial: '',
        });
        this.visibleDialog = true;
    }

    onEdit(emailType: any) {        
        this.id = emailType.id;
        this.formGroup.patchValue({
            emailType: emailType.type,
            isPersonal: emailType.isPersonal ? true : '',
            isOfficial: emailType.isOfficial ? true : '',
        });
        this.visibleDialog = true;
    }

    onCancel() {        
        this.visibleDialog = false;
    }

    onDelete(emailType: any) {        
        this.confirmationService.confirm({
            message: 'Are you sure you want to delete ' + emailType.type + ' email type?',
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.emailTypeService.deleteEmailType(emailType.id).subscribe({
                    next: (res) => {
                        console.log(res);
                        this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Delete Successfull', life: 3000 });
                        this.visibleDialog = false;                        
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
        const model = {
            id: this.id,
            type: this.formGroup.controls['emailType'].value ? this.formGroup.controls['emailType'].value.trim() : null,
            isPersonal: this.formGroup.controls['isPersonal'].value ? true : false,
            isOfficial: this.formGroup.controls['isOfficial'].value ? true : false,
        };

        if (this.formGroup.valid) {

            if (this.id === 0) {
                this.emailTypeService.addEmailType(model).subscribe({
                    next: (res) => {
                        if (res.status === 200) {
                            this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Create Successfull', life: 3000 });
                            this.visibleDialog = false;
                        }
                    },
                    error: (err) => {
                        this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Created Failed', life: 3000 });
                    },
                    complete: () => {
                        this.id = 0;
                        this.getEmailTypes();
                    }
                });
            } else {
                this.emailTypeService.updateEmailType(this.id, model).subscribe({
                    next: (res) => {
                        if (res.status === 200) {
                            this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Update Successfull', life: 3000 });
                            this.visibleDialog = false;
                        }
                    },
                    error: (err) => {
                        this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Update Failed', life: 3000 });
                    },
                    complete: () => {
                        this.id = 0;
                        this.getEmailTypes();
                    }
                });
            }
        }
    }

    getEmailTypes() {
        this.emailTypeService.getEmailTypes().subscribe({
            next: (res) => {
                this.emailTypes = res.body;
            },
            error: (err) => {
                this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Failed to get Email Type', life: 3000 });
            }
        });
    }
}
