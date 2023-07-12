import { HttpClient, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { resourceServerUrl } from '../../../common/auth-key';

@Injectable({
  providedIn: 'root'
})
export class AssignRecruiterRoleService {

    constructor(private http: HttpClient) { }

    getAllUser(): Observable<HttpResponse<any>> {
        const recruiterURI = `${resourceServerUrl}/api/v1/Recruiter/GetRecruiters`;
        return this.http.get(recruiterURI, { observe: 'response' })
    }
    getAllRank(): Observable<HttpResponse<any>> {
        const recruiterURI = `${resourceServerUrl}/api/v1/Rank/GetRanks`;
        return this.http.get(recruiterURI, { observe: 'response' })
    }
}
