using DyeDurhamLexicalSortEngine.Domain.Contracts;
using DyeDurhamLexicalSortEngine.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

class Program
{
    static void Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddSingleton<IFileMangerService, FileMangerService>();
                services.AddSingleton<INameSorterService, NameSorterService>();
            })
            .Build();

        var nameSorterService = host.Services.GetRequiredService<INameSorterService>();

        // Use service
        nameSorterService.DisplayAndSaveSortedFile("unsorted-names-list.txt");
    }

}