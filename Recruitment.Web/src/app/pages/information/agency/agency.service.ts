import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AgencyService {

    constructor(private http: HttpClient) { }

    getAllAgency(): Observable<any> {
        return this.http.get()

    }
}
