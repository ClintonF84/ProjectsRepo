using Microsoft.EntityFrameworkCore;
using Resume.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Core
{
    public class ResumeService : IResumeService
    {
        private ResumeDb db;

        public ResumeService()
        {

        }

        public ResumeService(ResumeDb db)
        {
            this.db = db;
        }

        public async Task<List<Skill>> GetSkills()
        {
            return await this.db.Skills.ToListAsync();
        }
    }
}
