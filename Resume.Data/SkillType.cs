using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Resume.Data
{
    [Table("SkillType")]
    public class SkillType : DbDefaults
    {
        public string TypeName { get; set; }

        public SkillType()
        {

        }
    }
}
