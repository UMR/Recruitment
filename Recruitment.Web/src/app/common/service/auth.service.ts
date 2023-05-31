import { HttpBackend, HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { authCookieKey } from '../auth-key'
import { getToken } from "../http-client.helper";

@Injectable()
export class AuthService {
    http: HttpClient;
    constructor(private httpBackend: HttpBackend) {
        this.http = new HttpClient(httpBackend);
    }
    get isLoggedIn(): boolean {
        let tokenInfo = this.getTokenInfo();
        return (typeof tokenInfo !== 'undefined' && tokenInfo !== null && typeof (tokenInfo as any).access_token !== 'undefined');
    }

    private getTokenInfo() {
        return localStorage.getItem(authCookieKey);
    }

    public get accessToken() {
        const accessTokenInfo = localStorage.getItem(authCookieKey);
        return accessTokenInfo && (accessTokenInfo as any).access_token;
    }

    public get refreshToken() {
        const accessTokenInfo = localStorage.getItem(authCookieKey);
        return accessTokenInfo && (accessTokenInfo as any).refresh_token;
    }

    login(loginId: string, password: string): Observable<any> {
        return getToken(this.http, loginId, password).subscribe(res => {
            console.log(res);
        }, err => {
            console.log(err);
        });
    }
}