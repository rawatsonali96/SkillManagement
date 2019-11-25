import { Component, OnInit } from '@angular/core';
import { SkillService } from '../skill.service';

@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrls: ['./user-profile.component.css']
})
export class UserProfileComponent implements OnInit {

  constructor(private skillService:SkillService ) { }

  ngOnInit() {
    this.skillService.getData().subscribe(
      res=>{
        console.log(res);
      },
      error=>{
        console.log("error");
      }
    );
  }

}
