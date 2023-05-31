import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { LoginService } from './login.service';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.scss']
})
export class LoginComponent {
    public userId: string = "test";
    public password: string = "test";

    constructor(private router: Router, private loginService: LoginService) { }
    onLoginClick() {
        this.loginService.getToken(this.userId, this.password).subscribe
            (res => {
                this.router.navigateByUrl("/");
                console.log(res);
            }, err => {
                console.log(err);
            });
        //this.router.navigateByUrl("/");
    }
}
