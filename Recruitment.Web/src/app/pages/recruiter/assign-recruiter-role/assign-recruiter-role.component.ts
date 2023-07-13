import { Component } from '@angular/core';
import { AssignRecruiterRoleService } from './assign-recruiter-role.service';

@Component({
    selector: 'app-assign-recruiter-role',
    templateUrl: './assign-recruiter-role.component.html',
    styleUrls: ['./assign-recruiter-role.component.scss']
})
export class AssignRecruiterRoleComponent {
    userRoles: any = [];

    users: any = [];
    roles: any = [];
    ranks: any = [];

    selectedUser: string = "";
    selectedRole: string = "";
    selectedRank: string = "";

    constructor(private assignRecruiterRoleService: AssignRecruiterRoleService) {
        this.getUser();
        this.getRank();
        this.getRole();
    }
    getUser() {
        this.assignRecruiterRoleService.getActiveUsers().subscribe(
            res => {
                if (res.body) {
                    this.users = res.body;
                }
                else {
                    this.users = [];
                }
            },
            err => {
                console.log(err);
            },
            () => { });
    }
    onChangeUser() {
        this.getRankByUser(this.selectedUser);
    }

    getRank() {
        this.assignRecruiterRoleService.getAllRank().subscribe(
            res => {
                if (res.body) {
                    this.ranks = res.body;
                }
                else {
                    this.ranks = [];
                }
            },
            err => {
                console.log(err);
            },
            () => { });
    }
    addRank() { }

    getRole() {
        this.assignRecruiterRoleService.getAllRole().subscribe(
            res => {
                if (res.body) {
                    this.roles = res.body;
                }
                else {
                    this.roles = [];
                }
            },
            err => {
                console.log(err);
            },
            () => { });
    }

    getRankByUser(userId: any) {
        this.assignRecruiterRoleService.getRankByUser(userId).subscribe(
            res => {
                if (res.body) {
                    this.selectedRank = res.body.rankLookupId;
                }
                else {
                    this.selectedRank = "";
                }
            },
            err => {
                console.log(err);
            },
            () => { });
    }

    deleteRole(role: any) { }
}
