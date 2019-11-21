using Models.Skill;
using Repositories;
using System;
using System.Collections.Generic;
using System.Text;
namespace Services
{
    public class SkillService: ISkillService
    {
        private readonly ISkillRepository skillRepository;
        public SkillService(ISkillRepository skillRepository)
        {
            this.skillRepository = skillRepository;
        }
        public List<Skill> SkillTreeStructure()
        {
            return skillRepository.SkillTreeStructure();
        }
    }
}
