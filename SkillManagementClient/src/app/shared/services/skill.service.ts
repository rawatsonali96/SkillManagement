import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Skill } from '../models/skill'

@Injectable({
  providedIn: 'root'
})
export class SkillService {
  private url = 'http://localhost:3000/Skills'

  constructor(private http: HttpClient) { }

  displaySkills(): Observable<Skill[]> {
    return this.http.get<Skill[]>(this.url);
  }
}
