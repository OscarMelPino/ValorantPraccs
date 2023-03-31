import { Component, OnInit } from '@angular/core'

@Component({
  selector: 'app-banner',
  templateUrl: './banner.component.html',
  styleUrls: ['./banner.component.scss']
})
export class BannerComponent {
  
  showLogin : boolean = false

  public triggerLoginView() : void {
    this.showLogin = !this.showLogin
  }
}
