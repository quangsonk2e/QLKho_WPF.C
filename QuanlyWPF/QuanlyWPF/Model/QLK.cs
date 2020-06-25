namespace QuanlyWPF.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLK : DbContext
    {
        public QLK()
            : base("name=QLKho")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Input> Inputs { get; set; }
        public virtual DbSet<InputInfo> InputInfoes { get; set; }
        public virtual DbSet<Object> Objects { get; set; }
        public virtual DbSet<Output> Outputs { get; set; }
        public virtual DbSet<OutputInfo> OutputInfoes { get; set; }
        public virtual DbSet<Suplier> Supliers { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.MoreInfo)
                .IsUnicode(false);

            modelBuilder.Entity<InputInfo>()
                .Property(e => e.InputPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InputInfo>()
                .Property(e => e.OutputPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Object>()
                .Property(e => e.QRCode)
                .IsUnicode(false);

            modelBuilder.Entity<Object>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<Suplier>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Suplier>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Suplier>()
                .Property(e => e.MoreInfo)
                .IsUnicode(false);

            modelBuilder.Entity<Unit>()
                .Property(e => e.DisplayName)
                .IsFixedLength();
        }
    }
}
