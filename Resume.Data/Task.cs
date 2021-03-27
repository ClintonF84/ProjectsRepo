using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Resume.Data
{
    [Table("Tasks")]
    public class Task : DbDefaults
    {
        public string TaskDescription { get; set; }

        public ICollection<WorkHistoryTask> WorkHistoryTasks { get; set; }
        public Task()
        {

        }
    }
}
