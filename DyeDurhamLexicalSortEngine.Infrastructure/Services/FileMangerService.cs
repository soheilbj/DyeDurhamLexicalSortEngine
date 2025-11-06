using DyeDurhamLexicalSortEngine.Domain.Contracts;
using DyeDurhamLexicalSortEngine.Domain.Entities;
using DyeDurhamLexicalSortEngine.Domain.Exceptions;
using DyeDurhamLexicalSortEngine.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Data;

namespace DyeDurhamLexicalSortEngine.Infrastructure.Services
{
    public class FileMangerService : IFileMangerService
    {
        #region Privates
        //method can be expanded to check file header,checksum and viruses
        //here is limited to use txt file 
        private bool IsFileValidated(string FilePath)
        {
            string extension = Path.GetExtension(FilePath);

            if (string.IsNullOrWhiteSpace(extension) || (extension != ".txt" && extension != ".text"))
            {
                return false;
            }
            return true;
        }
        #endregion
        public List<string> ReadeNameListFile(string FileName)
        {
            List<string> linesList = new List<string>();
            try
            {
                string FilePath = Path.Combine(AppContext.BaseDirectory, FileName);

                if (!File.Exists(FilePath))
                {
                    Console.WriteLine($"File not found: {FilePath}");
                }

                if (IsFileValidated(FileName) == false)
                {
                    throw new InvalidFileTypeException(FileName);
                }
                else
                {
                    string[] fileContent = File.ReadAllLines(FilePath);
                    linesList = new List<string>(fileContent);
                }
            }
            catch (InvalidFileTypeException ex)
            {
                NameSorterLogger.LogException(ex);
            }
            return linesList;
        }

        public void SaveSortedFile(List<Person> people)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sorted-names-list.txt");
            using (StreamWriter sw = File.CreateText(filePath))
            {
                foreach (var item in people)
                {
                    string dataToWrite = ($"{item.FirstName} {item.MiddleName} {item.SecondMiddleName} {item.LastName}");
                    Console.WriteLine(dataToWrite);
                    try
                    {
                        sw.WriteLine(dataToWrite);
                    }
                    catch (Exception ex)
                    {
                        //mus implement handler in future
                    }
                }
            }
        }
    }
}
