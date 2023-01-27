﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Support.API.Services.Data;

namespace Support.API.Services.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Support.API.Services.Models.Asset", b =>
                {
                    b.Property<int>("AssetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int?>("ParentId")
                        .HasColumnType("integer");

                    b.Property<string>("Path")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Type")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("AssetId");

                    b.ToTable("Asset");
                });

            modelBuilder.Entity("Support.API.Services.Models.Organization", b =>
                {
                    b.Property<int>("OrganizationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Color")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("IdProfile")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int?>("ParentId")
                        .HasColumnType("integer");

                    b.HasKey("OrganizationId");

                    b.HasIndex("IdProfile")
                        .IsUnique();

                    b.ToTable("Organization");
                });

            modelBuilder.Entity("Support.API.Services.Models.OrganizationProfile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("ConnectionsWithMeter")
                        .HasColumnType("integer");

                    b.Property<int>("ConnectionsWithoutMeter")
                        .HasColumnType("integer");

                    b.Property<string>("Department")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("Employes")
                        .HasColumnType("integer");

                    b.Property<string>("Formation")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("Latrines")
                        .HasColumnType("integer");

                    b.Property<string>("Municipality")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("OrganizationId")
                        .HasColumnType("integer");

                    b.Property<string>("Phone")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("Professionals")
                        .HasColumnType("integer");

                    b.Property<string>("Province")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("PublicPools")
                        .HasColumnType("integer");

                    b.Property<string>("ServiceContinuity")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("WaterConnections")
                        .HasColumnType("integer");

                    b.HasKey("ProfileId");

                    b.ToTable("OrganizationProfile");
                });

            modelBuilder.Entity("Support.API.Services.Models.OrganizationToKoboUser", b =>
                {
                    b.Property<int>("KoboUserId")
                        .HasColumnType("integer");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("integer");

                    b.HasKey("KoboUserId", "OrganizationId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("OrganizationToKoboUser");
                });

            modelBuilder.Entity("Support.API.Services.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Support.API.Services.Models.RoleToAsset", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int>("AssetId")
                        .HasColumnType("integer");

                    b.HasKey("RoleId", "AssetId");

                    b.HasIndex("AssetId");

                    b.ToTable("RoleToAsset");
                });

            modelBuilder.Entity("Support.API.Services.Models.RoleToKoboUser", b =>
                {
                    b.Property<int>("KoboUserId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("KoboUserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleToKoboUser");
                });

            modelBuilder.Entity("Support.API.Services.Models.Asset", b =>
                {
                    b.HasOne("Support.API.Services.Models.Asset", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("AssetId");
                });

            modelBuilder.Entity("Support.API.Services.Models.Organization", b =>
                {
                    b.HasOne("Support.API.Services.Models.OrganizationProfile", "OrganizationProfile")
                        .WithOne("Organization")
                        .HasForeignKey("Support.API.Services.Models.Organization", "IdProfile");

                    b.HasOne("Support.API.Services.Models.Organization", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("OrganizationId");
                });

            modelBuilder.Entity("Support.API.Services.Models.OrganizationToKoboUser", b =>
                {
                    b.HasOne("Support.API.Services.Models.Organization", "Organization")
                        .WithMany("OrganizationToKoboUsers")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Support.API.Services.Models.RoleToAsset", b =>
                {
                    b.HasOne("Support.API.Services.Models.Asset", "Asset")
                        .WithMany("RoleToAssets")
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Support.API.Services.Models.Role", "Role")
                        .WithMany("RoleToAssets")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Support.API.Services.Models.RoleToKoboUser", b =>
                {
                    b.HasOne("Support.API.Services.Models.Role", "Role")
                        .WithMany("RoleToKoboUsers")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
