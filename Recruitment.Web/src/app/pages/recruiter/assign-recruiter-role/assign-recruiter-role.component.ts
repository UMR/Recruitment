import { Component } from '@angular/core';
import { UserRankModel } from '../../../common/models/user-rank.model';
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

    enumId: any;

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
        this.getRoleByUser(this.selectedUser);
    }

    onChangeRank() {
        var index = this.ranks.findIndex((obj: any) => {
            return obj.rankLookupId === this.selectedRank;
        });
        this.enumId = this.ranks[index].enumId;
    }

    getRank() {
        this.assignRecruiterRoleService.getAllRank().subscribe(
            res => {
                console.log(res.body);
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

    addRank() {
        let userRank = {
            UserRankId: 0,
            userId: +this.selectedUser,
            rankLookupId: +this.selectedRank,
            enumId: +this.enumId,
            CreatedBy: 0,
            CreatedDate: new Date(),
            UpdatedBy: 0,
            UpdatedDate: new Date()
        }
        this.assignRecruiterRoleService.addRankByUser(userRank).subscribe(
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
    deleteRank() {

    }

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

    getRoleByUser(userId: any) {
        this.assignRecruiterRoleService.getRoleByUser(userId).subscribe(
            res => {
                if (res.body) {
                    this.userRoles = res.body;
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

    deleteRole(role: any) {
        console.log(role);
    }
}
