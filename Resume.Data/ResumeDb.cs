using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resume.Data
{
    public class ResumeDb : DbContext
    {
        public ResumeDb()
        {

        }

        public ResumeDb(DbContextOptions<ResumeDb> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            //optionBuilder.UseSqlServer()
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<SkillType> SkillTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<WorkHistory> WorkHistory { get; set; }
        public DbSet<WorkHistorySkill> WorkHistorySkills { get; set; }
        public DbSet<WorkHistoryTask> WorkHistoryTasks { get; set; }
        public DbSet<ResumeWorkHistory> ResumeWorkHistory { get; set; }
        //public DbSet<ResumeTask> ResumeTasks { get; set; }
    }
}
