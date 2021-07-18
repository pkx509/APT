using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GFCA.Infrastructure.Persistence.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(maxLength: 200, nullable: true),
                    ClientId = table.Column<string>(maxLength: 200, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Expiration = table.Column<DateTime>(nullable: false),
                    Data = table.Column<string>(maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(maxLength: 200, nullable: false),
                    Type = table.Column<string>(maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(maxLength: 200, nullable: true),
                    ClientId = table.Column<string>(maxLength: 200, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Expiration = table.Column<DateTime>(nullable: true),
                    Data = table.Column<string>(maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Actor",
                schema: "dbo",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    ActorName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    ActorEmail = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 4)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.ActorId);
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                schema: "dbo",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())")
                        .Annotation("ColumnOrder", 102),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 103),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 104),
                    BrandCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    BrandName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 3)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "BudgetType",
                schema: "dbo",
                columns: table => new
                {
                    BudgetTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BudgetTypeCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    BudgetTypeName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    BudgetTypeDesc = table.Column<string>(type: "varchar(max)", nullable: true)
                        .Annotation("ColumnOrder", 4)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetType", x => x.BudgetTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                schema: "dbo",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())")
                        .Annotation("ColumnOrder", 102),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 103),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 104),
                    CompanyCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    CompanyName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    Address = table.Column<string>(type: "varchar(max)", nullable: true)
                        .Annotation("ColumnOrder", 4)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                schema: "dbo",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())")
                        .Annotation("ColumnOrder", 102),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 103),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 104),
                    CustomerCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    CustomerName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    ShortName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 5),
                    AccountNo = table.Column<string>(type: "varchar(150)", nullable: true)
                        .Annotation("ColumnOrder", 7),
                    CustomerGroup = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 4),
                    Distributor = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 6)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "FlowItem",
                schema: "dbo",
                columns: table => new
                {
                    FlowItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlowItemCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    FlowItemName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 3)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowItem", x => x.FlowItemId);
                });

            migrationBuilder.CreateTable(
                name: "GLGroup",
                schema: "dbo",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    GroupName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    GroupPolicy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 2)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLGroup", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "OperatorCondition",
                schema: "dbo",
                columns: table => new
                {
                    OperatorConditionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperatorCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    OperatoDesc = table.Column<string>(type: "varchar(max)", nullable: true)
                        .Annotation("ColumnOrder", 3)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatorCondition", x => x.OperatorConditionId);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                schema: "dbo",
                columns: table => new
                {
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCategoryName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 2)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.ProductCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "SourceFund",
                schema: "dbo",
                columns: table => new
                {
                    SourceFundId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FundCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    FundName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    FundDesc = table.Column<string>(type: "varchar(max)", nullable: true)
                        .Annotation("ColumnOrder", 4)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourceFund", x => x.SourceFundId);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                schema: "dbo",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())")
                        .Annotation("ColumnOrder", 102),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 103),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 104),
                    SupplierCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    SupplierName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 3)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "tb_email_inbound",
                schema: "dbo",
                columns: table => new
                {
                    email_id = table.Column<int>(nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())")
                        .Annotation("ColumnOrder", 102),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 103),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 104),
                    from_email = table.Column<string>(type: "varchar(200)", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    data_path = table.Column<string>(type: "varchar(4000)", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    is_active = table.Column<int>(type: "int", nullable: false, defaultValueSql: "0")
                        .Annotation("ColumnOrder", 4),
                    remark = table.Column<string>(type: "varchar(4000)", nullable: true)
                        .Annotation("ColumnOrder", 5)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_email_inbound", x => x.email_id);
                });

            migrationBuilder.CreateTable(
                name: "Workflow",
                schema: "dbo",
                columns: table => new
                {
                    WorkflowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())")
                        .Annotation("ColumnOrder", 102),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 103),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 104),
                    WorkflowName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    WorkflowDesc = table.Column<string>(type: "varchar(max)", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    BeginDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("ColumnOrder", 4),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("ColumnOrder", 5)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workflow", x => x.WorkflowId);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowAction",
                schema: "dbo",
                columns: table => new
                {
                    ActionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    ActionName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    ActionPiority = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 4)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowAction", x => x.ActionId);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowActivity",
                schema: "dbo",
                columns: table => new
                {
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    ActivityName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    ActivityPiority = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 4)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowActivity", x => x.ActivityId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                schema: "dbo",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())")
                        .Annotation("ColumnOrder", 102),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 103),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 104),
                    DepartmentCode = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("ColumnOrder", 6),
                    DepartmentName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 7),
                    CompanyCode = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("ColumnOrder", 3),
                    BranchCode = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("ColumnOrder", 4),
                    BranchName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 5),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 2)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                    table.UniqueConstraint("AK_Department_CompanyCode_BranchCode_DepartmentCode", x => new { x.CompanyCode, x.BranchCode, x.DepartmentCode });
                    table.ForeignKey(
                        name: "FK_Department_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "dbo",
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Channel",
                schema: "dbo",
                columns: table => new
                {
                    ChannelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())")
                        .Annotation("ColumnOrder", 102),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 103),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 104),
                    ChannelCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    ChannelName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    ChannelDesc = table.Column<string>(type: "varchar(max)", nullable: true)
                        .Annotation("ColumnOrder", 4),
                    CustomerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channel", x => x.ChannelId);
                    table.ForeignKey(
                        name: "FK_Channel_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "dbo",
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GLAccount",
                schema: "dbo",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())")
                        .Annotation("ColumnOrder", 102),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 103),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 104),
                    GLCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    GLName = table.Column<string>(type: "varchar(200)", nullable: true)
                        .Annotation("ColumnOrder", 4),
                    Purpose = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 5),
                    Remark = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 6),
                    GLGroupId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 2)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLAccount", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_GLAccount_GLGroup_GLGroupId",
                        column: x => x.GLGroupId,
                        principalSchema: "dbo",
                        principalTable: "GLGroup",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerProduct",
                schema: "dbo",
                columns: table => new
                {
                    CustomerProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 2),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 3)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProduct", x => x.CustomerProductId);
                    table.UniqueConstraint("AK_CustomerProduct_CustomerId_ProductCategoryId", x => new { x.CustomerId, x.ProductCategoryId });
                    table.ForeignKey(
                        name: "FK_CustomerProduct_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "dbo",
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerProduct_ProductCategory_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalSchema: "dbo",
                        principalTable: "ProductCategory",
                        principalColumn: "ProductCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "dbo",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())")
                        .Annotation("ColumnOrder", 102),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 103),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 104),
                    ProductCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 6),
                    ProductName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 7),
                    SKU = table.Column<string>(type: "varchar(200)", nullable: true)
                        .Annotation("ColumnOrder", 8),
                    Color = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 9),
                    Width = table.Column<decimal>(type: "numeric(8,2)", nullable: true)
                        .Annotation("ColumnOrder", 10),
                    Height = table.Column<decimal>(type: "numeric(8,2)", nullable: true)
                        .Annotation("ColumnOrder", 12),
                    Weight = table.Column<decimal>(type: "numeric(8,2)", nullable: true)
                        .Annotation("ColumnOrder", 11),
                    Shape = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 13),
                    Size = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 14),
                    QTY = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 15),
                    UOM = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 16),
                    LTP = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 17),
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 3),
                    BrandCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 4),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 2),
                    ProductCategoryName = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 5)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Brand_BrandId",
                        column: x => x.BrandId,
                        principalSchema: "dbo",
                        principalTable: "Brand",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalSchema: "dbo",
                        principalTable: "ProductCategory",
                        principalColumn: "ProductCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CostCenter",
                schema: "dbo",
                columns: table => new
                {
                    CostCenterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CenterCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 4),
                    CenterName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 5),
                    Site = table.Column<string>(type: "varchar(max)", nullable: true)
                        .Annotation("ColumnOrder", 6),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    SourceFundId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 3)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostCenter", x => x.CostCenterId);
                    table.ForeignKey(
                        name: "FK_CostCenter_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "dbo",
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CostCenter_SourceFund_SourceFundId",
                        column: x => x.SourceFundId,
                        principalSchema: "dbo",
                        principalTable: "SourceFund",
                        principalColumn: "SourceFundId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocumentType",
                schema: "dbo",
                columns: table => new
                {
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())")
                        .Annotation("ColumnOrder", 102),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 103),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 104),
                    DocumentTypeCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    DocumentTypeName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 4),
                    DocumentTypeDesc = table.Column<string>(type: "varchar(max)", nullable: true)
                        .Annotation("ColumnOrder", 5),
                    WorkflowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 2)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentType", x => x.DocumentTypeId);
                    table.ForeignKey(
                        name: "FK_DocumentType_Workflow_WorkflowId",
                        column: x => x.WorkflowId,
                        principalSchema: "dbo",
                        principalTable: "Workflow",
                        principalColumn: "WorkflowId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowState",
                schema: "dbo",
                columns: table => new
                {
                    WorkflowStateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 4),
                    StateDesc = table.Column<string>(type: "varchar(max)", nullable: true)
                        .Annotation("ColumnOrder", 5),
                    NotifySubject = table.Column<string>(type: "varchar(200)", nullable: true)
                        .Annotation("ColumnOrder", 6),
                    NotifyMessage = table.Column<string>(type: "varchar(max)", nullable: true)
                        .Annotation("ColumnOrder", 7),
                    BeginDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                        .Annotation("ColumnOrder", 8),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "cast('9999-12-31T11:59:59' as datetime)")
                        .Annotation("ColumnOrder", 9),
                    WorkflowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 3),
                    PreviousStateId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 2)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowState", x => x.WorkflowStateId);
                    table.ForeignKey(
                        name: "FK_WorkflowState_WorkflowState_PreviousStateId",
                        column: x => x.PreviousStateId,
                        principalSchema: "dbo",
                        principalTable: "WorkflowState",
                        principalColumn: "WorkflowStateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkflowState_Workflow_WorkflowId",
                        column: x => x.WorkflowId,
                        principalSchema: "dbo",
                        principalTable: "Workflow",
                        principalColumn: "WorkflowId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                schema: "dbo",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())")
                        .Annotation("ColumnOrder", 102),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 103),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 104),
                    EmployeeCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    Prefix = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 4),
                    FirstName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 5),
                    LastName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 6),
                    Position = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 7),
                    Email = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 9),
                    Salary = table.Column<decimal>(type: "numeric(8,2)", nullable: false)
                        .Annotation("ColumnOrder", 8),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 2)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "dbo",
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierCustomer",
                schema: "dbo",
                columns: table => new
                {
                    SupplierCustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())")
                        .Annotation("ColumnOrder", 102),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 103),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 104),
                    BrandId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    ChannelId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 5),
                    SupplierId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 4),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 6)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierCustomer", x => x.SupplierCustomerId);
                    table.ForeignKey(
                        name: "FK_SupplierCustomer_Brand_BrandId",
                        column: x => x.BrandId,
                        principalSchema: "dbo",
                        principalTable: "Brand",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierCustomer_Channel_ChannelId",
                        column: x => x.ChannelId,
                        principalSchema: "dbo",
                        principalTable: "Channel",
                        principalColumn: "ChannelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierCustomer_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "dbo",
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierCustomer_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalSchema: "dbo",
                        principalTable: "Supplier",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TradeActivity",
                schema: "dbo",
                columns: table => new
                {
                    TradeActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())")
                        .Annotation("ColumnOrder", 102),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 103),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 104),
                    AccountId = table.Column<int>(nullable: false),
                    ActivityType = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    ActivityCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    ActivityName = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 4),
                    FixedContract = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("ColumnOrder", 5),
                    Deductable = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("ColumnOrder", 6),
                    SaleInTHBCS = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("ColumnOrder", 7),
                    SaleInGrossSale = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("ColumnOrder", 8),
                    SaleInNotSale = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("ColumnOrder", 9),
                    SaleOutTHBCS = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("ColumnOrder", 10),
                    SaleOutGrossSale = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("ColumnOrder", 11),
                    SaleOutNotSale = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("ColumnOrder", 12),
                    NotRelateSaleAbsAmt = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("ColumnOrder", 13),
                    Remark = table.Column<string>(type: "varchar(max)", nullable: true)
                        .Annotation("ColumnOrder", 14)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeActivity", x => x.TradeActivityId);
                    table.ForeignKey(
                        name: "FK_TradeActivity_GLAccount_AccountId",
                        column: x => x.AccountId,
                        principalSchema: "dbo",
                        principalTable: "GLAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TradeInvesment",
                schema: "dbo",
                columns: table => new
                {
                    TradeInvesmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())")
                        .Annotation("ColumnOrder", 102),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 103),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 104),
                    TradeCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    TradeName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    TradeActivity = table.Column<string>(nullable: true),
                    SubGroup = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 4),
                    DataSource = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 5),
                    IsFixedContract = table.Column<bool>(type: "bit", nullable: false)
                        .Annotation("ColumnOrder", 6),
                    Deductable = table.Column<bool>(type: "bit", nullable: false)
                        .Annotation("ColumnOrder", 7),
                    ToleranceLevel = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 8),
                    ToleranceLower = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 9),
                    ToleranceUpper = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 10),
                    CostElement = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 11),
                    ChannelId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    AccountId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeInvesment", x => x.TradeInvesmentId);
                    table.ForeignKey(
                        name: "FK_TradeInvesment_GLAccount_AccountId",
                        column: x => x.AccountId,
                        principalSchema: "dbo",
                        principalTable: "GLAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TradeInvesment_Channel_ChannelId",
                        column: x => x.ChannelId,
                        principalSchema: "dbo",
                        principalTable: "Channel",
                        principalColumn: "ChannelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TradeInvesment_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "dbo",
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                schema: "dbo",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())")
                        .Annotation("ColumnOrder", 102),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 103),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 104),
                    ReferenceNo = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 9),
                    DocumentYear = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 7),
                    DocumentMonth = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 8),
                    Version = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 18),
                    Revision = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 19),
                    ClientCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 10),
                    ClientName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 11),
                    CustomerCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 14),
                    CustomerName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 15),
                    ChannelCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 12),
                    ChannelName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 13),
                    TotalSale = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 16),
                    TotalInvestment = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 17),
                    CurrentStateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 20),
                    CurrentState = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 21),
                    NextStateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 22),
                    NextState = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 23),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    DocumentTypeCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 6),
                    SupplierId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    ChannelId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 4),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 5)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.DocumentId);
                    table.ForeignKey(
                        name: "FK_Document_Channel_ChannelId",
                        column: x => x.ChannelId,
                        principalSchema: "dbo",
                        principalTable: "Channel",
                        principalColumn: "ChannelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Document_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "dbo",
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Document_DocumentType_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalSchema: "dbo",
                        principalTable: "DocumentType",
                        principalColumn: "DocumentTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Document_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalSchema: "dbo",
                        principalTable: "Supplier",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActorState",
                schema: "dbo",
                columns: table => new
                {
                    ActorStateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactType = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 4),
                    RoleState = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 5),
                    User = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 6),
                    Position = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 7),
                    OperatorConditionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 8),
                    OperatorCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 9),
                    LimitValue = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 10),
                    ActorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 3),
                    WorkflowStateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 2)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorState", x => x.ActorStateId);
                    table.ForeignKey(
                        name: "FK_ActorState_Actor_ActorId",
                        column: x => x.ActorId,
                        principalSchema: "dbo",
                        principalTable: "Actor",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActorState_OperatorCondition_OperatorConditionId",
                        column: x => x.OperatorConditionId,
                        principalSchema: "dbo",
                        principalTable: "OperatorCondition",
                        principalColumn: "OperatorConditionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActorState_WorkflowState_WorkflowStateId",
                        column: x => x.WorkflowStateId,
                        principalSchema: "dbo",
                        principalTable: "WorkflowState",
                        principalColumn: "WorkflowStateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StateFlowItem",
                schema: "dbo",
                columns: table => new
                {
                    StateFlowItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlowItemCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 4),
                    FlowItemName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 5),
                    Sort = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 6),
                    WorkflowStateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 2),
                    FlowItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 3)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateFlowItem", x => x.StateFlowItemId);
                    table.ForeignKey(
                        name: "FK_StateFlowItem_FlowItem_FlowItemId",
                        column: x => x.FlowItemId,
                        principalSchema: "dbo",
                        principalTable: "FlowItem",
                        principalColumn: "FlowItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StateFlowItem_WorkflowState_WorkflowStateId",
                        column: x => x.WorkflowStateId,
                        principalSchema: "dbo",
                        principalTable: "WorkflowState",
                        principalColumn: "WorkflowStateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StateProcess",
                schema: "dbo",
                columns: table => new
                {
                    StateProcessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 5),
                    ActivityName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 7),
                    ActionPiority = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 10),
                    ActionCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 6),
                    ActionName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 8),
                    ActivityPiority = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 9),
                    WorkflowStateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 2),
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 4),
                    ActionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 3)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateProcess", x => x.StateProcessId);
                    table.ForeignKey(
                        name: "FK_StateProcess_WorkflowAction_ActionId",
                        column: x => x.ActionId,
                        principalSchema: "dbo",
                        principalTable: "WorkflowAction",
                        principalColumn: "ActionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StateProcess_WorkflowActivity_ActivityId",
                        column: x => x.ActivityId,
                        principalSchema: "dbo",
                        principalTable: "WorkflowActivity",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StateProcess_WorkflowState_WorkflowStateId",
                        column: x => x.WorkflowStateId,
                        principalSchema: "dbo",
                        principalTable: "WorkflowState",
                        principalColumn: "WorkflowStateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Budget",
                schema: "dbo",
                columns: table => new
                {
                    BudgetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())")
                        .Annotation("ColumnOrder", 102),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 103),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 104),
                    ActualLastYear = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 5),
                    BudgetValue = table.Column<decimal>(type: "numeric(13,4)", nullable: false)
                        .Annotation("ColumnOrder", 6),
                    BudgetTargetInYear = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 7),
                    PercentContribution = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 8),
                    SaleInvesment = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 9),
                    BrandId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 4),
                    DocumentId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    BudgetTypeId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    CostCenterId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 10),
                    CenterName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 11),
                    SourceFundId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 12),
                    FundName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 13)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budget", x => x.BudgetId);
                    table.ForeignKey(
                        name: "FK_Budget_Brand_BrandId",
                        column: x => x.BrandId,
                        principalSchema: "dbo",
                        principalTable: "Brand",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Budget_BudgetType_BudgetTypeId",
                        column: x => x.BudgetTypeId,
                        principalSchema: "dbo",
                        principalTable: "BudgetType",
                        principalColumn: "BudgetTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Budget_CostCenter_CostCenterId",
                        column: x => x.CostCenterId,
                        principalSchema: "dbo",
                        principalTable: "CostCenter",
                        principalColumn: "CostCenterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Budget_Document_DocumentId",
                        column: x => x.DocumentId,
                        principalSchema: "dbo",
                        principalTable: "Document",
                        principalColumn: "DocumentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Budget_SourceFund_SourceFundId",
                        column: x => x.SourceFundId,
                        principalSchema: "dbo",
                        principalTable: "SourceFund",
                        principalColumn: "SourceFundId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocumentAction",
                schema: "dbo",
                columns: table => new
                {
                    DocumentActionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 5),
                    Comment = table.Column<string>(type: "varchar(max)", nullable: true)
                        .Annotation("ColumnOrder", 6),
                    ActorId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    ActorName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 4),
                    DocumentId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 2)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentAction", x => x.DocumentActionId);
                    table.ForeignKey(
                        name: "FK_DocumentAction_Actor_ActorId",
                        column: x => x.ActorId,
                        principalSchema: "dbo",
                        principalTable: "Actor",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DocumentAction_Document_DocumentId",
                        column: x => x.DocumentId,
                        principalSchema: "dbo",
                        principalTable: "Document",
                        principalColumn: "DocumentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FixedContract",
                schema: "dbo",
                columns: table => new
                {
                    FixedContractId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())")
                        .Annotation("ColumnOrder", 102),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 103),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 104),
                    ConditionType = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 6),
                    ContractCategory = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 7),
                    ContractDesc = table.Column<string>(type: "varchar(max)", nullable: true)
                        .Annotation("ColumnOrder", 8),
                    UOM = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 9),
                    DateRefForm = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 10),
                    M01JAN = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 51),
                    M02FEB = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 52),
                    M03MAR = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 53),
                    M04APR = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 54),
                    M05MAY = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 55),
                    M06JUN = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 56),
                    M07JUL = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 57),
                    M08AUG = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 58),
                    M09SEP = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 59),
                    M10OCT = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 60),
                    M11NOV = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 61),
                    M12DEC = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 62),
                    DocumentId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 2),
                    AccountId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 3),
                    CostCenterId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 4),
                    BrandId = table.Column<int>(nullable: true),
                    TradeInvesmentId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("ColumnOrder", 5)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixedContract", x => x.FixedContractId);
                    table.ForeignKey(
                        name: "FK_FixedContract_GLAccount_AccountId",
                        column: x => x.AccountId,
                        principalSchema: "dbo",
                        principalTable: "GLAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FixedContract_Brand_BrandId",
                        column: x => x.BrandId,
                        principalSchema: "dbo",
                        principalTable: "Brand",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FixedContract_CostCenter_CostCenterId",
                        column: x => x.CostCenterId,
                        principalSchema: "dbo",
                        principalTable: "CostCenter",
                        principalColumn: "CostCenterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FixedContract_Document_DocumentId",
                        column: x => x.DocumentId,
                        principalSchema: "dbo",
                        principalTable: "Document",
                        principalColumn: "DocumentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FixedContract_TradeInvesment_TradeInvesmentId",
                        column: x => x.TradeInvesmentId,
                        principalSchema: "dbo",
                        principalTable: "TradeInvesment",
                        principalColumn: "TradeInvesmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SaleForecast",
                schema: "dbo",
                columns: table => new
                {
                    SaleForecastId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 1)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())")
                        .Annotation("ColumnOrder", 102),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 103),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                        .Annotation("ColumnOrder", 104),
                    ForecastType = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 5),
                    M01JAN = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 51),
                    M02FEB = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 52),
                    M03MAR = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 53),
                    M04APR = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 54),
                    M05MAY = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 55),
                    M06JUN = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 56),
                    M07JUL = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 57),
                    M08AUG = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 58),
                    M09SEP = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 59),
                    M10OCT = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 60),
                    M11NOV = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 61),
                    M12DEC = table.Column<decimal>(type: "numeric(13,4)", nullable: true)
                        .Annotation("ColumnOrder", 62),
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 2),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 3),
                    ProductCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 4),
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("ColumnOrder", 6),
                    BrandCode = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("ColumnOrder", 7),
                    BrandName = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("ColumnOrder", 8)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleForecast", x => x.SaleForecastId);
                    table.ForeignKey(
                        name: "FK_SaleForecast_Brand_BrandId",
                        column: x => x.BrandId,
                        principalSchema: "dbo",
                        principalTable: "Brand",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleForecast_Document_DocumentId",
                        column: x => x.DocumentId,
                        principalSchema: "dbo",
                        principalTable: "Document",
                        principalColumn: "DocumentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleForecast_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "dbo",
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Actor",
                columns: new[] { "ActorId", "ActorCode", "ActorEmail", "ActorName" },
                values: new object[] { 1, "AC001", "administrator@localhost", "administrator@localhost" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Brand",
                columns: new[] { "BrandId", "BrandCode", "BrandName", "CreatedBy", "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "B001", "CocoMax", "System", new DateTime(2021, 5, 16, 16, 37, 1, 319, DateTimeKind.Local).AddTicks(6460), null, null });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BudgetType",
                columns: new[] { "BudgetTypeId", "BudgetTypeCode", "BudgetTypeDesc", "BudgetTypeName" },
                values: new object[,]
                {
                    { 4, "BTS02", "Sale of % Sales Growth", "% Sales Growth" },
                    { 1, "BTI01", "Invesment Value", "Value" },
                    { 3, "BTS01", "Sale of Value", "Value" },
                    { 2, "BTI02", "Invesment of % Sales Growth", "% Sales Growth" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Channel",
                columns: new[] { "ChannelId", "ChannelCode", "ChannelDesc", "ChannelName", "CreatedBy", "CreatedDate", "CustomerId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 6, "CN004", "", "General Trade", "System", new DateTime(2021, 5, 16, 16, 37, 1, 317, DateTimeKind.Local).AddTicks(2320), null, null, null },
                    { 5, "CN004", "", "General Trade", "System", new DateTime(2021, 5, 16, 16, 37, 1, 317, DateTimeKind.Local).AddTicks(2320), null, null, null },
                    { 4, "CN004", "", "General Trade", "System", new DateTime(2021, 5, 16, 16, 37, 1, 317, DateTimeKind.Local).AddTicks(2320), null, null, null },
                    { 3, "CN003", "", "Food Service", "System", new DateTime(2021, 5, 16, 16, 37, 1, 317, DateTimeKind.Local).AddTicks(2320), null, null, null },
                    { 2, "CN002", "", "VAN", "System", new DateTime(2021, 5, 16, 16, 37, 1, 317, DateTimeKind.Local).AddTicks(2320), null, null, null },
                    { 1, "MT", "MT - Modern Trade", "Modern Trade", "System", new DateTime(2021, 5, 16, 16, 37, 1, 317, DateTimeKind.Local).AddTicks(2310), null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "CostCenter",
                columns: new[] { "CostCenterId", "CenterCode", "CenterName", "CompanyId", "Site", "SourceFundId" },
                values: new object[] { 1, "CC001", "Cost 001", null, "BKK Thailand", null });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Customer",
                columns: new[] { "CustomerId", "AccountNo", "CreatedBy", "CreatedDate", "CustomerCode", "CustomerGroup", "CustomerName", "Distributor", "ShortName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 57, "D11", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1690), "11000187", "THE MALL", "บริษัท เดอะมอลล์ กรุ๊ป จำกัด", "AAI", "TM BKP", null, null },
                    { 56, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1690), "11000172", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาเทอร์มินอลพัทยา)", "AAI", "FL TMNPAYA", null, null },
                    { 54, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1690), "11000173", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาพัทยากลาง)", "AAI", "FL PTYC", null, null },
                    { 53, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1690), "11000175", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาพัฒน์พงศ์)", "AAI", "FL PATPONG", null, null },
                    { 52, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1690), "11000165", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาจรัญสนิทวงศ์)", "AAI", "FL JRSNW", null, null },
                    { 51, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1690), "11000183", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาลาดพร้าว)", "AAI", "FL LADPRAO", null, null },
                    { 45, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1680), "11000157", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขารัชดา)", "AAI", "FL RATCADA", null, null },
                    { 49, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1680), "11000169", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขารามอินทรา)", "AAI", "FL RAMINDA", null, null },
                    { 48, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1680), "11000167", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาหัวหมาก)", "AAI", "FL HUAMARK", null, null },
                    { 47, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1680), "11000166", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาสุขุมวิท ซอย5)", "AAI", "FL SKV S5", null, null },
                    { 46, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1680), "11000162", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาทองหล่อ)", "AAI", "FL THONGL", null, null },
                    { 58, "D11", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1690), "11000194", null, null, "AAI", "TM HUAMARK", null, null },
                    { 50, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1680), "11000179", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาศรีนครินทร์)", "AAI", "FL SRINAKA", null, null },
                    { 59, "D11", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1690), "11000197", null, null, "AAI", "TM NWW", null, null },
                    { 65, "D11", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1700), "11000199", null, "บริษัท สยามพารากอน รีเทล จำกัด", "AAI", "PARAGON", null, null },
                    { 61, "D11", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1700), "11000188", null, null, "AAI", "TM BKE", null, null },
                    { 62, "D11", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1700), "11000193", null, null, "AAI", "TM THAPRA", null, null },
                    { 63, "D11", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1700), "11000186", null, null, "AAI", "TM CDC RP", null, null },
                    { 64, "D11", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1700), "11000189", null, null, "AAI", "TM DV", null, null },
                    { 44, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1680), "11000178", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาพุทธมณฑล สาย4)", "AAI", "FL PTMT S4", null, null },
                    { 66, "D11", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1700), "11000196", null, "บริษัท ซิตี้มอลล์ กรุ๊ป จำกัด", "AAI", "EMQUARTIER", null, null },
                    { 67, "D11", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1700), "11000202", null, null, "AAI", "EMPORIUM", null, null },
                    { 68, "D11", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1710), "11000198", null, "บริษัท พรอมานาด โฮมเฟรซมาร์ทจำกัด", "AAI", "TM PROMNAD", null, null },
                    { 69, "D11", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1710), "11000192", null, "บริษัท เดอะมอลล์ราชสีมา จำกัด", "AAI", "TM KORAT", null, null },
                    { 70, "D11", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1710), "11000195", null, "บริษัท หัวหิน รีเทล จำกัด", "AAI", "TM BLUEPOR", null, null },
                    { 71, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1710), "11000061", null, "บริษัท ฟอร์ท เวนดิ้ง จำกัด", "AAI", "FORTH VEND", null, null },
                    { 72, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1710), "11000106", null, "บริษัท ลาซาด้า จำกัด", "AAI", "LAZADA", null, null },
                    { 73, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1710), "11000131", null, "บริษัท เอสคอมเมิร์ซ (ประเทศไทย)จำกัด", "AAI", "S COMMERCE", null, null },
                    { 60, "D11", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1700), "11000184", null, null, "AAI", "TM PEOPLEP", null, null },
                    { 43, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1670), "11000170", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาพระราม 3)", "AAI", "FL RAMAIII", null, null },
                    { 55, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1690), "11000174", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาเพชรบุรี)", "AAI", "FL PBURI", null, null },
                    { 41, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1670), "11000164", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาหลักสี่)", "AAI", "FL LAK4", null, null },
                    { 18, "D031-DM06", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1640), "D031-DM06", null, null, "DK", "DK-LAWSON", null, null },
                    { 17, "D031-DM04", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1640), "D031-DM04", null, null, "DK", "DK-ISETAN", null, null },
                    { 16, "D031-DM03", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1640), "D031-DM03", null, null, "DK", "DK-FL", null, null },
                    { 15, "D031-DM02", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1640), "D031-DM02", null, null, "DK", "DK-CPF", null, null },
                    { 14, "D031-DM01", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1640), "D031-DM01", null, null, "DK", "DK-BOOTS", null, null },
                    { 13, "D031-DM09", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1640), "D031-DM09", null, null, "DK", "DK-TM", null, null },
                    { 12, "D031-DM05", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1630), "D031-DM05", null, "บริษัท ดีเคเอสเอช (ประเทศไทย) จำกัด", "DK", "DK-MAKRO", null, null },
                    { 42, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1670), "11000168", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาบางนา)", "AAI", "FL BANGNA", null, null },
                    { 19, "D031-DM08", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1640), "D031-DM08", null, null, "DK", "DK-THS", null, null },
                    { 10, "D08", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1630), "D031-DM18", null, "บริษัท ดีเคเอสเอช (ประเทศไทย) จำกัด", "DK", "DK-VILLA", null, null },
                    { 8, "D04", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1630), "D031-DM13", null, "บริษัท ดีเคเอสเอช (ประเทศไทย) จำกัด", "DK", "DK-CFM", null, null },
                    { 7, "D04", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1630), "11000066", "FAMILY MART", "บริษัท เซ็นทรัลแฟมิลี่มาร์ท จำกัด", "AAI", "FAMILYMART", null, null },
                    { 6, "D05", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1630), "D031-DM14", null, "บริษัท ดีเคเอสเอช (ประเทศไทย) จำกัด", "DK", "DK-TESCO", null, null },
                    { 5, "D05", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1630), "11000059", "TESCO LOTUS", "บริษัท เอก-ชัย ดีสทริบิวชั่นซิสเทม จำกัด", "AAI", "TESCO", null, null },
                    { 4, "D07", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1620), "D031-DM16", null, "บริษัท ดีเคเอสเอช (ประเทศไทย) จำกัด", "DK", "DK-TOPS", null, null },
                    { 3, "D07", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1620), "11000055", "TOPS", "บริษัท เซ็นทรัล ฟู้ด รีเทล จำกัดสาขาดีซี", "AAI", "TOPS", null, null },
                    { 2, "D03", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1620), "D031-DM12", null, "บริษัท ดีเคเอสเอช (ประเทศไทย) จำกัด", "DK", "DK-BIGC", null, null },
                    { 1, "D03", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1600), "11000046", "BIG C", "บริษัท บิ๊กซี ซูเปอร์เซ็นเตอร์จำกัด (มหาชน)", "AAI", "BIGC", null, null },
                    { 9, "D08", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1630), "11000081", "VILLA", "บริษัท วิลล่ามาร์เก็ท เจพี จำกัด", "AAI", "VILLA", null, null },
                    { 20, "D031-DM10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1650), "D031-DM10", null, null, "DK", "DK-TOKYU", null, null },
                    { 11, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1630), "11000056", "", "บริษัท ซีพี ออลล์ จำกัด (มหาชน)", "AAI", "CPALL", null, null },
                    { 22, "D031-DM17", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1650), "D031-DM17", null, null, "DK", "DK-ALL-D", null, null },
                    { 21, "D031-DM11", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1650), "D031-DM11", null, null, "DK", "DK-UFMFUJI", null, null },
                    { 39, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1670), "11000161", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาพอร์โตชิโน่ พระราม2)", "AAI", "FL POTOCIN", null, null },
                    { 38, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1670), "11000160", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาปิ่นเกล้า)", "AAI", "FL PINKLAO", null, null },
                    { 37, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1670), "11000159", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาเพชรเกษม)", "AAI", "FL P KASEM", null, null },
                    { 36, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1670), "11000158", "FOOD LAND", "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาเดอะไบร์ท พระราม2)", "AAI", "FL RAMAII", null, null },
                    { 35, "D09", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1660), "11000155", null, null, "AAI", "UFM FUJI4", null, null },
                    { 34, "D09", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1660), "11000154", null, null, "AAI", "UFM FUJI2", null, null },
                    { 33, "D09", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1660), "11000153", "UFM FUJI", "บริษัท ยูเอฟเอ็ม ฟูจิ ซูเปอร์ จำกัด", "AAI", "UFM FUJI1", null, null },
                    { 32, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1660), "11000132", null, "บริษัท ปตท. น้ำมันและการค้าปลิกจำกัด (มหาชน)", "AAI", "PTT OR", null, null },
                    { 31, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1660), "11000203", null, "บริษัท บู๊ทส์ รีเทล (ประเทศไทย)จำกัด", "AAI", "BOOTS", null, null },
                    { 40, "D10", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1670), "11000163", null, "บริษัท ฟู้ดแลนด์ซุปเปอร์มาร์เก็ตจำกัด (สาขาสุขุมวิท ซอย16)", "AAI", "FL SKV S16", null, null },
                    { 30, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1660), "11000152", null, "บริษัท สยามแม็คโคร จำกัด (มหาชน)", "AAI", "MAKRO", null, null },
                    { 29, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1660), "11000180", null, null, "AAI", "THS TBR", null, null },
                    { 28, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1660), "11000181", null, "บริษัท สรรพสินค้าตั้งฮั่วเส็ง จำกัด", "AAI", "THS BLP", null, null },
                    { 27, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1650), "11000176", null, "บริษัท สห ลอว์สัน จำกัด", "AAI", "LAWSON", null, null },
                    { 26, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1650), "11000151", null, "บริษัท ซีพีเอฟ เทรดดิ้ง จำกัด", "AAI", "CPF", null, null },
                    { 25, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1650), "11000150", null, "บริษัท ปตท.บริหารธุรกิจค้าปลีกจำกัด", "AAI", "PTT JIFFY", null, null },
                    { 24, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1650), "11000148", null, "บริษัท ปิโตรเลียมไทยคอร์ปอเรชั่นจำกัด", "AAI", "PT GSTORE", null, null },
                    { 23, "D031-DT02", "System", new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1650), "D031-DT02", null, null, "DK", "DK-G STORE", null, null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FlowItem",
                columns: new[] { "FlowItemId", "FlowItemCode", "FlowItemName" },
                values: new object[,]
                {
                    { 7, "FI07", "Commit" },
                    { 5, "FI05", "Reject" },
                    { 4, "FI04", "Approve" },
                    { 3, "FI03", "Cancel" },
                    { 6, "FI06", "Review" },
                    { 1, "FI01", "Submit" },
                    { 2, "FI02", "Confirm" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "OperatorCondition",
                columns: new[] { "OperatorConditionId", "OperatoDesc", "OperatorCode" },
                values: new object[,]
                {
                    { 7, "No have limit of approval", "None" },
                    { 5, "Equal to ...", "=" },
                    { 4, "Greater than or equal to ...", ">=" },
                    { 3, "Greater than ...", ">" },
                    { 6, "Not equal to ...", "!=" },
                    { 1, "Less than ...", "<" },
                    { 2, "Less than or equal to ...", "<=" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ProductCategory",
                columns: new[] { "ProductCategoryId", "ProductCategoryName" },
                values: new object[] { 1, "Beverage" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Supplier",
                columns: new[] { "SupplierId", "CreatedBy", "CreatedDate", "SupplierCode", "SupplierName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 2, "System", new DateTime(2021, 5, 16, 16, 37, 1, 314, DateTimeKind.Local).AddTicks(3890), "CS002", "Team B", null, null },
                    { 1, "System", new DateTime(2021, 5, 16, 16, 37, 1, 314, DateTimeKind.Local).AddTicks(3620), "CS001", "Team A", null, null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Workflow",
                columns: new[] { "WorkflowId", "BeginDate", "CreatedBy", "CreatedDate", "EndDate", "UpdatedBy", "UpdatedDate", "WorkflowDesc", "WorkflowName" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 16, 16, 37, 1, 333, DateTimeKind.Local).AddTicks(4140), "System", new DateTime(2021, 5, 16, 16, 37, 1, 333, DateTimeKind.Local).AddTicks(9470), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), null, null, null, "Fixed Contract workflow" },
                    { 2, new DateTime(2021, 5, 16, 16, 37, 1, 333, DateTimeKind.Local).AddTicks(8910), "System", new DateTime(2021, 5, 16, 16, 37, 1, 333, DateTimeKind.Local).AddTicks(9470), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), null, null, null, "Sale Forecast workflow" },
                    { 3, new DateTime(2021, 5, 16, 16, 37, 1, 333, DateTimeKind.Local).AddTicks(9400), "System", new DateTime(2021, 5, 16, 16, 37, 1, 333, DateTimeKind.Local).AddTicks(9470), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), null, null, null, "Budget Planing workflow" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "WorkflowAction",
                columns: new[] { "ActionId", "ActionCode", "ActionName", "ActionPiority" },
                values: new object[,]
                {
                    { 1, "ACT001", "Behavior", 1 },
                    { 2, "ACT002", "Activity", 2 },
                    { 3, "ACT003", "Interaction", 3 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "WorkflowActivity",
                columns: new[] { "ActivityId", "ActivityCode", "ActivityName", "ActivityPiority" },
                values: new object[,]
                {
                    { 2, "ATI002", "Do", 2 },
                    { 1, "ATI001", "Entry", 1 },
                    { 3, "ATI003", "Exit", 3 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "DocumentType",
                columns: new[] { "DocumentTypeId", "CreatedBy", "CreatedDate", "DocumentTypeCode", "DocumentTypeDesc", "DocumentTypeName", "UpdatedBy", "UpdatedDate", "WorkflowId" },
                values: new object[,]
                {
                    { 4, "System", new DateTime(2021, 5, 16, 16, 37, 1, 309, DateTimeKind.Local).AddTicks(5440), "SF03", "Sale Forecast - Product (SKU)", "Sale Forecast", null, null, 2 },
                    { 5, "System", new DateTime(2021, 5, 16, 16, 37, 1, 309, DateTimeKind.Local).AddTicks(5440), "BP01", "Budget Planing", "Budget Planing", null, null, 3 },
                    { 1, "System", new DateTime(2021, 5, 16, 16, 37, 1, 290, DateTimeKind.Local).AddTicks(5480), "FC01", "Fixed Contract", "Fixed Contract", null, null, 1 },
                    { 3, "System", new DateTime(2021, 5, 16, 16, 37, 1, 309, DateTimeKind.Local).AddTicks(5380), "SF02", "Sale Forecast - Brand", "Sale Forecast", null, null, 2 },
                    { 2, "System", new DateTime(2021, 5, 16, 16, 37, 1, 309, DateTimeKind.Local).AddTicks(4510), "SF01", "Sale Forecast - Client", "Sale Forecast", null, null, 2 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Product",
                columns: new[] { "ProductId", "BrandCode", "BrandId", "Color", "CreatedBy", "CreatedDate", "Height", "LTP", "ProductCategoryId", "ProductCategoryName", "ProductCode", "ProductName", "QTY", "SKU", "Shape", "Size", "UOM", "UpdatedBy", "UpdatedDate", "Weight", "Width" },
                values: new object[,]
                {
                    { 10, null, 1, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4460), null, null, 1, null, "P010", "Water", null, "Water-Mineral-Bottom-1000ml", null, "1000ml", "Bottom", null, null, null, null },
                    { 1, null, 1, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4180), null, null, 1, null, "P001", "Beer", null, "Beer-Premuim-Can-250cc", null, "250cc", "UOM", null, null, null, null },
                    { 2, null, 1, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4450), null, null, 1, null, "P002", "Beer", null, "Beer-Premuim-Can-500cc", null, "500cc", "Can", null, null, null, null },
                    { 3, null, 1, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4450), null, null, 1, null, "P003", "Beer", null, "Beer-Premuim-Bottom-750ml", null, "750ml", "Can", null, null, null, null },
                    { 4, null, 1, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4450), 3m, null, 1, null, "P004", "Beer", null, "Beer-Lager-4x3-Can Dozen-500cc", null, "500cc", "Bottom", null, null, null, 4m },
                    { 5, null, 1, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4450), 3m, null, 1, null, "P005", "Beer", null, "Beer-Lager-4x3-Bottom Dozen-750ml", null, "750ml", "Can Dozen", null, null, null, 4m },
                    { 6, null, 1, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4450), null, null, 1, null, "P006", "Beer", null, "Beer-Lager-Pack-750ml", null, "750ml", "Bottom Dozen", null, null, null, null },
                    { 7, null, 1, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4460), null, null, 1, null, "P007", "Water", null, "Water-RO-Bottom-600ml", null, "600ml", "Pack", null, null, null, null },
                    { 8, null, 1, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4460), null, null, 1, null, "P008", "Water", null, "Water-RO-Bottom-1000ml", null, "1000ml", "Bottom", null, null, null, null },
                    { 9, null, 1, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4460), null, null, 1, null, "P009", "Water", null, "Water-Mineral-Bottom-600ml", null, "600ml", "Bottom", null, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "TradeInvesment",
                columns: new[] { "TradeInvesmentId", "AccountId", "ChannelId", "CostElement", "CreatedBy", "CreatedDate", "CustomerId", "DataSource", "Deductable", "IsFixedContract", "SubGroup", "ToleranceLevel", "ToleranceLower", "ToleranceUpper", "TradeActivity", "TradeCode", "TradeName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, 1, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 317, DateTimeKind.Local).AddTicks(8960), 1, null, false, false, null, null, null, null, "Compensation", "TINV001", null, null, null },
                    { 2, null, 1, null, "System", new DateTime(2021, 5, 16, 16, 37, 1, 317, DateTimeKind.Local).AddTicks(8970), 1, null, false, false, null, null, null, null, "Allowance", "TINV002", null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "WorkflowState",
                columns: new[] { "WorkflowStateId", "BeginDate", "EndDate", "NotifyMessage", "NotifySubject", "PreviousStateId", "StateDesc", "StateName", "WorkflowId" },
                values: new object[,]
                {
                    { 11, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", null, null, "DRAFT", 2 },
                    { 12, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 12, null, "SM. Approval", 2 },
                    { 13, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 13, null, "DM. Approval", 2 },
                    { 14, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 14, null, "GM. Approval", 2 },
                    { 15, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 15, null, "Accountant Reviewer", 2 },
                    { 1, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Draft", "{DocNo} : Draft", null, null, "DRAFT", 1 },
                    { 21, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", null, null, "DRAFT", 3 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ActorState",
                columns: new[] { "ActorStateId", "ActorId", "ContactType", "LimitValue", "OperatorCode", "OperatorConditionId", "Position", "RoleState", "User", "WorkflowStateId" },
                values: new object[,]
                {
                    { 1, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 1 },
                    { 32, 1, "EMAIL", null, "None", 7, "SM", "SM", "panupong.k@itsmart.co.th", 13 },
                    { 31, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 13 },
                    { 35, 1, "EMAIL", null, "None", 7, "SM", "SM", "panupong.k@itsmart.co.th", 14 },
                    { 36, 1, "EMAIL", null, "None", 7, "DM", "DM", "panupong.k@itsmart.co.th", 14 },
                    { 37, 1, "EMAIL", null, "None", 7, "GM", "GM", "panupong.k@itsmart.co.th", 14 },
                    { 38, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 15 },
                    { 39, 1, "EMAIL", null, "None", 7, "SM", "SM", "panupong.k@itsmart.co.th", 15 },
                    { 30, 1, "EMAIL", null, "None", 7, "SM", "SM", "panupong.k@itsmart.co.th", 12 },
                    { 29, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 12 },
                    { 33, 1, "EMAIL", null, "None", 7, "DM", "DM", "panupong.k@itsmart.co.th", 13 },
                    { 40, 1, "EMAIL", null, "None", 7, "DM", "DM", "panupong.k@itsmart.co.th", 15 },
                    { 42, 1, "EMAIL", null, "None", 7, "Accountant", "ACC", "panupong.k@itsmart.co.th", 15 },
                    { 43, 1, "EMAIL", null, "None", 7, "CEO", "CEO", "panupong.k@itsmart.co.th", 15 },
                    { 28, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 11 },
                    { 55, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 21 },
                    { 41, 1, "EMAIL", null, "None", 7, "GM", "GM", "panupong.k@itsmart.co.th", 15 },
                    { 34, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 14 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "StateFlowItem",
                columns: new[] { "StateFlowItemId", "FlowItemCode", "FlowItemId", "FlowItemName", "Sort", "WorkflowStateId" },
                values: new object[,]
                {
                    { 21, "FI06", 6, "Review", 1, 15 },
                    { 20, "FI05", 5, "Reject", 2, 14 },
                    { 22, "FI07", 7, "Commit", 2, 15 },
                    { 23, "FI01", 1, "Submit", 1, 21 },
                    { 24, "FI02", 3, "Confirm", 2, 21 },
                    { 25, "FI03", 4, "Cancel", 3, 21 },
                    { 19, "FI04", 4, "Approve", 1, 14 },
                    { 13, "FI02", 3, "Confirm", 2, 11 },
                    { 14, "FI03", 4, "Cancel", 3, 11 },
                    { 18, "FI05", 5, "Reject", 2, 13 },
                    { 12, "FI01", 1, "Submit", 1, 11 },
                    { 16, "FI05", 5, "Reject", 2, 12 },
                    { 15, "FI04", 4, "Approve", 1, 12 },
                    { 3, "FI03", 4, "Cancel", 3, 1 },
                    { 2, "FI02", 3, "Confirm", 2, 1 },
                    { 1, "FI01", 1, "Submit", 1, 1 },
                    { 17, "FI04", 4, "Approve", 1, 13 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "StateProcess",
                columns: new[] { "StateProcessId", "ActionCode", "ActionId", "ActionName", "ActionPiority", "ActivityCode", "ActivityId", "ActivityName", "ActivityPiority", "WorkflowStateId" },
                values: new object[,]
                {
                    { 1, "ACT003", 1, "Interaction", 3, "ATI001", 1, "Entry", 1, 1 },
                    { 51, "ACT003", 3, "Interaction", 3, "ATI002", 1, "Do", 2, 15 },
                    { 50, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 15 },
                    { 48, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 15 },
                    { 47, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 15 },
                    { 46, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 15 },
                    { 45, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 15 },
                    { 63, "ACT003", 3, "Interaction", 3, "ATI001", 1, "Entry", 1, 21 },
                    { 49, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 15 },
                    { 36, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 13 },
                    { 35, "ACT003", 3, "Interaction", 3, "ATI002", 1, "Do", 2, 12 },
                    { 44, "ACT003", 3, "Interaction", 3, "ATI002", 1, "Do", 2, 14 },
                    { 43, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 14 },
                    { 42, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 14 },
                    { 41, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 14 },
                    { 40, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 14 },
                    { 33, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 12 },
                    { 34, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 12 },
                    { 32, "ACT003", 3, "Interaction", 3, "ATI001", 1, "Entry", 1, 11 },
                    { 37, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 13 },
                    { 38, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 13 },
                    { 39, "ACT003", 3, "Interaction", 3, "ATI002", 1, "Do", 2, 13 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "WorkflowState",
                columns: new[] { "WorkflowStateId", "BeginDate", "EndDate", "NotifyMessage", "NotifySubject", "PreviousStateId", "StateDesc", "StateName", "WorkflowId" },
                values: new object[,]
                {
                    { 25, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 21, null, "CEO. Approval", 3 },
                    { 24, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 21, null, "GM. Approval", 3 },
                    { 23, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 21, null, "DM. Approval", 3 },
                    { 22, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 21, null, "SM. Approval", 3 },
                    { 17, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 14, null, "DM. Rejected", 2 },
                    { 19, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 12, null, "Cancelled", 2 },
                    { 18, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 15, null, "GM. Rejected", 2 },
                    { 26, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 21, null, "Accountant Reviewer", 3 },
                    { 2, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "SM. Approval", "{DocNo} : Approval", 1, null, "SM. Approval", 1 },
                    { 9, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Cancelled", "{DocNo} : Cancelled", 1, null, "Cancelled", 1 },
                    { 16, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 13, null, "SM. Rejected", 2 },
                    { 35, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 21, null, "Cancelled", 3 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ActorState",
                columns: new[] { "ActorStateId", "ActorId", "ContactType", "LimitValue", "OperatorCode", "OperatorConditionId", "Position", "RoleState", "User", "WorkflowStateId" },
                values: new object[,]
                {
                    { 2, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 2 },
                    { 57, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 22 },
                    { 56, 1, "EMAIL", 50000m, "<=", 2, "SM", "SM", "panupong.k@itsmart.co.th", 22 },
                    { 61, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 24 },
                    { 87, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 35 },
                    { 60, 1, "EMAIL", 500000m, "<=", 2, "GM", "GM", "panupong.k@itsmart.co.th", 24 },
                    { 52, 1, "EMAIL", null, "None", 7, "GM", "GM", "panupong.k@itsmart.co.th", 18 },
                    { 51, 1, "EMAIL", null, "None", 7, "DM", "DM", "panupong.k@itsmart.co.th", 18 },
                    { 50, 1, "EMAIL", null, "None", 7, "SM", "SM", "panupong.k@itsmart.co.th", 18 },
                    { 49, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 18 },
                    { 58, 1, "EMAIL", 100000m, "<=", 2, "DM", "DM", "panupong.k@itsmart.co.th", 23 },
                    { 62, 1, "EMAIL", 1000000m, ">=", 2, "CEO", "CEO", "panupong.k@itsmart.co.th", 25 },
                    { 63, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 25 },
                    { 48, 1, "EMAIL", null, "None", 7, "DM", "DM", "panupong.k@itsmart.co.th", 17 },
                    { 47, 1, "EMAIL", null, "None", 7, "SM", "SM", "panupong.k@itsmart.co.th", 17 },
                    { 46, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 17 },
                    { 3, 1, "EMAIL", null, "None", 7, "SM", "SM", "panupong.k@itsmart.co.th", 2 },
                    { 45, 1, "EMAIL", null, "None", 7, "SM", "SM", "panupong.k@itsmart.co.th", 16 },
                    { 44, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 16 },
                    { 65, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 26 },
                    { 53, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 19 },
                    { 66, 1, "EMAIL", null, "None", 7, "CEO", "CEO", "panupong.k@itsmart.co.th", 26 },
                    { 26, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 9 },
                    { 64, 1, "EMAIL", null, "None", 7, "Accountant", "Accountant", "panupong.k@itsmart.co.th", 26 },
                    { 59, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 23 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "StateFlowItem",
                columns: new[] { "StateFlowItemId", "FlowItemCode", "FlowItemId", "FlowItemName", "Sort", "WorkflowStateId" },
                values: new object[,]
                {
                    { 33, "FI05", 5, "Reject", 2, 25 },
                    { 26, "FI04", 4, "Approve", 1, 22 },
                    { 4, "FI04", 4, "Approve", 1, 2 },
                    { 30, "FI04", 4, "Approve", 1, 24 },
                    { 5, "FI05", 5, "Reject", 2, 2 },
                    { 35, "FI07", 7, "Commit", 2, 26 },
                    { 28, "FI04", 4, "Approve", 1, 23 },
                    { 34, "FI06", 6, "Review", 1, 26 },
                    { 27, "FI05", 5, "Reject", 2, 22 },
                    { 32, "FI04", 4, "Approve", 1, 25 },
                    { 29, "FI05", 5, "Reject", 2, 23 },
                    { 31, "FI05", 5, "Reject", 2, 24 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "StateProcess",
                columns: new[] { "StateProcessId", "ActionCode", "ActionId", "ActionName", "ActionPiority", "ActivityCode", "ActivityId", "ActivityName", "ActivityPiority", "WorkflowStateId" },
                values: new object[,]
                {
                    { 75, "ACT003", 3, "Interaction", 3, "ATI002", 1, "Do", 2, 24 },
                    { 72, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 24 },
                    { 73, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 24 },
                    { 74, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 24 },
                    { 70, "ACT003", 3, "Interaction", 3, "ATI002", 1, "Do", 2, 23 },
                    { 76, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 26 },
                    { 77, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 26 },
                    { 78, "ACT003", 3, "Interaction", 3, "ATI002", 1, "Do", 2, 26 },
                    { 71, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 24 },
                    { 69, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 23 },
                    { 100, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 35 },
                    { 67, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 23 },
                    { 2, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 2 },
                    { 3, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 2 },
                    { 4, "ACT003", 3, "Interaction", 3, "ATI002", 1, "Do", 2, 2 },
                    { 30, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 9 },
                    { 61, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 19 },
                    { 52, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 16 },
                    { 53, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 16 },
                    { 68, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 23 },
                    { 55, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 17 },
                    { 56, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 17 },
                    { 54, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 17 },
                    { 65, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 22 },
                    { 58, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 18 },
                    { 59, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 18 },
                    { 60, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 18 },
                    { 64, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 22 },
                    { 57, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 18 },
                    { 66, "ACT003", 3, "Interaction", 3, "ATI002", 1, "Do", 2, 22 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "WorkflowState",
                columns: new[] { "WorkflowStateId", "BeginDate", "EndDate", "NotifyMessage", "NotifySubject", "PreviousStateId", "StateDesc", "StateName", "WorkflowId" },
                values: new object[,]
                {
                    { 36, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 26, null, "Completed", 3 },
                    { 28, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 23, null, "Accountant Reviewer", 3 },
                    { 32, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 23, null, "DM. Rejected", 3 },
                    { 31, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 22, null, "SM. Rejected", 3 },
                    { 3, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "DM. Approval", "{DocNo} : Approval", 2, null, "DM. Approval", 1 },
                    { 29, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 24, null, "Accountant Reviewer", 3 },
                    { 34, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 25, null, "CEO. Rejected", 3 },
                    { 30, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 25, null, "Accountant Reviewer", 3 },
                    { 20, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 16, null, "Completed", 2 },
                    { 33, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 24, null, "GM. Rejected", 3 },
                    { 6, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "SM. Rejected", "{DocNo} : Rejected", 2, null, "SM. Rejected", 1 },
                    { 27, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 22, null, "Accountant Reviewer", 3 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ActorState",
                columns: new[] { "ActorStateId", "ActorId", "ContactType", "LimitValue", "OperatorCode", "OperatorConditionId", "Position", "RoleState", "User", "WorkflowStateId" },
                values: new object[,]
                {
                    { 4, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 3 },
                    { 69, 1, "EMAIL", null, "None", 7, "CEO", "CEO", "panupong.k@itsmart.co.th", 27 },
                    { 77, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 30 },
                    { 76, 1, "EMAIL", null, "None", 7, "Accountant", "Accountant", "panupong.k@itsmart.co.th", 30 },
                    { 79, 1, "EMAIL", null, "None", 7, "SM", "SM", "panupong.k@itsmart.co.th", 31 },
                    { 80, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 31 },
                    { 70, 1, "EMAIL", null, "None", 7, "Accountant", "Accountant", "panupong.k@itsmart.co.th", 28 },
                    { 71, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 28 },
                    { 72, 1, "EMAIL", null, "None", 7, "CEO", "CEO", "panupong.k@itsmart.co.th", 28 },
                    { 84, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 33 },
                    { 83, 1, "EMAIL", null, "None", 7, "GM", "GM", "panupong.k@itsmart.co.th", 33 },
                    { 81, 1, "EMAIL", null, "None", 7, "DM", "DM", "panupong.k@itsmart.co.th", 32 },
                    { 82, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 32 },
                    { 73, 1, "EMAIL", null, "None", 7, "Accountant", "Accountant", "panupong.k@itsmart.co.th", 29 },
                    { 74, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 29 },
                    { 75, 1, "EMAIL", null, "None", 7, "CEO", "CEO", "panupong.k@itsmart.co.th", 29 },
                    { 68, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 27 },
                    { 67, 1, "EMAIL", null, "None", 7, "Accountant", "Accountant", "panupong.k@itsmart.co.th", 27 },
                    { 78, 1, "EMAIL", null, "None", 7, "CEO", "CEO", "panupong.k@itsmart.co.th", 30 },
                    { 54, 1, "EMAIL", null, "None", 7, "CEO", "CEO", "panupong.k@itsmart.co.th", 20 },
                    { 5, 1, "EMAIL", null, "None", 7, "SM", "SM", "panupong.k@itsmart.co.th", 3 },
                    { 6, 1, "EMAIL", null, "None", 7, "DM", "DM", "panupong.k@itsmart.co.th", 3 },
                    { 90, 1, "EMAIL", null, "None", 7, "CEO", "CEO", "panupong.k@itsmart.co.th", 36 },
                    { 89, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 36 },
                    { 18, 1, "EMAIL", null, "None", 7, "SM", "SM", "panupong.k@itsmart.co.th", 6 },
                    { 17, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 6 },
                    { 88, 1, "EMAIL", null, "None", 7, "Accountant", "Accountant", "panupong.k@itsmart.co.th", 36 },
                    { 85, 1, "EMAIL", null, "None", 7, "CEO", "CEO", "panupong.k@itsmart.co.th", 34 },
                    { 86, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 34 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "StateFlowItem",
                columns: new[] { "StateFlowItemId", "FlowItemCode", "FlowItemId", "FlowItemName", "Sort", "WorkflowStateId" },
                values: new object[,]
                {
                    { 6, "FI04", 4, "Approve", 1, 3 },
                    { 7, "FI05", 5, "Reject", 2, 3 },
                    { 39, "FI07", 7, "Commit", 2, 28 },
                    { 43, "FI07", 7, "Commit", 2, 30 },
                    { 38, "FI06", 6, "Review", 1, 28 },
                    { 40, "FI06", 6, "Review", 1, 29 },
                    { 42, "FI06", 6, "Review", 1, 30 },
                    { 37, "FI07", 7, "Commit", 2, 27 },
                    { 36, "FI06", 6, "Review", 1, 27 },
                    { 41, "FI07", 7, "Commit", 2, 29 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "StateProcess",
                columns: new[] { "StateProcessId", "ActionCode", "ActionId", "ActionName", "ActionPiority", "ActivityCode", "ActivityId", "ActivityName", "ActivityPiority", "WorkflowStateId" },
                values: new object[,]
                {
                    { 99, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 33 },
                    { 90, "ACT003", 3, "Interaction", 3, "ATI002", 1, "Do", 2, 30 },
                    { 97, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 33 },
                    { 96, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 33 },
                    { 89, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 30 },
                    { 101, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 36 },
                    { 87, "ACT003", 3, "Interaction", 3, "ATI002", 1, "Do", 2, 29 },
                    { 86, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 29 },
                    { 85, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 29 },
                    { 88, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 30 },
                    { 98, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 33 },
                    { 84, "ACT003", 3, "Interaction", 3, "ATI002", 1, "Do", 2, 28 },
                    { 94, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 32 },
                    { 5, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 3 },
                    { 6, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 3 },
                    { 7, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 3 },
                    { 8, "ACT003", 3, "Interaction", 3, "ATI002", 1, "Do", 2, 3 },
                    { 21, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 6 },
                    { 22, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 6 },
                    { 62, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 20 },
                    { 95, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 32 },
                    { 80, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 27 },
                    { 79, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 27 },
                    { 91, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 31 },
                    { 92, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 31 },
                    { 82, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 28 },
                    { 83, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 28 },
                    { 102, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 36 },
                    { 93, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 32 },
                    { 81, "ACT003", 3, "Interaction", 3, "ATI002", 1, "Do", 2, 27 },
                    { 103, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 36 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "WorkflowState",
                columns: new[] { "WorkflowStateId", "BeginDate", "EndDate", "NotifyMessage", "NotifySubject", "PreviousStateId", "StateDesc", "StateName", "WorkflowId" },
                values: new object[,]
                {
                    { 37, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 27, null, "Completed", 3 },
                    { 10, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Completed", "{DocNo} : Completed", 6, null, "Completed", 1 },
                    { 40, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 30, null, "Completed", 3 },
                    { 7, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "DM. Rejected", "{DocNo} : Rejected", 3, null, "DM. Rejected", 1 },
                    { 4, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "GM. Approval", "{DocNo} : Approval", 3, null, "GM. Approval", 1 },
                    { 38, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 28, null, "Completed", 3 },
                    { 39, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "", "", 29, null, "Completed", 3 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ActorState",
                columns: new[] { "ActorStateId", "ActorId", "ContactType", "LimitValue", "OperatorCode", "OperatorConditionId", "Position", "RoleState", "User", "WorkflowStateId" },
                values: new object[,]
                {
                    { 7, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 4 },
                    { 102, 1, "EMAIL", null, "None", 7, "CEO", "CEO", "panupong.k@itsmart.co.th", 40 },
                    { 101, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 40 },
                    { 100, 1, "EMAIL", null, "None", 7, "Accountant", "Accountant", "panupong.k@itsmart.co.th", 40 },
                    { 99, 1, "EMAIL", null, "None", 7, "CEO", "CEO", "panupong.k@itsmart.co.th", 39 },
                    { 98, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 39 },
                    { 97, 1, "EMAIL", null, "None", 7, "Accountant", "Accountant", "panupong.k@itsmart.co.th", 39 },
                    { 96, 1, "EMAIL", null, "None", 7, "CEO", "CEO", "panupong.k@itsmart.co.th", 38 },
                    { 95, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 38 },
                    { 94, 1, "EMAIL", null, "None", 7, "Accountant", "Accountant", "panupong.k@itsmart.co.th", 38 },
                    { 93, 1, "EMAIL", null, "None", 7, "CEO", "CEO", "panupong.k@itsmart.co.th", 37 },
                    { 91, 1, "EMAIL", null, "None", 7, "Accountant", "Accountant", "panupong.k@itsmart.co.th", 37 },
                    { 27, 1, "EMAIL", null, "None", 7, "CEO", "CEO", "panupong.k@itsmart.co.th", 10 },
                    { 21, 1, "EMAIL", null, "None", 7, "DM", "DM", "panupong.k@itsmart.co.th", 7 },
                    { 92, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 37 },
                    { 19, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 7 },
                    { 8, 1, "EMAIL", null, "None", 7, "SM", "SM", "panupong.k@itsmart.co.th", 4 },
                    { 9, 1, "EMAIL", null, "None", 7, "DM", "DM", "panupong.k@itsmart.co.th", 4 },
                    { 10, 1, "EMAIL", null, "None", 7, "GM", "GM", "panupong.k@itsmart.co.th", 4 },
                    { 20, 1, "EMAIL", null, "None", 7, "SM", "SM", "panupong.k@itsmart.co.th", 7 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "StateFlowItem",
                columns: new[] { "StateFlowItemId", "FlowItemCode", "FlowItemId", "FlowItemName", "Sort", "WorkflowStateId" },
                values: new object[,]
                {
                    { 8, "FI04", 4, "Approve", 1, 4 },
                    { 9, "FI05", 5, "Reject", 2, 4 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "StateProcess",
                columns: new[] { "StateProcessId", "ActionCode", "ActionId", "ActionName", "ActionPiority", "ActivityCode", "ActivityId", "ActivityName", "ActivityPiority", "WorkflowStateId" },
                values: new object[,]
                {
                    { 113, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 40 },
                    { 112, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 39 },
                    { 111, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 39 },
                    { 110, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 39 },
                    { 9, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 4 },
                    { 109, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 38 },
                    { 108, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 38 },
                    { 107, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 38 },
                    { 10, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 4 },
                    { 12, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 4 },
                    { 106, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 37 },
                    { 105, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 37 },
                    { 104, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 37 },
                    { 13, "ACT003", 3, "Interaction", 3, "ATI002", 1, "Do", 2, 4 },
                    { 114, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 40 },
                    { 31, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 10 },
                    { 25, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 7 },
                    { 24, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 7 },
                    { 23, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 7 },
                    { 11, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 4 },
                    { 115, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 40 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "WorkflowState",
                columns: new[] { "WorkflowStateId", "BeginDate", "EndDate", "NotifyMessage", "NotifySubject", "PreviousStateId", "StateDesc", "StateName", "WorkflowId" },
                values: new object[,]
                {
                    { 5, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "ACC. Review", "{DocNo} : Review", 4, null, "Accountant Reviewer", 1 },
                    { 8, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "GM. Rejected", "{DocNo} : Rejected", 4, null, "GM. Rejected", 1 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ActorState",
                columns: new[] { "ActorStateId", "ActorId", "ContactType", "LimitValue", "OperatorCode", "OperatorConditionId", "Position", "RoleState", "User", "WorkflowStateId" },
                values: new object[,]
                {
                    { 11, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 5 },
                    { 12, 1, "EMAIL", null, "None", 7, "SM", "SM", "panupong.k@itsmart.co.th", 5 },
                    { 13, 1, "EMAIL", null, "None", 7, "DM", "DM", "panupong.k@itsmart.co.th", 5 },
                    { 14, 1, "EMAIL", null, "None", 7, "GM", "GM", "panupong.k@itsmart.co.th", 5 },
                    { 15, 1, "EMAIL", null, "None", 7, "Accountant", "ACC", "panupong.k@itsmart.co.th", 5 },
                    { 16, 1, "EMAIL", null, "None", 7, "CEO", "CEO", "panupong.k@itsmart.co.th", 5 },
                    { 25, 1, "EMAIL", null, "None", 7, "GM", "GM", "panupong.k@itsmart.co.th", 8 },
                    { 24, 1, "EMAIL", null, "None", 7, "DM", "DM", "panupong.k@itsmart.co.th", 8 },
                    { 23, 1, "EMAIL", null, "None", 7, "SM", "SM", "panupong.k@itsmart.co.th", 8 },
                    { 22, 1, "EMAIL", null, "None", 7, "Sales", "Sales", "panupong.k@itsmart.co.th", 8 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "StateFlowItem",
                columns: new[] { "StateFlowItemId", "FlowItemCode", "FlowItemId", "FlowItemName", "Sort", "WorkflowStateId" },
                values: new object[,]
                {
                    { 10, "FI06", 6, "Review", 1, 5 },
                    { 11, "FI07", 7, "Commit", 2, 5 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "StateProcess",
                columns: new[] { "StateProcessId", "ActionCode", "ActionId", "ActionName", "ActionPiority", "ActivityCode", "ActivityId", "ActivityName", "ActivityPiority", "WorkflowStateId" },
                values: new object[,]
                {
                    { 27, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 8 },
                    { 26, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 8 },
                    { 17, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 5 },
                    { 19, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 5 },
                    { 18, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 5 },
                    { 28, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 8 },
                    { 16, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 5 },
                    { 15, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 5 },
                    { 14, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 5 },
                    { 20, "ACT003", 3, "Interaction", 3, "ATI002", 1, "Do", 2, 5 },
                    { 29, "ACT001", 1, "Behavior", 1, "ATI002", 1, "Do", 2, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_ActorState_ActorId",
                schema: "dbo",
                table: "ActorState",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorState_OperatorConditionId",
                schema: "dbo",
                table: "ActorState",
                column: "OperatorConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorState_WorkflowStateId",
                schema: "dbo",
                table: "ActorState",
                column: "WorkflowStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Budget_BrandId",
                schema: "dbo",
                table: "Budget",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Budget_BudgetTypeId",
                schema: "dbo",
                table: "Budget",
                column: "BudgetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Budget_CostCenterId",
                schema: "dbo",
                table: "Budget",
                column: "CostCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Budget_DocumentId",
                schema: "dbo",
                table: "Budget",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Budget_SourceFundId",
                schema: "dbo",
                table: "Budget",
                column: "SourceFundId");

            migrationBuilder.CreateIndex(
                name: "IX_Channel_CustomerId",
                schema: "dbo",
                table: "Channel",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CostCenter_CompanyId",
                schema: "dbo",
                table: "CostCenter",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CostCenter_SourceFundId",
                schema: "dbo",
                table: "CostCenter",
                column: "SourceFundId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProduct_ProductCategoryId",
                schema: "dbo",
                table: "CustomerProduct",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_CompanyId",
                schema: "dbo",
                table: "Department",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_ChannelId",
                schema: "dbo",
                table: "Document",
                column: "ChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_CustomerId",
                schema: "dbo",
                table: "Document",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_DocumentTypeId",
                schema: "dbo",
                table: "Document",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_SupplierId",
                schema: "dbo",
                table: "Document",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentAction_ActorId",
                schema: "dbo",
                table: "DocumentAction",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentAction_DocumentId",
                schema: "dbo",
                table: "DocumentAction",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentType_WorkflowId",
                schema: "dbo",
                table: "DocumentType",
                column: "WorkflowId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentId",
                schema: "dbo",
                table: "Employee",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_FixedContract_AccountId",
                schema: "dbo",
                table: "FixedContract",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_FixedContract_BrandId",
                schema: "dbo",
                table: "FixedContract",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_FixedContract_CostCenterId",
                schema: "dbo",
                table: "FixedContract",
                column: "CostCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_FixedContract_DocumentId",
                schema: "dbo",
                table: "FixedContract",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_FixedContract_TradeInvesmentId",
                schema: "dbo",
                table: "FixedContract",
                column: "TradeInvesmentId");

            migrationBuilder.CreateIndex(
                name: "IX_GLAccount_GLGroupId",
                schema: "dbo",
                table: "GLAccount",
                column: "GLGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BrandId",
                schema: "dbo",
                table: "Product",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryId",
                schema: "dbo",
                table: "Product",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleForecast_BrandId",
                schema: "dbo",
                table: "SaleForecast",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleForecast_DocumentId",
                schema: "dbo",
                table: "SaleForecast",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleForecast_ProductId",
                schema: "dbo",
                table: "SaleForecast",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StateFlowItem_FlowItemId",
                schema: "dbo",
                table: "StateFlowItem",
                column: "FlowItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StateFlowItem_WorkflowStateId",
                schema: "dbo",
                table: "StateFlowItem",
                column: "WorkflowStateId");

            migrationBuilder.CreateIndex(
                name: "IX_StateProcess_ActionId",
                schema: "dbo",
                table: "StateProcess",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_StateProcess_ActivityId",
                schema: "dbo",
                table: "StateProcess",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_StateProcess_WorkflowStateId",
                schema: "dbo",
                table: "StateProcess",
                column: "WorkflowStateId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierCustomer_BrandId",
                schema: "dbo",
                table: "SupplierCustomer",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierCustomer_ChannelId",
                schema: "dbo",
                table: "SupplierCustomer",
                column: "ChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierCustomer_CustomerId",
                schema: "dbo",
                table: "SupplierCustomer",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierCustomer_SupplierId",
                schema: "dbo",
                table: "SupplierCustomer",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_TradeActivity_AccountId",
                schema: "dbo",
                table: "TradeActivity",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_TradeInvesment_AccountId",
                schema: "dbo",
                table: "TradeInvesment",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_TradeInvesment_ChannelId",
                schema: "dbo",
                table: "TradeInvesment",
                column: "ChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_TradeInvesment_CustomerId",
                schema: "dbo",
                table: "TradeInvesment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowState_PreviousStateId",
                schema: "dbo",
                table: "WorkflowState",
                column: "PreviousStateId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowState_WorkflowId",
                schema: "dbo",
                table: "WorkflowState",
                column: "WorkflowId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "ActorState",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Budget",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CustomerProduct",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "DocumentAction",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Employee",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "FixedContract",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SaleForecast",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "StateFlowItem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "StateProcess",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SupplierCustomer",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tb_email_inbound",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TradeActivity",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "OperatorCondition",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "BudgetType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Actor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Department",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CostCenter",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TradeInvesment",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Document",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "FlowItem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "WorkflowAction",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "WorkflowActivity",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "WorkflowState",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Company",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SourceFund",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GLAccount",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Channel",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "DocumentType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Supplier",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Brand",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ProductCategory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GLGroup",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Customer",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Workflow",
                schema: "dbo");
        }
    }
}
