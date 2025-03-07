﻿using Microsoft.EntityFrameworkCore;

namespace WebAppFormMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        public DbSet<ContactMessage> ContactMessages { get; set; }

        public DbSet<Contacto> Contactos { get; set; }
    }
}
