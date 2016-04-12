using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using MyFollow.Models;

namespace MyFollow.Migrations
{
    [DbContext(typeof(MyFollowDbContext))]
    [Migration("20160412044622_identity")]
    partial class identity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("MyFollow.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("Country")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("Pin")
                        .HasAnnotation("MaxLength", 20);

                    b.Property<string>("State");

                    b.Property<string>("StreetOne")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("StreetTwo")
                        .HasAnnotation("MaxLength", 50);

                    b.HasKey("Id");
                });

            modelBuilder.Entity("MyFollow.Models.EndUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<string>("ContactNumber")
                        .HasAnnotation("MaxLength", 20);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<DateTime>("DateOfJoining");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Gender")
                        .HasAnnotation("MaxLength", 10);

                    b.Property<int?>("UserProductMappingId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("MyFollow.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Details")
                        .HasAnnotation("MaxLength", 1000);

                    b.Property<string>("Introduction")
                        .HasAnnotation("MaxLength", 500);

                    b.Property<string>("MediaNameFive")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("MediaNameFour")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("MediaNameOne")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("MediaNameThree")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("MediaNameTwo")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<int>("ProductOwnerId");

                    b.Property<int?>("UserProductMappingId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("MyFollow.Models.ProductOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("ContactNumber")
                        .HasAnnotation("MaxLength", 20);

                    b.Property<DateTime>("DateOfJoining");

                    b.Property<string>("Description")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("FacebookPageUrl")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<DateTime>("FoundedIn");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("RandomNumber")
                        .HasAnnotation("MaxLength", 20);

                    b.Property<string>("Role")
                        .HasAnnotation("MaxLength", 10);

                    b.Property<string>("TwitterHandle")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("WebSiteUrl")
                        .HasAnnotation("MaxLength", 50);

                    b.HasKey("Id");
                });

            modelBuilder.Entity("MyFollow.Models.UserProductMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProductId");

                    b.Property<int>("UsreId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MyFollow.Models.EndUser", b =>
                {
                    b.HasOne("MyFollow.Models.Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("MyFollow.Models.UserProductMapping")
                        .WithMany()
                        .HasForeignKey("UserProductMappingId");
                });

            modelBuilder.Entity("MyFollow.Models.Product", b =>
                {
                    b.HasOne("MyFollow.Models.ProductOwner")
                        .WithMany()
                        .HasForeignKey("ProductOwnerId");

                    b.HasOne("MyFollow.Models.UserProductMapping")
                        .WithMany()
                        .HasForeignKey("UserProductMappingId");
                });

            modelBuilder.Entity("MyFollow.Models.ProductOwner", b =>
                {
                    b.HasOne("MyFollow.Models.Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });
        }
    }
}
