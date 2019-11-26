using System;
using System.Collections.Generic;
using System.Text;

namespace SkillModel
{
    public class SkillNode
    {
        public int SkillId { get; set; }
        public string Description { get; set; }
        public String SkillName { get; set; }
        public Nullable<int> ParentSkillId { get; set; }
        public List<SkillNode> skills { get; set; }
        public UserSkillDetails UserSkillDetails { get; set; }
    }
}
