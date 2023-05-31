import { HttpClient, HttpHeaders } from '@angular/common/http';
import { authorizationServerUrl, clientSecret } from './auth-key';

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


export function getToken(http: HttpClient, userID: string, password: string): any {
    const body = accessTokenBody.replace('{0}', userID).replace('{1}', password);
    return http.post(accessTokenUrl, body, { headers: getheaders() });
}

export function revokeToken(http: HttpClient, refreshToken: string): any {
    const body = refreshTokenRevokeBody.replace('{0}', refreshToken);
    return http.post(accessTokenRevokeUrl, body, { headers: getheaders() });
}

export function getTokenFromRefreshToken(http: HttpClient, refreshToken: string): any {
    const body = accessTokenFromRefreshTokenBody.replace('{0}', refreshToken);
    return http.post(accessTokenUrl, body, { headers: getheaders() });
}
