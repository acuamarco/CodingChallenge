import { TestBed, async } from '@angular/core/testing';
import { AppComponent } from './app.component';
import { DropDownsModule } from '@progress/kendo-angular-dropdowns';
import { GridModule } from '@progress/kendo-angular-grid';
import { UserService } from './user.service';
import { HttpClientTestingModule } from '@angular/common/http/testing';
describe('AppComponent', function () {
    beforeEach(async(function () {
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
    it('should create the app', function () {
        var fixture = TestBed.createComponent(AppComponent);
        var app = fixture.debugElement.componentInstance;
        expect(app).toBeTruthy();
    });
    it("should have as title 'coding-challenge'", function () {
        var fixture = TestBed.createComponent(AppComponent);
        var app = fixture.debugElement.componentInstance;
        expect(app.title).toEqual('Coding Challenge - Marco Rodriguez');
    });
});
//# sourceMappingURL=app.component.spec.js.map