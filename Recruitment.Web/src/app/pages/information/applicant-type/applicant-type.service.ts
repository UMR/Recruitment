import { HttpClient, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { resourceServerUrl } from '../../../common/auth-key';
import { AgencyModel } from '../../../common/models/agency.model';

@Injectable({
  providedIn: 'root'
})
export class ApplicantTypeService {

    constructor(private http: HttpClient) { }

    getAllAppType(): Observable<HttpResponse<any>> {
        const appTypeURI = `${resourceServerUrl}/api/v1/Agencies/GetAgencies`;
        return this.http.get(appTypeURI, { observe: 'response' })
    }
    
    addAppType(appType: AgencyModel): Observable<HttpResponse<any>> {
        const addAppTypeURI = `${resourceServerUrl}/api/v1/Agencies/CreateAgency/`;
        return this.http.post(addAppTypeURI, appType, { observe: 'response' })
    }

    updateAppType(appTypeId: number, appType: AgencyModel) {
        const updateAppTypeURI = `${resourceServerUrl}/api/v1/Agencies/UpdateAgency/` + appTypeId;
        return this.http.put(updateAppTypeURI, appType, { observe: 'response' })
    }

    deleteAppType(appTypeId: any): Observable<HttpResponse<any>> {
        const deleteAppTypeURI = `${resourceServerUrl}/api/v1/Agencies/DeleteAgency/`;
        return this.http.delete(deleteAppTypeURI + appTypeId, { observe: 'response' })
    }
}
