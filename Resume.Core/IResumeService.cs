using Resume.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Core
{
    public interface IResumeService
    {
        public Task<List<Skill>> GetSkills();
    }
}
