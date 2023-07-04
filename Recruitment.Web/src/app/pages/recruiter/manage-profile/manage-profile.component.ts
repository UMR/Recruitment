import { Component } from '@angular/core';
import { MessageService } from 'primeng/api';
import { AgencyModel } from '../../../common/models/agency.model';
import { ApplicantTypeModel } from '../../../common/models/applicant-type.model';
import { AgencyService } from '../../information/agency/agency.service';
import { ApplicantTypeService } from '../../information/applicant-type/applicant-type.service';
import { ManageProfileService } from './manage-profile.service';

@Component({
    selector: 'app-manage-profile',
    templateUrl: './manage-profile.component.html',
    styleUrls: ['./manage-profile.component.scss']
})
export class ManageProfileComponent {

    loginId: string = "";
    agencys: AgencyModel[] = [];
    appTypes: ApplicantTypeModel[] = [];
    userId: number = 0;
    firstName: string = "";
    lastName: string = "";
    email: string = "";
    telephone: string = "";
    timeOut: number = 0;
    agencyId: number = 0;
    applicantTypeId: number = 0;

    constructor(private messageService: MessageService, private appTypeService: ApplicantTypeService, private agencyService: AgencyService, private manageProfileService:ManageProfileService) {
        this.getAllAgency();
        this.getAllAppType();
        this.getUser();
    }

    onClearClick() {
    }

    onChangeClick() {

    }

    getUser() {
        this.manageProfileService.getUser().subscribe(
            res => {
                console.log(res);
            },
            err => {
                console.log(err);
            },
            () => {
            });
    }

    getAllAgency() {
        this.agencyService.getAllAgency().subscribe(
            res => {
                this.agencys = res.body;
            },
            err => {
                console.log(err);
            },
            () => {
            });
    }

    getAllAppType() {
        this.appTypeService.getAllAppType().subscribe(
            res => {
                this.appTypes = res.body;
            },
            err => {
                console.log(err);
            },
            () => {
            });
    }
}
