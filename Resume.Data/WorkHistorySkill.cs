using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Resume.Data
{
    [Table("WorkHistorySkills")]
    public class WorkHistorySkill : DbDefaults
    {
        public int WorkHistoryId { get; set; }
        public WorkHistory WorkHistory { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }

        public WorkHistorySkill()
        {

        }
    }
}
