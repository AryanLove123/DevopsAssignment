using Microsoft.EntityFrameworkCore;
using Shared;
using System;
using System.Collections.Generic;
using System.Text;


namespace DAL
{
    public class BookReadingContext : DbContext
    {
        public BookReadingContext(DbContextOptions<BookReadingContext> options) 
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Invitation> Invitations { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
