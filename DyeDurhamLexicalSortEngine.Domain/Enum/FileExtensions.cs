using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyeDurhamLexicalSortEngine.Domain.Enum
{
    public enum FileExtensions
    {
        [Description(".txt")]
        Text,
        [Description(".doc")]//open to expand for future 
        Doc,
    }
}
