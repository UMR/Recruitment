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
                this.users = res.body;
            },
            err => {
                console.log(err);
            },
            () => { });
    }
    getRank() {
        this.assignRecruiterRoleService.getAllRank().subscribe(
            res => {
                this.ranks = res.body;
            },
            err => {
                console.log(err);
            },
            () => { });
    }

    getRole() {
        this.assignRecruiterRoleService.getAllRole().subscribe(
            res => {
                this.roles = res.body;
            },
            err => {
                console.log(err);
            },
            () => { });
    }

    deleteRole(role: any) { }
}
