import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  registerMode = false;

  constructor() { }

  ngOnInit() {
  }

  registerToggle() {
    console.log('registerToggle');
    this.registerMode = !this.registerMode;
  }

  cancelRegisterMode(registerMode: boolean) {
    console.log('cancelRegisterMode');
    this.registerMode = registerMode;
  }

}
