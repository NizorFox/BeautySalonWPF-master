﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeautySalonWPF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BeautyDatebaseEntities : DbContext
    {
        public BeautyDatebaseEntities()
            : base("name=BeautyDatebaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientServices> ClientServices { get; set; }
        public virtual DbSet<DocumentByService> DocumentByService { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductPhoto> ProductPhoto { get; set; }
        public virtual DbSet<ProductSale> ProductSale { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<ServiceCategoryes> ServiceCategoryes { get; set; }
        public virtual DbSet<ServicePhotos> ServicePhotos { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}