using SkillModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillRepository
{
    public class SkillRepo
    {
        DatabaseSet databaseSet;
        public SkillRepo(DatabaseSet dbSet)
        {
            this.databaseSet = dbSet;
        }
        public void  AddSkill(Skill skill)
        {
            this.databaseSet.Skills.Add(skill);
            this.databaseSet.SaveChanges();
        }
        public void AddEmployee(Employee employee)
        {
            this.databaseSet.Employees.Add(employee);
            this.databaseSet.SaveChanges();
        }
        public void AddUserSkill(UserSkill userskill)
        {
            this.databaseSet.UserSkills.Add(userskill);
            this.databaseSet.SaveChanges();
        }
        public IEnumerable<Skill> ShowSkills()
        {
            return this.databaseSet.Skills.ToList();
        }
        public IEnumerable<Employee> ShowEmployees()
        {
            return this.databaseSet.Employees.ToList();
        }
        public IEnumerable<Employee> ShowEmployees(int id)
        {
          
          return (from Employee in databaseSet.Employees
                            where Employee.EmpId == id
                            select Employee).ToList();
        }
        public IEnumerable<UserSkill> ShowUserSkills(int id)
        {
            return (from UserSkill in databaseSet.UserSkills
                    where UserSkill.EmpID == id
                    select UserSkill).ToList();
        }

        public IEnumerable<UserSkill> ShowUserSkills()
        {
            return this.databaseSet.UserSkills.ToList();
        }
        public List<SkillNode> FillNode (IEnumerable<Skill> table, Dictionary<int, SkillNode> map, int? parentId = null)
        {
            var result = table.Where(x => x.ParentSkillId.Equals(parentId)).Select(item => new SkillNode
            {
                SkillId = item.SkillId,
                ParentSkillId = item.ParentSkillId,
                SkillName=item.SkillName,
                skills = FillNode(table, map, item.SkillId)
            }).ToList();
            foreach (var element in result)
            {
                if (element.skills.Count == 0)
                {
                    map.Add(element.SkillId, element);
                    element.skills = null;
                }
            }
            return result;
        }
    }
}
