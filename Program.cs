using Commands.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new CommandsContext()))
            {
                var course = unitOfWork.Commands.Get(1);
                unitOfWork.Complete();
            }
        }
    }
}
