﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class fsEntities : DbContext
    {
        public fsEntities()
            : base("name=fsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<OrderType> OrderType { get; set; }
        public virtual DbSet<ProductDetail> ProductDetail { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Town> Town { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserGroup> UserGroup { get; set; }
        public virtual DbSet<Variant> Variant { get; set; }
        public virtual DbSet<VariantGroup> VariantGroup { get; set; }
        public virtual DbSet<VariantProperty> VariantProperty { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<ProductImage> ProductImage { get; set; }
        public virtual DbSet<VwCustomer> VwCustomer { get; set; }
        public virtual DbSet<Prefix> Prefix { get; set; }
        public virtual DbSet<PriceListGroup> PriceListGroup { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<CustomerDetail> CustomerDetail { get; set; }
        public virtual DbSet<CustomerDetailType> CustomerDetailType { get; set; }
        public virtual DbSet<VwCustomerDetail> VwCustomerDetail { get; set; }
        public virtual DbSet<VwSupplier> VwSupplier { get; set; }
        public virtual DbSet<SupplierDetail> SupplierDetail { get; set; }
        public virtual DbSet<VwSupplierDetail> VwSupplierDetail { get; set; }
        public virtual DbSet<VwProduct> VwProduct { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductVariant> ProductVariant { get; set; }
        public virtual DbSet<ProductVariantWithGroupName> ProductVariantWithGroupName { get; set; }
        public virtual DbSet<ProductPriceList> ProductPriceList { get; set; }
        public virtual DbSet<VwProductPriceList> VwProductPriceList { get; set; }
        public virtual DbSet<VwProductDetails> VwProductDetails { get; set; }
        public virtual DbSet<VwOrder> VwOrder { get; set; }
        public virtual DbSet<VwOrderDetails> VwOrderDetails { get; set; }
        public virtual DbSet<VwProductStockInWarehouse> VwProductStockInWarehouse { get; set; }
    
        public virtual ObjectResult<string> GetPrefix(string prefixCode)
        {
            var prefixCodeParameter = prefixCode != null ?
                new ObjectParameter("prefixCode", prefixCode) :
                new ObjectParameter("prefixCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetPrefix", prefixCodeParameter);
        }
    }
}
