using Commands.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Persistance.EntityConfig
{
    class ProgrammingLanguageConfig : EntityTypeConfiguration<ProgrammingLanguage>
    {
        public ProgrammingLanguageConfig()
        {
            ToTable("ProgrammingLanguages");

            HasKey(pl => pl.Id);

            Property(pl => pl.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
