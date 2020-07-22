using Commands.Core.Models;
using Commands.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace Commands.Persistance.Repositories
{
    public class CommandRepository : Repository<Command>, ICommandRepository
    {
        public CommandRepository(CommandsContext context) : base(context)
        {
        }

        public Command FindByName(string name)
        {
            return _context.Set<Command>().Single(c => c.Name == name);
        }
    }
}
