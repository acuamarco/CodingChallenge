import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Project } from 'src/app/project';
import { environment } from '../environments/environment';

@Injectable()
export class ProjectService {

  constructor(private http: HttpClient) { }

  public getProjectsByUser(userId: number) {
    return this.http.get<Array<Project>>(environment.api_endpoint + 'user/' + userId + '/projects');
  }
}
