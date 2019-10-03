﻿// <auto-generated />
using System;
using MarinaIvanna;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MarinaIvanna.Migrations.trbd
{
    [DbContext(typeof(trbdContext))]
    partial class trbdContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DbCore.Models.ProblemLink", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("CompanyId");

                    b.Property<long?>("ProblemId");

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ProblemId");

                    b.HasIndex("UserId");

                    b.ToTable("ProblemLinks");
                });

            modelBuilder.Entity("MarinaIvanna.Companies", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("companies_un");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("MarinaIvanna.Problems", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Key");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique()
                        .HasName("problems_un");

                    b.ToTable("Problems");
                });

            modelBuilder.Entity("MarinaIvanna.RequestStatuses", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StatusName");

                    b.HasKey("Id");

                    b.HasIndex("StatusName")
                        .IsUnique()
                        .HasName("requeststatuses_un");

                    b.ToTable("RequestStatuses");
                });

            modelBuilder.Entity("MarinaIvanna.UserRequiesties", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<long?>("CompanyId");

                    b.Property<string>("Email");

                    b.Property<string>("Message");

                    b.Property<string>("Name");

                    b.Property<long?>("ProblemsId");

                    b.Property<long?>("RunnerId");

                    b.Property<long?>("SenderId");

                    b.Property<long?>("StatusId");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnName("uid")
                        .HasColumnType("character varying");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ProblemsId");

                    b.HasIndex("RunnerId");

                    b.HasIndex("SenderId");

                    b.HasIndex("StatusId");

                    b.ToTable("UserRequiesties");
                });

            modelBuilder.Entity("MarinaIvanna.UserRoles", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("userroles_un");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("MarinaIvanna.Users", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("CompanyId");

                    b.Property<byte[]>("Hash");

                    b.Property<DateTime>("LastLogin");

                    b.Property<string>("Login");

                    b.Property<string>("Name");

                    b.Property<byte[]>("Salt");

                    b.Property<long?>("UserRoleId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("Login")
                        .IsUnique()
                        .HasName("users_un");

                    b.HasIndex("UserRoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DbCore.Models.ProblemLink", b =>
                {
                    b.HasOne("MarinaIvanna.Companies", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("MarinaIvanna.Problems", "Problem")
                        .WithMany()
                        .HasForeignKey("ProblemId");

                    b.HasOne("MarinaIvanna.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MarinaIvanna.UserRequiesties", b =>
                {
                    b.HasOne("MarinaIvanna.Companies", "Company")
                        .WithMany("UserRequiesties")
                        .HasForeignKey("CompanyId");

                    b.HasOne("MarinaIvanna.Problems", "Problems")
                        .WithMany("UserRequiesties")
                        .HasForeignKey("ProblemsId");

                    b.HasOne("MarinaIvanna.Users", "Runner")
                        .WithMany("UserRequiestiesRunner")
                        .HasForeignKey("RunnerId");

                    b.HasOne("MarinaIvanna.Users", "Sender")
                        .WithMany("UserRequiestiesSender")
                        .HasForeignKey("SenderId");

                    b.HasOne("MarinaIvanna.RequestStatuses", "Status")
                        .WithMany("UserRequiesties")
                        .HasForeignKey("StatusId");
                });

            modelBuilder.Entity("MarinaIvanna.Users", b =>
                {
                    b.HasOne("MarinaIvanna.Companies", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId");

                    b.HasOne("MarinaIvanna.UserRoles", "UserRole")
                        .WithMany("Users")
                        .HasForeignKey("UserRoleId");
                });
#pragma warning restore 612, 618
        }
    }
}
