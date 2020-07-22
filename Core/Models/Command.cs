using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Core.Models
{
    public class Command
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProgrammingLanguage ProgrammingLanguage { get; set; }
        public int ProgrammingLanguageId { get; set; }
    }
}
