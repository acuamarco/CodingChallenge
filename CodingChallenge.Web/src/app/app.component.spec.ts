import { TestBed, async } from '@angular/core/testing';
import { AppComponent } from './app.component';
import { DropDownsModule } from '@progress/kendo-angular-dropdowns';
import { GridModule } from '@progress/kendo-angular-grid';
import { UserService } from './user.service';
import { HttpClientTestingModule } from '@angular/common/http/testing';
describe('AppComponent', () => {
  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [
        DropDownsModule,
        GridModule,
        HttpClientTestingModule
      ],
      declarations: [
        AppComponent
      ],
      providers: [UserService]
    }).compileComponents();
  }));

  it('should create the app', () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app).toBeTruthy();
  });

  it(`should have as title 'coding-challenge'`, () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.title).toEqual('Coding Challenge - Marco Rodriguez');
  });
});
