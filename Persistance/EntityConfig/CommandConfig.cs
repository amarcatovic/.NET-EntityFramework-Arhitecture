using Commands.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Persistance.EntityConfig
{
    class CommandConfig : EntityTypeConfiguration<Command>
    {
        public CommandConfig()
        {
            ToTable("Commands");

            HasKey(c => c.Id);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Description)
                .IsRequired()
                .IsMaxLength();

            HasRequired(c => c.ProgrammingLanguage)
                .WithMany(pl => pl.Commands)
                .HasForeignKey(c => c.ProgrammingLanguageId)
                .WillCascadeOnDelete(false);
        }
    }
}
