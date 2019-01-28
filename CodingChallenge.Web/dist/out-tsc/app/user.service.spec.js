import { environment } from '../environments/environment';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { UserService } from './user.service';
import { TestBed, getTestBed } from '@angular/core/testing';
describe('UserService', function () {
    var injector;
    var service;
    var httpMock;
    beforeEach(function () {
        TestBed.configureTestingModule({
            imports: [HttpClientTestingModule],
            providers: [UserService]
        });
        injector = getTestBed();
        service = injector.get(UserService);
        httpMock = injector.get(HttpTestingController);
    });
    describe('#getUsers', function () {
        it('should return an Observable<User[]>', function () {
            var mockUsers = [
                { id: 1, name: 'User 1' },
                { id: 2, name: 'User 2' }
            ];
            service.getUsers().subscribe(function (users) {
                expect(users.length).toBe(2);
                expect(users).toEqual(mockUsers);
            });
            var req = httpMock.expectOne(environment.api_endpoint + 'user');
            expect(req.request.method).toBe("GET");
            req.flush(mockUsers);
        });
    });
    describe('#getProjectsByUser', function () {
        it('should return an Observable<Project[]>', function () {
            var mockProjects = [{ id: 1, startDate: "1/1/2019", timeToStart: "Started", endDate: "2/2/2019", status: "Active", credits: 1 }];
            service.getProjectsByUser(1).subscribe(function (projects) {
                expect(projects.length).toBe(1);
                expect(projects).toEqual(mockProjects);
            });
            var req = httpMock.expectOne(environment.api_endpoint + 'user/1/projects');
            expect(req.request.method).toBe("GET");
            req.flush(mockProjects);
        });
    });
});
//# sourceMappingURL=user.service.spec.js.map