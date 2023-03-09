using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PurchasingDepartment.Models.ProcurementModel {
    public partial class ProcurementModel : DbContext {
        public ProcurementModel()
            : base("name=ProcurementModel") {
        }

        public virtual DbSet<Адрес> Адрес { get; set; }
        public virtual DbSet<Должность> Должность { get; set; }
        public virtual DbSet<ЕдиницаИзмерения> ЕдиницаИзмерения { get; set; }
        public virtual DbSet<Заказ> Заказ { get; set; }
        public virtual DbSet<ЗаказТовар> ЗаказТовар { get; set; }
        public virtual DbSet<Организация> Организация { get; set; }
        public virtual DbSet<Поставщик> Поставщик { get; set; }
        public virtual DbSet<Склад> Склад { get; set; }
        public virtual DbSet<Сотрудник> Сотрудник { get; set; }
        public virtual DbSet<Статус> Статус { get; set; }
        public virtual DbSet<Телефон> Телефон { get; set; }
        public virtual DbSet<Товар> Товар { get; set; }
        public virtual DbSet<УровеньДоступа> УровеньДоступа { get; set; }
        public virtual DbSet<ЭлектроннаяПочта> ЭлектроннаяПочта { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Адрес>()
                .HasMany(e => e.Поставщик)
                .WithRequired(e => e.Адрес)
                .HasForeignKey(e => e.КодАдреса)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Адрес>()
                .HasMany(e => e.Склад)
                .WithRequired(e => e.Адрес)
                .HasForeignKey(e => e.КодАдреса)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Должность>()
                .HasMany(e => e.Сотрудник)
                .WithRequired(e => e.Должность)
                .HasForeignKey(e => e.КодДолжности)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ЕдиницаИзмерения>()
                .HasMany(e => e.Товар)
                .WithRequired(e => e.ЕдиницаИзмерения)
                .HasForeignKey(e => e.КодЕденицыИзмерения)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Заказ>()
                .HasMany(e => e.ЗаказТовар)
                .WithRequired(e => e.Заказ)
                .HasForeignKey(e => e.КодЗаказа)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Организация>()
                .HasMany(e => e.Сотрудник)
                .WithRequired(e => e.Организация)
                .HasForeignKey(e => e.КодОрганизации)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Поставщик>()
                .HasMany(e => e.Заказ)
                .WithRequired(e => e.Поставщик)
                .HasForeignKey(e => e.КодПоставщика)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Склад>()
                .HasMany(e => e.Заказ)
                .WithRequired(e => e.Склад)
                .HasForeignKey(e => e.КодCклада)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Сотрудник>()
                .HasMany(e => e.Заказ)
                .WithRequired(e => e.Сотрудник)
                .HasForeignKey(e => e.КодСотрудника)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Статус>()
                .HasMany(e => e.Заказ)
                .WithRequired(e => e.Статус)
                .HasForeignKey(e => e.КодСтатуса)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Телефон>()
                .HasMany(e => e.Поставщик)
                .WithRequired(e => e.Телефон)
                .HasForeignKey(e => e.КодТелефона)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Телефон>()
                .HasMany(e => e.Склад)
                .WithRequired(e => e.Телефон)
                .HasForeignKey(e => e.КодТелефона)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Телефон>()
                .HasMany(e => e.Сотрудник)
                .WithRequired(e => e.Телефон)
                .HasForeignKey(e => e.КодТелефона)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Товар>()
                .Property(e => e.Цена)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Товар>()
                .HasMany(e => e.ЗаказТовар)
                .WithRequired(e => e.Товар)
                .HasForeignKey(e => e.КодТовара)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<УровеньДоступа>()
                .HasMany(e => e.Сотрудник)
                .WithRequired(e => e.УровеньДоступа)
                .HasForeignKey(e => e.КодУровняДоступа)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ЭлектроннаяПочта>()
                .HasMany(e => e.Поставщик)
                .WithOptional(e => e.ЭлектроннаяПочта)
                .HasForeignKey(e => e.КодЭлектроннойПочты);

            modelBuilder.Entity<ЭлектроннаяПочта>()
                .HasMany(e => e.Сотрудник)
                .WithOptional(e => e.ЭлектроннаяПочта)
                .HasForeignKey(e => e.КодЭлектроннойПочты);
        }
    }
}
