using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DAL
{
    class SystemContext : DbContext
    {
        public SystemContext() : base("SystemContext")
        {

        }
        public DbSet<UserDB> Users { get; set; }
        public DbSet<TaskDB> Tasks { get; set; }
        public DbSet<QuestionDB> Questions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
