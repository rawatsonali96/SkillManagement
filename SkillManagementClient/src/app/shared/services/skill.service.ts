import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Skill } from '../models/skill'

@Injectable({
  providedIn: 'root'
})
export class SkillService {
  private url = 'http://localhost:3000/Skills';
  private url1 = 'https://localhost:57218/api/Skills/UserSkillsTree/';
  id: number;

  constructor(private http: HttpClient) { }

  displaySkills(): Observable<Skill[]> {
    return this.http.get<Skill[]>(this.url);
  }
  getData() {
    console.log("inside data");
    this.id = 1;
    return this.http.get(this.url1 + this.id);
  }
}
