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
        const URI = `${resourceServerUrl}/api/v1/EmailTypes/GetEmailTypes`;
        return this.http.get(URI, { observe: 'response' })
    }

    getById(id: number): Observable<HttpResponse<any>> {
        const URI = `${resourceServerUrl}/api/v1/EmailTypes/GetEmailType/${id}`;
        return this.http.get(URI, { observe: 'response' })
    }

    add(emailType: any): Observable<HttpResponse<any>> {
        const URI = `${resourceServerUrl}/api/v1/EmailTypes/CreateEmailType/`;
        return this.http.post(URI, emailType, { observe: 'response' })
    }

    update(id: number, emailType: any) {
        const URI = `${resourceServerUrl}/api/v1/EmailTypes/UpdateEmailType/${id}`;
        return this.http.put(URI, emailType, { observe: 'response' })
    }

    delete(id: number): Observable<HttpResponse<any>> {
        const URI = `${resourceServerUrl}/api/v1/EmailTypes/DeleteEmailType/${id}`;
        return this.http.delete(URI, { observe: 'response' })
    }

}
