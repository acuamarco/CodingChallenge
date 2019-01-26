import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { User } from 'src/app/user';
import { Project } from 'src/app/project';
import { environment } from '../environments/environment';

@Injectable()
export class UserService {

  constructor(private http: HttpClient) { }

  public getUsers() {
    return this.http.get<Array<User>>(environment.api_endpoint + 'user');
  }

  public getProjectsByUser(userId: number) {
    return this.http.get<Array<Project>>(environment.api_endpoint + 'user/' + userId + '/projects');
  }
}
