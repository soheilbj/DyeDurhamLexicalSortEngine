using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyeDurhamLexicalSortEngine.Domain.Entities
{
    //data annotation can be applied based on project requirements
    public class Person: BaseEntity
    {
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? SecondMiddleName { get; set; }
        public string? LastName { get; set; }
    }
}
