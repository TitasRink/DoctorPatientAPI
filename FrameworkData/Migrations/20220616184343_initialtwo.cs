using Microsoft.EntityFrameworkCore.Migrations;

namespace FrameworkData.Migrations
{
    public partial class initialtwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Doctors_DepartamentModelId",
                table: "Doctors",
                column: "DepartamentModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Departments_DepartamentModelId",
                table: "Doctors",
                column: "DepartamentModelId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Departments_DepartamentModelId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_DepartamentModelId",
                table: "Doctors");
        }
    }
}
