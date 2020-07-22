using Commands.Core.Models;
using Commands.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Persistance.Repositories
{
    public class ProgrammingLanguageRepository : Repository<ProgrammingLanguage>, IProgrammingLanguageRepository
    {
        public ProgrammingLanguageRepository(CommandsContext context) : base(context)
        {

        }
    }
}
