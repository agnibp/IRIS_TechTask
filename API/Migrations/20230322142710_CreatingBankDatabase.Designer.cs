﻿// <auto-generated />
using API.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(BanksDBContext))]
    [Migration("20230322142710_CreatingBankDatabase")]
    partial class CreatingBankDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Models.BankDetail", b =>
                {
                    b.Property<int>("bank_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("bank_id"));

                    b.Property<string>("bank_head_office_location")
                        .HasMaxLength(15)
                        .HasColumnType("Varchar");

                    b.Property<string>("bank_name")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.HasKey("bank_id");

                    b.ToTable("BankDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
