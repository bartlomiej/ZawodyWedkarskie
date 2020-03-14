import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-kolo-wedkarskie',
  templateUrl: './KoloWedkarskie.component.html',
  styleUrls: ['./KoloWedkarskie.component.css']
})
export class KoloWedkarskieComponent implements OnInit {

  kola: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getKolaWedkarskie();
  }

  getKolaWedkarskie(){
    this.http.get('https://localhost:5001/api/KolaWedkarskie').subscribe(resp => {
      this.kola = resp;
      console.log(this.kola);
    }, error => {
      console.log(error);
    });
  }

}
