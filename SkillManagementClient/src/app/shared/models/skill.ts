export interface Skill{
    description:String;
    skillName:string;
    skillId:number;
    userSkill:UserSkill;
    skills:Array<Skill>;
    parentSkillId:number
    
}
export interface UserSkill{
    userSkillID:number;
    skillId:number;
    empId:number;
    onjob:number;
    managerRating:number;
    self:number;
    proficencyLevel :string;
    rating:number;
    certifications:boolean;    
}
