using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bookstore_API.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Author> Authors;
        
        public DbSet<Book> Books;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
