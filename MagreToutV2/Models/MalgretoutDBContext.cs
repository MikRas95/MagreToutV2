﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MalgreToutV2.Models
{
    public partial class MalgretoutDBContext : DbContext
    {
        public MalgretoutDBContext()
        {
        }

        public MalgretoutDBContext(DbContextOptions<MalgretoutDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DemoAd> DemoAds { get; set; }
        public virtual DbSet<DemoContactPerson> DemoContactPeople { get; set; }
        public virtual DbSet<DemoEmployee> DemoEmployees { get; set; }
        public virtual DbSet<DemoMagazine> DemoMagazines { get; set; }
        public virtual DbSet<DemoPickupPoint> DemoPickupPoints { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.

                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NewMalgreToutDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DemoAd>(entity =>
            {
                entity.HasKey(e => e.AdId)
                    .HasName("PK__DemoAd__7130D5AE9E246393");

                entity.Property(e => e.Company).IsUnicode(false);

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.DemoAds)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DemoAd__VersionI__619B8048");
            });

            modelBuilder.Entity<DemoContactPerson>(entity =>
            {
                entity.HasKey(e => e.ContactPersonId)
                    .HasName("PK__DemoCont__97C702BE5E152840");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);
                
                //entity.HasOne(d => d.PickupPoint)
                //    .WithMany(p => p.ContactPerson)
                //    .HasForeignKey(d => d.PickupPointId)
                //    .HasConstraintName("FK__DemoConta__Picku__06CD04F7");
            });

            modelBuilder.Entity<DemoEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__DemoEmpl__7AD04F11A2587C54");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.Role).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<DemoMagazine>(entity =>
            {
                entity.HasKey(e => e.VersionId)
                    .HasName("PK__DemoMaga__16C6400F7AF2A123");

                entity.Property(e => e.Version).IsUnicode(false);
            });

            modelBuilder.Entity<DemoPickupPoint>(entity =>
            {
                entity.HasKey(e => e.PickupPointId)
                    .HasName("PK__DemoPick__195D7EA028B2385C");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);

                entity.Property(e => e.PostalCode).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}