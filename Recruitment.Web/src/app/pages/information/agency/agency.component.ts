import { Component } from '@angular/core';
import { ConfirmationService, MessageService } from 'primeng/api';
import { Product } from '../../../common/models/agency.model';
import { AgencyService } from './agency.service';

@Component({
    selector: 'app-agency',
    templateUrl: './agency.component.html',
    styleUrls: ['./agency.component.scss']
})
export class AgencyComponent {
    productDialog: boolean = false;
    products: Product[] = [];
    product: any;
    selectedProducts: Product[] = [];
    submitted: boolean = false;
    statuses: any[] = [];

    constructor(private messageService: MessageService, private confirmationService: ConfirmationService, private agencyService: AgencyService) { }

    ngOnInit() {
        this.getAllAgency();
    }

    editProduct(product: Product) {
        this.product = { ...product };
        this.productDialog = true;
    }

    deleteProduct(product: Product) {
        this.confirmationService.confirm({
            message: 'Are you sure you want to delete ' + product.name + '?',
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.products = this.products.filter((val) => val.id !== product.id);
                this.product = {};
                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Product Deleted', life: 3000 });
            }
        });
    }
    getAllAgency() {
        this.agencyService.getAllAgency().subscribe(
            res => {
                console.log(res);
            },
            err => {
                console.log(err);
            },
            () => {
            });
    }
}
