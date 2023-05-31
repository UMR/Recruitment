import { HttpBackend, HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";


const accessTokenUrl = `http://localhost:4000/connect/token`;
const accessTokenBody = `grant_type=password&username={0}&password={1}&scope=recruitment.fullaccess&client_id=recruitmentweb&client_secret=s*|9%2~*=95*+|t8*~3**%;U73*+-c`;

@Injectable()
export class LoginService {
    private http: HttpClient;

    constructor(private httpBackend: HttpBackend) {
        this.http = new HttpClient(httpBackend);
    }
    getheaders(): HttpHeaders {
        let headers = new HttpHeaders({
            'Content-Type': 'application/x-www-form-urlencoded',
            //'Authorization': 'Basic YXBpY2xpZW50aWQ6YXBpU2VjcmV0'
        });
        return headers;
    }

    getToken(userID: string, password: string): Observable<any> {
        const body = accessTokenBody.replace('{0}', userID).replace('{1}', password);
        return this.http.post(accessTokenUrl, body, { headers: this.getheaders() });
    }
}
    //get isLoggedIn() {
    //    if (this.authService.isLoggedIn) {
    //        return true;
    //    }
    //    return false;
    //}
    //login(userID: string, password: string) {
    //    return this.authService.login(userID, password);
    //}