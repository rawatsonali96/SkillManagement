using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SkillModel
{
    public class UserSkill
    {
        [Key]
        public int UserSkillID { get; set; }
        public int SkillId { get; set; }
        [ForeignKey("SkillId")]
        public Skill Skill { get; set; }
        public int EmpID { get; set; }

        [ForeignKey("EmpID")]
        public Employee Employee { get; set; }
        public double ManagerRating { get; set; }

        public double Rating { get; set; }
        public String ProficencyLevel { get; set; }
        public bool Certification { get; set; }
    }
}
