using Commands.Core.Models;
using Commands.Persistance.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Persistance
{
    public class CommandsContext : DbContext
    {
        public CommandsContext() {}

        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        public DbSet<Command> Commands { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CommandConfig());
            modelBuilder.Configurations.Add(new ProgrammingLanguageConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
