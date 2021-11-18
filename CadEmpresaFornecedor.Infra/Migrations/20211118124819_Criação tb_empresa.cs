using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CadEmpresaFornecedor.Infra.Migrations
{
    public partial class Criaçãotb_empresa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_empresa",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFantasia = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    UF = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_empresa", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_empresa");
        }
    }
}
