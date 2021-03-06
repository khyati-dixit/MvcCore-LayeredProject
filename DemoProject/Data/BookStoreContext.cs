﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Data
{
    
        public class BookStoreContext : IdentityDbContext
        {
            public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
            {

            }
            public DbSet<Books> Books { get; set; }
            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);
            }
        }
    
}
