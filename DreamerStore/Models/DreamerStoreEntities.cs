using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DreamerStore.Models
{
    public partial class DreamerStoreEntities : DbContext
    {
        public DreamerStoreEntities()
            : base("name=SUV")
        {
        }

        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillProduct> BillProducts { get; set; }
        public virtual DbSet<BillStt> BillStts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<DetailedProduct> DetailedProducts { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<DiscountUse> DiscountUses { get; set; }
        public virtual DbSet<Footer> Footers { get; set; }
        public virtual DbSet<Logo> Logoes { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<TermOfPayment> TermOfPayments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banner>()
                .Property(e => e.Meta)
                .IsUnicode(false);

            modelBuilder.Entity<Banner>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.Meta)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .HasMany(e => e.BillProducts)
                .WithRequired(e => e.Bill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bill>()
                .HasMany(e => e.DiscountUses)
                .WithRequired(e => e.Bill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BillProduct>()
                .Property(e => e.Meta)
                .IsUnicode(false);

            modelBuilder.Entity<BillStt>()
                .Property(e => e.Meta)
                .IsUnicode(false);

            modelBuilder.Entity<BillStt>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.BillStt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Meta)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DetailedProduct>()
                .Property(e => e.DetailedProductName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DetailedProduct>()
                .Property(e => e.Meta)
                .IsUnicode(false);

            modelBuilder.Entity<DetailedProduct>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<DetailedProduct>()
                .HasMany(e => e.BillProducts)
                .WithRequired(e => e.DetailedProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Discount>()
                .Property(e => e.Meta)
                .IsUnicode(false);

            modelBuilder.Entity<Discount>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Discount>()
                .HasMany(e => e.DiscountUses)
                .WithRequired(e => e.Discount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiscountUse>()
                .Property(e => e.Meta)
                .IsUnicode(false);

            modelBuilder.Entity<Footer>()
                .Property(e => e.Meta)
                .IsUnicode(false);

            modelBuilder.Entity<Footer>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Logo>()
                .Property(e => e.Meta)
                .IsUnicode(false);

            modelBuilder.Entity<Logo>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Meta)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Meta)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.DetailedProducts)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductImages)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductImage>()
                .Property(e => e.ProductImageLink)
                .IsUnicode(false);

            modelBuilder.Entity<TermOfPayment>()
                .Property(e => e.Meta)
                .IsUnicode(false);

            modelBuilder.Entity<TermOfPayment>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<TermOfPayment>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.TermOfPayment)
                .HasForeignKey(e => e.BillTermOfPayment)
                .WillCascadeOnDelete(false);
        }
    }
}
