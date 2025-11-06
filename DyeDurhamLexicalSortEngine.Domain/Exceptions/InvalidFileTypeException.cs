using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyeDurhamLexicalSortEngine.Domain.Exceptions
{
    public class InvalidFileTypeException : Exception
    {
        public InvalidFileTypeException(string filename): base($"file with name: {filename} should be txt") { }

     
    }
}
