import { Component } from '@angular/core';
import { ConfirmationService, MessageService } from 'primeng/api';
import { User } from '../../../common/models/user.model';
import { ManageRecruiterService } from './manage-recruiter.service';

@Component({
  selector: 'app-manage-recruiter',
  templateUrl: './manage-recruiter.component.html',
  styleUrls: ['./manage-recruiter.component.scss']
})
export class ManageRecruiterComponent {
    userDialog: boolean = false;
    users: User[] = [];
    user: any;
    submitted: boolean = false;
    isActive: any = [];
    statuses: any[] = [];
    addEditTxt: string = "Add";

    constructor(private messageService: MessageService, private confirmationService: ConfirmationService,
        private userService: ManageRecruiterService) { }

    ngOnInit() {
        this.getAllAgency();
    }

    editUser(agency: User) {
        this.addEditTxt = "Edit";
        this.user = { ...agency };
        this.userDialog = true;
    }

    deleteUser(user: User) {
        this.confirmationService.confirm({
            message: 'Are you sure you want to delete ' + user.firstName + ' agency ?',
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                //this.agencyService.deleteAgency(user.loginId).subscribe(res => {
                //    console.log(res);
                //    if (res && res.body) {
                //        this.agencys = this.agencys.filter((val) => val.agencyId !== agency.agencyId);
                //        this.agency = {};
                //        this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Agency Deleted', life: 3000 });
                //    }
                //}, err => { })

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

    getAllAgency() {
        //this.agencyService.getAllAgency().subscribe(
        //    res => {
        //        this.agencys = res.body;
        //        console.log(res);
        //    },
        //    err => {
        //        console.log(err);
        //    },
        //    () => {
        //    });
    }
}
