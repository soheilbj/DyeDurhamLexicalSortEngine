using DyeDurhamLexicalSortEngine.Domain.Contracts;
using DyeDurhamLexicalSortEngine.Domain.Entities;
using DyeDurhamLexicalSortEngine.Domain.Exceptions;
using DyeDurhamLexicalSortEngine.Infrastructure.Services;

namespace Infrastructure.Test
{
    public class NameSorterServiceFixture
    {
        public INameSorterService Service { get; }

        public NameSorterServiceFixture()
        {
            Service = new NameSorterService(new FileMangerService());
        }
    }
    public class NameSorterServiceTest : IClassFixture<NameSorterServiceFixture>
    {
        private readonly INameSorterService _service;

        public NameSorterServiceTest(NameSorterServiceFixture servicefixture)
        {
            _service = servicefixture.Service;
        }

        [Fact]
        public void SortBy_LastName()
        {
            var people = new List<string> { "Janet Parsons"
                                            ,"Vaughn Lewis"
                                            ,"Adonis Julius Archer"
                                            ,"Shelby Nathan Yoder"
                                            ,"Marin Alvarez"
                                            ,"London Lindsey"
                                            ,"Beau Tristan Bentley"
                                            ,"Leo Gardner"
                                            ,"Hunter Uriah Mathew Clarke"
                                            ,"Mikayla Lopez"
                                            ,"Frankie Conner Ritter"};

            _service.DisplayAndSaveSortedFile(people);
        }


        [Fact]
        public void SortBy_InvalidParameter_ShouldThrowException()
        {
            // Arrange
            var people = new List<string> { "Janet Parsons"
                                            ,"Vaughn Lewis"
                                            ,"Adonis Adonis Adonis Adonis Adonis Adonis Julius Archer"
                                            ,"Shelby Nathan Yoder"
                                            ,"Marin Alvarez"
                                            ,"London Lindsey"
                                            ,"Beau Tristan Bentley"
                                            ,"Leo Gardner"
                                            ,"Hunter Uriah Mathew Clarke"
                                            ,"Mikayla Lopez"
                                            ,"Frankie Conner Ritter"};
            // Act & Assert
            Assert.Throws<InvalidNumberNameParameterException>(() => _service.DisplayAndSaveSortedFile(people));
        }

        [Fact]
        public void SortBy_EmptyList_ShouldReturnEmptyList()
        {
            // Arrange
            var people = new List<string>();
            // Act
             _service.DisplayAndSaveSortedFile(people);
        }
    }
}
