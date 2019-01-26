import { AppComponent } from './app.component';
import { BrowserModule } from '@angular/platform-browser';
import { ButtonsModule } from '@progress/kendo-angular-buttons';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { DropDownsModule } from '@progress/kendo-angular-dropdowns';
import { GridModule } from '@progress/kendo-angular-grid';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { ProjectService } from 'src/app/project.service';
import { UserService } from 'src/app/user.service';


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserAnimationsModule,
    BrowserModule,
    ButtonsModule,
    DropDownsModule,
    GridModule,
    HttpClientModule
  ],
  providers: [
    UserService,
    ProjectService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
