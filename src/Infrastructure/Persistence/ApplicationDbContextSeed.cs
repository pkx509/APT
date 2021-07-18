using GFCA.Domain.Entities.Sales;
using GFCA.Domain.Entities.Accountants;
using GFCA.Domain.Entities.Warehouses;
using GFCA.Domain.Entities.Workflows;
using GFCA.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using GFCA.Domain.Entities.Documents;
using GFCA.Domain.Entities.BusinessParties;

namespace GFCA.Infrastructure.Persistence
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedDefaultUserAsync(UserManager<User> userManager)
        {
            var defaultUser = new User { UserName = "administrator@localhost", Email = "administrator@localhost" };

            if (userManager.Users.All(u => u.UserName != defaultUser.UserName))
            {
                await userManager.CreateAsync(defaultUser, "admin1");
            }
        }

        // insert together models
        public static void SeedMasterData(this ModelBuilder builder)
        {

            builder.SeedMasterAccountant();
            builder.SeedMasterDocument();
            builder.SeedMasterSale();
            builder.SeedMasterProduct();
            builder.SeedMasterWorkflow();
            
        }

        private static void SeedMasterAccountant(this ModelBuilder builder)
        {
            builder.Entity<CostCenter>().HasData
            (
                new CostCenter { CostCenterId = 1, CenterCode = "CC001", CenterName = "Cost 001", Site = "BKK Thailand" }
            );
            /*
            builder.Entity<GLAccount>().HasData
            (
                new GLAccount { AccountId = 1, CompanyCode = "001", AccountTypeCode = "01", AccountTypeName = "Domestic Account Receiveable", AccountGroup = "General", AccountNo = "000001", AccountName = "Trade Debtors (domestic)", Purpose = "null" },
                new GLAccount { AccountId = 2, CompanyCode = "001", AccountTypeCode = "01", AccountTypeName = "Foreign Account Receiveable", AccountGroup = "General", AccountNo = "000002", AccountName = "Trade Debtors (foreign)", Purpose = "null" },
                new GLAccount { AccountId = 3, CompanyCode = "001", AccountTypeCode = "01", AccountTypeName = "Checks Receiveable", AccountGroup = "General", AccountNo = "000003", AccountName = "K-BANK (cheques received)", Purpose = "null" },
                new GLAccount { AccountId = 4, CompanyCode = "001", AccountTypeCode = "01", AccountTypeName = "Cash on Hand", AccountGroup = "General", AccountNo = "000004", AccountName = "SCB Account", Purpose = "null" },
                new GLAccount { AccountId = 5, CompanyCode = "001", AccountTypeCode = "01", AccountTypeName = "Overpayment A/R Account", AccountGroup = "General", AccountNo = "000005", AccountName = "null", Purpose = "null" },
                new GLAccount { AccountId = 6, CompanyCode = "001", AccountTypeCode = "01", AccountTypeName = "Underpayment A/R Account", AccountGroup = "General", AccountNo = "000006", AccountName = "null", Purpose = "null" },
                new GLAccount { AccountId = 7, CompanyCode = "001", AccountTypeCode = "01", AccountTypeName = "Down Payment Clearing Account", AccountGroup = "General", AccountNo = "000007", AccountName = "null", Purpose = "null" },
                new GLAccount { AccountId = 8, CompanyCode = "001", AccountTypeCode = "01", AccountTypeName = "Realized Exchange Diff. Gain", AccountGroup = "General", AccountNo = "000008", AccountName = "Realised Foreign Exchange Gains", Purpose = "null" },
                new GLAccount { AccountId = 9, CompanyCode = "001", AccountTypeCode = "01", AccountTypeName = "Realized Exchange Diff. Loss", AccountGroup = "General", AccountNo = "000009", AccountName = "Realised Foreign Exchange Losses", Purpose = "null" },
                new GLAccount { AccountId = 10, CompanyCode = "001", AccountTypeCode = "01", AccountTypeName = "Cash Discount", AccountGroup = "General", AccountNo = "000010", AccountName = "Customer Discount for Early Payment", Purpose = "null" },
                new GLAccount { AccountId = 11, CompanyCode = "001", AccountTypeCode = "01", AccountTypeName = "Revenue Account", AccountGroup = "General", AccountNo = "000011", AccountName = "Sale Revenue (Domestic) - Beer", Purpose = "null" },
                new GLAccount { AccountId = 12, CompanyCode = "001", AccountTypeCode = "01", AccountTypeName = "Sales Credit Account", AccountGroup = "General", AccountNo = "000012", AccountName = "Sale Revenue (Domestic) - Beer", Purpose = "null" },
                new GLAccount { AccountId = 13, CompanyCode = "001", AccountTypeCode = "01", AccountTypeName = "Down Payment Interim Account", AccountGroup = "General", AccountNo = "000013", AccountName = "null", Purpose = "null" },
                new GLAccount { AccountId = 14, CompanyCode = "001", AccountTypeCode = "02", AccountTypeName = "Domestic Account Receiveable", AccountGroup = "TAX", AccountNo = "000014", AccountName = "null", Purpose = "null" },
                new GLAccount { AccountId = 15, CompanyCode = "001", AccountTypeCode = "02", AccountTypeName = "Foreign Account Receiveable", AccountGroup = "TAX", AccountNo = "000015", AccountName = "null", Purpose = "null" },
                new GLAccount { AccountId = 16, CompanyCode = "001", AccountTypeCode = "02", AccountTypeName = "Checks Receiveable", AccountGroup = "TAX", AccountNo = "000016", AccountName = "null", Purpose = "null" },
                new GLAccount { AccountId = 17, CompanyCode = "001", AccountTypeCode = "02", AccountTypeName = "Cash on Hand", AccountGroup = "TAX", AccountNo = "000017", AccountName = "null", Purpose = "null" },
                new GLAccount { AccountId = 18, CompanyCode = "001", AccountTypeCode = "02", AccountTypeName = "Overpayment A/R Account", AccountGroup = "TAX", AccountNo = "000018", AccountName = "null", Purpose = "null" },
                new GLAccount { AccountId = 19, CompanyCode = "001", AccountTypeCode = "02", AccountTypeName = "Underpayment A/R Account", AccountGroup = "TAX", AccountNo = "000019", AccountName = "null", Purpose = "null" },
                new GLAccount { AccountId = 20, CompanyCode = "001", AccountTypeCode = "02", AccountTypeName = "Down Payment Clearing Account", AccountGroup = "TAX", AccountNo = "000020", AccountName = "null", Purpose = "null" },
                new GLAccount { AccountId = 21, CompanyCode = "001", AccountTypeCode = "02", AccountTypeName = "Realized Exchange Diff. Gain", AccountGroup = "TAX", AccountNo = "000021", AccountName = "null", Purpose = "null" },
                new GLAccount { AccountId = 22, CompanyCode = "001", AccountTypeCode = "02", AccountTypeName = "Realized Exchange Diff. Loss", AccountGroup = "TAX", AccountNo = "000022", AccountName = "null", Purpose = "null" },
                new GLAccount { AccountId = 23, CompanyCode = "001", AccountTypeCode = "02", AccountTypeName = "Cash Discount", AccountGroup = "TAX", AccountNo = "000023", AccountName = "null", Purpose = "null" },
                new GLAccount { AccountId = 24, CompanyCode = "001", AccountTypeCode = "02", AccountTypeName = "Revenue Account", AccountGroup = "TAX", AccountNo = "000024", AccountName = "null", Purpose = "null" },
                new GLAccount { AccountId = 25, CompanyCode = "001", AccountTypeCode = "02", AccountTypeName = "Sales Credit Account", AccountGroup = "TAX", AccountNo = "000025", AccountName = "null", Purpose = "null" },
                new GLAccount { AccountId = 26, CompanyCode = "001", AccountTypeCode = "02", AccountTypeName = "Down Payment Interim Account", AccountGroup = "TAX", AccountNo = "000026", AccountName = "null", Purpose = "null" }
            );
            */
        }
        private static void SeedMasterDocument(this ModelBuilder builder)
        {

            var documentTypes = new DocumentType[]
            {
                new DocumentType { DocumentTypeId = 1, WorkflowId = 1, DocumentTypeCode = "FC01", DocumentTypeName = "Fixed Contract", DocumentTypeDesc = "Fixed Contract" },
                new DocumentType { DocumentTypeId = 2, WorkflowId = 2, DocumentTypeCode = "SF01", DocumentTypeName = "Sale Forecast", DocumentTypeDesc = "Sale Forecast - Client" },
                new DocumentType { DocumentTypeId = 3, WorkflowId = 2, DocumentTypeCode = "SF02", DocumentTypeName = "Sale Forecast", DocumentTypeDesc = "Sale Forecast - Brand" },
                new DocumentType { DocumentTypeId = 4, WorkflowId = 2, DocumentTypeCode = "SF03", DocumentTypeName = "Sale Forecast", DocumentTypeDesc = "Sale Forecast - Product (SKU)" },
                new DocumentType { DocumentTypeId = 5, WorkflowId = 3, DocumentTypeCode = "BP01", DocumentTypeName = "Budget Planing", DocumentTypeDesc = "Budget Planing" }
            };
            if (documentTypes.Length > 0)
            {
                for (int i = 0; i < documentTypes.Length; i++)
                {
                    documentTypes[i].CreatedBy = "System";
                    documentTypes[i].CreatedDate = DateTime.Now;
                }
                builder.Entity<DocumentType>().HasData(documentTypes);
            }

            var budgetTypes = new BudgetType[]
            {
                new BudgetType { BudgetTypeId = 1, BudgetTypeCode = "BTI01", BudgetTypeName = "Value", BudgetTypeDesc = "Invesment Value" },
                new BudgetType { BudgetTypeId = 2, BudgetTypeCode = "BTI02", BudgetTypeName = "% Sales Growth", BudgetTypeDesc = "Invesment of % Sales Growth" },
                new BudgetType { BudgetTypeId = 3, BudgetTypeCode = "BTS01", BudgetTypeName = "Value", BudgetTypeDesc = "Sale of Value" },
                new BudgetType { BudgetTypeId = 4, BudgetTypeCode = "BTS02", BudgetTypeName = "% Sales Growth", BudgetTypeDesc = "Sale of % Sales Growth" }
            };

            if (budgetTypes.Length > 0)
            {
                for (int i = 0; i < budgetTypes.Length; i++)
                {
                    
                }
                builder.Entity<BudgetType>().HasData(budgetTypes);
            }
        }
        private static void SeedMasterSale(this ModelBuilder builder)
        {

            Supplier[] suppliers = new Supplier[]
            {
                //new Supplier { SupplierId = 1, BrandId = 1, CustomerId = 1, SupplierCode = "CS001", SupplierName = "Team A" },
                //new Supplier { SupplierId = 2, BrandId = 1, CustomerId = 2, SupplierCode = "CS002", SupplierName = "Team B" }
                new Supplier { SupplierId = 1, SupplierCode = "CS001", SupplierName = "Team A" },
                new Supplier { SupplierId = 2, SupplierCode = "CS002", SupplierName = "Team B" }
            };
            if (suppliers.Length > 0)
            {
                for (int i = 0; i < suppliers.Length; i++)
                {
                    suppliers[i].CreatedBy = "System";
                    suppliers[i].CreatedDate = DateTime.Now;
                }
                builder.Entity<Supplier>().HasData(suppliers);
            }


            Customer[] customers = new Customer[]
            {
                new Customer { CustomerId = 1, CustomerCode = "11000046", CustomerName = "บริษัท บิ๊กซี ซูเปอร์เซ็นเตอร์จำกัด (มหาชน)", ShortName = "BIGC", AccountNo = "D03", Distributor = "AAI", CustomerGroup = "BIG C" },
                new Customer { CustomerId = 2, CustomerCode = "D031-DM12", CustomerName = "บริษัท ดีเคเอสเอช (ประเทศไทย) จำกัด", ShortName = "DK-BIGC", AccountNo = "D03", Distributor = "DK", CustomerGroup = null },
                new Customer { CustomerId = 3, CustomerCode = "11000055", CustomerName = "บริษัท เซ็นทรัล ฟู้ด รีเทล จำกัดสาขาดีซี", ShortName = "TOPS", AccountNo = "D07", Distributor = "AAI", CustomerGroup = "TOPS" },
                new Customer { CustomerId = 4, CustomerCode = "D031-DM16", CustomerName = "บริษัท ดีเคเอสเอช (ประเทศไทย) จำกัด", ShortName = "DK-TOPS", AccountNo = "D07", Distributor = "DK", CustomerGroup = null },
                new Customer { CustomerId = 5, CustomerCode = "11000059", CustomerName = "บริษัท เอก-ชัย ดีสทริบิวชั่นซิสเทม จำกัด", ShortName = "TESCO", AccountNo = "D05", Distributor = "AAI", CustomerGroup = "TESCO LOTUS" },
                new Customer { CustomerId = 6, CustomerCode = "D031-DM14", CustomerName = "บริษัท ดีเคเอสเอช (ประเทศไทย) จำกัด", ShortName = "DK-TESCO", AccountNo = "D05", Distributor = "DK", CustomerGroup = null },
                new Customer { CustomerId = 7, CustomerCode = "11000066", CustomerName = "บริษัท เซ็นทรัลแฟมิลี่มาร์ท จำกัด", ShortName = "FAMILYMART", AccountNo = "D04", Distributor = "AAI", CustomerGroup = "FAMILY MART" },
                new Customer { CustomerId = 8, CustomerCode = "D031-DM13", CustomerName = "บริษัท ดีเคเอสเอช (ประเทศไทย) จำกัด", ShortName = "DK-CFM", AccountNo = "D04", Distributor = "DK", CustomerGroup = null },
                new Customer { CustomerId = 9, CustomerCode = "11000081", CustomerName = "บริษัท วิลล่ามาร์เก็ท เจพี จำกัด", ShortName = "VILLA", AccountNo = "D08", Distributor = "AAI", CustomerGroup = "VILLA" },
                new Customer { CustomerId = 10, CustomerCode = "D031-DM18", CustomerName = "บริษัท ดีเคเอสเอช (ประเทศไทย) จำกัด", ShortName = "DK-VILLA", AccountNo = "D08", Distributor = "DK", CustomerGroup = null },
                new Customer { CustomerId = 11, CustomerCode = "11000056", CustomerName = "บริษัท ซีพี ออลล์ จำกัด (มหาชน)", ShortName = "CPALL", AccountNo = null, Distributor = "AAI", CustomerGroup = "" },
                new Customer { CustomerId = 12, CustomerCode = "D031-DM05", CustomerName = "บริษัท ดีเคเอสเอช (ประเทศไทย) จำกัด", ShortName = "DK-MAKRO", AccountNo = "D031-DM05", Distributor = "DK", CustomerGroup = null },
                new Customer { CustomerId = 13, CustomerCode = "D031-DM09", CustomerName = null, ShortName = "DK-TM", AccountNo = "D031-DM09", Distributor = "DK", CustomerGroup = null },
                new Customer { CustomerId = 14, CustomerCode = "D031-DM01", CustomerName = null, ShortName = "DK-BOOTS", AccountNo = "D031-DM01", Distributor = "DK", CustomerGroup = null },
                new Customer { CustomerId = 15, CustomerCode = "D031-DM02", CustomerName = null, ShortName = "DK-CPF", AccountNo = "D031-DM02", Distributor = "DK", CustomerGroup = null },
                new Customer { CustomerId = 16, CustomerCode = "D031-DM03", CustomerName = null, ShortName = "DK-FL", AccountNo = "D031-DM03", Distributor = "DK", CustomerGroup = null },
                new Customer { CustomerId = 17, CustomerCode = "D031-DM04", CustomerName = null, ShortName = "DK-ISETAN", AccountNo = "D031-DM04", Distributor = "DK", CustomerGroup = null },
                new Customer { CustomerId = 18, CustomerCode = "D031-DM06", CustomerName = null, ShortName = "DK-LAWSON", AccountNo = "D031-DM06", Distributor = "DK", CustomerGroup = null },
                new Customer { CustomerId = 19, CustomerCode = "D031-DM08", CustomerName = null, ShortName = "DK-THS", AccountNo = "D031-DM08", Distributor = "DK", CustomerGroup = null },
                new Customer { CustomerId = 20, CustomerCode = "D031-DM10", CustomerName = null, ShortName = "DK-TOKYU", AccountNo = "D031-DM10", Distributor = "DK", CustomerGroup = null },
                new Customer { CustomerId = 21, CustomerCode = "D031-DM11", CustomerName = null, ShortName = "DK-UFMFUJI", AccountNo = "D031-DM11", Distributor = "DK", CustomerGroup = null },
                new Customer { CustomerId = 22, CustomerCode = "D031-DM17", CustomerName = null, ShortName = "DK-ALL-D", AccountNo = "D031-DM17", Distributor = "DK", CustomerGroup = null },
                new Customer { CustomerId = 23, CustomerCode = "D031-DT02", CustomerName = null, ShortName = "DK-G STORE", AccountNo = "D031-DT02", Distributor = "DK", CustomerGroup = null },
                new Customer { CustomerId = 24, CustomerCode = "11000148", CustomerName = "บริษัท ปิโตรเลียมไทยคอร์ปอเรชั่นจำกัด", ShortName = "PT GSTORE", AccountNo = null, Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 25, CustomerCode = "11000150", CustomerName = "บริษัท ปตท.บริหารธุรกิจค้าปลีกจำกัด", ShortName = "PTT JIFFY", AccountNo = null, Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 26, CustomerCode = "11000151", CustomerName = "บริษัท ซีพีเอฟ เทรดดิ้ง จำกัด", ShortName = "CPF", AccountNo = null, Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 27, CustomerCode = "11000176", CustomerName = "บริษัท สห ลอว์สัน จำกัด", ShortName = "LAWSON", AccountNo = null, Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 28, CustomerCode = "11000181", CustomerName = "บริษัท สรรพสินค้าตั้งฮั่วเส็ง จำกัด", ShortName = "THS BLP", AccountNo = null, Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 29, CustomerCode = "11000180", CustomerName = null, ShortName = "THS TBR", AccountNo = null, Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 30, CustomerCode = "11000152", CustomerName = "บริษัท สยามแม็คโคร จำกัด (มหาชน)", ShortName = "MAKRO", AccountNo = null, Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 31, CustomerCode = "11000203", CustomerName = "บริษัท บู๊ทส์ รีเทล (ประเทศไทย)จำกัด", ShortName = "BOOTS", AccountNo = null, Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 32, CustomerCode = "11000132", CustomerName = "บริษัท ปตท. น้ำมันและการค้าปลิกจำกัด (มหาชน)", ShortName = "PTT OR", AccountNo = null, Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 33, CustomerCode = "11000153", CustomerName = "บริษัท ยูเอฟเอ็ม ฟูจิ ซูเปอร์ จำกัด", ShortName = "UFM FUJI1", AccountNo = "D09", Distributor = "AAI", CustomerGroup = "UFM FUJI" },
                new Customer { CustomerId = 34, CustomerCode = "11000154", CustomerName = null, ShortName = "UFM FUJI2", AccountNo = "D09", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 35, CustomerCode = "11000155", CustomerName = null, ShortName = "UFM FUJI4", AccountNo = "D09", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 36, CustomerCode = "11000158", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาเดอะไบร์ท พระราม2)", ShortName = "FL RAMAII", AccountNo = "D10", Distributor = "AAI", CustomerGroup = "FOOD LAND" },
                new Customer { CustomerId = 37, CustomerCode = "11000159", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาเพชรเกษม)", ShortName = "FL P KASEM", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 38, CustomerCode = "11000160", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาปิ่นเกล้า)", ShortName = "FL PINKLAO", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 39, CustomerCode = "11000161", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาพอร์โตชิโน่ พระราม2)", ShortName = "FL POTOCIN", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 40, CustomerCode = "11000163", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาสุขุมวิท ซอย16)", ShortName = "FL SKV S16", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 41, CustomerCode = "11000164", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาหลักสี่)", ShortName = "FL LAK4", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 42, CustomerCode = "11000168", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาบางนา)", ShortName = "FL BANGNA", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 43, CustomerCode = "11000170", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาพระราม 3)", ShortName = "FL RAMAIII", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 44, CustomerCode = "11000178", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาพุทธมณฑล สาย4)", ShortName = "FL PTMT S4", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 45, CustomerCode = "11000157", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขารัชดา)", ShortName = "FL RATCADA", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 46, CustomerCode = "11000162", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาทองหล่อ)", ShortName = "FL THONGL", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 47, CustomerCode = "11000166", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาสุขุมวิท ซอย5)", ShortName = "FL SKV S5", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 48, CustomerCode = "11000167", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาหัวหมาก)", ShortName = "FL HUAMARK", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 49, CustomerCode = "11000169", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขารามอินทรา)", ShortName = "FL RAMINDA", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 50, CustomerCode = "11000179", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาศรีนครินทร์)", ShortName = "FL SRINAKA", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 51, CustomerCode = "11000183", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาลาดพร้าว)", ShortName = "FL LADPRAO", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 52, CustomerCode = "11000165", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาจรัญสนิทวงศ์)", ShortName = "FL JRSNW", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 53, CustomerCode = "11000175", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาพัฒน์พงศ์)", ShortName = "FL PATPONG", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 54, CustomerCode = "11000173", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาพัทยากลาง)", ShortName = "FL PTYC", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 55, CustomerCode = "11000174", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาเพชรบุรี)", ShortName = "FL PBURI", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 56, CustomerCode = "11000172", CustomerName = "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาเทอร์มินอลพัทยา)", ShortName = "FL TMNPAYA", AccountNo = "D10", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 57, CustomerCode = "11000187", CustomerName = "บริษัท เดอะมอลล์ กรุ๊ป จำกัด", ShortName = "TM BKP", AccountNo = "D11", Distributor = "AAI", CustomerGroup = "THE MALL" },
                new Customer { CustomerId = 58, CustomerCode = "11000194", CustomerName = null, ShortName = "TM HUAMARK", AccountNo = "D11", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 59, CustomerCode = "11000197", CustomerName = null, ShortName = "TM NWW", AccountNo = "D11", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 60, CustomerCode = "11000184", CustomerName = null, ShortName = "TM PEOPLEP", AccountNo = "D11", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 61, CustomerCode = "11000188", CustomerName = null, ShortName = "TM BKE", AccountNo = "D11", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 62, CustomerCode = "11000193", CustomerName = null, ShortName = "TM THAPRA", AccountNo = "D11", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 63, CustomerCode = "11000186", CustomerName = null, ShortName = "TM CDC RP", AccountNo = "D11", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 64, CustomerCode = "11000189", CustomerName = null, ShortName = "TM DV", AccountNo = "D11", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 65, CustomerCode = "11000199", CustomerName = "บริษัท สยามพารากอน รีเทล จำกัด", ShortName = "PARAGON", AccountNo = "D11", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 66, CustomerCode = "11000196", CustomerName = "บริษัท ซิตี้มอลล์ กรุ๊ป จำกัด", ShortName = "EMQUARTIER", AccountNo = "D11", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 67, CustomerCode = "11000202", CustomerName = null, ShortName = "EMPORIUM", AccountNo = "D11", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 68, CustomerCode = "11000198", CustomerName = "บริษัท พรอมานาด โฮมเฟรซมาร์ทจำกัด", ShortName = "TM PROMNAD", AccountNo = "D11", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 69, CustomerCode = "11000192", CustomerName = "บริษัท เดอะมอลล์ราชสีมา จำกัด", ShortName = "TM KORAT", AccountNo = "D11", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 70, CustomerCode = "11000195", CustomerName = "บริษัท หัวหิน รีเทล จำกัด", ShortName = "TM BLUEPOR", AccountNo = "D11", Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 71, CustomerCode = "11000061", CustomerName = "บริษัท ฟอร์ท เวนดิ้ง จำกัด", ShortName = "FORTH VEND", AccountNo = null, Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 72, CustomerCode = "11000106", CustomerName = "บริษัท ลาซาด้า จำกัด", ShortName = "LAZADA", AccountNo = null, Distributor = "AAI", CustomerGroup = null },
                new Customer { CustomerId = 73, CustomerCode = "11000131", CustomerName = "บริษัท เอสคอมเมิร์ซ (ประเทศไทย)จำกัด", ShortName = "S COMMERCE", AccountNo = null, Distributor = "AAI", CustomerGroup = null }
            };
            if (customers.Length > 0)
            {
                for (int i = 0; i < customers.Length; i++)
                {
                    customers[i].CreatedBy = "System";
                    customers[i].CreatedDate = DateTime.Now;
                }
                builder.Entity<Customer>().HasData(customers);
            }

            Channel[] channels = new Channel[]
            {
                new Channel { ChannelId = 1, ChannelCode = "MT", ChannelName = "Modern Trade", ChannelDesc = "MT - Modern Trade" },
                new Channel { ChannelId = 2, ChannelCode = "CN002", ChannelName = "VAN", ChannelDesc = "" },
                new Channel { ChannelId = 3, ChannelCode = "CN003", ChannelName = "Food Service", ChannelDesc = "" },
                new Channel { ChannelId = 4, ChannelCode = "CN004", ChannelName = "General Trade", ChannelDesc = "" },
                new Channel { ChannelId = 5, ChannelCode = "CN004", ChannelName = "General Trade", ChannelDesc = "" },
                new Channel { ChannelId = 6, ChannelCode = "CN004", ChannelName = "General Trade", ChannelDesc = "" }
            };
            if (channels.Length > 0)
            {
                for (int i = 0; i < channels.Length; i++)
                {
                    channels[i].CreatedBy = "System";
                    channels[i].CreatedDate = DateTime.Now;
                }
                builder.Entity<Channel>().HasData(channels);
            }

            TradeInvesment[] tradeInvesments = new TradeInvesment[]
            {
                new TradeInvesment { TradeInvesmentId = 1, ChannelId = 1, CustomerId = 1, TradeCode = "TINV001", TradeActivity = "Compensation" },
                new TradeInvesment { TradeInvesmentId = 2, ChannelId = 1, CustomerId = 1, TradeCode = "TINV002", TradeActivity = "Allowance" }
            };
            if (tradeInvesments.Length > 0)
            {
                for (int i = 0; i < tradeInvesments.Length; i++)
                {
                    tradeInvesments[i].CreatedBy = "System";
                    tradeInvesments[i].CreatedDate = DateTime.Now;
                }
                builder.Entity<TradeInvesment>().HasData(tradeInvesments);
            }

        }
        private static void SeedMasterProduct(this ModelBuilder builder)
        {

            Brand[] brands = new Brand[]
            {
                new Brand { BrandId = 1, BrandCode = "B001", BrandName = "CocoMax" }
            };
            
            if (brands.Length > 0)
            {
                for (int i = 0; i < brands.Length; i++)
                {
                    brands[i].CreatedBy = "System";
                    brands[i].CreatedDate = DateTime.Now;
                }
                builder.Entity<Brand>().HasData(brands);
            }

            ProductCategory[] productCategories = new ProductCategory[]
            {
                new ProductCategory { ProductCategoryId = 1, ProductCategoryName = "Beverage" }
            };
            if (productCategories.Length > 0)
            {
                /*
                for (int i = 0; i < productCategories.Length; i++)
                {
                    productCategories[i].CreatedBy = "System";
                    productCategories[i].CreatedDate = DateTime.Now;
                }
                */
                builder.Entity<ProductCategory>().HasData(productCategories);
            }

            Product[] products = new Product[]
            {
                new Product { ProductId = 1, ProductCategoryId = 1, BrandId = 1, ProductCode = "P001", ProductName = "Beer", SKU = "Beer-Premuim-Can-250cc", Width = null, Height = null, Size = "250cc", UOM = "UOM" },
                new Product { ProductId = 2, ProductCategoryId = 1, BrandId = 1, ProductCode = "P002", ProductName = "Beer", SKU = "Beer-Premuim-Can-500cc", Width = null, Height = null, Size = "500cc", UOM = "Can" },
                new Product { ProductId = 3, ProductCategoryId = 1, BrandId = 1, ProductCode = "P003", ProductName = "Beer", SKU = "Beer-Premuim-Bottom-750ml", Width = null, Height = null, Size = "750ml", UOM = "Can" },
                new Product { ProductId = 4, ProductCategoryId = 1, BrandId = 1, ProductCode = "P004", ProductName = "Beer", SKU = "Beer-Lager-4x3-Can Dozen-500cc", Width = 4, Height = 3, Size = "500cc", UOM = "Bottom" },
                new Product { ProductId = 5, ProductCategoryId = 1, BrandId = 1, ProductCode = "P005", ProductName = "Beer", SKU = "Beer-Lager-4x3-Bottom Dozen-750ml", Width = 4, Height = 3, Size = "750ml", UOM = "Can Dozen" },
                new Product { ProductId = 6, ProductCategoryId = 1, BrandId = 1, ProductCode = "P006", ProductName = "Beer", SKU = "Beer-Lager-Pack-750ml", Width = null, Height = null, Size = "750ml", UOM = "Bottom Dozen" },
                new Product { ProductId = 7, ProductCategoryId = 1, BrandId = 1, ProductCode = "P007", ProductName = "Water", SKU = "Water-RO-Bottom-600ml", Width = null, Height = null, Size = "600ml", UOM = "Pack" },
                new Product { ProductId = 8, ProductCategoryId = 1, BrandId = 1, ProductCode = "P008", ProductName = "Water", SKU = "Water-RO-Bottom-1000ml", Width = null, Height = null, Size = "1000ml", UOM = "Bottom" },
                new Product { ProductId = 9, ProductCategoryId = 1, BrandId = 1, ProductCode = "P009", ProductName = "Water", SKU = "Water-Mineral-Bottom-600ml", Width = null, Height = null, Size = "600ml", UOM = "Bottom" },
                new Product { ProductId = 10, ProductCategoryId = 1, BrandId = 1, ProductCode = "P010", ProductName = "Water", SKU = "Water-Mineral-Bottom-1000ml", Width = null, Height = null, Size = "1000ml", UOM = "Bottom" }
            };
            
            if (products.Length > 0)
            {
                for (int i = 0; i < products.Length; i++)
                {
                    products[i].CreatedBy = "System";
                    products[i].CreatedDate = DateTime.Now;
                }
                builder.Entity<Product>().HasData(products);
            }
        }
        private static void SeedMasterWorkflow(this ModelBuilder builder)
        {

            Workflow[] workflows = new Workflow[]
            {

                new Workflow { WorkflowId = 1, WorkflowName = "Fixed Contract workflow", BeginDate = DateTime.Now },
                new Workflow { WorkflowId = 2, WorkflowName = "Sale Forecast workflow", BeginDate = DateTime.Now },
                new Workflow { WorkflowId = 3, WorkflowName = "Budget Planing workflow", BeginDate = DateTime.Now }

            };

            if (workflows.Length > 0)
            {
                for (int i = 0; i < workflows.Length; i++)
                {
                    workflows[i].CreatedBy = "System";
                    workflows[i].CreatedDate = DateTime.Now;
                }
                builder.Entity<Workflow>().HasData(workflows);
            }

            FlowItem[] flowItems = new FlowItem[]
            {
                new FlowItem { FlowItemId = 1, FlowItemCode = "FI01", FlowItemName = "Submit" },
                new FlowItem { FlowItemId = 2, FlowItemCode = "FI02", FlowItemName = "Confirm" },
                new FlowItem { FlowItemId = 3, FlowItemCode = "FI03", FlowItemName = "Cancel" },
                new FlowItem { FlowItemId = 4, FlowItemCode = "FI04", FlowItemName = "Approve" },
                new FlowItem { FlowItemId = 5, FlowItemCode = "FI05", FlowItemName = "Reject" },
                new FlowItem { FlowItemId = 6, FlowItemCode = "FI06", FlowItemName = "Review" },
                new FlowItem { FlowItemId = 7, FlowItemCode = "FI07", FlowItemName = "Commit" }
            };

            if (flowItems.Length > 0)
            {
                for (int i = 0; i < flowItems.Length; i++)
                {

                }
                builder.Entity<FlowItem>().HasData(flowItems);
            }

            WorkflowActivity[] workflowActivities = new WorkflowActivity[]
            {
                new WorkflowActivity { ActivityId = 1, ActivityCode = "ATI001", ActivityName = "Entry", ActivityPiority = 1 },
                new WorkflowActivity { ActivityId = 2, ActivityCode = "ATI002", ActivityName = "Do", ActivityPiority = 2 },
                new WorkflowActivity { ActivityId = 3, ActivityCode = "ATI003", ActivityName = "Exit", ActivityPiority = 3 }
            };

            if (workflowActivities.Length > 0)
            {
                for (int i = 0; i < workflowActivities.Length; i++)
                {

                }

                builder.Entity<WorkflowActivity>().HasData(workflowActivities);
            }

            WorkflowAction[] workflowActions = new WorkflowAction[]
            {
                new WorkflowAction { ActionId = 1, ActionCode = "ACT001", ActionName = "Behavior", ActionPiority = 1 },
                new WorkflowAction { ActionId = 2, ActionCode = "ACT002", ActionName = "Activity", ActionPiority = 2 },
                new WorkflowAction { ActionId = 3, ActionCode = "ACT003", ActionName = "Interaction", ActionPiority = 3 }
            };

            if (workflowActions.Length > 0)
            {
                for (int i = 0; i < workflowActions.Length; i++)
                {

                }
                builder.Entity<WorkflowAction>().HasData(workflowActions);
            }


            StateProcess[] stateProcesses = new StateProcess[]
            {

                //FC Draft
                //new StateProcess(1, 1, 1, 3, "ATI001", "ACT003", "Entry", "Interaction", 1, 3),
                new StateProcess { StateProcessId = 1, WorkflowStateId = 1, ActivityId = 1, ActionId = 1, ActivityCode = "ATI001", ActionCode = "ACT003", ActivityName = "Entry", ActionName = "Interaction", ActivityPiority = 1, ActionPiority = 3 },
                new StateProcess(2, 2, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(3, 2, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(4, 2, 1, 3, "ATI002", "ACT003", "Do", "Interaction", 2, 3),//Comment
                new StateProcess(5, 3, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(6, 3, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(7, 3, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(8, 3, 1, 3, "ATI002", "ACT003", "Do", "Interaction", 2, 3),//Comment
                new StateProcess(9, 4, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(10, 4, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(11, 4, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(12, 4, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(13, 4, 1, 3, "ATI002", "ACT003", "Do", "Interaction", 2, 3),//Comment
                new StateProcess(14, 5, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(15, 5, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(16, 5, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(17, 5, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(18, 5, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(19, 5, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(20, 5, 1, 3, "ATI002", "ACT003", "Do", "Interaction", 2, 3),//Comment
                new StateProcess(21, 6, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(22, 6, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(23, 7, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(24, 7, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(25, 7, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(26, 8, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(27, 8, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(28, 8, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(29, 8, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(30, 9, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(31, 10, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                //SF Draft
                new StateProcess(32, 11, 1, 3, "ATI001", "ACT003", "Entry", "Interaction", 1, 3),
                new StateProcess(33, 12, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(34, 12, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(35, 12, 1, 3, "ATI002", "ACT003", "Do", "Interaction", 2, 3),//Comment
                new StateProcess(36, 13, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(37, 13, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(38, 13, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(39, 13, 1, 3, "ATI002", "ACT003", "Do", "Interaction", 2, 3),//Comment
                new StateProcess(40, 14, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(41, 14, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(42, 14, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(43, 14, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(44, 14, 1, 3, "ATI002", "ACT003", "Do", "Interaction", 2, 3),//Comment
                new StateProcess(45, 15, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(46, 15, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(47, 15, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(48, 15, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(49, 15, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(50, 15, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(51, 15, 1, 3, "ATI002", "ACT003", "Do", "Interaction", 2, 3),//Comment
                new StateProcess(52, 16, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(53, 16, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(54, 17, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(55, 17, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(56, 17, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(57, 18, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(58, 18, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(59, 18, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(60, 18, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(61, 19, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(62, 20, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                //BP Draft
                new StateProcess(63, 21, 1, 3, "ATI001", "ACT003", "Entry", "Interaction", 1, 3),
                new StateProcess(64, 22, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(65, 22, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(66, 22, 1, 3, "ATI002", "ACT003", "Do", "Interaction", 2, 3),//Comment
                new StateProcess(67, 23, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(68, 23, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(69, 23, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(70, 23, 1, 3, "ATI002", "ACT003", "Do", "Interaction", 2, 3),//Comment
                new StateProcess(71, 24, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(72, 24, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(73, 24, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(74, 24, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(75, 24, 1, 3, "ATI002", "ACT003", "Do", "Interaction", 2, 3),//Comment
                new StateProcess(76, 26, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(77, 26, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(78, 26, 1, 3, "ATI002", "ACT003", "Do", "Interaction", 2, 3),//Comment
                new StateProcess(79, 27, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(80, 27, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(81, 27, 1, 3, "ATI002", "ACT003", "Do", "Interaction", 2, 3),//Comment
                new StateProcess(82, 28, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(83, 28, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(84, 28, 1, 3, "ATI002", "ACT003", "Do", "Interaction", 2, 3),//Comment
                new StateProcess(85, 29, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(86, 29, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(87, 29, 1, 3, "ATI002", "ACT003", "Do", "Interaction", 2, 3),//Comment
                new StateProcess(88, 30, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(89, 30, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(90, 30, 1, 3, "ATI002", "ACT003", "Do", "Interaction", 2, 3),//Comment
                new StateProcess(91, 31, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(92, 31, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(93, 32, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(94, 32, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(95, 32, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(96, 33, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(97, 33, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(98, 33, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(99, 33, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(100, 35, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(101, 36, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(102, 36, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(103, 36, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(104, 37, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(105, 37, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(106, 37, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(107, 38, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(108, 38, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(109, 38, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(110, 39, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(111, 39, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(112, 39, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(113, 40, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(114, 40, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1),
                new StateProcess(115, 40, 1, 1, "ATI002", "ACT001", "Do", "Behavior", 2, 1)
            };

            if (stateProcesses.Length > 0)
            {
                for (int i = 0; i < stateProcesses.Length; i++)
                {

                }
                builder.Entity<StateProcess>().HasData(stateProcesses);
            }

            StateFlowItem[] stateFlowItems = new StateFlowItem[]
            {
                /* Fixed Contract Draft */
                new StateFlowItem { StateFlowItemId = 1, WorkflowStateId = 1, FlowItemId = 1, FlowItemCode = "FI01", FlowItemName = "Submit", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 2, WorkflowStateId = 1, FlowItemId = 3, FlowItemCode = "FI02", FlowItemName = "Confirm", Sort = 2, },
                new StateFlowItem { StateFlowItemId = 3, WorkflowStateId = 1, FlowItemId = 4, FlowItemCode = "FI03", FlowItemName = "Cancel", Sort = 3, },
                new StateFlowItem { StateFlowItemId = 4, WorkflowStateId = 2, FlowItemId = 4, FlowItemCode = "FI04", FlowItemName = "Approve", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 5, WorkflowStateId = 2, FlowItemId = 5, FlowItemCode = "FI05", FlowItemName = "Reject", Sort = 2, },
                new StateFlowItem { StateFlowItemId = 6, WorkflowStateId = 3, FlowItemId = 4, FlowItemCode = "FI04", FlowItemName = "Approve", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 7, WorkflowStateId = 3, FlowItemId = 5, FlowItemCode = "FI05", FlowItemName = "Reject", Sort = 2, },
                new StateFlowItem { StateFlowItemId = 8, WorkflowStateId = 4, FlowItemId = 4, FlowItemCode = "FI04", FlowItemName = "Approve", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 9, WorkflowStateId = 4, FlowItemId = 5, FlowItemCode = "FI05", FlowItemName = "Reject", Sort = 2, },
                new StateFlowItem { StateFlowItemId = 10, WorkflowStateId = 5, FlowItemId = 6, FlowItemCode = "FI06", FlowItemName = "Review", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 11, WorkflowStateId = 5, FlowItemId = 7, FlowItemCode = "FI07", FlowItemName = "Commit", Sort = 2, },

                /* Sale Forecast Draft */
                new StateFlowItem { StateFlowItemId = 12, WorkflowStateId = 11, FlowItemId = 1, FlowItemCode = "FI01", FlowItemName = "Submit", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 13, WorkflowStateId = 11, FlowItemId = 3, FlowItemCode = "FI02", FlowItemName = "Confirm", Sort = 2, },
                new StateFlowItem { StateFlowItemId = 14, WorkflowStateId = 11, FlowItemId = 4, FlowItemCode = "FI03", FlowItemName = "Cancel", Sort = 3, },
                new StateFlowItem { StateFlowItemId = 15, WorkflowStateId = 12, FlowItemId = 4, FlowItemCode = "FI04", FlowItemName = "Approve", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 16, WorkflowStateId = 12, FlowItemId = 5, FlowItemCode = "FI05", FlowItemName = "Reject", Sort = 2, },
                new StateFlowItem { StateFlowItemId = 17, WorkflowStateId = 13, FlowItemId = 4, FlowItemCode = "FI04", FlowItemName = "Approve", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 18, WorkflowStateId = 13, FlowItemId = 5, FlowItemCode = "FI05", FlowItemName = "Reject", Sort = 2, },
                new StateFlowItem { StateFlowItemId = 19, WorkflowStateId = 14, FlowItemId = 4, FlowItemCode = "FI04", FlowItemName = "Approve", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 20, WorkflowStateId = 14, FlowItemId = 5, FlowItemCode = "FI05", FlowItemName = "Reject", Sort = 2, },
                new StateFlowItem { StateFlowItemId = 21, WorkflowStateId = 15, FlowItemId = 6, FlowItemCode = "FI06", FlowItemName = "Review", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 22, WorkflowStateId = 15, FlowItemId = 7, FlowItemCode = "FI07", FlowItemName = "Commit", Sort = 2, },

                /* Budget Planing Draft */
                new StateFlowItem { StateFlowItemId = 23, WorkflowStateId = 21, FlowItemId = 1, FlowItemCode = "FI01", FlowItemName = "Submit", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 24, WorkflowStateId = 21, FlowItemId = 3, FlowItemCode = "FI02", FlowItemName = "Confirm", Sort = 2, },
                new StateFlowItem { StateFlowItemId = 25, WorkflowStateId = 21, FlowItemId = 4, FlowItemCode = "FI03", FlowItemName = "Cancel", Sort = 3, },
                new StateFlowItem { StateFlowItemId = 26, WorkflowStateId = 22, FlowItemId = 4, FlowItemCode = "FI04", FlowItemName = "Approve", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 27, WorkflowStateId = 22, FlowItemId = 5, FlowItemCode = "FI05", FlowItemName = "Reject", Sort = 2, },
                new StateFlowItem { StateFlowItemId = 28, WorkflowStateId = 23, FlowItemId = 4, FlowItemCode = "FI04", FlowItemName = "Approve", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 29, WorkflowStateId = 23, FlowItemId = 5, FlowItemCode = "FI05", FlowItemName = "Reject", Sort = 2, },
                new StateFlowItem { StateFlowItemId = 30, WorkflowStateId = 24, FlowItemId = 4, FlowItemCode = "FI04", FlowItemName = "Approve", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 31, WorkflowStateId = 24, FlowItemId = 5, FlowItemCode = "FI05", FlowItemName = "Reject", Sort = 2, },
                new StateFlowItem { StateFlowItemId = 32, WorkflowStateId = 25, FlowItemId = 4, FlowItemCode = "FI04", FlowItemName = "Approve", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 33, WorkflowStateId = 25, FlowItemId = 5, FlowItemCode = "FI05", FlowItemName = "Reject", Sort = 2, },
                new StateFlowItem { StateFlowItemId = 34, WorkflowStateId = 26, FlowItemId = 6, FlowItemCode = "FI06", FlowItemName = "Review", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 35, WorkflowStateId = 26, FlowItemId = 7, FlowItemCode = "FI07", FlowItemName = "Commit", Sort = 2, },
                new StateFlowItem { StateFlowItemId = 36, WorkflowStateId = 27, FlowItemId = 6, FlowItemCode = "FI06", FlowItemName = "Review", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 37, WorkflowStateId = 27, FlowItemId = 7, FlowItemCode = "FI07", FlowItemName = "Commit", Sort = 2, },
                new StateFlowItem { StateFlowItemId = 38, WorkflowStateId = 28, FlowItemId = 6, FlowItemCode = "FI06", FlowItemName = "Review", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 39, WorkflowStateId = 28, FlowItemId = 7, FlowItemCode = "FI07", FlowItemName = "Commit", Sort = 2, },
                new StateFlowItem { StateFlowItemId = 40, WorkflowStateId = 29, FlowItemId = 6, FlowItemCode = "FI06", FlowItemName = "Review", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 41, WorkflowStateId = 29, FlowItemId = 7, FlowItemCode = "FI07", FlowItemName = "Commit", Sort = 2, },
                new StateFlowItem { StateFlowItemId = 42, WorkflowStateId = 30, FlowItemId = 6, FlowItemCode = "FI06", FlowItemName = "Review", Sort = 1, },
                new StateFlowItem { StateFlowItemId = 43, WorkflowStateId = 30, FlowItemId = 7, FlowItemCode = "FI07", FlowItemName = "Commit", Sort = 2, }
            };
            if (stateFlowItems.Length > 0)
            {
                for (int i = 0; i < stateFlowItems.Length; i++)
                {

                }
                builder.Entity<StateFlowItem>().HasData(stateFlowItems);
            }

            WorkflowState[] workflowStates = new WorkflowState[]
            {
                //new table creadit limit 50k, 100k, 500k, 1M
                new WorkflowState { WorkflowStateId = 1,  PreviousStateId = null, WorkflowId = 1, StateName = "DRAFT", NotifySubject = "{DocNo} : Draft", NotifyMessage = "Draft" },
                new WorkflowState { WorkflowStateId = 2,  PreviousStateId = 1, WorkflowId = 1, StateName = "SM. Approval", NotifySubject = "{DocNo} : Approval", NotifyMessage = "SM. Approval" },
                new WorkflowState { WorkflowStateId = 3,  PreviousStateId = 2, WorkflowId = 1, StateName = "DM. Approval", NotifySubject = "{DocNo} : Approval", NotifyMessage = "DM. Approval" },
                new WorkflowState { WorkflowStateId = 4,  PreviousStateId = 3, WorkflowId = 1, StateName = "GM. Approval", NotifySubject = "{DocNo} : Approval", NotifyMessage = "GM. Approval" },
                new WorkflowState { WorkflowStateId = 5,  PreviousStateId = 4, WorkflowId = 1, StateName = "Accountant Reviewer", NotifySubject = "{DocNo} : Review", NotifyMessage = "ACC. Review" },
                new WorkflowState { WorkflowStateId = 6,  PreviousStateId = 2, WorkflowId = 1, StateName = "SM. Rejected", NotifySubject = "{DocNo} : Rejected", NotifyMessage = "SM. Rejected" },
                new WorkflowState { WorkflowStateId = 7,  PreviousStateId = 3, WorkflowId = 1, StateName = "DM. Rejected", NotifySubject = "{DocNo} : Rejected", NotifyMessage = "DM. Rejected" },
                new WorkflowState { WorkflowStateId = 8,  PreviousStateId = 4, WorkflowId = 1, StateName = "GM. Rejected", NotifySubject = "{DocNo} : Rejected", NotifyMessage = "GM. Rejected" },
                new WorkflowState { WorkflowStateId = 9,  PreviousStateId = 1, WorkflowId = 1, StateName = "Cancelled", NotifySubject = "{DocNo} : Cancelled", NotifyMessage = "Cancelled" },
                new WorkflowState { WorkflowStateId = 10, PreviousStateId = 6, WorkflowId = 1, StateName = "Completed", NotifySubject = "{DocNo} : Completed", NotifyMessage = "Completed" },

                new WorkflowState { WorkflowStateId = 11, PreviousStateId = null, WorkflowId = 2, StateName = "DRAFT", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 12, PreviousStateId = 12, WorkflowId = 2, StateName = "SM. Approval", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 13, PreviousStateId = 13, WorkflowId = 2, StateName = "DM. Approval", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 14, PreviousStateId = 14, WorkflowId = 2, StateName = "GM. Approval", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 15, PreviousStateId = 15, WorkflowId = 2, StateName = "Accountant Reviewer", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 16, PreviousStateId = 13, WorkflowId = 2, StateName = "SM. Rejected", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 17, PreviousStateId = 14, WorkflowId = 2, StateName = "DM. Rejected", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 18, PreviousStateId = 15, WorkflowId = 2, StateName = "GM. Rejected", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 19, PreviousStateId = 12, WorkflowId = 2, StateName = "Cancelled", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 20, PreviousStateId = 16, WorkflowId = 2, StateName = "Completed", NotifySubject = "", NotifyMessage = "" },

                new WorkflowState { WorkflowStateId = 21, PreviousStateId = null, WorkflowId = 3, StateName = "DRAFT", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 22, PreviousStateId = 21, WorkflowId = 3, StateName = "SM. Approval", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 23, PreviousStateId = 21, WorkflowId = 3, StateName = "DM. Approval", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 24, PreviousStateId = 21, WorkflowId = 3, StateName = "GM. Approval", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 25, PreviousStateId = 21, WorkflowId = 3, StateName = "CEO. Approval", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 26, PreviousStateId = 21, WorkflowId = 3, StateName = "Accountant Reviewer", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 27, PreviousStateId = 22, WorkflowId = 3, StateName = "Accountant Reviewer", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 28, PreviousStateId = 23, WorkflowId = 3, StateName = "Accountant Reviewer", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 29, PreviousStateId = 24, WorkflowId = 3, StateName = "Accountant Reviewer", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 30, PreviousStateId = 25, WorkflowId = 3, StateName = "Accountant Reviewer", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 31, PreviousStateId = 22, WorkflowId = 3, StateName = "SM. Rejected" , NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 32, PreviousStateId = 23, WorkflowId = 3, StateName = "DM. Rejected" , NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 33, PreviousStateId = 24, WorkflowId = 3, StateName = "GM. Rejected" , NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 34, PreviousStateId = 25, WorkflowId = 3, StateName = "CEO. Rejected", NotifySubject = "", NotifyMessage = "" },

                new WorkflowState { WorkflowStateId = 35, PreviousStateId = 21, WorkflowId = 3, StateName = "Cancelled", NotifySubject = "", NotifyMessage = "" },

                new WorkflowState { WorkflowStateId = 36, PreviousStateId = 26, WorkflowId = 3, StateName = "Completed", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 37, PreviousStateId = 27, WorkflowId = 3, StateName = "Completed", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 38, PreviousStateId = 28, WorkflowId = 3, StateName = "Completed", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 39, PreviousStateId = 29, WorkflowId = 3, StateName = "Completed", NotifySubject = "", NotifyMessage = "" },
                new WorkflowState { WorkflowStateId = 40, PreviousStateId = 30, WorkflowId = 3, StateName = "Completed", NotifySubject = "", NotifyMessage = "" }

            };

            if (workflowStates.Length > 0)
            {
                for (int i = 0; i < workflowStates.Length; i++)
                {

                }
                builder.Entity<WorkflowState>().HasData(workflowStates);
            }

            builder.Entity<Actor>().HasData
            (
                new Actor { ActorId = 1, ActorCode = "AC001", ActorName = "administrator@localhost", ActorEmail = "administrator@localhost" }
            );

            builder.Entity<OperatorCondition>().HasData
            (
                new OperatorCondition { OperatorConditionId = 1, OperatorCode = "<", OperatoDesc = "Less than ..." },
                new OperatorCondition { OperatorConditionId = 2, OperatorCode = "<=", OperatoDesc = "Less than or equal to ..." },
                new OperatorCondition { OperatorConditionId = 3, OperatorCode = ">", OperatoDesc = "Greater than ..." },
                new OperatorCondition { OperatorConditionId = 4, OperatorCode = ">=", OperatoDesc = "Greater than or equal to ..." },
                new OperatorCondition { OperatorConditionId = 5, OperatorCode = "=", OperatoDesc = "Equal to ..." },
                new OperatorCondition { OperatorConditionId = 6, OperatorCode = "!=", OperatoDesc = "Not equal to ..." },
                new OperatorCondition { OperatorConditionId = 7, OperatorCode = "None", OperatoDesc = "No have limit of approval" }
            );

            builder.Entity<ActorState>().HasData
            (
                //Fixed Contract
                new ActorState { ActorStateId = 1, WorkflowStateId = 1, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 2, WorkflowStateId = 2, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 3, WorkflowStateId = 2, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "SM", RoleState = "SM", LimitValue = null },
                new ActorState { ActorStateId = 4, WorkflowStateId = 3, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 5, WorkflowStateId = 3, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "SM", RoleState = "SM", LimitValue = null },
                new ActorState { ActorStateId = 6, WorkflowStateId = 3, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "DM", RoleState = "DM", LimitValue = null },
                new ActorState { ActorStateId = 7, WorkflowStateId = 4, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 8, WorkflowStateId = 4, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "SM", RoleState = "SM", LimitValue = null },
                new ActorState { ActorStateId = 9, WorkflowStateId = 4, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "DM", RoleState = "DM", LimitValue = null },
                new ActorState { ActorStateId = 10, WorkflowStateId = 4, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "GM", RoleState = "GM", LimitValue = null },
                new ActorState { ActorStateId = 11, WorkflowStateId = 5, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 12, WorkflowStateId = 5, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "SM", RoleState = "SM", LimitValue = null },
                new ActorState { ActorStateId = 13, WorkflowStateId = 5, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "DM", RoleState = "DM", LimitValue = null },
                new ActorState { ActorStateId = 14, WorkflowStateId = 5, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "GM", RoleState = "GM", LimitValue = null },
                new ActorState { ActorStateId = 15, WorkflowStateId = 5, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Accountant", RoleState = "ACC", LimitValue = null },
                new ActorState { ActorStateId = 16, WorkflowStateId = 5, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "CEO", RoleState = "CEO", LimitValue = null },
                new ActorState { ActorStateId = 17, WorkflowStateId = 6, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 18, WorkflowStateId = 6, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "SM", RoleState = "SM", LimitValue = null },
                new ActorState { ActorStateId = 19, WorkflowStateId = 7, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 20, WorkflowStateId = 7, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "SM", RoleState = "SM", LimitValue = null },
                new ActorState { ActorStateId = 21, WorkflowStateId = 7, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "DM", RoleState = "DM", LimitValue = null },
                new ActorState { ActorStateId = 22, WorkflowStateId = 8, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 23, WorkflowStateId = 8, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "SM", RoleState = "SM", LimitValue = null },
                new ActorState { ActorStateId = 24, WorkflowStateId = 8, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "DM", RoleState = "DM", LimitValue = null },
                new ActorState { ActorStateId = 25, WorkflowStateId = 8, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "GM", RoleState = "GM", LimitValue = null },
                new ActorState { ActorStateId = 26, WorkflowStateId = 9, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 27, WorkflowStateId = 10, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "CEO", RoleState = "CEO", LimitValue = null },

                //Sale forecast
                new ActorState { ActorStateId = 28, WorkflowStateId = 11, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 29, WorkflowStateId = 12, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 30, WorkflowStateId = 12, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "SM", RoleState = "SM", LimitValue = null },
                new ActorState { ActorStateId = 31, WorkflowStateId = 13, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 32, WorkflowStateId = 13, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "SM", RoleState = "SM", LimitValue = null },
                new ActorState { ActorStateId = 33, WorkflowStateId = 13, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "DM", RoleState = "DM", LimitValue = null },
                new ActorState { ActorStateId = 34, WorkflowStateId = 14, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 35, WorkflowStateId = 14, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "SM", RoleState = "SM", LimitValue = null },
                new ActorState { ActorStateId = 36, WorkflowStateId = 14, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "DM", RoleState = "DM", LimitValue = null },
                new ActorState { ActorStateId = 37, WorkflowStateId = 14, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "GM", RoleState = "GM", LimitValue = null },
                new ActorState { ActorStateId = 38, WorkflowStateId = 15, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 39, WorkflowStateId = 15, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "SM", RoleState = "SM", LimitValue = null },
                new ActorState { ActorStateId = 40, WorkflowStateId = 15, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "DM", RoleState = "DM", LimitValue = null },
                new ActorState { ActorStateId = 41, WorkflowStateId = 15, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "GM", RoleState = "GM", LimitValue = null },
                new ActorState { ActorStateId = 42, WorkflowStateId = 15, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Accountant", RoleState = "ACC", LimitValue = null },
                new ActorState { ActorStateId = 43, WorkflowStateId = 15, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "CEO", RoleState = "CEO", LimitValue = null },
                new ActorState { ActorStateId = 44, WorkflowStateId = 16, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 45, WorkflowStateId = 16, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "SM", RoleState = "SM", LimitValue = null },
                new ActorState { ActorStateId = 46, WorkflowStateId = 17, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 47, WorkflowStateId = 17, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "SM", RoleState = "SM", LimitValue = null },
                new ActorState { ActorStateId = 48, WorkflowStateId = 17, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "DM", RoleState = "DM", LimitValue = null },
                new ActorState { ActorStateId = 49, WorkflowStateId = 18, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 50, WorkflowStateId = 18, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "SM", RoleState = "SM", LimitValue = null },
                new ActorState { ActorStateId = 51, WorkflowStateId = 18, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "DM", RoleState = "DM", LimitValue = null },
                new ActorState { ActorStateId = 52, WorkflowStateId = 18, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "GM", RoleState = "GM", LimitValue = null },
                new ActorState { ActorStateId = 53, WorkflowStateId = 19, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 54, WorkflowStateId = 20, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "CEO", RoleState = "CEO", LimitValue = null },

                //Budget Planing
                //Draft
                new ActorState { ActorStateId = 55, WorkflowStateId = 21, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                //Approval
                new ActorState { ActorStateId = 56, WorkflowStateId = 22, ActorId = 1, OperatorConditionId = 2, OperatorCode = "<=", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "SM", RoleState = "SM", LimitValue = 50_000m },
                new ActorState { ActorStateId = 57, WorkflowStateId = 22, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 58, WorkflowStateId = 23, ActorId = 1, OperatorConditionId = 2, OperatorCode = "<=", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "DM", RoleState = "DM", LimitValue = 100_000m },
                new ActorState { ActorStateId = 59, WorkflowStateId = 23, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 60, WorkflowStateId = 24, ActorId = 1, OperatorConditionId = 2, OperatorCode = "<=", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "GM", RoleState = "GM", LimitValue = 500_000m },
                new ActorState { ActorStateId = 61, WorkflowStateId = 24, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 62, WorkflowStateId = 25, ActorId = 1, OperatorConditionId = 2, OperatorCode = ">=", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "CEO", RoleState = "CEO", LimitValue = 1_000_000m },
                new ActorState { ActorStateId = 63, WorkflowStateId = 25, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                //Reviwer
                new ActorState { ActorStateId = 64, WorkflowStateId = 26, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Accountant", RoleState = "Accountant", LimitValue = null },
                new ActorState { ActorStateId = 65, WorkflowStateId = 26, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 66, WorkflowStateId = 26, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "CEO", RoleState = "CEO", LimitValue = null },
                new ActorState { ActorStateId = 67, WorkflowStateId = 27, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Accountant", RoleState = "Accountant", LimitValue = null },
                new ActorState { ActorStateId = 68, WorkflowStateId = 27, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 69, WorkflowStateId = 27, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "CEO", RoleState = "CEO", LimitValue = null },
                new ActorState { ActorStateId = 70, WorkflowStateId = 28, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Accountant", RoleState = "Accountant", LimitValue = null },
                new ActorState { ActorStateId = 71, WorkflowStateId = 28, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 72, WorkflowStateId = 28, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "CEO", RoleState = "CEO", LimitValue = null },
                new ActorState { ActorStateId = 73, WorkflowStateId = 29, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Accountant", RoleState = "Accountant", LimitValue = null },
                new ActorState { ActorStateId = 74, WorkflowStateId = 29, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 75, WorkflowStateId = 29, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "CEO", RoleState = "CEO", LimitValue = null },
                new ActorState { ActorStateId = 76, WorkflowStateId = 30, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Accountant", RoleState = "Accountant", LimitValue = null },
                new ActorState { ActorStateId = 77, WorkflowStateId = 30, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 78, WorkflowStateId = 30, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "CEO", RoleState = "CEO", LimitValue = null },
                //Reject
                new ActorState { ActorStateId = 79, WorkflowStateId = 31, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "SM", RoleState = "SM", LimitValue = null },
                new ActorState { ActorStateId = 80, WorkflowStateId = 31, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 81, WorkflowStateId = 32, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "DM", RoleState = "DM", LimitValue = null },
                new ActorState { ActorStateId = 82, WorkflowStateId = 32, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 83, WorkflowStateId = 33, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "GM", RoleState = "GM", LimitValue = null },
                new ActorState { ActorStateId = 84, WorkflowStateId = 33, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 85, WorkflowStateId = 34, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "CEO", RoleState = "CEO", LimitValue = null },
                new ActorState { ActorStateId = 86, WorkflowStateId = 34, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                //Cancelled
                new ActorState { ActorStateId = 87, WorkflowStateId = 35, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },

                //Completed
                new ActorState { ActorStateId = 88, WorkflowStateId = 36, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Accountant", RoleState = "Accountant", LimitValue = null },
                new ActorState { ActorStateId = 89, WorkflowStateId = 36, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 90, WorkflowStateId = 36, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "CEO", RoleState = "CEO", LimitValue = null },
                new ActorState { ActorStateId = 91, WorkflowStateId = 37, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Accountant", RoleState = "Accountant", LimitValue = null },
                new ActorState { ActorStateId = 92, WorkflowStateId = 37, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 93, WorkflowStateId = 37, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "CEO", RoleState = "CEO", LimitValue = null },
                new ActorState { ActorStateId = 94, WorkflowStateId = 38, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Accountant", RoleState = "Accountant", LimitValue = null },
                new ActorState { ActorStateId = 95, WorkflowStateId = 38, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 96, WorkflowStateId = 38, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "CEO", RoleState = "CEO", LimitValue = null },
                new ActorState { ActorStateId = 97, WorkflowStateId = 39, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Accountant", RoleState = "Accountant", LimitValue = null },
                new ActorState { ActorStateId = 98, WorkflowStateId = 39, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 99, WorkflowStateId = 39, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "CEO", RoleState = "CEO", LimitValue = null },
                new ActorState { ActorStateId = 100, WorkflowStateId = 40, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Accountant", RoleState = "Accountant", LimitValue = null },
                new ActorState { ActorStateId = 101, WorkflowStateId = 40, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "Sales", RoleState = "Sales", LimitValue = null },
                new ActorState { ActorStateId = 102, WorkflowStateId = 40, ActorId = 1, OperatorConditionId = 7, OperatorCode = "None", ContactType = "EMAIL", User = "panupong.k@itsmart.co.th", Position = "CEO", RoleState = "CEO", LimitValue = null }

            );

        }

    }
}
