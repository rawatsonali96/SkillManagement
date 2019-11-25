using SkillModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillManagement.Model
{
    public class SkillTemp
    {
        [Key]
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public int EmpID { get; set; }

        [ForeignKey("EmpID")]
        public Employee Employee { get; set; }

    }
}
