using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System.IO;
using NetCoreFastenalLib.DataModels;
using NetCoreFastenalLib;

namespace Asp.MVC.Learning.Models
{
    public class testDatabase : DbContext
    {

        public virtual DbSet<FastenalCode> FastenalPartCodes { get; set; }
        public virtual DbSet<QuotationItem> QuotationItems { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<QuotationForSingleItem> QuotationForSingleItems { get; set; }
        public virtual DbSet<QuotationProject> QuotationProjects { get; set; }
        public virtual DbSet<SupplierBase> Suppliers { get; set; }
        public virtual DbSet<Quoter> Quoters { get; set; }
        public virtual DbSet<SalesPerson> Sales { get; set; }

        public virtual DbSet<VPOItemCost> VPOItems { get; set; }
        public virtual DbSet<ItemTreeCode> ItemTreeCodes { get; set; }

        public virtual DbSet<MroPart> MroParts { get; set; }
        public virtual DbSet<FastenalCodeInReceiveExcelFile> FastenalCodeInReceiveExcelFiles { get; set; }
        public virtual DbSet<DohItems> DohItems { get; set; }

        public virtual DbSet<VendorForPO> VendorForPO { get; set; }

        public virtual DbSet<FastenalCodeForOpenPO> FastenalCodeForOpenPO { set; get; }
        public virtual DbSet<FastenalCodeForStock> FastenalCodeForStock { get; set; }
        public virtual DbSet<SystemSetting> SystemSettings { get; set; }
        public virtual DbSet<UserInformation> UserInformation { get; set; }
        public virtual DbSet<FastenalBranch> FastenalBranches { get; set; }
        public virtual DbSet<DohSimplified> DohSimplifieds { get; set; }
        public virtual DbSet<OneApproval> Approvals { get; set; }

        public virtual DbSet<FastenalCodeMOQ> FastenalCodeMOQs { get; set; }
        public virtual DbSet<FastenalCodeMinMax> FastenalCodeMinMaxes { get; set; }

        public virtual DbSet<FastenalCodeSixMonthUsage> FastenalCodeSixMonthUsages { get; set; }
        public virtual DbSet<FastenalCodeForecastFromCustomer> FastenalCodeForecastFromCustomers { get; set; }
        public virtual DbSet<MOQList> MOQList { get; set; }
        public virtual DbSet<FastenalCodeLeadTime> FastenalCodeLeadtimes { get; set; }
        public virtual DbSet<FastenalCodeAverageVPOAndSellPrice> FastenalCodeAverageVPOAndSellPrices { get; set; }

        private DbContextOptionsBuilder builder;

        public DbSet<Test> tests { get; set; }

        public string DatabasePath { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connstring = "Server=tcp:aspmvcearningdbserver.database.windows.net," +
                             "1433;Initial Catalog=Asp.MVC.Learning_db;" +
                             "Persist Security Info=False;" +
                             "User ID=wansheng;Password=Mydb2020$;" +
                             "MultipleActiveResultSets=False;" +
                             "Encrypt=True;" +
                             "TrustServerCertificate=False;" +
                             "Connection Timeout=30;";
            optionsBuilder.UseSqlServer(connstring);
        }

        public testDatabase()
        {

        }
        public testDatabase(string databasePath)
        {
            this.DatabasePath = databasePath;
        }
    }
}
