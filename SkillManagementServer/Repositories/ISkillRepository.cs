using Models.Skill;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public interface ISkillRepository
    {
        List<Skill> SkillTreeStructure();
    }
}
