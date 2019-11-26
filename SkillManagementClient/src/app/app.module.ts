import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { SkillComponent } from './skill/skill.component';
import {FormsModule} from '@angular/forms'
import { HttpClientModule } from '@angular/common/http';
import { ManagerProfileComponent } from './manager-profile/manager-profile.component';
import { EmployeeViewComponent } from './employee-view/employee-view.component';

@NgModule({
  declarations: [
    AppComponent,
    UserProfileComponent,
    SkillComponent,
    ManagerProfileComponent,
    EmployeeViewComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
