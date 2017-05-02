namespace CarServiceData
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using CarServiceData.Models;
    using System.Reflection;
    using System.IO;
    public partial class DBModel : DbContext
    {
        
        public DBModel(string connString)
            : base("name=DBModel")
        {
        }

        public virtual DbSet<car> Car { get; set; }
        public virtual DbSet<client> Ñlient { get; set; }
        public virtual DbSet<order> Order { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<car>()
                .Property(e => e.Mark)
                .IsUnicode(false);

            modelBuilder.Entity<car>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<car>()
                .Property(e => e.Transmission)
                .IsUnicode(false);

            modelBuilder.Entity<car>()
                .HasMany(e => e.order)
                .WithRequired(e => e.car)
                .HasForeignKey(e => e.CarId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<client>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.SecondName)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.ThirdName)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .HasMany(e => e.car)
                .WithRequired(e => e.client)
                .HasForeignKey(e => e.ClientId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<order>()
                .Property(e => e.Title)
                .IsUnicode(false);
        }
    }
}
