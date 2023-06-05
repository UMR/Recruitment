import { Component } from '@angular/core';
import { ConfirmationService, MessageService } from 'primeng/api';
import { AgencyModel } from '../../../common/models/agency.model';
import { AgencyService } from './agency.service';

@Component({
    selector: 'app-agency',
    templateUrl: './agency.component.html',
    styleUrls: ['./agency.component.scss']
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
            message: 'Are you sure you want to delete ' + product.agencyName + '?',
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.agencys = this.agencys.filter((val) => val.agencyId !== product.agencyId);
                this.agency = {};
                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Product Deleted', life: 3000 });
            }
        });
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