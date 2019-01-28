import { environment } from '../environments/environment';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { UserService } from './user.service';
import { TestBed, getTestBed } from '@angular/core/testing';

describe('UserService', () => {
  let injector: TestBed;
  let service: UserService;
  let httpMock: HttpTestingController;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [UserService]
    });
    injector = getTestBed();
    service = injector.get(UserService);
    httpMock = injector.get(HttpTestingController);
  });

  describe('#getUsers', () => {
    it('should return an Observable<User[]>', () => {
      const mockUsers = [
        { id: 1, name: 'User 1' },
        { id: 2, name: 'User 2' }
      ];

      service.getUsers().subscribe(users => {
        expect(users.length).toBe(2);
        expect(users).toEqual(mockUsers);
      });

      const req = httpMock.expectOne(environment.api_endpoint + 'user');
      expect(req.request.method).toBe("GET");
      req.flush(mockUsers);
    });
  });

  describe('#getProjectsByUser', () => {
    it('should return an Observable<Project[]>', () => {

      const mockProjects = [{ id: 1, startDate: "1/1/2019", timeToStart: "Started", endDate: "2/2/2019", status: "Active", credits: 1 }];

      service.getProjectsByUser(1).subscribe(projects => {
        expect(projects.length).toBe(1);
        expect(projects).toEqual(mockProjects);
      });

      const req = httpMock.expectOne(environment.api_endpoint + 'user/1/projects');
      expect(req.request.method).toBe("GET");
      req.flush(mockProjects);
    });
  });

});
