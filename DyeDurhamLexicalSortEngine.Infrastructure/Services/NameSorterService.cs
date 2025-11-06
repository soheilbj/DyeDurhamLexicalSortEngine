using DyeDurhamLexicalSortEngine.Domain.Contracts;
using DyeDurhamLexicalSortEngine.Domain.Entities;
using DyeDurhamLexicalSortEngine.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyeDurhamLexicalSortEngine.Infrastructure.Services
{
    public class NameSorterService : INameSorterService
    {
        private readonly IFileMangerService _fileService;

        public NameSorterService(IFileMangerService fileService)
        {
            _fileService = fileService;
        }

        #region private

        private List<Person> ParseNameList(List<string> DataList)
        {
            var allpersonData = new List<Person>();
            if (DataList.Any())
            {
                foreach (var item in DataList)
                {
                    //if (item != string.Empty)
                   // try
                    {
                        var parts = item.Split(' ');
                        var people = new Person();

                        switch (parts.Length)
                        {
                            case 2:
                                people.FirstName = parts[0];
                                people.LastName = parts[1];
                                break;
                            case 3:
                                people.FirstName = parts[0];
                                people.MiddleName = parts[1];
                                people.LastName = parts[2];
                                break;
                            case 4:
                                people.FirstName = parts[0];
                                people.MiddleName = parts[1];
                                people.SecondMiddleName = parts[2];
                                people.LastName = parts[3];
                                break;
                            case > 4:
                                throw new InvalidNumberNameParameterException();

                        }
                        allpersonData.Add(people);
                    }                    
                  //  catch(InvalidNumberNameParameterException ex)
                    {
                        // implmenet based on requirement 
                        //check empty lines and log 
                        //throw new InvalidNumberNameParameterException();
                    }
                }
                return allpersonData.OrderBy(x => x.LastName).ToList();
            }
            else  // return nothing or throw exception and log here 
            { return new List<Person>(); }
        }
        private List<Person> ParseAndSortNameList(string FileName)
        {
            var alldata = _fileService.ReadeNameListFile(FileName);
            return ParseNameList(alldata);
        }

        #endregion

        public void DisplayAndSaveSortedFile(string FileName)
        {
            var data = ParseAndSortNameList(FileName);
            _fileService.SaveSortedFile(data);
        }
        public void DisplayAndSaveSortedFile(List<string> allpersonData)
        {
            var data = ParseNameList(allpersonData);
            _fileService.SaveSortedFile(data);
        }
    }
}
