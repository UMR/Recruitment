import { HttpClient, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { resourceServerUrl } from '../auth-key';

@Injectable({
    providedIn: 'root'
})
export class LowerCaseWordService {

    constructor(private http: HttpClient) { }

    getAll(): Observable<HttpResponse<any>> {
        const URI = `${resourceServerUrl}/api/v1/LowerCaseWords/GetAll`;
        return this.http.get(URI, { observe: 'response' })
    }

    getById(id: number): Observable<HttpResponse<any>> {
        const URI = `${resourceServerUrl}/api/v1/LowerCaseWords/GetById/${id}`;
        return this.http.get(URI, { observe: 'response' })
    }

    create(model: any): Observable<HttpResponse<any>> {
        const URI = `${resourceServerUrl}/api/v1/LowerCaseWords/Create/`;
        return this.http.post(URI, model, { observe: 'response' })
    }

    update(id: number, model: any) {
        const URI = `${resourceServerUrl}/api/v1/LowerCaseWords/Update/${id}`;
        return this.http.put(URI, model, { observe: 'response' })
    }

    delete(id: number): Observable<HttpResponse<any>> {
        const URI = `${resourceServerUrl}/api/v1/LowerCaseWords/Delete/${id}`;
        return this.http.delete(URI, { observe: 'response' })
    }

}
