"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.accessTokenFromRefreshTokenBody = exports.refreshTokenRevokeBody = exports.accessTokenRevokeUrl = exports.accessTokenBody = exports.accessTokenUrl = void 0;
var auth_key_1 = require("../auth-key");
exports.accessTokenUrl = "".concat(auth_key_1.authorizationServerUrl, "/connect/token");
exports.accessTokenBody = "grant_type=password&username={0}&password={1}&scope=recruitment.fullaccess&client_id=recruitmentweb&client_secret=".concat(encodeURIComponent(auth_key_1.clientSecret));
exports.accessTokenRevokeUrl = "".concat(auth_key_1.authorizationServerUrl, "/connect/revocation");
exports.refreshTokenRevokeBody = 'token={0}&token_type_hint=refresh_token';
exports.accessTokenFromRefreshTokenBody = 'grant_type=refresh_token&refresh_token={0}';
//# sourceMappingURL=auth.constant.js.map