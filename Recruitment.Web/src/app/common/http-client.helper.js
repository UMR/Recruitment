"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.getTokenFromRefreshToken = exports.revokeToken = exports.getToken = void 0;
var http_1 = require("@angular/common/http");
var auth_key_1 = require("./auth-key");
var accessTokenUrl = "".concat(auth_key_1.authorizationServerUrl, "/connect/token");
var accessTokenBody = "grant_type=password&username={0}&password={1}&scope=recruitment.fullaccess&client_id=recruitmentweb&client_secret=".concat(encodeURIComponent(auth_key_1.clientSecret));
var accessTokenRevokeUrl = "".concat(auth_key_1.authorizationServerUrl, "/connect/revocation");
var refreshTokenRevokeBody = 'token={0}&token_type_hint=refresh_token';
var accessTokenFromRefreshTokenBody = 'grant_type=refresh_token&refresh_token={0}';
function getheaders() {
    var headers = new http_1.HttpHeaders({
        'Content-Type': 'application/x-www-form-urlencoded',
        //'Authorization': 'Basic YXBpY2xpZW50aWQ6YXBpU2VjcmV0'
    });
    return headers;
}
function getToken(http, userID, password) {
    var body = accessTokenBody.replace('{0}', userID).replace('{1}', password);
    return http.post(accessTokenUrl, body, { headers: getheaders() });
}
exports.getToken = getToken;
function revokeToken(http, refreshToken) {
    var body = refreshTokenRevokeBody.replace('{0}', refreshToken);
    return http.post(accessTokenRevokeUrl, body, { headers: getheaders() });
}
exports.revokeToken = revokeToken;
function getTokenFromRefreshToken(http, refreshToken) {
    var body = accessTokenFromRefreshTokenBody.replace('{0}', refreshToken);
    return http.post(accessTokenUrl, body, { headers: getheaders() });
}
exports.getTokenFromRefreshToken = getTokenFromRefreshToken;
//# sourceMappingURL=http-client.helper.js.map