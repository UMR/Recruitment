import { HttpClient, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { resourceServerUrl } from '../../../common/auth-key';

@Injectable({
    providedIn: 'root'
})
export class AssignRecruiterRoleService {

    constructor(private http: HttpClient) { }

    getActiveUsers(): Observable<HttpResponse<any>> {
        const recruiterURI = `${resourceServerUrl}/api/v1/Users/GetActiveUser/`;
        return this.http.get(recruiterURI, { observe: 'response' })
    }

    getAllRank(): Observable<HttpResponse<any>> {
        const recruiterURI = `${resourceServerUrl}/api/v1/Rank/GetRanks`;
        return this.http.get(recruiterURI, { observe: 'response' })
    }

    getRankByUser(userId: number): Observable<HttpResponse<any>> {
        const recruiterURI = `${resourceServerUrl}/api/v1/Rank/GetRankByUser/` + userId;
        return this.http.get(recruiterURI, { observe: 'response' })
    }

    getAllRole(): Observable<HttpResponse<any>> {
        const recruiterURI = `${resourceServerUrl}/api/v1/ManageRole/GetRole`;
        return this.http.get(recruiterURI, { observe: 'response' })
    }
    getRoleByUser(userId: number): Observable<HttpResponse<any>> {
        const recruiterURI = `${resourceServerUrl}/api/v1/ManageRole/GetRoleByUser/` + userId;
        return this.http.get(recruiterURI, { observe: 'response' })
    }
}
