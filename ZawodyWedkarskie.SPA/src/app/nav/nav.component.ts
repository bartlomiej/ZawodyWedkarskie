import { Component, OnInit } from '@angular/core';

import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';
import { JwtHelperService } from '@auth0/angular-jwt';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  jwtHelper = new JwtHelperService();

  model: any = {};

  constructor(public authService: AuthService, private alerify: AlertifyService) { }

  ngOnInit() {
    const token = localStorage.getItem('token');
    if (token) {
      console.log(this.jwtHelper.decodeToken(token));
      this.authService.decodeToken = this.jwtHelper.decodeToken(token);
    }
  }

  login() {
    console.log(this.model);
    this.authService.login(this.model).subscribe(next => {
      this.alerify.success('Zalogowałeś się !');
    }, error => {
      this.alerify.error('Błąd logowania ' + error);
    });
  }

  loggedIn() {
    return this.authService.loggedIn();
  }

  logout() {
    localStorage.removeItem('token');
    this.alerify.message('Zostałeś wylogowany');
  }
}
