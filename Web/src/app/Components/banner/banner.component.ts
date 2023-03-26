import { Component, OnInit } from '@angular/core';
import { Config } from 'src/app/SYS/config';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-banner',
  templateUrl: './banner.component.html',
  styleUrls: ['./banner.component.scss']
})
export class BannerComponent implements OnInit {

  constructor (private http : HttpClient) {}

   ngOnInit(): void {
    console.log(Config.Current.apiurl);
  }
}
