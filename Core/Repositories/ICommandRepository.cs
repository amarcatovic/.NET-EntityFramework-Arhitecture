using Commands.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Core.Repositories
{
    public interface ICommandRepository : IRepository<Command>
    {
        Command FindByName(string name);
    }
}
