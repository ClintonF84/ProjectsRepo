using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Resume.Data
{
    [Table("Resume")]
    public class Resume : DbDefaults
    {
        public string College { get; set; }
        public string YearGraduatedFrom { get; set; }

        public ICollection<ResumeSkill> Skills { get; set; }
        public ICollection<ResumeWorkHistory> WorkHistory { get; set; }
    }
}
