using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Skill;
namespace Repositories
{
    public class SkillRepository: ISkillRepository
    {
        List<Skill> list = new List<Skill>();
        public SkillRepository()
        { 
            list.Add(new Skill() { skillId = 0, parentSkillId = null});
            list.Add(new Skill() { skillId = 1, parentSkillId = 0 });
            list.Add(new Skill() { skillId = 2, parentSkillId = 0 });
            list.Add(new Skill() { skillId = 3, parentSkillId = 2 });
            list.Add(new Skill() { skillId = 4, parentSkillId = 2 });
            list.Add(new Skill() { skillId = 5, parentSkillId = 3 });
        }
        public List<Skill> SkillTreeStructure()
        {
            //List<Skill> skillsTree = new List<Skill>();
            //var rootNode = list.Find(x => x.parentSkillId == null);
            //var parentNode = rootNode;
            //skillsTree.Add(parentNode);
            //while (list.Count > 0 )
            //{
            //    var childrenNodes = list.FindAll(x => x.parentSkillId.Equals(parentNode));
            //    list.Remove(parentNode);
            //    skillsTree.AddRange(childrenNodes);
            //}        
            //return list;
            var lookUp = list.ToLookup(list => list.parentSkillId);
            return null;
        }
    }
}
