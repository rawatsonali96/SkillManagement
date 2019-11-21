export interface Skill{
    desc:String;
    skillName:string;
    skillId:number;
    userSkill:UserSkill;
    skills:Array<Skill>;

    
}
export interface UserSkill{
    onjob:number;
    self:number;
    level:string;
    rating:number;
    certifications:boolean;
    
}
