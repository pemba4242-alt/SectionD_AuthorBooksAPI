using SectionD_AuthorBooksAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SectionD_AuthorBooksAPI.Domain.Entities
{
    public class Author : BaseEntity
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public List<Book> Books { get; set; } = new();
    }
}
