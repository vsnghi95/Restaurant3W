﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BussinessObject2
{
    public partial class restaurant2Context : DbContext
    {
        public restaurant2Context()
        {
        }

        public restaurant2Context(DbContextOptions<restaurant2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DepositCate> DepositCates { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodCategory> FoodCategories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<ReserveDetail> ReserveDetails { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<TablesRe> TablesRes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);Database=restaurant2; Uid=sa; Pwd=12345");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Vietnamese_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Aid)
                    .HasName("PK__Account__DE508E2E05AA0C4E");

                entity.ToTable("Account");

                entity.Property(e => e.Aid).HasColumnName("aid");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.Role)
                    .HasConstraintName("FK__Account__role__38996AB5");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__Customer__D837D05FEFFD94EA");

                entity.ToTable("Customer");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("customer_name");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<DepositCate>(entity =>
            {
                entity.HasKey(e => e.DepositId)
                    .HasName("PK__DepositC__AB60DF71DCECBB73");

                entity.ToTable("DepositCate");

                entity.Property(e => e.DepositName).HasMaxLength(50);
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.HasKey(e => e.Fid)
                    .HasName("PK__Food__D9908D64148D7351");

                entity.ToTable("Food");

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.Cateid).HasColumnName("cateid");

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("fname");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("price");

                entity.HasOne(d => d.Cate)
                    .WithMany(p => p.Foods)
                    .HasForeignKey(d => d.Cateid)
                    .HasConstraintName("FK__Food__cateid__4E88ABD4");
            });

            modelBuilder.Entity<FoodCategory>(entity =>
            {
                entity.HasKey(e => e.Cateid)
                    .HasName("PK__FoodCate__A88C49CCFB35A4BD");

                entity.ToTable("FoodCategory");

                entity.Property(e => e.Cateid).HasColumnName("cateid");

                entity.Property(e => e.Catename)
                    .HasMaxLength(50)
                    .HasColumnName("catename");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK__Orders__C2FFCF13C161A56D");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.NumGuest).HasColumnName("num_guest");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("order_date");

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.RidNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Rid)
                    .HasConstraintName("FK__Orders__rid__49C3F6B7");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.Odid)
                    .HasName("PK__OrderDet__8D153E09EDA855A5");

                entity.ToTable("OrderDetail");

                entity.Property(e => e.Odid).HasColumnName("odid");

                entity.Property(e => e.AmountOfFood)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("amountOfFood");

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.FidNavigation)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.Fid)
                    .HasConstraintName("FK__OrderDetail__fid__52593CB8");

                entity.HasOne(d => d.OidNavigation)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.Oid)
                    .HasConstraintName("FK__OrderDetail__oid__5165187F");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Reservat__C2B7EDE8EE041DD3");

                entity.ToTable("Reservation");

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Aid).HasColumnName("aid");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.DepositType).HasColumnName("depositType");

                entity.Property(e => e.DepositValue)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("depositValue");

                entity.Property(e => e.NumGuest).HasColumnName("num_guest");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.ResDate)
                    .HasColumnType("datetime")
                    .HasColumnName("res_date");

                entity.HasOne(d => d.AidNavigation)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.Aid)
                    .HasConstraintName("FK__Reservation__aid__4316F928");

                entity.HasOne(d => d.CidNavigation)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.Cid)
                    .HasConstraintName("FK__Reservation__cid__4222D4EF");

                entity.HasOne(d => d.DepositTypeNavigation)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.DepositType)
                    .HasConstraintName("FK__Reservati__depos__412EB0B6");
            });

            modelBuilder.Entity<ReserveDetail>(entity =>
            {
                entity.HasKey(e => e.Rdid)
                    .HasName("PK__ReserveD__C5675820BAFF210E");

                entity.ToTable("ReserveDetail");

                entity.Property(e => e.Rdid).HasColumnName("rdid");

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Tid).HasColumnName("tid");

                entity.HasOne(d => d.RidNavigation)
                    .WithMany(p => p.ReserveDetails)
                    .HasForeignKey(d => d.Rid)
                    .HasConstraintName("FK__ReserveDeta__rid__45F365D3");

                entity.HasOne(d => d.TidNavigation)
                    .WithMany(p => p.ReserveDetails)
                    .HasForeignKey(d => d.Tid)
                    .HasConstraintName("FK__ReserveDeta__tid__46E78A0C");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Roleid).HasColumnName("roleid");

                entity.Property(e => e.Rolename)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("rolename");
            });

            modelBuilder.Entity<TablesRe>(entity =>
            {
                entity.HasKey(e => e.Tid)
                    .HasName("PK__TablesRe__DC105B0FB90BF6A4");

                entity.Property(e => e.Tid)
                    .ValueGeneratedNever()
                    .HasColumnName("tid");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("table_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}