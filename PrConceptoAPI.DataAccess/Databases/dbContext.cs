using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PrConceptoAPI.Domain.Entities;

namespace PrConceptoAPI.DataAccess.Databases
{
    public partial class dbContext : DbContext
    {
        private readonly string ConectionString;
        public dbContext()
        {
            ConectionString = Environment.GetEnvironmentVariable("DBConnection");
        }

        public dbContext(DbContextOptions<dbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<UserInfoModel> InfoUser { get; set; }  
        public virtual DbSet<PrConcepto> PrConceptos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PrConcepto>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__PrConcep__B7C9263893A37DDF");

                entity.ToTable("PrConcepto");

                entity.Property(e => e.NameUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PwdUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserInfoModel>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("PrConcepto");
                entity.Property(e => e.UserName)
                .HasMaxLength(30)
                 .IsUnicode(false);

                entity.Property(e => e.PwdUser)
                .HasMaxLength(30)
                 .IsUnicode(false);
            }); 

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
