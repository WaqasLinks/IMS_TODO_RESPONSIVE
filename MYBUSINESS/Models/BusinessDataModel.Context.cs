﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MYBUSINESS.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BusinessContext : DbContext
    {
        public BusinessContext()
            : base("name=BusinessContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BankAccount> BankAccounts { get; set; }
        public virtual DbSet<BusinessInfo> BusinessInfoes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<ExpenseDetail> ExpenseDetails { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<LoanDetail> LoanDetails { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<MyBusinessInfo> MyBusinessInfoes { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PO> POes { get; set; }
        public virtual DbSet<POD> PODs { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
        public virtual DbSet<Rent> Rents { get; set; }
        public virtual DbSet<RentDetail> RentDetails { get; set; }
        public virtual DbSet<Right> Rights { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceDetail> ServiceDetails { get; set; }
        public virtual DbSet<SO> SOes { get; set; }
        public virtual DbSet<SOD> SODs { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
    
        public virtual ObjectResult<spPOReport_Result1> spPOReport(string purchaseOrderID)
        {
            var purchaseOrderIDParameter = purchaseOrderID != null ?
                new ObjectParameter("PurchaseOrderID", purchaseOrderID) :
                new ObjectParameter("PurchaseOrderID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spPOReport_Result1>("spPOReport", purchaseOrderIDParameter);
        }
    
        public virtual ObjectResult<spSOReport_Result1> spSOReport(string saleOrderID)
        {
            var saleOrderIDParameter = saleOrderID != null ?
                new ObjectParameter("SaleOrderID", saleOrderID) :
                new ObjectParameter("SaleOrderID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSOReport_Result1>("spSOReport", saleOrderIDParameter);
        }
    
        public virtual ObjectResult<spExpenseReport_Result1> spExpenseReport(string purchaseOrderID)
        {
            var purchaseOrderIDParameter = purchaseOrderID != null ?
                new ObjectParameter("PurchaseOrderID", purchaseOrderID) :
                new ObjectParameter("PurchaseOrderID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spExpenseReport_Result1>("spExpenseReport", purchaseOrderIDParameter);
        }
    
        public virtual ObjectResult<spLoanReport_Result1> spLoanReport(string purchaseOrderID)
        {
            var purchaseOrderIDParameter = purchaseOrderID != null ?
                new ObjectParameter("PurchaseOrderID", purchaseOrderID) :
                new ObjectParameter("PurchaseOrderID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spLoanReport_Result1>("spLoanReport", purchaseOrderIDParameter);
        }
    
        public virtual ObjectResult<spRentReport_Result1> spRentReport(string saleOrderID)
        {
            var saleOrderIDParameter = saleOrderID != null ?
                new ObjectParameter("SaleOrderID", saleOrderID) :
                new ObjectParameter("SaleOrderID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spRentReport_Result1>("spRentReport", saleOrderIDParameter);
        }
    
        public virtual ObjectResult<spServiceReport_Result1> spServiceReport(string saleOrderID)
        {
            var saleOrderIDParameter = saleOrderID != null ?
                new ObjectParameter("SaleOrderID", saleOrderID) :
                new ObjectParameter("SaleOrderID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spServiceReport_Result1>("spServiceReport", saleOrderIDParameter);
        }
    }
}