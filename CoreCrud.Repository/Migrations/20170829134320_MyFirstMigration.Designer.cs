using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CoreCrud.Repository;

namespace CoreCrud.Repository.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20170829134320_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreCrud.Data.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("IPAddress");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CoreCrud.Data.UserProfile", b =>
                {
                    b.Property<long>("Id");

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Address");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("IPAddress");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedDate");

                    b.HasKey("Id");

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("CoreCrud.Data.UserProfile", b =>
                {
                    b.HasOne("CoreCrud.Data.User", "User")
                        .WithOne("UserProfile")
                        .HasForeignKey("CoreCrud.Data.UserProfile", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
