import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Skill } from '../models/skill'

@Injectable({
  providedIn: 'root'
})
export class SkillService {
  private url = 'http://localhost:3000/Skills'
   url1 = 'https://localhost:44307/api/Skills/';
  id: number;

  constructor(private http: HttpClient) { }

  // displaySkills(): Observable<Skill[]> {
  //   return this.http.get<Skill[]>(this.url);
  // }
  displaySkills() {
    console.log("inside data");
    this.id = 2;
    return this.http.get<Skill[]>(this.url1 +'UserSkillsTree/'+this.id);
  }
  getEmployees(){
    console.log("Employee");
    
    return this.http.get(this.url1+'Employee');
  }
}
