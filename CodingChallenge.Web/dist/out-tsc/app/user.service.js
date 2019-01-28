import * as tslib_1 from "tslib";
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../environments/environment';
var UserService = /** @class */ (function () {
    function UserService(http) {
        this.http = http;
        this.httpOptions = {
            headers: new HttpHeaders({
                'Access-Control-Allow-Origin': '*',
                'Authorization': 'authkey',
                'userid': '1'
            })
        };
    }
    UserService.prototype.getUsers = function () {
        return this.http.get(environment.api_endpoint + 'user', this.httpOptions);
    };
    UserService.prototype.getProjectsByUser = function (userId) {
        return this.http.get(environment.api_endpoint + 'user/' + userId + '/projects', this.httpOptions);
    };
    UserService = tslib_1.__decorate([
        Injectable(),
        tslib_1.__metadata("design:paramtypes", [HttpClient])
    ], UserService);
    return UserService;
}());
export { UserService };
//# sourceMappingURL=user.service.js.map