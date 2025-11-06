using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyeDurhamLexicalSortEngine.Domain.Dtos
{
    public class SortedPersonDto
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public required string FullName { get; set; }
    }
}
