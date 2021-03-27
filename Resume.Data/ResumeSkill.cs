using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Resume.Data
{
    [Table("ResumeSkills")]
    public class ResumeSkill : DbDefaults
    {
        public int ResumeId { get; set; }
        public Resume Resume { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
        public ResumeSkill()
        {

        }
    }
}
