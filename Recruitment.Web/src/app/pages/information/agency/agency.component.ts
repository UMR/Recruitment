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
    productDialog: boolean = false;
    agencys: AgencyModel[] = [];
    agency: any;
    submitted: boolean = false;
    isActive: any = [];
    statuses: any[] = [];

    constructor(private messageService: MessageService, private confirmationService: ConfirmationService, private agencyService: AgencyService) { }

    ngOnInit() {
        this.getAllAgency();
    }

    editProduct(agency: AgencyModel) {
        this.agency = { ...agency };
        this.productDialog = true;
    }

    deleteProduct(product: AgencyModel) {
        this.confirmationService.confirm({
            message: 'Are you sure you want to delete ' + product.agencyName + ' agency ?',
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.agencys = this.agencys.filter((val) => val.agencyId !== product.agencyId);
                this.agency = {};
                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Agency Deleted', life: 3000 });
            }
        });
    }
    saveProduct() {
        this.submitted = true;

        if (this.agency.agencyName.trim()) {
            if (this.agency.id) {
                this.agencys[this.findIndexById(this.agency.agencyId)] = this.agency;
                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Product Updated', life: 3000 });
            } else {
                //this.agency.id = this.createId();
                this.agencys.push(this.agency);
                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Product Created', life: 3000 });
            }

            this.agencys = [...this.agencys];
            this.productDialog = false;
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
        this.productDialog = false;
        this.submitted = false;
    }

    changeStatus(id: any, value: any) {
        console.log(id, value);
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
