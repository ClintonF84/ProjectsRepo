using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Resume.Data
{
    public class DbDefaults
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate{ get; set; }
        public DateTime ModifiedDate{ get; set; }

        public DbDefaults()
        {

        }
    }
}
