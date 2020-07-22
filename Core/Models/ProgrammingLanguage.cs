using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Core.Models
{
    public class ProgrammingLanguage
    {
        public ProgrammingLanguage()
        {
            Commands = new HashSet<Command>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Command> Commands { get; set; }
    }
}
