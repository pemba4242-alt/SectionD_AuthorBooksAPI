using Microsoft.EntityFrameworkCore;
using SectionD_AuthorBooksAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SectionD_AuthorBooksAPI.Infrastructure
{
    public class AuthorBooksAPIDbContext : DbContext
    {
        public AuthorBooksAPIDbContext(DbContextOptions<AuthorBooksAPIDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasMany(b => b.Authors)
                .WithMany(a => a.Books)
                .UsingEntity<Dictionary<string, object>>(
                    "AuthorBook",
                    j => j.HasOne<Author>().WithMany().HasForeignKey("AuthorId"),
                    j => j.HasOne<Book>().WithMany().HasForeignKey("BookId")
                );
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
