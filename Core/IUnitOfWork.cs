using Commands.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICommandRepository Commands { get; }
        IProgrammingLanguageRepository ProgrammingLanguages { get; }

        int Complete();
    }
}
