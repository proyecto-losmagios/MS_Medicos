using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AccessData.Migrations
{
    public partial class initialModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Especialidades_EspecialidadesCodigo",
                table: "Medicos");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_EspecialidadesCodigo",
                table: "Medicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Especialidades",
                table: "Especialidades");

            migrationBuilder.DropColumn(
                name: "EspecialidadesCodigo",
                table: "Medicos");

            migrationBuilder.AlterColumn<int>(
                name: "EspecialidadId",
                table: "Especialidades",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Especialidades",
                table: "Especialidades",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_EspecialidadId",
                table: "Medicos",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Especialidades_Codigo",
                table: "Especialidades",
                column: "Codigo",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Especialidades_EspecialidadId",
                table: "Medicos",
                column: "EspecialidadId",
                principalTable: "Especialidades",
                principalColumn: "EspecialidadId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Especialidades_EspecialidadId",
                table: "Medicos");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_EspecialidadId",
                table: "Medicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Especialidades",
                table: "Especialidades");

            migrationBuilder.DropIndex(
                name: "IX_Especialidades_Codigo",
                table: "Especialidades");

            migrationBuilder.AddColumn<string>(
                name: "EspecialidadesCodigo",
                table: "Medicos",
                type: "character varying(8)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "EspecialidadId",
                table: "Especialidades",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Especialidades",
                table: "Especialidades",
                column: "Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_EspecialidadesCodigo",
                table: "Medicos",
                column: "EspecialidadesCodigo");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Especialidades_EspecialidadesCodigo",
                table: "Medicos",
                column: "EspecialidadesCodigo",
                principalTable: "Especialidades",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
