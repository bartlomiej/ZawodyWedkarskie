import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

import { JwtHelperService } from '@auth0/angular-jwt';
import { inherits } from 'util';

@Injectable()
export class AuthService {

  jwtHelper = new JwtHelperService();
  baseUrl = 'http://localhost:5000/api/auth/';
  decodeToken: any;

  constructor(private http: HttpClient) { }

  login(model: any) {
    return this.http.post(this.baseUrl + 'login', model).pipe(
      map((response: any) => {
        const user = response;
        if (user) {
          console.log(user.token);
          localStorage.setItem('token', user.token);
        }
      })
    );
  }

  register(model: any) {
    console.log('AuthService register');
    return this.http.post(this.baseUrl + 'register', model);
  }

  loggedIn() {
    const token = localStorage.getItem('token');
    return !this.jwtHelper.isTokenExpired(token);
  }
}
