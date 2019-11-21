using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.EmployeeDetails
{
    public class EmployeeDetails
    {
        [Key]
        public int EmpId { get; set; }
    }
}
