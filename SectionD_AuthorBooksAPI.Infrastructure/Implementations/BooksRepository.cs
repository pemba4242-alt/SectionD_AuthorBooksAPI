using SectionD_AuthorBooksAPI.Domain.Entities;
using SectionD_AuthorBooksAPI.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SectionD_AuthorBooksAPI.Infrastructure.Implementations
{
    public class BooksRepository : IBooksRepository
    {
        public async Task<List<Book>> GetAllAsync()
        {

        }
    }
}
