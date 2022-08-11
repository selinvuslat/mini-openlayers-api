using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using EFCoreTutorial.Data.Models;

namespace EFCoreTutorial.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }


        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // make the configurations
                optionsBuilder.UseNpgsql("Server=localHost; Port=5432; Database=Dbstaj;  User Id=postgres; Password=1016");
            }

            base.OnConfiguring(optionsBuilder);
        }*/


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.HasDefaultSchema("dbo");

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("location");
                entity.Property(i => i.Id).HasColumnName("id").HasColumnType("int").UseIdentityColumn().IsRequired();
                entity.Property(i => i.Name).HasColumnName("name").HasColumnType("nvarchar").HasMaxLength(100);
                entity.Property(i => i.X).HasColumnName("x").HasColumnType("int");
                entity.Property(i => i.Y).HasColumnName("y").HasColumnType("int");
            });

            base.OnModelCreating(modelBuilder);*/
            modelBuilder.UseSerialColumns();
        }

        public DbSet<LocationView> Locations { get; set; }

    }
}
