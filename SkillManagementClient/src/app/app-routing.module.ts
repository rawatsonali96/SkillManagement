import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EmployeeViewComponent } from './employee-view/employee-view.component';
import { UserProfileComponent } from './user-profile/user-profile.component';


const routes: Routes = [
  {path:'',component:UserProfileComponent,pathMatch:'full'},
  { path: 'viewEmployee', component: EmployeeViewComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
