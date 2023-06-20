import { HttpClient, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { resourceServerUrl } from '../../../common/auth-key';

@Injectable({
    providedIn: 'root'
})
export class PositionLicenseRequirementService {

    constructor(private http: HttpClient) { }

    getAll(): Observable<HttpResponse<any>> {
        const URI = `${resourceServerUrl}/api/v1/PositionLicenseRequirement/GetPositionLicenseRequirements`;
        return this.http.get(URI, { observe: 'response' })
    }

    getById(id: number): Observable<HttpResponse<any>> {
        const URI = `${resourceServerUrl}/api/v1/PositionLicenseRequirement/GetPositionLicenseRequirementById/${id}`;
        return this.http.get(URI, { observe: 'response' })
    }

    add(emailType: any): Observable<HttpResponse<any>> {
        const URI = `${resourceServerUrl}/api/v1/PositionLicenseRequirement/CreatePositionLicenseRequirement/`;
        return this.http.post(URI, emailType, { observe: 'response' })
    }

    update(id: number, emailType: any) {
        const URI = `${resourceServerUrl}/api/v1/PositionLicenseRequirement/UpdatePositionLicenseRequirement/${id}`;
        return this.http.put(URI, emailType, { observe: 'response' })
    }

    delete(id: number): Observable<HttpResponse<any>> {
        const URI = `${resourceServerUrl}/api/v1/PositionLicenseRequirement/DeletePositionLicenseRequirement/${id}`;
        return this.http.delete(URI, { observe: 'response' })
    }

}
