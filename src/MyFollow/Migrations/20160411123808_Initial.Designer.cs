using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using MyFollow.Models;

namespace MyFollow.Migrations
{
    [DbContext(typeof(MyFollowDbContext))]
    [Migration("20160411123808_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("Street1")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("Street2")
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

                    b.Property<string>("Detail")
                        .HasAnnotation("MaxLength", 1000);

                    b.Property<string>("Intro")
                        .HasAnnotation("MaxLength", 500);

                    b.Property<string>("Media1")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("Media2")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("Media3")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("Media4")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("Media5")
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
