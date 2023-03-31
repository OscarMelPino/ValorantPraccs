import { animate } from '@angular/animations';
import { HttpClient } from '@angular/common/http';
import { emitDistinctChangesOnlyDefaultValue } from '@angular/compiler';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Agent } from '../COR/Agents';
import { Config } from '../SYS/config';

@Injectable({
  providedIn: 'root'
})

export class ApiService {

  constructor(private http : HttpClient) { }  

  getAgents() : Observable<Agent[]> {
    return this.http.get<Agent[]>(Config.Current.agentsendpoint!)
  }

  getAgentByID(agentID : number) : Observable<Agent> {
    const endpoint = Config.Current.agentsendpoint + '/' + agentID
    return this.http.get<Agent>(endpoint)
  }

  validateCredentials(username : string, password : string) : boolean {
    let valid : boolean = false
    this.http.post<boolean>(Config.Current.loginendpoint!, { username: username, password: password })
        .subscribe(ok => valid = ok)
    return valid
  }

  registerUser(username : string, password : string) : boolean {
    let created : boolean = false
    const endpoint = Config.Current.loginendpoint + '/new'
    this.http.post<boolean>(endpoint, { username: username, password: password })
        .subscribe(ok => created = ok)
    return created
  }
}
