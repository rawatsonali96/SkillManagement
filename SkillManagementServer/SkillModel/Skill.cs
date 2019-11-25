using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SkillModel
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        
        public string Description { get; set; }
        public String SkillName { get; set; }

        public Nullable<int> ParentSkillId { get; set; }
       
        [ForeignKey("UserSkills")]

        public ICollection<UserSkill> UserSkills { get; set; }
        //[ForeignKey("ParentSkillId")]
        //public Skill ParentSkill { get; set; }
    }
}
