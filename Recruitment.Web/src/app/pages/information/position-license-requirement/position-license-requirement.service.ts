import { HttpClient, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { resourceServerUrl } from '../../../common/auth-key';

@Injectable({
    providedIn: 'root'
})
export class PositionLicenseRequirementService {

    constructor(private http: HttpClient) { }

    getPositionLicenseRequirements(): Observable<HttpResponse<any>> {
        const URI = `${resourceServerUrl}/api/v1/PositionLicenseRequirements/GetPositionLicenseRequirements`;
        return this.http.get(URI, { observe: 'response' })
    }

    getPositionLicenseRequirementById(id: number): Observable<HttpResponse<any>> {
        const URI = `${resourceServerUrl}/api/v1/PositionLicenseRequirements/GetPositionLicenseRequirementById/${id}`;
        return this.http.get(URI, { observe: 'response' })
    }

    addPositionLicenseRequirement(emailType: any): Observable<HttpResponse<any>> {
        const URI = `${resourceServerUrl}/api/v1/PositionLicenseRequirements/CreatePositionLicenseRequirement/`;
        return this.http.post(URI, emailType, { observe: 'response' })
    }

    updatePositionLicenseRequirement(id: number, emailType: any) {
        const URI = `${resourceServerUrl}/api/v1/PositionLicenseRequirements/UpdatePositionLicenseRequirement/${id}`;
        return this.http.put(URI, emailType, { observe: 'response' })
    }

    deletePositionLicenseRequirement(id: number): Observable<HttpResponse<any>> {
        const URI = `${resourceServerUrl}/api/v1/PositionLicenseRequirements/DeletePositionLicenseRequirement/${id}`;
        return this.http.delete(URI, { observe: 'response' })
    }

}
