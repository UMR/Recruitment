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

    public emailTypes: any[] = [];
    public formGroup!: FormGroup;
    public submitted: boolean = false;
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
        this.visibleDialog = true;
    }

    onEdit() {
        this.visibleDialog = true;
    }

    onCancel() {
        this.visibleDialog = false;
    }

    onClear() {
        this.submitted = false;
        this.formGroup.reset();
    }

    onSave(): void {
        this.submitted = true;
        const model = {
            emailType: this.formGroup.controls['emailType'].value,
            isPersonal: this.formGroup.controls['isPersonal'].value,
            isOfficial: this.formGroup.controls['isOfficial'].value
        }

        console.log(model);

        this.emailTypeService.addEmailType(model).subscribe({
            next: (res) => {
                console.log(res);                
                this.visibleDialog = false;
            },
            error: (err) => {
                console.log(err);
            },
            complete: () => {                
            }
        });        
    }

    getEmailTypes() {
        this.emailTypeService.getEmailTypes().subscribe({
            next: (res) => {
                this.emailTypes = res.body;
            },
            error: (err) => {
                console.log(err);
            },
            complete: () => {
            }
        });
    }

}
