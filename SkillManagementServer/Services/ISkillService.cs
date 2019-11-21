using Models.Skill;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ISkillService
    {
        List<Skill> SkillTreeStructure();
    }
}
