using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Resume.Data
{
    [Table("WorkHistory")]
    public class WorkHistory : DbDefaults
    {
        public string Company { get; set; }
        public string Title { get; set; }
        public string StartMonth { get; set; }
        public string StartYear { get; set; }
        public string EndMonth { get; set; }
        public string EndYear { get; set; }
        public ICollection<WorkHistorySkill> Skills { get; set; }
        public ICollection<WorkHistoryTask> Tasks { get; set; }
    }
}

