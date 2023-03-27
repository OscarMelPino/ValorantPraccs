import { Component, OnInit } from '@angular/core'
import { ApiService } from 'src/app/Services/api.service'
import { FormsModule } from '@angular/forms'

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {

  constructor(private api : ApiService) {}

  username : string = ''
  password : string = ''

  async ValidateCredentials() {    
    const user = this.username
    const hashedPassword = await this.hashPassword(this.password);
    if (this.api.validateCredentials(user, hashedPassword)){

    }
  }
  
  private async hashPassword(password: string): Promise<string> {
  const encoder = new TextEncoder();
  const data = encoder.encode(password);
  const digest = await window.crypto.subtle.digest('SHA-256', data);
  return Array.from(new Uint8Array(digest)).map(x => x.toString(16).padStart(2, '0')).join('');
}


}
