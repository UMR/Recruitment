"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.resourceServerUrl = exports.scopes = exports.pathMatch = exports.authorizationServerUrl = exports.authCookieKey = void 0;
exports.authCookieKey = 'tokenKeyUMRRecruitment';
//////////////////////////////   Localhost   ///////////////////////////
exports.authorizationServerUrl = 'http://localhost:4000';
exports.pathMatch = '/RecruitmentSPA';
exports.scopes = ['recruitment.fullaccess', 'openid'];
exports.resourceServerUrl = 'http://localhost:4001';
//////////////////////    172.16.1.11 TEST   //////////////////////////
//export const authorizationServerUrl = 'http://www.umrtest.com/UMRRecruitmentBasicAPIAuthorizationServer';
//export const pathMatch = '/RecruitmentSPA';
//export const scopes = ['recruitment.fullaccess', 'offline_access', 'openid'];
//export const resourceServerUrl = 'http://www.umrtest.com/UMRRecruitmentBasicAPIResourceServer';
//////////////////////////    172.16.1.104 PRODUCTION  //////////////////////////
//export const authorizationServerUrl = 'https://www.universalmedicalrecord.com/UMRRecruitmentBasicAPIAuthorizationServer';
//export const pathMatch = '/RecruitmentSPA';
//export const scopes = ['recruitment.fullaccess', 'offline_access', 'openid'];
//export const resourceServerUrl = 'https://www.universalmedicalrecord.com/UMRRecruitmentBasicAPIResourceServer';
//////////////////////////   mechatronicssolutionscorp  //////////////////////////
//export const authorizationServerUrl = 'https://www.mechatronicssolutionscorp.com/UMRRecruitmentBasicAPIAuthorizationServer';
//export const pathMatch = '/RecruitmentSPA';
//export const scopes = ['recruitment.fullaccess', 'offline_access', 'openid'];
//export const resourceServerUrl = 'https://www.mechatronicssolutionscorp.com/UMRRecruitmentBasicAPIResourceServer';
//# sourceMappingURL=constant.js.map