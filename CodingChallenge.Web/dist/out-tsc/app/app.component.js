import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { Observable } from 'rxjs/Rx';
import { UserService } from './user.service';
import * as moment from 'moment';
var AppComponent = /** @class */ (function () {
    function AppComponent(userService) {
        this.userService = userService;
        this.title = 'Coding Challenge - Marco Rodriguez';
        this.defaultUser = { name: "--", id: 0 };
    }
    AppComponent.prototype.valueChange = function (value) {
        this.getProjects(value.id);
    };
    AppComponent.prototype.getUsers = function () {
        this.userList = [this.defaultUser];
        var c = this;
        this.userService.getUsers().subscribe(function (data) {
            data.forEach(function (user) {
                c.userList.push(user);
            });
        }, function (error) {
            console.error("Error reading the list of users");
            return Observable.throw(error);
        });
    };
    AppComponent.prototype.getProjects = function (userId) {
        this.projectList = [];
        var c = this;
        this.userService.getProjectsByUser(userId).subscribe(function (data) {
            data.forEach(function (project) {
                project.startDate = moment(project.startDate).format('MM/DD/YYYY');
                project.endDate = moment(project.endDate).format('MM/DD/YYYY');
                c.projectList.push(project);
            });
            c.projectList = data;
        }, function (error) {
            console.error("Error reading the list of projects");
            return Observable.throw(error);
        });
    };
    AppComponent.prototype.ngOnInit = function () {
        this.getUsers();
    };
    AppComponent = tslib_1.__decorate([
        Component({
            selector: 'app-root',
            templateUrl: './app.component.html',
            styleUrls: ['./app.component.css']
        }),
        tslib_1.__metadata("design:paramtypes", [UserService])
    ], AppComponent);
    return AppComponent;
}());
export { AppComponent };
//# sourceMappingURL=app.component.js.map