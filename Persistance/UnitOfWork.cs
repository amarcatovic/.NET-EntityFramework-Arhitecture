using Commands.Core;
using Commands.Core.Repositories;
using Commands.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CommandsContext _context;
        public UnitOfWork(CommandsContext context)
        {
            _context = context;
            Commands = new CommandRepository(context);
            ProgrammingLanguages = new ProgrammingLanguageRepository(context);
        }

        public ICommandRepository Commands { get; private set; }

        public IProgrammingLanguageRepository ProgrammingLanguages { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
