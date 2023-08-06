using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace New_Clother_Model.Models
{
    public partial class NewClotherContext : DbContext
    {
        public NewClotherContext()
        {
        }

        public NewClotherContext(DbContextOptions<NewClotherContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DmColor> DmColors { get; set; } = null!;
        public virtual DbSet<DmItem> DmItems { get; set; } = null!;
        public virtual DbSet<DmItemType> DmItemTypes { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductAttribute> ProductAttributes { get; set; } = null!;
        public virtual DbSet<UserLogin> UserLogins { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=34.92.234.249;Initial Catalog=NewClother;User ID=sas;Password=Hungyk0707@");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DmColor>(entity =>
            {
                entity.HasKey(e => e.ColorId);

                entity.ToTable("DM_COLOR");

                entity.Property(e => e.ColorId)
                    .HasMaxLength(20)
                    .HasColumnName("COLOR_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.ColorName)
                    .HasMaxLength(100)
                    .HasColumnName("COLOR_NAME");
            });

            modelBuilder.Entity<DmItem>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("DM_ITEM");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(20)
                    .HasColumnName("ITEM_ID");

                entity.Property(e => e.Acrive).HasColumnName("ACRIVE");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .HasColumnName("ITEM_NAME");

                entity.Property(e => e.ItemTypeId)
                    .HasMaxLength(20)
                    .HasColumnName("ITEM_TYPE_ID");
            });

            modelBuilder.Entity<DmItemType>(entity =>
            {
                entity.HasKey(e => e.ItemTypeId);

                entity.ToTable("DM_ITEM_TYPE");

                entity.Property(e => e.ItemTypeId)
                    .HasMaxLength(50)
                    .HasColumnName("ITEM_TYPE_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.ItemTypeName)
                    .HasMaxLength(200)
                    .HasColumnName("ITEM_TYPE_NAME");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.PrKey);

                entity.ToTable("PRODUCT");

                entity.Property(e => e.PrKey)
                    .HasMaxLength(20)
                    .HasColumnName("PR_KEY");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DATE_CREATE");

                entity.Property(e => e.DateModify)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DATE_MODIFY");

                entity.Property(e => e.Image)
                    .HasMaxLength(500)
                    .HasColumnName("IMAGE");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(200)
                    .HasColumnName("PRODUCT_NAME");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<ProductAttribute>(entity =>
            {
                entity.HasKey(e => e.PrKey);

                entity.ToTable("PRODUCT_ATTRIBUTE");

                entity.Property(e => e.PrKey)
                    .ValueGeneratedNever()
                    .HasColumnName("PR_KEY");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.AttributeName)
                    .HasMaxLength(100)
                    .HasColumnName("ATTRIBUTE_NAME");

                entity.Property(e => e.ColorId)
                    .HasMaxLength(20)
                    .HasColumnName("COLOR_ID");

                entity.Property(e => e.FrKey)
                    .HasMaxLength(20)
                    .HasColumnName("FR_KEY");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(20)
                    .HasColumnName("ITEM_ID");

                entity.Property(e => e.PriceProduct)
                    .HasColumnType("money")
                    .HasColumnName("PRICE_PRODUCT");

                entity.Property(e => e.PriceSale)
                    .HasColumnType("money")
                    .HasColumnName("PRICE_SALE");

                entity.Property(e => e.Size)
                    .HasMaxLength(20)
                    .HasColumnName("SIZE");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("USER_LOGIN");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .HasColumnName("USER_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.ChangepassDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CHANGEPASS_DATE");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(20)
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.FirstLogin).HasColumnName("FIRST_LOGIN");

                entity.Property(e => e.OrganizationId)
                    .HasMaxLength(20)
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.UserGroupId)
                    .HasMaxLength(20)
                    .HasColumnName("USER_GROUP_ID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .HasColumnName("USER_NAME");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(50)
                    .HasColumnName("USER_PASSWORD");

                entity.Property(e => e.UserType)
                    .HasMaxLength(20)
                    .HasColumnName("USER_TYPE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
