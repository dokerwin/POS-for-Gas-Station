//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gas_station
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Gas_stationDb : DbContext
    {
        public Gas_stationDb()
            : base("name=Gas_stationDb")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Advertising> Advertisings { get; set; }
        public virtual DbSet<Cashier> Cashiers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CatPromotion> CatPromotions { get; set; }
        public virtual DbSet<Cistern> Cisterns { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Developer> Developers { get; set; }
        public virtual DbSet<Distributor> Distributors { get; set; }
        public virtual DbSet<Forecourt> Forecourts { get; set; }
        public virtual DbSet<FuelDelivery> FuelDeliveries { get; set; }
        public virtual DbSet<Lgn> Lgns { get; set; }
        public virtual DbSet<LoyaltyCard> LoyaltyCards { get; set; }
        public virtual DbSet<MOP> MOPs { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<ProdPromotion> ProdPromotions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductReceipt> ProductReceipts { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<Station> Stations { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Type_Product> Type_Product { get; set; }
        public virtual DbSet<TypeOfEmployment> TypeOfEmployments { get; set; }
    }
}
