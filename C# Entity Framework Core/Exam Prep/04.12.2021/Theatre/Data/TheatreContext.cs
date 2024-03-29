﻿
namespace Theatre.Data
{
    using Models;
    using Microsoft.EntityFrameworkCore;

    public class TheatreContext : DbContext
    {
        public TheatreContext() { }

        public TheatreContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Play> Plays { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Theatre> Theatres  { get; set; }
        public DbSet<Cast> Casts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
