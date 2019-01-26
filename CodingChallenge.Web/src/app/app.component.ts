import { Component } from '@angular/core';
import { Observable } from 'rxjs/Rx';
import { Project } from 'src/app/project';
import { ProjectService } from 'src/app/project.service';
import { User } from 'src/app/user';
import { UserService } from 'src/app/user.service';

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
  
  constructor(private userService: UserService, private projectService: ProjectService) {
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
        data.forEach(function(user) {
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
    this.projectService.getProjectsByUser(userId).subscribe(
      data => {
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
