import { Component, OnInit } from '@angular/core';
import { SkillService } from '../shared/services/skill.service';
import { Skill } from '../shared/models/skill';

@Component({
  selector: 'app-skill',
  templateUrl: './skill.component.html',
  styleUrls: ['./skill.component.css']
})
export class SkillComponent implements OnInit {
  private skills: Skill[] = [];
  

  constructor(private skillservice: SkillService) { }

  ngOnInit() {
    this.skillservice.displaySkills().subscribe(res => {
      this.skills = res;
       console.log(this.skills);
    }, err => {
      console.log(err)
    });
   // this.fillEmpty(this.skills);
    console.log(this.skills);
    
  }
  // fillEmpty(skills:Array<Skill>)
  // {

  //   skills.forEach(element => {
  //     if(element.skills===null)
  //     {
  //       if(element.userSkill===null)
  //         element.userSkill
  //     }
  //     else this.fillEmpty(element.skills)
  //   });

  // }
  OnSubmit() {
    console.log("Submitted");
    console.log(this.skills);




  }
}
