import { Component, OnInit } from '@angular/core';
import { AuthService } from '../common/service/auth.service';


@Component({
  templateUrl: 'dashboard.component.html',
  styleUrls: ['dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
    constructor(private authService: AuthService) {
        console.log(this.authService.isLoggedIn);
    }

  ngOnInit(): void {
      console.log(this.authService.isLoggedIn);
  }

}
