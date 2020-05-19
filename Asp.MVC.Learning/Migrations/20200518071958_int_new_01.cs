using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.MVC.Learning.Migrations
{
    public partial class int_new_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    addressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.addressID);
                });

            migrationBuilder.CreateTable(
                name: "CellphoneNumber",
                columns: table => new
                {
                    TelephoneID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellphoneNumber", x => x.TelephoneID);
                });

            migrationBuilder.CreateTable(
                name: "DohSimplifieds",
                columns: table => new
                {
                    DohSimplifiedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FastenalCode = table.Column<string>(maxLength: 20, nullable: true),
                    LeadTime = table.Column<int>(nullable: false),
                    PMU = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DohSimplifieds", x => x.DohSimplifiedId);
                });

            migrationBuilder.CreateTable(
                name: "FastenalBranches",
                columns: table => new
                {
                    FastenalBranchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(nullable: true),
                    BranchCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FastenalBranches", x => x.FastenalBranchId);
                });

            migrationBuilder.CreateTable(
                name: "FastenalCodeAverageVPOAndSellPrices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FastenalPartNumber = table.Column<string>(nullable: true),
                    AverageVPOPrice = table.Column<double>(nullable: false),
                    AverageSellPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FastenalCodeAverageVPOAndSellPrices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FastenalCodeForecastFromCustomers",
                columns: table => new
                {
                    ForccastId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FastenalPartNumber = table.Column<string>(nullable: true),
                    ForecastQty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FastenalCodeForecastFromCustomers", x => x.ForccastId);
                });

            migrationBuilder.CreateTable(
                name: "FastenalCodeLeadtimes",
                columns: table => new
                {
                    FastenalCodeLeadTimeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FastenalCode = table.Column<string>(nullable: true),
                    LeadTime = table.Column<float>(nullable: false),
                    SafetyLeadTime = table.Column<int>(nullable: false),
                    OrderFrequency = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FastenalCodeLeadtimes", x => x.FastenalCodeLeadTimeId);
                });

            migrationBuilder.CreateTable(
                name: "FastenalCodeMinMaxes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FastenalPartNumber = table.Column<string>(nullable: true),
                    DataVersion = table.Column<string>(nullable: true),
                    AddDate = table.Column<string>(nullable: true),
                    IsHubControl = table.Column<bool>(nullable: false),
                    UsageMonth01 = table.Column<int>(nullable: false),
                    UsageMonth02 = table.Column<int>(nullable: false),
                    UsageMonth03 = table.Column<int>(nullable: false),
                    UsageMonth04 = table.Column<int>(nullable: false),
                    UsageMonth05 = table.Column<int>(nullable: false),
                    UsageMonth06 = table.Column<int>(nullable: false),
                    TotalHalfYearUsage = table.Column<int>(nullable: false),
                    OrderFrequency = table.Column<int>(nullable: false),
                    ForecastQty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FastenalCodeMinMaxes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FastenalCodeSixMonthUsages",
                columns: table => new
                {
                    FastenalUsageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FastenalPartNumber = table.Column<string>(nullable: true),
                    TotalHalfYearUsage = table.Column<int>(nullable: false),
                    UsageMonth01 = table.Column<int>(nullable: false),
                    UsageMonth02 = table.Column<int>(nullable: false),
                    UsageMonth03 = table.Column<int>(nullable: false),
                    UsageMonth04 = table.Column<int>(nullable: false),
                    UsageMonth05 = table.Column<int>(nullable: false),
                    UsageMonth06 = table.Column<int>(nullable: false),
                    OrderFrequency = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FastenalCodeSixMonthUsages", x => x.FastenalUsageId);
                });

            migrationBuilder.CreateTable(
                name: "ItemTreeCodes",
                columns: table => new
                {
                    ItemTreeCodeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FastenalCode = table.Column<string>(nullable: true),
                    StockType = table.Column<string>(nullable: true),
                    VendorName = table.Column<string>(nullable: true),
                    VendorItemNumber = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaterialCost = table.Column<double>(nullable: false),
                    PosCost = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTreeCodes", x => x.ItemTreeCodeId);
                });

            migrationBuilder.CreateTable(
                name: "MOQList",
                columns: table => new
                {
                    MOQListID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FastenalPartNumber = table.Column<string>(nullable: true),
                    VendorNumber = table.Column<string>(nullable: true),
                    ReorderQty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MOQList", x => x.MOQListID);
                });

            migrationBuilder.CreateTable(
                name: "MroParts",
                columns: table => new
                {
                    PartId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartName = table.Column<string>(nullable: true),
                    SupplierModelInformation = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SupplierBrandName = table.Column<string>(nullable: true),
                    FirstLevelCategory = table.Column<string>(nullable: true),
                    FastenalCode = table.Column<string>(nullable: true),
                    SupplierProductCode = table.Column<string>(nullable: true),
                    SaleUnit = table.Column<string>(nullable: true),
                    CurrencyType = table.Column<int>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    PricePerSaleUnitWithoutVAT = table.Column<double>(nullable: false),
                    SupplierSuggestedSalePrice = table.Column<double>(nullable: false),
                    MOQ = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MroParts", x => x.PartId);
                });

            migrationBuilder.CreateTable(
                name: "SystemSettings",
                columns: table => new
                {
                    SystemSettingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastUsedFolderPath = table.Column<string>(nullable: true),
                    LastForecastFolderPath = table.Column<string>(nullable: true),
                    LastRunTimeStamp = table.Column<DateTime>(nullable: false),
                    ErrorMessage = table.Column<string>(nullable: true),
                    InfoMessage = table.Column<string>(nullable: true),
                    MinMaxUsageLast6MonthHeaders = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemSettings", x => x.SystemSettingId);
                });

            migrationBuilder.CreateTable(
                name: "VendorForPO",
                columns: table => new
                {
                    VendorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorFastenalCode = table.Column<string>(nullable: true),
                    VendorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorForPO", x => x.VendorId);
                });

            migrationBuilder.CreateTable(
                name: "VPOItems",
                columns: table => new
                {
                    VpoItemCostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FastenalCode = table.Column<string>(nullable: true),
                    VendorName = table.Column<string>(nullable: true),
                    VendorNumber = table.Column<string>(nullable: true),
                    VendorPO = table.Column<string>(nullable: true),
                    BranchId = table.Column<string>(nullable: true),
                    PriceInOriginalCurrency = table.Column<double>(nullable: false),
                    OrderQty = table.Column<int>(nullable: false),
                    TotalAmountInOriginalCurrency = table.Column<double>(nullable: true),
                    CurrencyType = table.Column<int>(nullable: false),
                    ExchangeRateToUSD = table.Column<double>(nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VPOItems", x => x.VpoItemCostId);
                });

            migrationBuilder.CreateTable(
                name: "WiredPhoneNumber",
                columns: table => new
                {
                    TelephoneID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaCode = table.Column<string>(maxLength: 5, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 10, nullable: false),
                    ExtensionNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WiredPhoneNumber", x => x.TelephoneID);
                });

            migrationBuilder.CreateTable(
                name: "Approvals",
                columns: table => new
                {
                    OneApprovalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 15, nullable: false),
                    WorksheetSavePath = table.Column<string>(nullable: true),
                    FastenalBranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Approvals", x => x.OneApprovalID);
                    table.ForeignKey(
                        name: "FK_Approvals_FastenalBranches_FastenalBranchId",
                        column: x => x.FastenalBranchId,
                        principalTable: "FastenalBranches",
                        principalColumn: "FastenalBranchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInformation",
                columns: table => new
                {
                    UserInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchFastenalBranchId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInformation", x => x.UserInfoId);
                    table.ForeignKey(
                        name: "FK_UserInformation_FastenalBranches_BranchFastenalBranchId",
                        column: x => x.BranchFastenalBranchId,
                        principalTable: "FastenalBranches",
                        principalColumn: "FastenalBranchId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdditonalProperty",
                columns: table => new
                {
                    PropertyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyName = table.Column<string>(nullable: true),
                    PropertyValue = table.Column<string>(nullable: true),
                    MroPartPartId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditonalProperty", x => x.PropertyId);
                    table.ForeignKey(
                        name: "FK_AdditonalProperty_MroParts_MroPartPartId",
                        column: x => x.MroPartPartId,
                        principalTable: "MroParts",
                        principalColumn: "PartId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PackagingType",
                columns: table => new
                {
                    PackagingTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackagingTypeName = table.Column<string>(nullable: true),
                    QtyPerPackage = table.Column<string>(nullable: true),
                    MroPartPartId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackagingType", x => x.PackagingTypeId);
                    table.ForeignKey(
                        name: "FK_PackagingType_MroParts_MroPartPartId",
                        column: x => x.MroPartPartId,
                        principalTable: "MroParts",
                        principalColumn: "PartId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FastenalCodeMOQs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FastenalPartNumber = table.Column<string>(nullable: true),
                    VendorId = table.Column<int>(nullable: true),
                    Moq = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FastenalCodeMOQs", x => x.id);
                    table.ForeignKey(
                        name: "FK_FastenalCodeMOQs_VendorForPO_VendorId",
                        column: x => x.VendorId,
                        principalTable: "VendorForPO",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FastenalPartCodesFTS",
                columns: table => new
                {
                    FastenalCodeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FastenalPartNumber = table.Column<string>(nullable: false),
                    FastenalDescription = table.Column<string>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    VendorId = table.Column<int>(nullable: true),
                    VendorPoNumber = table.Column<string>(nullable: true),
                    VendorPartNumber = table.Column<string>(nullable: true),
                    ProcessPartNumber = table.Column<string>(nullable: true),
                    OrderQty = table.Column<int>(nullable: true),
                    QtyReceived = table.Column<int>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: true),
                    OpenQty = table.Column<int>(nullable: true),
                    DataLastUpdatedTime = table.Column<DateTime>(nullable: true),
                    StorageLocation = table.Column<string>(maxLength: 15, nullable: true),
                    QOH = table.Column<int>(nullable: true),
                    OriginalBranch = table.Column<string>(nullable: true),
                    LastScannedInDate = table.Column<DateTime>(nullable: true),
                    CarrierType = table.Column<string>(nullable: true),
                    Qty = table.Column<int>(nullable: true),
                    FastenalCodeInReceiveExcelFile_DataLastUpdatedTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FastenalPartCodesFTS", x => x.FastenalCodeId);
                    table.ForeignKey(
                        name: "FK_FastenalPartCodesFTS_VendorForPO_VendorId",
                        column: x => x.VendorId,
                        principalTable: "VendorForPO",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    PeronID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<short>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    CellphoneNumberTelephoneID = table.Column<int>(nullable: true),
                    WiredPhoneNumberTelephoneID = table.Column<int>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.PeronID);
                    table.ForeignKey(
                        name: "FK_Employees_CellphoneNumber_CellphoneNumberTelephoneID",
                        column: x => x.CellphoneNumberTelephoneID,
                        principalTable: "CellphoneNumber",
                        principalColumn: "TelephoneID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_WiredPhoneNumber_WiredPhoneNumberTelephoneID",
                        column: x => x.WiredPhoneNumberTelephoneID,
                        principalTable: "WiredPhoneNumber",
                        principalColumn: "TelephoneID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DohItems",
                columns: table => new
                {
                    DohItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderQty = table.Column<int>(nullable: false),
                    fastenalCode = table.Column<string>(nullable: true),
                    fastenalDescription = table.Column<string>(nullable: true),
                    vendorName = table.Column<string>(nullable: true),
                    vendorId = table.Column<string>(nullable: true),
                    vendorMoq = table.Column<int>(nullable: false),
                    vendorLeadtime = table.Column<int>(nullable: false),
                    ReleaseNumber = table.Column<int>(nullable: false),
                    PurchaseCost = table.Column<float>(nullable: false),
                    SellingPrice = table.Column<float>(nullable: false),
                    AnnualUsage = table.Column<int>(nullable: false),
                    CurrentQOH = table.Column<int>(nullable: false),
                    SafetyLeadtime = table.Column<int>(nullable: false),
                    OrderFrequency = table.Column<int>(nullable: false),
                    VPONumber = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    TypeOfInventoryCommitment = table.Column<string>(nullable: true),
                    IsAgreementCoversAllInventoryPurchase = table.Column<string>(nullable: true),
                    OtherCommentAboutCommitmentType = table.Column<string>(nullable: true),
                    CurrencyType = table.Column<int>(nullable: false),
                    MyBranchCode = table.Column<string>(nullable: true),
                    SrPoTrackingQty = table.Column<int>(nullable: false),
                    QtyOfOpenPo = table.Column<int>(nullable: false),
                    QtyOfStock = table.Column<int>(nullable: false),
                    QtyOfReceive = table.Column<int>(nullable: false),
                    AverageVPOPurchaseCost = table.Column<float>(nullable: false),
                    OneApprovalID = table.Column<int>(nullable: false),
                    FastenalCodeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DohItems", x => x.DohItemId);
                    table.ForeignKey(
                        name: "FK_DohItems_FastenalPartCodesFTS_FastenalCodeId",
                        column: x => x.FastenalCodeId,
                        principalTable: "FastenalPartCodesFTS",
                        principalColumn: "FastenalCodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DohItems_Approvals_OneApprovalID",
                        column: x => x.OneApprovalID,
                        principalTable: "Approvals",
                        principalColumn: "OneApprovalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuotationProjects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectSerialID = table.Column<string>(nullable: false),
                    ProjectName = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    projectState = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SalesPersonPeronID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotationProjects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_QuotationProjects_Employees_SalesPersonPeronID",
                        column: x => x.SalesPersonPeronID,
                        principalTable: "Employees",
                        principalColumn: "PeronID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuotationItems",
                columns: table => new
                {
                    ItemId = table.Column<string>(nullable: false),
                    CustomerDescription = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    EAUFromCustomer = table.Column<double>(nullable: false),
                    quotationState = table.Column<int>(nullable: false),
                    QuotationProjectProjectId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotationItems", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_QuotationItems_QuotationProjects_QuotationProjectProjectId",
                        column: x => x.QuotationProjectProjectId,
                        principalTable: "QuotationProjects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Quoters",
                columns: table => new
                {
                    PeronID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<short>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    CellphoneNumberTelephoneID = table.Column<int>(nullable: true),
                    WiredPhoneNumberTelephoneID = table.Column<int>(nullable: true),
                    QuoterName = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    QuotationProjectProjectId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quoters", x => x.PeronID);
                    table.ForeignKey(
                        name: "FK_Quoters_CellphoneNumber_CellphoneNumberTelephoneID",
                        column: x => x.CellphoneNumberTelephoneID,
                        principalTable: "CellphoneNumber",
                        principalColumn: "TelephoneID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Quoters_QuotationProjects_QuotationProjectProjectId",
                        column: x => x.QuotationProjectProjectId,
                        principalTable: "QuotationProjects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Quoters_WiredPhoneNumber_WiredPhoneNumberTelephoneID",
                        column: x => x.WiredPhoneNumberTelephoneID,
                        principalTable: "WiredPhoneNumber",
                        principalColumn: "TelephoneID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierChineseName = table.Column<string>(nullable: true),
                    SupplierEnglishName = table.Column<string>(nullable: true),
                    SupplierBriefIntroduction = table.Column<string>(nullable: true),
                    SupplierAddressaddressID = table.Column<int>(nullable: true),
                    QuotationProjectProjectId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierID);
                    table.ForeignKey(
                        name: "FK_Suppliers_QuotationProjects_QuotationProjectProjectId",
                        column: x => x.QuotationProjectProjectId,
                        principalTable: "QuotationProjects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Suppliers_Address_SupplierAddressaddressID",
                        column: x => x.SupplierAddressaddressID,
                        principalTable: "Address",
                        principalColumn: "addressID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemProperty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quotationItemItemId = table.Column<string>(nullable: true),
                    PropertyName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemProperty_QuotationItems_quotationItemItemId",
                        column: x => x.quotationItemItemId,
                        principalTable: "QuotationItems",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactPerson",
                columns: table => new
                {
                    PeronID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<short>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    CellphoneNumberTelephoneID = table.Column<int>(nullable: true),
                    WiredPhoneNumberTelephoneID = table.Column<int>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    EmailAdress = table.Column<string>(nullable: true),
                    SupplierBaseSupplierID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPerson", x => x.PeronID);
                    table.ForeignKey(
                        name: "FK_ContactPerson_CellphoneNumber_CellphoneNumberTelephoneID",
                        column: x => x.CellphoneNumberTelephoneID,
                        principalTable: "CellphoneNumber",
                        principalColumn: "TelephoneID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContactPerson_Suppliers_SupplierBaseSupplierID",
                        column: x => x.SupplierBaseSupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContactPerson_WiredPhoneNumber_WiredPhoneNumberTelephoneID",
                        column: x => x.WiredPhoneNumberTelephoneID,
                        principalTable: "WiredPhoneNumber",
                        principalColumn: "TelephoneID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuotationForSingleItems",
                columns: table => new
                {
                    QuotationItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MOQ = table.Column<double>(nullable: false),
                    SentOutDate = table.Column<DateTime>(nullable: false),
                    ReceivedDate = table.Column<DateTime>(nullable: false),
                    QuotationItemItemId = table.Column<string>(nullable: true),
                    QuotationState = table.Column<int>(nullable: false),
                    RFQSupplierSupplierID = table.Column<int>(nullable: true),
                    VatExcludedPrice = table.Column<float>(nullable: false),
                    TargetPrice = table.Column<float>(nullable: false),
                    ToolingFee = table.Column<int>(nullable: false),
                    CommentsForThisQuotation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotationForSingleItems", x => x.QuotationItemId);
                    table.ForeignKey(
                        name: "FK_QuotationForSingleItems_QuotationItems_QuotationItemItemId",
                        column: x => x.QuotationItemItemId,
                        principalTable: "QuotationItems",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuotationForSingleItems_Suppliers_RFQSupplierSupplierID",
                        column: x => x.RFQSupplierSupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierProduct",
                columns: table => new
                {
                    SupplierProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    ImageData = table.Column<byte[]>(nullable: true),
                    SupplierID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierProduct", x => x.SupplierProductId);
                    table.ForeignKey(
                        name: "FK_SupplierProduct_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditonalProperty_MroPartPartId",
                table: "AdditonalProperty",
                column: "MroPartPartId");

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_FastenalBranchId",
                table: "Approvals",
                column: "FastenalBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactPerson_CellphoneNumberTelephoneID",
                table: "ContactPerson",
                column: "CellphoneNumberTelephoneID");

            migrationBuilder.CreateIndex(
                name: "IX_ContactPerson_SupplierBaseSupplierID",
                table: "ContactPerson",
                column: "SupplierBaseSupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_ContactPerson_WiredPhoneNumberTelephoneID",
                table: "ContactPerson",
                column: "WiredPhoneNumberTelephoneID");

            migrationBuilder.CreateIndex(
                name: "IX_DohItems_FastenalCodeId",
                table: "DohItems",
                column: "FastenalCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_DohItems_OneApprovalID",
                table: "DohItems",
                column: "OneApprovalID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CellphoneNumberTelephoneID",
                table: "Employees",
                column: "CellphoneNumberTelephoneID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_WiredPhoneNumberTelephoneID",
                table: "Employees",
                column: "WiredPhoneNumberTelephoneID");

            migrationBuilder.CreateIndex(
                name: "IX_FastenalCodeMOQs_VendorId",
                table: "FastenalCodeMOQs",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_FastenalPartCodesFTS_VendorId",
                table: "FastenalPartCodesFTS",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemProperty_quotationItemItemId",
                table: "ItemProperty",
                column: "quotationItemItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingType_MroPartPartId",
                table: "PackagingType",
                column: "MroPartPartId");

            migrationBuilder.CreateIndex(
                name: "IX_QuotationForSingleItems_QuotationItemItemId",
                table: "QuotationForSingleItems",
                column: "QuotationItemItemId");

            migrationBuilder.CreateIndex(
                name: "IX_QuotationForSingleItems_RFQSupplierSupplierID",
                table: "QuotationForSingleItems",
                column: "RFQSupplierSupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_QuotationItems_QuotationProjectProjectId",
                table: "QuotationItems",
                column: "QuotationProjectProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_QuotationProjects_SalesPersonPeronID",
                table: "QuotationProjects",
                column: "SalesPersonPeronID");

            migrationBuilder.CreateIndex(
                name: "IX_Quoters_CellphoneNumberTelephoneID",
                table: "Quoters",
                column: "CellphoneNumberTelephoneID");

            migrationBuilder.CreateIndex(
                name: "IX_Quoters_QuotationProjectProjectId",
                table: "Quoters",
                column: "QuotationProjectProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Quoters_WiredPhoneNumberTelephoneID",
                table: "Quoters",
                column: "WiredPhoneNumberTelephoneID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierProduct_SupplierID",
                table: "SupplierProduct",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_QuotationProjectProjectId",
                table: "Suppliers",
                column: "QuotationProjectProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_SupplierAddressaddressID",
                table: "Suppliers",
                column: "SupplierAddressaddressID");

            migrationBuilder.CreateIndex(
                name: "IX_UserInformation_BranchFastenalBranchId",
                table: "UserInformation",
                column: "BranchFastenalBranchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditonalProperty");

            migrationBuilder.DropTable(
                name: "ContactPerson");

            migrationBuilder.DropTable(
                name: "DohItems");

            migrationBuilder.DropTable(
                name: "DohSimplifieds");

            migrationBuilder.DropTable(
                name: "FastenalCodeAverageVPOAndSellPrices");

            migrationBuilder.DropTable(
                name: "FastenalCodeForecastFromCustomers");

            migrationBuilder.DropTable(
                name: "FastenalCodeLeadtimes");

            migrationBuilder.DropTable(
                name: "FastenalCodeMinMaxes");

            migrationBuilder.DropTable(
                name: "FastenalCodeMOQs");

            migrationBuilder.DropTable(
                name: "FastenalCodeSixMonthUsages");

            migrationBuilder.DropTable(
                name: "ItemProperty");

            migrationBuilder.DropTable(
                name: "ItemTreeCodes");

            migrationBuilder.DropTable(
                name: "MOQList");

            migrationBuilder.DropTable(
                name: "PackagingType");

            migrationBuilder.DropTable(
                name: "QuotationForSingleItems");

            migrationBuilder.DropTable(
                name: "Quoters");

            migrationBuilder.DropTable(
                name: "SupplierProduct");

            migrationBuilder.DropTable(
                name: "SystemSettings");

            migrationBuilder.DropTable(
                name: "UserInformation");

            migrationBuilder.DropTable(
                name: "VPOItems");

            migrationBuilder.DropTable(
                name: "FastenalPartCodesFTS");

            migrationBuilder.DropTable(
                name: "Approvals");

            migrationBuilder.DropTable(
                name: "MroParts");

            migrationBuilder.DropTable(
                name: "QuotationItems");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "VendorForPO");

            migrationBuilder.DropTable(
                name: "FastenalBranches");

            migrationBuilder.DropTable(
                name: "QuotationProjects");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "CellphoneNumber");

            migrationBuilder.DropTable(
                name: "WiredPhoneNumber");
        }
    }
}
