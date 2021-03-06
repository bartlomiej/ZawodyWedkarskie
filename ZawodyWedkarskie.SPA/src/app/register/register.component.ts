import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  @Output() cancelRegister = new EventEmitter();
  model: any = {};

  constructor(private authService: AuthService, private alerify: AlertifyService) { }

  ngOnInit() {
  }

  rejestruj() {
    console.log('register');
    this.authService.register(this.model).subscribe(() => {
      this.alerify.success('Zarejestrowałeś się !');
    }, error => {
      this.alerify.error('Wystąpił błąd podczas rejestracji !');
    });
  }

  przerwij() {
    this.cancelRegister.emit(false);
  }
}
