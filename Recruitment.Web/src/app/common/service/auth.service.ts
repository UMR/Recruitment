import { HttpBackend, HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { Observable } from "rxjs";
import { authCookieKey, authorizationServerUrl, clientSecret } from '../auth-key';

const accessTokenUrl = `${authorizationServerUrl}/connect/token`;
const accessTokenBody = `grant_type=password&username={0}&password={1}&scope=recruitment.fullaccess&client_id=recruitmentweb&client_secret=${encodeURIComponent(clientSecret)}`;
const accessTokenRevokeUrl = `${authorizationServerUrl}/connect/revocation`;
const refreshTokenRevokeBody = 'token={0}&token_type_hint=refresh_token';

const accessTokenFromRefreshTokenBody = 'grant_type=refresh_token&refresh_token={0}';

function getheaders(): HttpHeaders {
    let headers = new HttpHeaders({
        'Content-Type': 'application/x-www-form-urlencoded',
        //'Authorization': 'Basic YXBpY2xpZW50aWQ6YXBpU2VjcmV0'
    });
    return headers;
}


@Injectable()
export class AuthService {
    http: HttpClient;
    public redirectUrl: string = "";

    constructor(private httpBackend: HttpBackend, private router: Router) {
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

    getToken(http: HttpClient, userID: string, password: string): Observable<any> {
        const body = accessTokenBody.replace('{0}', userID).replace('{1}', password);
        return http.post(accessTokenUrl, body, { headers: getheaders() });
    }
    logout() {
        localStorage.removeItem(authCookieKey);
        const tokenInfo = this.getTokenInfo();
        if (tokenInfo && (tokenInfo as any).refresh_token) {
            const refreshToken = (tokenInfo as any).refresh_token;
            //this.revokeToken(this.http, refreshToken).subscribe(_ => this.logoutNavigate(), err => this.logoutNavigate());
        }
        else {
            localStorage.removeItem(authCookieKey);
            this.logoutNavigate();
        }
    }
    logoutNavigate() {
        this.router.navigate(['/login']).then(isNavigated => {
            if (isNavigated) {

            }
        });
    }
    revokeToken(http: HttpClient, refreshToken: string): any {
        const body = refreshTokenRevokeBody.replace('{0}', refreshToken);
        return http.post(accessTokenRevokeUrl, body, { headers: getheaders() });
    }

    getTokenFromRefreshToken(http: HttpClient, refreshToken: string): any {
        const body = accessTokenFromRefreshTokenBody.replace('{0}', refreshToken);
        return http.post(accessTokenUrl, body, { headers: getheaders() });
    }
}