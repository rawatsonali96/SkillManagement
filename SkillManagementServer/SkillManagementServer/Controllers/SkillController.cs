﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace SkillManagementServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
       private readonly ISkillService _skillService;
       public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }
        // GET: api/Skill
        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_skillService.SkillTreeStructure());
        }

        // GET: api/Skill/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Skill
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Skill/5
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
