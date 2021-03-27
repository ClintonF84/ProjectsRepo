using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Resume.Data
{
    [Table("WorkHistoryTasks")]
    public class WorkHistoryTask : DbDefaults
    {
        public int WorkHistoryId { get; set; }
        public WorkHistory WorkHistory { get; set; }
        public int TaskId { get; set; }
        public Task Task { get; set; }
        public WorkHistoryTask()
        {

        }
    }
}
