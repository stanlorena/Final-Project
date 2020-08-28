using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppData.Migrations
{
    public partial class Addinitialentitymodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StareCivila",
                table: "Persons");

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "Persons",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Prenume",
                table: "Persons",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "Persons",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationalitate",
                table: "Persons",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipContract = table.Column<string>(nullable: false),
                    NumarContract = table.Column<int>(nullable: false),
                    DataInceput = table.Column<DateTime>(nullable: false),
                    DataSfarsit = table.Column<DateTime>(nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Strada = table.Column<string>(nullable: false),
                    Numar = table.Column<int>(nullable: false),
                    Bloc = table.Column<string>(nullable: true),
                    Etaj = table.Column<int>(nullable: false),
                    Apartament = table.Column<int>(nullable: false),
                    Localitate = table.Column<string>(nullable: false),
                    Judet = table.Column<string>(nullable: false),
                    DataInceput = table.Column<DateTime>(nullable: false),
                    DataSfarsit = table.Column<DateTime>(nullable: false),
                    PersoanaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonAddresses_Persons_PersoanaId",
                        column: x => x.PersoanaId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonIdentities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNP = table.Column<long>(nullable: false),
                    Serie = table.Column<int>(nullable: false),
                    Numar = table.Column<int>(nullable: false),
                    Emitent = table.Column<int>(nullable: false),
                    DataEmitere = table.Column<DateTime>(nullable: false),
                    DataExpirare = table.Column<DateTime>(nullable: false),
                    PersoanaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonIdentities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonIdentities_Persons_PersoanaId",
                        column: x => x.PersoanaId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContractFiscalities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fiscalitate = table.Column<string>(nullable: false),
                    SeAcordaDeduceri = table.Column<bool>(nullable: false),
                    DataInceput = table.Column<DateTime>(nullable: false),
                    DataSfarsit = table.Column<DateTime>(nullable: false),
                    ContractId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractFiscalities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractFiscalities_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContractInsurances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asigurare = table.Column<string>(nullable: false),
                    CompanieAsigurare = table.Column<string>(nullable: false),
                    DataInceput = table.Column<DateTime>(nullable: false),
                    DataSfarsit = table.Column<DateTime>(nullable: false),
                    ContractId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractInsurances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractInsurances_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContractOrganizatoricalAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Departament = table.Column<string>(nullable: false),
                    Functie = table.Column<string>(nullable: false),
                    DataInceput = table.Column<DateTime>(nullable: false),
                    DataSfarsit = table.Column<DateTime>(nullable: false),
                    ContractId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractOrganizatoricalAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractOrganizatoricalAssignments_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContractPeriods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Perioada = table.Column<string>(nullable: false),
                    DataInceput = table.Column<DateTime>(nullable: false),
                    DataSfarsit = table.Column<DateTime>(nullable: false),
                    ContractId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractPeriods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractPeriods_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContractSalaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salariu = table.Column<double>(nullable: false),
                    DataInceput = table.Column<DateTime>(nullable: false),
                    DataSfarsit = table.Column<DateTime>(nullable: false),
                    ContractId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractSalaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractSalaries_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContractWorkPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramLucru = table.Column<string>(nullable: false),
                    Norma = table.Column<string>(nullable: false),
                    DataInceput = table.Column<DateTime>(nullable: false),
                    DataSfarsit = table.Column<DateTime>(nullable: false),
                    ContractId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractWorkPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractWorkPrograms_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContractFiscalities_ContractId",
                table: "ContractFiscalities",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractInsurances_ContractId",
                table: "ContractInsurances",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractOrganizatoricalAssignments_ContractId",
                table: "ContractOrganizatoricalAssignments",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractPeriods_ContractId",
                table: "ContractPeriods",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_PersonId",
                table: "Contracts",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractSalaries_ContractId",
                table: "ContractSalaries",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractWorkPrograms_ContractId",
                table: "ContractWorkPrograms",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonAddresses_PersoanaId",
                table: "PersonAddresses",
                column: "PersoanaId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonIdentities_PersoanaId",
                table: "PersonIdentities",
                column: "PersoanaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContractFiscalities");

            migrationBuilder.DropTable(
                name: "ContractInsurances");

            migrationBuilder.DropTable(
                name: "ContractOrganizatoricalAssignments");

            migrationBuilder.DropTable(
                name: "ContractPeriods");

            migrationBuilder.DropTable(
                name: "ContractSalaries");

            migrationBuilder.DropTable(
                name: "ContractWorkPrograms");

            migrationBuilder.DropTable(
                name: "PersonAddresses");

            migrationBuilder.DropTable(
                name: "PersonIdentities");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Nationalitate",
                table: "Persons");

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Prenume",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "StareCivila",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
