using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyeDurhamLexicalSortEngine.Domain.Exceptions
{
    public class InvalidNumberNameParameterException : Exception
    {
        public InvalidNumberNameParameterException(): base($"maximum Number of names should be 3 for these parameters") { }

     
    }
}
