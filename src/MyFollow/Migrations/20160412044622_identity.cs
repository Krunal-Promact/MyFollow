using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace MyFollow.Migrations
{
    public partial class identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_EndUser_Address_AddressId", table: "EndUser");
            migrationBuilder.DropForeignKey(name: "FK_Product_ProductOwner_ProductOwnerId", table: "Product");
            migrationBuilder.DropForeignKey(name: "FK_ProductOwner_Address_AddressId", table: "ProductOwner");
            migrationBuilder.DropColumn(name: "Detail", table: "Product");
            migrationBuilder.DropColumn(name: "Intro", table: "Product");
            migrationBuilder.DropColumn(name: "Media1", table: "Product");
            migrationBuilder.DropColumn(name: "Media2", table: "Product");
            migrationBuilder.DropColumn(name: "Media3", table: "Product");
            migrationBuilder.DropColumn(name: "Media4", table: "Product");
            migrationBuilder.DropColumn(name: "Media5", table: "Product");
            migrationBuilder.DropColumn(name: "Street1", table: "Address");
            migrationBuilder.DropColumn(name: "Street2", table: "Address");
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRoleClaim<string>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId",
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
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserClaim<string>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentityUserClaim<string>_IdentityUser_UserId",
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
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserLogin<string>", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_IdentityUserLogin<string>_IdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<string>", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_IdentityUserRole<string>_IdentityRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IdentityUserRole<string>_IdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Product",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Introduction",
                table: "Product",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "MediaNameFive",
                table: "Product",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "MediaNameFour",
                table: "Product",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "MediaNameOne",
                table: "Product",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "MediaNameThree",
                table: "Product",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "MediaNameTwo",
                table: "Product",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "StreetOne",
                table: "Address",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "StreetTwo",
                table: "Address",
                nullable: true);
            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");
            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName");
            migrationBuilder.AddForeignKey(
                name: "FK_EndUser_Address_AddressId",
                table: "EndUser",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductOwner_ProductOwnerId",
                table: "Product",
                column: "ProductOwnerId",
                principalTable: "ProductOwner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_ProductOwner_Address_AddressId",
                table: "ProductOwner",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_EndUser_Address_AddressId", table: "EndUser");
            migrationBuilder.DropForeignKey(name: "FK_Product_ProductOwner_ProductOwnerId", table: "Product");
            migrationBuilder.DropForeignKey(name: "FK_ProductOwner_Address_AddressId", table: "ProductOwner");
            migrationBuilder.DropColumn(name: "Details", table: "Product");
            migrationBuilder.DropColumn(name: "Introduction", table: "Product");
            migrationBuilder.DropColumn(name: "MediaNameFive", table: "Product");
            migrationBuilder.DropColumn(name: "MediaNameFour", table: "Product");
            migrationBuilder.DropColumn(name: "MediaNameOne", table: "Product");
            migrationBuilder.DropColumn(name: "MediaNameThree", table: "Product");
            migrationBuilder.DropColumn(name: "MediaNameTwo", table: "Product");
            migrationBuilder.DropColumn(name: "StreetOne", table: "Address");
            migrationBuilder.DropColumn(name: "StreetTwo", table: "Address");
            migrationBuilder.DropTable("AspNetRoleClaims");
            migrationBuilder.DropTable("AspNetUserClaims");
            migrationBuilder.DropTable("AspNetUserLogins");
            migrationBuilder.DropTable("AspNetUserRoles");
            migrationBuilder.DropTable("AspNetRoles");
            migrationBuilder.DropTable("AspNetUsers");
            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "Product",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Intro",
                table: "Product",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Media1",
                table: "Product",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Media2",
                table: "Product",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Media3",
                table: "Product",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Media4",
                table: "Product",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Media5",
                table: "Product",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Street1",
                table: "Address",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Street2",
                table: "Address",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_EndUser_Address_AddressId",
                table: "EndUser",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductOwner_ProductOwnerId",
                table: "Product",
                column: "ProductOwnerId",
                principalTable: "ProductOwner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_ProductOwner_Address_AddressId",
                table: "ProductOwner",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
