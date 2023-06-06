import { HttpClient, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { resourceServerUrl } from '../../../common/auth-key';

@Injectable({
  providedIn: 'root'
})
export class AgencyService {
    private agencyURI: string = `${resourceServerUrl}/api/v1/Agencies/GetAgencies`;
    private deleteAgencyURI: string = `${resourceServerUrl}/api/v1/Agencies/DeleteAgency/`;

    constructor(private http: HttpClient) { }

    getAllAgency(): Observable<HttpResponse<any>> {
        return this.http.get(this.agencyURI, { observe: 'response' })
    }
    deleteAgency(agencyId: any): Observable<HttpResponse<any>> {
        return this.http.delete(this.deleteAgencyURI + agencyId, { observe: 'response' })
    }
}
