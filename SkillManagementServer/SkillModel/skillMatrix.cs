using System;
using System.Collections.Generic;
using System.Text;

namespace SkillModel
{
    public class skillMatrix
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public IEnumerable<SkillNode> skillNodes { get; set; }
    }
}
