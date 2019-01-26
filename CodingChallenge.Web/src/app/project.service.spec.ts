import { environment } from '../environments/environment';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { ProjectService } from './project.service';
import { TestBed, getTestBed } from '@angular/core/testing';

describe('ProjectService', () => {
  let injector: TestBed;
  let service: ProjectService;
  let httpMock: HttpTestingController;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [ProjectService]
    });
    injector = getTestBed();
    service = injector.get(ProjectService);
    httpMock = injector.get(HttpTestingController);
  });

  describe('#getProjects', () => {
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
