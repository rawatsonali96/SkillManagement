using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillManagement.Model
{
    public class SkillTree
    {
        public int id { get; set; }
        public int? parentId{ get; set; }
        public List<SkillTree> skills { get; set; }
    }
}
