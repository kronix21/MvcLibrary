﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcLibrary.Models;

namespace MvcLibrary.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MvcLibrary.Models.Book> Book { get; set; } = default!;
        public DbSet<MvcLibrary.Models.Avtor> Avtor { get; set; } = default!;
        public DbSet<MvcLibrary.Models.Present> Present { get; set; } = default!;
    }
}
