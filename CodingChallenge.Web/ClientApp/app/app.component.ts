import { Component } from '@angular/core';
import { Observable } from 'rxjs/Rx';
import { Project } from './project';
import { User } from './user';
import { UserService } from './user.service';
import * as moment from 'moment';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent {
    title = 'Coding Challenge - Marco Rodriguez';

    public defaultUser: User;
    public projectList: Array<Project>;
    public userList: Array<User>;

    constructor(private userService: UserService) {
        this.defaultUser = { name: "--", id: 0 };
    }

    public valueChange(value: User): void {
        this.getProjects(value.id);
    }

    private getUsers() {
        this.userList = [this.defaultUser];
        let c = this;
        this.userService.getUsers().subscribe(
            data => {
                data.forEach(function (user) {
                    c.userList.push(user);
                });
            },
            error => {
                console.error("Error reading the list of users");
                return Observable.throw(error);
            }
        );
    }

    private getProjects(userId: number) {
        this.projectList = [];
        let c = this;
        this.userService.getProjectsByUser(userId).subscribe(
            data => {
                data.forEach(function (project) {
                    project.startDate = moment(project.startDate).format('MM/DD/YYYY');
                    project.endDate = moment(project.endDate).format('MM/DD/YYYY');
                    c.projectList.push(project);
                })
                c.projectList = data;
            },
            error => {
                console.error("Error reading the list of projects");
                return Observable.throw(error);
            }
        );
    }

    ngOnInit() {
        this.getUsers();
    }
}
