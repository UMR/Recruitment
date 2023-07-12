import { Component } from '@angular/core';
import { AssignRecruiterRoleService } from './assign-recruiter-role.service';

@Component({
    selector: 'app-assign-recruiter-role',
    templateUrl: './assign-recruiter-role.component.html',
    styleUrls: ['./assign-recruiter-role.component.scss']
})
export class AssignRecruiterRoleComponent {
    users: any = [];
    userRoles: any = [];
    roles: any = [];
    ranks: any = [];

    selectedUser: string = "";
    selectedRole: string = "";
    selectedRank: string = "";

    constructor(private assignRecruiterRoleService: AssignRecruiterRoleService) {
        this.getUser();
        this.getRank()
    }
    getUser() {
        this.assignRecruiterRoleService.getAllUser().subscribe(
            res => {
                console.log(res)
                this.users = res.body;
                //this.firstName = res.body.firstName;
            },
            err => {
                console.log(err);
            },
            () => {
            });
    }
    getRank() {
        this.assignRecruiterRoleService.getAllRank().subscribe(
            res => {
                console.log(res)
                this.ranks = res.body;
                //this.firstName = res.body.firstName;
            },
            err => {
                console.log(err);
            },
            () => {
            });
    }

    deleteRole(role: any) { }
}
