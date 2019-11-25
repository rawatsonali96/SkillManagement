using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkillManagement.Model;
using SkillManagement.Repository;
using SkillModel;
using SkillServices;

namespace SkillManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
       SkillService skillService;
      // DatabaseSet databaseSet;
       public SkillsController(SkillService skillService)
        {
            this.skillService = skillService;
        }

        // GET: api/Skills
        [HttpGet("Skills")]
        public IEnumerable<Skill> GetSkills()
        {
            return this.skillService.ShowSkills();
        }
        // GET: api/Skills
        [HttpGet("Employee")]
        public IEnumerable<Employee> GetEmployee()
        {
            return this.skillService.ShowEmployees();
        }
        // GET: api/Skills
        [HttpGet("UserSkills")]
        public IEnumerable<UserSkill> GetUserSkills(int id)
        {
            return this.skillService.ShowUserSkills(id);
        }
        [HttpGet("UserSkillsTree/{id}")]
        public IEnumerable<SkillNode> GetUserSkillsTree(int id)
        {
            var result =this.skillService.FillNode(id);
            return result;
        }
        // GET: api/Skills/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Skills
        [HttpPost("Skill")]
        public void Post(Skill value)
        {
            this.skillService.AddSkill(value);
        }
        
        [HttpPost("UserSkill")]
        public void Post(UserSkill value)
        {
            this.skillService.AddUserSkill(value);
        }
        [HttpPost("Employee")]
        public void Post(Employee value)
        {
            this.skillService.AddEmployee(value);
        }

        // PUT: api/Skills/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
