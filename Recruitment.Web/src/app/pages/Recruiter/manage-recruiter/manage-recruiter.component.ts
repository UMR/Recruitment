import { Component } from '@angular/core';
import { ConfirmationService, MessageService } from 'primeng/api';
import { AgencyModel } from '../../../common/models/agency.model';
import { UserModel } from '../../../common/models/user.model';
import { ManageRecruiterService } from './manage-recruiter.service';

@Component({
    selector: 'app-manage-recruiter',
    templateUrl: './manage-recruiter.component.html',
    styleUrls: ['./manage-recruiter.component.scss']
})
export class ManageRecruiterComponent {
    userDialog: boolean = false;
    users: UserModel[] = [];
    user: any;
    submitted: boolean = false;
    isActive: any = [];
    statuses: any[] = [];
    addEditTxt: string = "Add";
    agencys: AgencyModel[] = [];

    constructor(private messageService: MessageService, private confirmationService: ConfirmationService,
        private manageRecruiterService: ManageRecruiterService) { }

    ngOnInit() {
        this.getAllUser();
    }

    editUser(agency: UserModel) {
        this.addEditTxt = "Edit";
        this.user = { ...agency };
        this.userDialog = true;
    }

    deleteUser(user: UserModel) {
        this.confirmationService.confirm({
            message: 'Are you sure you want to delete ' + user.firstName + ' agency ?',
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.manageRecruiterService.deleteRecruiter(user.userId,"5034").subscribe(res => {
                    console.log(res);
                    if (res && res.body) {
                        this.user = {};
                        this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Agency Deleted', life: 3000 });
                    }
                }, err => { })

            }
        });
    }
    saveUser() {
        this.submitted = true;

        if (this.user.agencyName.trim()) {
            if (this.user.agencyId) {
                //this.agencyService.updateAgency(this.agency.agencyId, this.agency).subscribe(res => {
                //    console.log(res);
                //    this.getAllAgency();
                //    this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Agency Updated', life: 3000 });
                //},
                //    error => {
                //        this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Agency Updated Faild', life: 3000 });
                //    },
                //    () => { })

            } else {
                ////this.agency.agencyId = this.createId();
                //this.agencyService.addAgency(this.agency).subscribe(res => {
                //    this.getAllAgency();
                //    this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Agency Created', life: 3000 });
                //},
                //    err => {
                //        this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Agency Created Faild', life: 3000 });
                //    },
                //    () => { })

            }

            this.users = [...this.users];
            this.userDialog = false;
            this.user = {};
        }
    }
    findIndexById(id: string): number {
        let index = -1;
        for (let i = 0; i < this.users.length; i++) {
            if (this.users[i].agencyId.toString() === id) {
                index = i;
                break;
            }
        }

        return index;
    }

    hideDialog() {
        this.userDialog = false;
        this.submitted = false;
    }

    changeStatus(id: any, value: boolean) {
        let updateAgency = {
            agencyId: id,
            isActive: !value
        }
        //this.userService.updateAgencyStatus(id, updateAgency)
        //    .subscribe(res => {
        //        console.log(res);
        //        if ((res.body as any).success) {
        //            this.getAllAgency();
        //            this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Agency Updated', life: 3000 });
        //        }
        //        else {
        //            this.messageService.add({ severity: 'error', summary: 'Error', detail: (res.body as any).errors[0], life: 3000 });
        //        }
        //    },
        //        err => { },
        //        () => { });
    }

    openNewUser() {
        this.addEditTxt = "Add";
        this.user = {};
        this.submitted = false;
        this.userDialog = true;
    }

    getAllUser() {
        this.manageRecruiterService.getAllRecruiter().subscribe(
            res => {
                this.users = res.body;
                console.log(res);
            },
            err => {
                console.log(err);
            },
            () => {
            });
    }
}
