﻿import { HttpBackend, HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { AuthService } from "../common/service/auth.service";

@Injectable()
export class LoginService {
    private http: HttpClient;

    constructor(private authService: AuthService, private httpBackend: HttpBackend) {
        this.http = new HttpClient(httpBackend);
    }


    get isLoggedIn() {
        if (this.authService.isLoggedIn) {
            return true;
        }
        return false;
    }
    login(userID: string, password: string) {
        return this.authService.getToken(this.http, userID, password);
    }
}