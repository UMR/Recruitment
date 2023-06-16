import { Component, OnInit } from '@angular/core';
import { ConfirmationService, MessageService } from 'primeng/api';

import { EmailTypeService } from './email-type.service';

@Component({
    selector: 'app-email-type',
    templateUrl: './email-type.component.html',
    styleUrls: ['./email-type.component.scss']
})
export class EmailTypeComponent implements OnInit {

    public emailTypes: any[] = [];
    public visibleDialog: boolean = false;

    constructor(private messageService: MessageService, private confirmationService: ConfirmationService,
        private emailTypeService: EmailTypeService) { }

    ngOnInit(): void {
        this.getEmailTypes();
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
        
    }

    onSave(): void {
        this.visibleDialog = false;
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
