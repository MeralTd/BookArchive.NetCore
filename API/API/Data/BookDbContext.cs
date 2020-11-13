using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions options)
           : base(options)
        { }
        public DbSet<Book> Books { get; set; }
    }
}
