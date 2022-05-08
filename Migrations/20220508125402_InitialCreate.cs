using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EPassport.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegistrationDetails",
                columns: table => new
                {
                    LoginID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DOB = table.Column<DateTime>(type: "date", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmailID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationDetails", x => x.LoginID);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationDetails",
                columns: table => new
                {
                    ApplicantID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DOB = table.Column<DateTime>(type: "date", nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    District = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaritalStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PAN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmploymentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EducationalQualification = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LoginID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationDetails", x => x.ApplicantID);
                    table.ForeignKey(
                        name: "FK_ApplicationDetails_RegistrationDetails",
                        column: x => x.LoginID,
                        principalTable: "RegistrationDetails",
                        principalColumn: "LoginID");
                });

            migrationBuilder.CreateTable(
                name: "LoginCredentials",
                columns: table => new
                {
                    UserType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LoginID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_LoginCredentials_RegistrationDetails",
                        column: x => x.LoginID,
                        principalTable: "RegistrationDetails",
                        principalColumn: "LoginID");
                });

            migrationBuilder.CreateTable(
                name: "AddressDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    HouseNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StreetName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    District = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Pincode = table.Column<int>(type: "int", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmailID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ApplicantID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AddressDetails_ApplicationDetails",
                        column: x => x.ApplicantID,
                        principalTable: "ApplicationDetails",
                        principalColumn: "ApplicantID");
                });

            migrationBuilder.CreateTable(
                name: "AppointmentDetails",
                columns: table => new
                {
                    MonthID = table.Column<int>(type: "int", nullable: false),
                    MonthName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AvailableDays = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TimeSlots = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ApplicantID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentDetails", x => x.MonthID);
                    table.ForeignKey(
                        name: "FK_AppointmentDetails_ApplicationDetails",
                        column: x => x.ApplicantID,
                        principalTable: "ApplicationDetails",
                        principalColumn: "ApplicantID");
                });

            migrationBuilder.CreateTable(
                name: "FamilyDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    FathersName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MothersName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ApplicantID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FamilyDetails_ApplicationDetails",
                        column: x => x.ApplicantID,
                        principalTable: "ApplicationDetails",
                        principalColumn: "ApplicantID");
                });

            migrationBuilder.CreateTable(
                name: "PassportOffice",
                columns: table => new
                {
                    OfficeID = table.Column<int>(type: "int", nullable: false),
                    OfficeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Jurisdiction = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApplicantID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassportOffice", x => x.OfficeID);
                    table.ForeignKey(
                        name: "FK_PassportOffice_ApplicationDetails",
                        column: x => x.ApplicantID,
                        principalTable: "ApplicationDetails",
                        principalColumn: "ApplicantID");
                });

            migrationBuilder.CreateTable(
                name: "ReferenceDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    ReferenceName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ApplicantID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReferenceDetails_ApplicationDetails",
                        column: x => x.ApplicantID,
                        principalTable: "ApplicationDetails",
                        principalColumn: "ApplicantID");
                });

            migrationBuilder.CreateTable(
                name: "SupportingDocumentDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Document1 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Document2 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ApplicantID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportingDocumentDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SupportingDocumentDetails_ApplicationDetails",
                        column: x => x.ApplicantID,
                        principalTable: "ApplicationDetails",
                        principalColumn: "ApplicantID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressDetails_ApplicantID",
                table: "AddressDetails",
                column: "ApplicantID");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationDetails_LoginID",
                table: "ApplicationDetails",
                column: "LoginID");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetails_ApplicantID",
                table: "AppointmentDetails",
                column: "ApplicantID");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyDetails_ApplicantID",
                table: "FamilyDetails",
                column: "ApplicantID");

            migrationBuilder.CreateIndex(
                name: "IX_LoginCredentials_LoginID",
                table: "LoginCredentials",
                column: "LoginID");

            migrationBuilder.CreateIndex(
                name: "IX_PassportOffice_ApplicantID",
                table: "PassportOffice",
                column: "ApplicantID");

            migrationBuilder.CreateIndex(
                name: "IX_ReferenceDetails_ApplicantID",
                table: "ReferenceDetails",
                column: "ApplicantID");

            migrationBuilder.CreateIndex(
                name: "IX_SupportingDocumentDetails_ApplicantID",
                table: "SupportingDocumentDetails",
                column: "ApplicantID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressDetails");

            migrationBuilder.DropTable(
                name: "AppointmentDetails");

            migrationBuilder.DropTable(
                name: "FamilyDetails");

            migrationBuilder.DropTable(
                name: "LoginCredentials");

            migrationBuilder.DropTable(
                name: "PassportOffice");

            migrationBuilder.DropTable(
                name: "ReferenceDetails");

            migrationBuilder.DropTable(
                name: "SupportingDocumentDetails");

            migrationBuilder.DropTable(
                name: "ApplicationDetails");

            migrationBuilder.DropTable(
                name: "RegistrationDetails");
        }
    }
}
