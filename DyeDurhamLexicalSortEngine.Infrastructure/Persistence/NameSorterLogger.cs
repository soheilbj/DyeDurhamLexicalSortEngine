using DyeDurhamLexicalSortEngine.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyeDurhamLexicalSortEngine.Infrastructure.Persistence
{
    public static class NameSorterLogger
    {

        private static string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");

        private static  string fileName = $"NameSorter_log_{timestamp}.txt";

        private static string logDirectory = AppDomain.CurrentDomain.BaseDirectory; 
        private static string filePath = Path.Combine(logDirectory, fileName);
        public static void LogError(string message)
        {
            Log("server error", message);
        }
        public static void LogInfo(string message)
        {
            Log("info", message);
        }
        public static void LogException(Exception ex)
        {
            string message = $"message: {ex.Message}\nStackTrace: {ex.StackTrace}";
            Log("exception log", message);
        }
     

        private static void Log(string logType, string message)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{logType}] {message}";
            Console.WriteLine(logEntry);

            try
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine(logEntry);
                    
                }
                
            }
            catch (Exception ex)
            {
                //mus implement handler in future
            }
        }
    }
}
