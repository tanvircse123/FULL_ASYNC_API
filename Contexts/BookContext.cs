using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FULL_ASYNC_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace FULL_ASYNC_API.Contexts
{
    public class BookContext:DbContext
    {
        public BookContext(DbContextOptions<BookContext> options):base(options)
        {
        }
        public DbSet<Book> Books {get;set;}
        public DbSet<Author>Authors {get;set;} 

    }
}