﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArtelierAvenue.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ArtelierAvenueEntities : DbContext
    {
        public ArtelierAvenueEntities()
            : base("name=ArtelierAvenueEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Featured> Featureds { get; set; }
        public virtual DbSet<ListingPicture> ListingPictures { get; set; }
        public virtual DbSet<ListingStatu> ListingStatus { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<OrderReturn> OrderReturns { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductClassification> ProductClassifications { get; set; }
        public virtual DbSet<ProductColor> ProductColors { get; set; }
        public virtual DbSet<ProductListing> ProductListings { get; set; }
        public virtual DbSet<ProductMaterial> ProductMaterials { get; set; }
        public virtual DbSet<ProductOrder> ProductOrders { get; set; }
        public virtual DbSet<ProductOrderLine> ProductOrderLines { get; set; }
        public virtual DbSet<ProductOrderStatu> ProductOrderStatus { get; set; }
        public virtual DbSet<ProductPicture> ProductPictures { get; set; }
        public virtual DbSet<ProductSize> ProductSizes { get; set; }
        public virtual DbSet<ProductStatu> ProductStatus { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<ReturnLine> ReturnLines { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ServiceListing> ServiceListings { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VAT> VATs { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
    }
}
