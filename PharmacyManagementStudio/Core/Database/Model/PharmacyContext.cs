using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PharmacyManagementStudio.Core.Database.Model
{
    public partial class PharmacyContext : DbContext
    {
        public PharmacyContext()
            : base("name=PharmacyContext")
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Medicine> Medicine { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Saler> Saler { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Gmail)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Medicine>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Medicine>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Medicine>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Medicine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Saler>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Saler>()
                .Property(e => e.Gmail)
                .IsUnicode(false);

            modelBuilder.Entity<Saler>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Saler>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Saler)
                .WillCascadeOnDelete(false);
        }
    }
}
