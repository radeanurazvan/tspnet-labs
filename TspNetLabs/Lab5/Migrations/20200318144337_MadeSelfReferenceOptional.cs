using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab5.Migrations
{
    public partial class MadeSelfReferenceOptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SelfReferences_SelfReferences_ParentId",
                table: "SelfReferences");

            migrationBuilder.AlterColumn<Guid>(
                name: "ParentId",
                table: "SelfReferences",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_SelfReferences_SelfReferences_ParentId",
                table: "SelfReferences",
                column: "ParentId",
                principalTable: "SelfReferences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SelfReferences_SelfReferences_ParentId",
                table: "SelfReferences");

            migrationBuilder.AlterColumn<Guid>(
                name: "ParentId",
                table: "SelfReferences",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SelfReferences_SelfReferences_ParentId",
                table: "SelfReferences",
                column: "ParentId",
                principalTable: "SelfReferences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
