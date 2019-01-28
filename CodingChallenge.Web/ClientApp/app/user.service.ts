import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { User } from './user';
import { Project } from './project';
import { environment } from '../environments/environment';

@Injectable()
export class UserService {

    constructor(private http: HttpClient) { }

    private httpOptions = {
        headers: new HttpHeaders({
            'Access-Control-Allow-Origin': '*',
            'Authorization': 'authkey',
            'userid': '1'
        })
    };

    public getUsers() {
        return this.http.get<Array<User>>(environment.api_endpoint + 'user', this.httpOptions);
    }

    public getProjectsByUser(userId: number) {
        
        return this.http.get<Array<Project>>(environment.api_endpoint + 'user/' + userId + '/projects', this.httpOptions);
    }
}
