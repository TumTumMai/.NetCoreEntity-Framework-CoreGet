using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DBContexts
{
    public class MyDBContext : DbContext
    {
        public DbSet<TESTS> TEST { get; set; }


        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map entities to tables  
            modelBuilder.Entity<TESTS>().ToTable("TEST");

            // Configure Primary Keys  
            modelBuilder.Entity<TESTS>().HasKey(u => u.id).HasName("PK_TEST");


            // Configure columns  
            modelBuilder.Entity<TESTS>().Property(u => u.id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<TESTS>().Property(u => u.date).HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<TESTS>().Property(u => u.stus).HasColumnType("boolean").IsRequired();
            modelBuilder.Entity<TESTS>().Property(u => u.Des).HasColumnType("varchar(250)").IsRequired();

         

        }

    }
}
