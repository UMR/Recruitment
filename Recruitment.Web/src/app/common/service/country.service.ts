import { HttpClient, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { resourceServerUrl } from '../auth-key';

@Injectable({
    providedIn: 'root'
})
export class CountryService {

    constructor(private http: HttpClient) { }

    getAll(): Observable<HttpResponse<any>> {
        const URI = `${resourceServerUrl}/api/v1/countries/GetAll`;
        return this.http.get(URI, { observe: 'response' })
    }

    getById(id: number): Observable<HttpResponse<any>> {
        const URI = `${resourceServerUrl}/api/v1/countries/GetById/${id}`;
        return this.http.get(URI, { observe: 'response' })
    }

    create(model: any): Observable<HttpResponse<any>> {
        const URI = `${resourceServerUrl}/api/v1/countries/Create/`;
        return this.http.post(URI, model, { observe: 'response' })
    }

    update(id: number, model: any) {
        const URI = `${resourceServerUrl}/api/v1/countries/Update/${id}`;
        return this.http.put(URI, model, { observe: 'response' })
    }

    delete(id: number): Observable<HttpResponse<any>> {
        const URI = `${resourceServerUrl}/api/v1/countries/Delete/${id}`;
        return this.http.delete(URI, { observe: 'response' })
    }

}
