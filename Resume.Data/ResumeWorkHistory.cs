using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Resume.Data
{
    [Table("ResumeWorkHistories")]
    public class ResumeWorkHistory : DbDefaults
    {
        public int WorkHistoryId { get; set; }
        public WorkHistory WorkHistory { get; set; }

        public int ResumeId { get; set; }
        public Resume Resume { get; set; }
        public ResumeWorkHistory()
        {

        }
    }
}
