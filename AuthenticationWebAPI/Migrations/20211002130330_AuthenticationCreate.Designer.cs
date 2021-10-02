﻿// <auto-generated />
using AuthenticationWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuthenticationWebAPI.Migrations
{
    [DbContext(typeof(AuthenticationDBContext))]
    [Migration("20211002130330_AuthenticationCreate")]
    partial class AuthenticationCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AuthenticationWebAPI.Models.Authentication", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("surname")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("Authentications");
                });
#pragma warning restore 612, 618
        }
    }
}
