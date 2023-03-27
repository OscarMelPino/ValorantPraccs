import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Agent } from './COR/Agents';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  constructor(private http:HttpClient){}
  agents : Agent[] | undefined
  title = 'ValoPracc';
}
