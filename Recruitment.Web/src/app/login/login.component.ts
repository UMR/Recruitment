import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { authCookieKey } from '../common/auth-key';
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
    ngOnInit() {
        if (this.loginService.isLoggedIn) {
            this.router.navigate(['/']);
        }
    }
    onLoginClick() {
        this.loginService.login(this.userId, this.password)
            .subscribe(res => {
                this.router.navigateByUrl("/");
            },
                err => {
                    console.log(err);
                }
            );
    }
}
