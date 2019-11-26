using System;
using System.Collections.Generic;
using System.Text;

namespace SkillModel
{
   public  class UserSkillDetails
    {
        
        public int UserSkillID { get; set; }
        public double ManagerRating { get; set; }
        public double Rating { get; set; }
        public String ProficencyLevel { get; set; }
        public bool Certification { get; set; }
    }
}
