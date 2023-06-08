import { Component, OnInit } from '@angular/core';
import { ConfirmationService, MessageService } from 'primeng/api';

import { EmailTypeService } from './email-type.service';

@Component({
  selector: 'app-email-type',
  templateUrl: './email-type.component.html',
  styleUrls: ['./email-type.component.scss']
})
export class EmailTypeComponent implements OnInit {

    public emailTypes = [];

    constructor(private messageService: MessageService, private confirmationService: ConfirmationService,
        private emailTypeService: EmailTypeService) { }

    ngOnInit() {
        this.getEmailTypes();
    }

    //getEmailTypes() {
    //    this.emailTypeService.getEmailTypes().subscribe({
    //        next: (res) => {
    //            console.log(res);
    //        },
    //        error: (err) => {
    //        },
    //        complete: () => {
    //        }
    //    });

    //}

    getEmailTypes() {
        this.emailTypeService.getEmailTypes().subscribe({
            next: (res) => {
                console.log(res);
                this.emailTypes = res.body;
                console.log(this.emailTypes);
            },
            error: (err) => {
                console.log(err);
            },
            complete: () => {
            }
        });

    }

}
