using SkillModel;
using SkillRepository;
using System;
using System.Collections.Generic;

namespace SkillServices
{
    public class SkillService
    {
        private readonly SkillRepo skillRepo;
        public SkillService(SkillRepo skillRepo)
        {
            this.skillRepo = skillRepo;
        }
        public void AddSkill(Skill skill)
        {
            try
            {
                this.skillRepo.AddSkill(skill);
            }
            catch(Exception exp)
            {
                throw exp;
            }
            
        }
        public void AddEmployee(Employee employee)
        {
            try
            {
                this.skillRepo.AddEmployee(employee);
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
        public void AddUserSkill(UserSkill userskill)
        {
            try
            {
                this.skillRepo.AddUserSkill(userskill);
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
        public IEnumerable<Skill> ShowSkills()
        {
            try
            {
                return this.skillRepo.ShowSkills();
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
        public IEnumerable<Employee> ShowEmployees()
        {
            try
            {
               return this.skillRepo.ShowEmployees();
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
        public IEnumerable<Employee> ShowEmployees(int id)
        {
            try
            {
                return this.skillRepo.ShowEmployees(id);
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
        public IEnumerable<UserSkill> ShowUserSkills(int id)
        {
            try
            {
                return this.skillRepo.ShowUserSkills(id);
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
        public IEnumerable<SkillNode> FillNode(int id)
        {

            try
            {
                var skills = this.skillRepo.ShowSkills();
                var userskills = this.skillRepo.ShowUserSkills(id);
                var userSkillDictionary = new Dictionary<int, SkillNode>();
                var result = this.skillRepo.FillNode(skills, userSkillDictionary, null);
                foreach (var userskil in userskills)
                {


                    var record = userSkillDictionary[userskil.SkillId];
                    if (record != null)
                    {
                        record.UserSkillDetails = new UserSkillDetails()
                        {
                            UserSkillID = userskil.UserSkillID,
                            Certification = userskil.Certification,
                            ManagerRating = userskil.ManagerRating,
                            ProficencyLevel = userskil.ProficencyLevel,
                            Rating = userskil.Rating
                        };
                    }


                }
                return result;
            }
            catch (Exception ex)
            {  
                throw;
            }          
            
        }
        public List<Employee> listOfEmployees()
        {

            return skillRepo.listOfEmployees();
        }

        public List<skillMatrix> getSkillMatrix()
        {
            //var result = skillRepo.GetSkillMatrix();
            //var skills = this.ShowSkills();
            //var userSkillDictionary = new Dictionary<int, SkillNode>();
            List<skillMatrix> skillMatrix = new List<skillMatrix>();
            List<Employee> employees = this.listOfEmployees();
            foreach (var Employee in employees)
            {
          //      var userskills = this.ShowUserSkills(Employee.EmpId);
                skillMatrix.Add(new skillMatrix()
                {
                    EmployeeId = Employee.EmpId,
                    EmployeeName = Employee.EmpName,
                    skillNodes = this.FillNode(Employee.EmpId)
                });
            }
            return skillMatrix;
        }
    }
}
