using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FairWorks.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    TaxOffice = table.Column<string>(nullable: true),
                    TaxNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContractTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fairs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fairs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonelTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesPersons",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false),
                    Surname = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    isInternational = table.Column<bool>(nullable: false),
                    Commission = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesPersons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StandTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interviewers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false),
                    Surname = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    DirectPhone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CompanyId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviewers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interviewers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyCompanyProfiles",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(nullable: false),
                    CompanyProfileId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyCompanyProfiles", x => new { x.CompanyId, x.CompanyProfileId });
                    table.ForeignKey(
                        name: "FK_CompanyCompanyProfiles_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyCompanyProfiles_CompanyProfiles_CompanyProfileId",
                        column: x => x.CompanyProfileId,
                        principalTable: "CompanyProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    FairId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductGroups_Fairs_FairId",
                        column: x => x.FairId,
                        principalTable: "Fairs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    JobId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guests_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false),
                    Surname = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PersonelTypeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personels_PersonelTypes_PersonelTypeId",
                        column: x => x.PersonelTypeId,
                        principalTable: "PersonelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanySectors",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(nullable: false),
                    SectorId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySectors", x => new { x.CompanyId, x.SectorId });
                    table.ForeignKey(
                        name: "FK_CompanySectors_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanySectors_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Salons",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false),
                    SalonNo = table.Column<string>(nullable: true),
                    Area = table.Column<int>(nullable: false),
                    SectorId = table.Column<Guid>(nullable: false),
                    FairId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salons_Fairs_FairId",
                        column: x => x.FairId,
                        principalTable: "Fairs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Salons_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    ProductGroupId = table.Column<Guid>(nullable: false),
                    CompanyId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductGroups_ProductGroupId",
                        column: x => x.ProductGroupId,
                        principalTable: "ProductGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantHandBooks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false),
                    SendDate = table.Column<DateTime>(nullable: true),
                    PersonelId = table.Column<Guid>(nullable: false),
                    DeliverDate = table.Column<DateTime>(nullable: true),
                    isDelivered = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantHandBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParticipantHandBooks_Personels_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false),
                    SalesPersonId = table.Column<Guid>(nullable: false),
                    InterviewDate = table.Column<DateTime>(nullable: false),
                    InterviewerId = table.Column<Guid>(nullable: true),
                    SectorId = table.Column<Guid>(nullable: true),
                    SalonId = table.Column<Guid>(nullable: false),
                    CompanyProfileId = table.Column<Guid>(nullable: false),
                    CompanyId = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interviews_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interviews_CompanyProfiles_CompanyProfileId",
                        column: x => x.CompanyProfileId,
                        principalTable: "CompanyProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interviews_Interviewers_InterviewerId",
                        column: x => x.InterviewerId,
                        principalTable: "Interviewers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Interviews_SalesPersons_SalesPersonId",
                        column: x => x.SalesPersonId,
                        principalTable: "SalesPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interviews_Salons_SalonId",
                        column: x => x.SalonId,
                        principalTable: "Salons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interviews_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false),
                    OfferDate = table.Column<DateTime>(nullable: false),
                    SalonId = table.Column<Guid>(nullable: false),
                    SalesPersonId = table.Column<Guid>(nullable: false),
                    OfferArea = table.Column<int>(nullable: false),
                    OfferUnitPrice = table.Column<int>(nullable: false),
                    ExchangeType = table.Column<string>(nullable: true),
                    ExchangeRate = table.Column<int>(nullable: false),
                    MaturityCount = table.Column<int>(nullable: false),
                    PaymentPlan = table.Column<string>(nullable: true),
                    ExpireDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Offers_SalesPersons_SalesPersonId",
                        column: x => x.SalesPersonId,
                        principalTable: "SalesPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Offers_Salons_SalonId",
                        column: x => x.SalonId,
                        principalTable: "Salons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stands",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Width = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Area = table.Column<int>(nullable: false),
                    StandTypeId = table.Column<Guid>(nullable: false),
                    SalonId = table.Column<Guid>(nullable: false),
                    CompanyId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stands_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stands_Salons_SalonId",
                        column: x => x.SalonId,
                        principalTable: "Salons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stands_StandTypes_StandTypeId",
                        column: x => x.StandTypeId,
                        principalTable: "StandTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterviewFairs",
                columns: table => new
                {
                    InterviewId = table.Column<Guid>(nullable: false),
                    FairId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewFairs", x => new { x.InterviewId, x.FairId });
                    table.ForeignKey(
                        name: "FK_InterviewFairs_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterviewFairs_Fairs_FairId",
                        column: x => x.FairId,
                        principalTable: "Fairs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InterviewFairs_Interviews_InterviewId",
                        column: x => x.InterviewId,
                        principalTable: "Interviews",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UptatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UptatedAt = table.Column<DateTime>(nullable: false),
                    ContractDate = table.Column<DateTime>(nullable: false),
                    SalesPersonId = table.Column<Guid>(nullable: false),
                    InterviewerId = table.Column<Guid>(nullable: false),
                    CompanyId = table.Column<Guid>(nullable: false),
                    ContractTypeId = table.Column<Guid>(nullable: false),
                    StandId = table.Column<Guid>(nullable: false),
                    SalonId = table.Column<Guid>(nullable: false),
                    AreaUnitPrice = table.Column<int>(nullable: false),
                    ExchangeType = table.Column<string>(nullable: true),
                    ExchangeRate = table.Column<int>(nullable: false),
                    DiscountRate = table.Column<int>(nullable: false),
                    MaturityCount = table.Column<int>(nullable: false),
                    PaymentPlan = table.Column<string>(nullable: true),
                    ExpireDate = table.Column<DateTime>(nullable: false),
                    isSold = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_ContractTypes_ContractTypeId",
                        column: x => x.ContractTypeId,
                        principalTable: "ContractTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_Interviewers_InterviewerId",
                        column: x => x.InterviewerId,
                        principalTable: "Interviewers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contracts_SalesPersons_SalesPersonId",
                        column: x => x.SalesPersonId,
                        principalTable: "SalesPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_Salons_SalonId",
                        column: x => x.SalonId,
                        principalTable: "Salons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_Stands_StandId",
                        column: x => x.StandId,
                        principalTable: "Stands",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyCompanyProfiles_CompanyProfileId",
                table: "CompanyCompanyProfiles",
                column: "CompanyProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanySectors_SectorId",
                table: "CompanySectors",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_CompanyId",
                table: "Contracts",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ContractTypeId",
                table: "Contracts",
                column: "ContractTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_InterviewerId",
                table: "Contracts",
                column: "InterviewerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_SalesPersonId",
                table: "Contracts",
                column: "SalesPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_SalonId",
                table: "Contracts",
                column: "SalonId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_StandId",
                table: "Contracts",
                column: "StandId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guests_JobId",
                table: "Guests",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviewers_CompanyId",
                table: "Interviewers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewFairs_CompanyId",
                table: "InterviewFairs",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewFairs_FairId",
                table: "InterviewFairs",
                column: "FairId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_CompanyId",
                table: "Interviews",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_CompanyProfileId",
                table: "Interviews",
                column: "CompanyProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_InterviewerId",
                table: "Interviews",
                column: "InterviewerId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_SalesPersonId",
                table: "Interviews",
                column: "SalesPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_SalonId",
                table: "Interviews",
                column: "SalonId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_SectorId",
                table: "Interviews",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_CompanyId",
                table: "Offers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_SalesPersonId",
                table: "Offers",
                column: "SalesPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_SalonId",
                table: "Offers",
                column: "SalonId");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantHandBooks_PersonelId",
                table: "ParticipantHandBooks",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_PersonelTypeId",
                table: "Personels",
                column: "PersonelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_FairId",
                table: "ProductGroups",
                column: "FairId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyId",
                table: "Products",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductGroupId",
                table: "Products",
                column: "ProductGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Salons_FairId",
                table: "Salons",
                column: "FairId");

            migrationBuilder.CreateIndex(
                name: "IX_Salons_SectorId",
                table: "Salons",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Stands_CompanyId",
                table: "Stands",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Stands_SalonId",
                table: "Stands",
                column: "SalonId");

            migrationBuilder.CreateIndex(
                name: "IX_Stands_StandTypeId",
                table: "Stands",
                column: "StandTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyCompanyProfiles");

            migrationBuilder.DropTable(
                name: "CompanySectors");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "InterviewFairs");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "ParticipantHandBooks");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ContractTypes");

            migrationBuilder.DropTable(
                name: "Stands");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Interviews");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "ProductGroups");

            migrationBuilder.DropTable(
                name: "StandTypes");

            migrationBuilder.DropTable(
                name: "CompanyProfiles");

            migrationBuilder.DropTable(
                name: "Interviewers");

            migrationBuilder.DropTable(
                name: "SalesPersons");

            migrationBuilder.DropTable(
                name: "Salons");

            migrationBuilder.DropTable(
                name: "PersonelTypes");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Fairs");

            migrationBuilder.DropTable(
                name: "Sectors");
        }
    }
}
