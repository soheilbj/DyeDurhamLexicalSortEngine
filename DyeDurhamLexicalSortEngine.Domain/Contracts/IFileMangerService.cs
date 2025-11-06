using DyeDurhamLexicalSortEngine.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyeDurhamLexicalSortEngine.Domain.Contracts
{
    public interface IFileMangerService
    {
        List<string> ReadeNameListFile(string FileName);
        void SaveSortedFile(List<Person> people);
    }
}
