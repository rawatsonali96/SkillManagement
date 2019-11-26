import { Component, OnInit } from '@angular/core';
import { SkillService } from '../shared/services/skill.service';

@Component({
  selector: 'app-manager-profile',
  templateUrl: './manager-profile.component.html',
  styleUrls: ['./manager-profile.component.css']
})
export class ManagerProfileComponent implements OnInit {

  constructor(private skill:SkillService) { }

  ngOnInit() {
    this.skill.getEmployees().subscribe(
      res=>{
        console.log(res);
      },
      error=>{
        console.log("error");
      }
    );
  }

}
