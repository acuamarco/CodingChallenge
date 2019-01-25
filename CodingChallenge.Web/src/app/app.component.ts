import { Component } from '@angular/core';
import { User } from 'src/app/User';
import { Project } from 'src/app/Project';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Coding Challenge - Marco Rodriguez';

  public defaultUser: User = { name: "--", id: 0 };

  public userList: Array<User> = [
    this.defaultUser,
    { name: "User 1", id: 1 },
    { name: "User 2", id: 2 },
    { name: "User 3", id: 3 }
  ];

  public projectList: Array<Project> = [
    { id: 1, startDate: "1/1/2019", timeToStart: "Started", endDate: "1/1/2020", credits: 2, status: "Active" },
    { id: 2, startDate: "2/2/2019", timeToStart: "15", endDate: "1/1/2021", credits: 3, status: "Inactive" },
  ];

  public valueChange(value: User): void {
    this.log('valueChange', value.name);
  }

  private log(event: string, arg: any): void {
    console.log(`${event} ${arg || ''}`);
  }
}
