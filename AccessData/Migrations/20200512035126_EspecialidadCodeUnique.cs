using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AccessData.Migrations
{
    public partial class EspecialidadCodeUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "EspecialidadesCodigo",
                table: "Medicos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Especialidades",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "Especialidades",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(8)",
                oldMaxLength: 8,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EspecialidadId",
                table: "Especialidades",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Especialidades",
                type: "character varying(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<int>(
                name: "EspecialidadId",
                table: "Especialidades",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "Especialidades",
                type: "character varying(8)",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 8);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Especialidades",
                table: "Especialidades",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_EspecialidadId",
                table: "Medicos",
                column: "EspecialidadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Especialidades_EspecialidadId",
                table: "Medicos",
                column: "EspecialidadId",
                principalTable: "Especialidades",
                principalColumn: "EspecialidadId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
