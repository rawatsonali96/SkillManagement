import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class SkillService{

  url:string;
  id:Number;
  constructor(private httpClient: HttpClient) {
    this.url="https://localhost:57218/api/Skills/UserSkillsTree/"
  }

  getData()
  {
    console.log("inside data");

    this.id=1;
    return this.httpClient.get(this.url+this.id);
  }
}
