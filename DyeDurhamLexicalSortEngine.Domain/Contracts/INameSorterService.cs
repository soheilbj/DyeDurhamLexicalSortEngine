using DyeDurhamLexicalSortEngine.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyeDurhamLexicalSortEngine.Domain.Contracts
{
    public interface INameSorterService
    {
        void DisplayAndSaveSortedFile(string FileName);
        void DisplayAndSaveSortedFile(List<string> allpersonData);
    }
}
