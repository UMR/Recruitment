import { Component } from '@angular/core';
import { ConfirmationService, MessageService } from 'primeng/api';
import { AgencyModel } from '../../../common/models/agency.model';
import { ContactInfoService } from './contact-info.service';

@Component({
  selector: 'app-contact-info',
  templateUrl: './contact-info.component.html',
  styleUrls: ['./contact-info.component.scss']
})
export class ContactInfoComponent {
    contactInfoDialog: boolean = false;
    contactInformations: AgencyModel[] = [];
    contactInfo: any;
    submitted: boolean = false;
    addEditTxt: string = "Add";

    constructor(private messageService: MessageService, private confirmationService: ConfirmationService,
        private agencyService: ContactInfoService) { }

    ngOnInit() {
        this.getAllAgency();
    }

    addContactInfo(): void {
        this.contactInfoDialog = true;
    }

    editContactInfo(contactInfo: AgencyModel) {
        this.addEditTxt = "Edit";
        this.contactInfo = { ...contactInfo };
        this.contactInfoDialog = true;
    }

    deleteContactInfo(product: AgencyModel) {
        this.confirmationService.confirm({
            message: 'Are you sure you want to delete ' + product.agencyName + ' agency ?',
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.agencyService.deleteContactInfo(product.agencyId).subscribe(res => {
                    console.log(res);
                    if (res && res.body) {
                        this.contactInformations = this.contactInformations.filter((val) => val.agencyId !== product.agencyId);
                        this.contactInfo = {};
                        this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Agency Deleted', life: 3000 });
                    }
                }, err => { })

            }
        });
    }
    saveContactInfo() {
        this.submitted = true;

        if (this.contactInfo.agencyName.trim()) {
            if (this.contactInfo.agencyId) {
                //this.agencys[this.findIndexById(this.agency.agencyId)] = this.agency;
                this.agencyService.updateContactInfo(this.contactInfo.agencyId, this.contactInfo).subscribe(res => {
                    console.log(res);
                    this.getAllAgency();
                    this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Agency Updated', life: 3000 });
                },
                    error => {
                        this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Agency Updated Faild', life: 3000 });
                    },
                    () => { })

            } else {
                //this.agency.agencyId = this.createId();
                this.agencyService.addContactInfo(this.contactInfo).subscribe(res => {
                    this.getAllAgency();
                    this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Agency Created', life: 3000 });
                },
                    err => {
                        this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Agency Created Faild', life: 3000 });
                    },
                    () => { })

            }

            this.contactInformations = [...this.contactInformations];
            this.contactInfoDialog = false;
            this.contactInfo = {};
        }
    }
    findIndexById(id: string): number {
        let index = -1;
        for (let i = 0; i < this.contactInformations.length; i++) {
            if (this.contactInformations[i].agencyId.toString() === id) {
                index = i;
                break;
            }
        }

        return index;
    }

    hideAddEditDialog() {
        this.contactInfoDialog = false;
        this.submitted = false;
    }

    openNewAgency() {
        this.addEditTxt = "Add";
        this.contactInfo = {};
        this.submitted = false;
        this.contactInfoDialog = true;
    }

    getAllAgency() {
        this.agencyService.getContactInformations().subscribe(
            res => {
                this.contactInformations = res.body;
                console.log(res);
            },
            err => {
                console.log(err);
            },
            () => {
            });
    }
}
