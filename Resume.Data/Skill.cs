using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Resume.Data
{
    [Table("Skills")]
    public class Skill : DbDefaults
    {
        public string Name { get; set; }

        public SkillType SkillType { get; set; }
        public int SkillTypeId { get; set; }

        public ICollection<ResumeSkill> ResumeSkills { get; set; }
        public ICollection<WorkHistorySkill> WorkHistorySkills { get; set; }

        public Skill()
        {
        }
    }
}
