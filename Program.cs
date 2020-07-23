using Commands.Core.Models;
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
                var commands = unitOfWork.Commands.GetAll();
                
                foreach(var command in commands)
                {
                    Console.WriteLine($"Command: {command.Name} - Language: {command.ProgrammingLanguage.Name}");
                }
               
                Console.ReadLine();
            }
        }
    }
}
