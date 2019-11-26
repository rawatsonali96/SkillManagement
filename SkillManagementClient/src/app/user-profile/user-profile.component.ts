import { Component, OnInit } from '@angular/core';
import { SkillService } from '../shared/services/skill.service';

@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrls: ['./user-profile.component.css']
})
export class UserProfileComponent implements OnInit {

  constructor(private skillService:SkillService ) { }

  ngOnInit() {
    this.skillService.displaySkills().subscribe(
      res=>{
        console.log(res);
      },
      error=>{
        console.log("error");
      }
    );
  }

}
