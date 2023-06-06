import { Component } from '@angular/core';
import { ConfirmationService, MessageService } from 'primeng/api';
import { AgencyModel } from '../../../common/models/agency.model';
import { AgencyService } from './agency.service';

@Component({
    selector: 'app-agency',
    templateUrl: './agency.component.html',
    styleUrls: ['./agency.component.css']
})
export class AgencyComponent {
    agencyDialog: boolean = false;
    agencys: AgencyModel[] = [];
    agency: any;
    submitted: boolean = false;
    isActive: any = [];
    statuses: any[] = [];
    addEditTxt: string = "Add";

    constructor(private messageService: MessageService, private confirmationService: ConfirmationService, private agencyService: AgencyService) { }

    ngOnInit() {
        this.getAllAgency();
    }

    editProduct(agency: AgencyModel) {
        this.addEditTxt = "Edit";
        this.agency = { ...agency };
        this.agencyDialog = true;
    }

    deleteProduct(product: AgencyModel) {
        this.confirmationService.confirm({
            message: 'Are you sure you want to delete ' + product.agencyName + ' agency ?',
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.agencyService.deleteAgency(product.agencyId).subscribe(res => {
                    console.log(res);
                    if (res && res.body) {
                        this.agencys = this.agencys.filter((val) => val.agencyId !== product.agencyId);
                        this.agency = {};
                        this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Agency Deleted', life: 3000 });
                    }
                }, err => { })

            }
        });
    }
    saveProduct() {
        this.submitted = true;

        if (this.agency.agencyName.trim()) {
            if (this.agency.agencyId) {
                //this.agencys[this.findIndexById(this.agency.agencyId)] = this.agency;
                this.agencyService.updateAgency(this.agency.agencyId, this.agency).subscribe(res => {
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
                this.agencyService.addAgency(this.agency).subscribe(res => {
                    this.getAllAgency();
                    this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Agency Created', life: 3000 });
                },
                    err => {
                        this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Agency Created Faild', life: 3000 });
                    },
                    () => { })

            }

            this.agencys = [...this.agencys];
            this.agencyDialog = false;
            this.agency = {};
        }
    }
    findIndexById(id: string): number {
        let index = -1;
        for (let i = 0; i < this.agencys.length; i++) {
            if (this.agencys[i].agencyId.toString() === id) {
                index = i;
                break;
            }
        }

        return index;
    }
    hideDialog() {
        this.agencyDialog = false;
        this.submitted = false;
    }

    changeStatus(id: any, value: any) {
        console.log(id, value);
    }

    openNewAgency() {
        this.addEditTxt = "Add";
        this.agency = {};
        this.submitted = false;
        this.agencyDialog = true;
    }

    getAllAgency() {
        this.agencyService.getAllAgency().subscribe(
            res => {
                this.agencys = res.body;
                console.log(res);
            },
            err => {
                console.log(err);
            },
            () => {
            });
    }
}
