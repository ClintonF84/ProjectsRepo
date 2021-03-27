using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Resume.Data
{
    public class DbContextFactory : IDesignTimeDbContextFactory<ResumeDb>
    {
        private IConfiguration Configuration => new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        public DbContextFactory()
        {

        }

        public ResumeDb CreateDbContext(string[] args)
        {
            string connectionString = this.Configuration.GetConnectionString("resume");
            var builder = new DbContextOptionsBuilder<ResumeDb>();
            builder.UseSqlServer(connectionString, ob => ob.MigrationsAssembly("Resume.Data"));

            return new ResumeDb(builder.Options);
        }
    }
}
