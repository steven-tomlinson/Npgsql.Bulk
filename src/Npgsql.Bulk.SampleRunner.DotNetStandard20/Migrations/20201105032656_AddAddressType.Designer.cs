﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.Bulk.DAL;
using Npgsql.Bulk.SampleRunner.DotNetStandard20.DAL;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using NpgsqlTypes;

namespace Npgsql.Bulk.SampleRunner.DotNetStandard20.Migrations
{
    [DbContext(typeof(BulkContext))]
    [Migration("20201105032656_AddAddressType")]
    partial class AddAddressType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:Enum:address_type", "type1,type2")
                .HasAnnotation("Npgsql:Enum:address_type_int", "first,second")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Npgsql.Bulk.SampleRunner.DotNetStandard20.DAL.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("address_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<AddressType>("AddressType")
                        .HasColumnName("address_type")
                        .HasColumnType("address_type");

                    b.Property<AddressTypeInt>("AddressTypeInt")
                        .HasColumnName("address_type_int")
                        .HasColumnType("address_type_int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<NpgsqlRange<DateTime>>("Duration")
                        .HasColumnName("range")
                        .HasColumnType("tsrange");

                    b.Property<int?>("ExtraHouseNumber")
                        .HasColumnName("extra_house_number")
                        .HasColumnType("integer");

                    b.Property<int>("HouseNumber")
                        .HasColumnName("house_number")
                        .HasColumnType("integer");

                    b.Property<TimeSpan>("Interval")
                        .HasColumnName("interval")
                        .HasColumnType("interval");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnName("postal_code")
                        .HasColumnType("text");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnName("street_name")
                        .HasColumnType("text");

                    b.Property<int>("UnmappedEnum")
                        .HasColumnName("unmapped_enum")
                        .HasColumnType("integer");

                    b.Property<uint>("xmin")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("xid");

                    b.HasKey("AddressId");

                    b.ToTable("addresses","public");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Address");
                });

            modelBuilder.Entity("Npgsql.Bulk.SampleRunner.DotNetStandard20.DAL.Address2EF", b =>
                {
                    b.HasBaseType("Npgsql.Bulk.SampleRunner.DotNetStandard20.DAL.Address");

                    b.Property<int>("Index2")
                        .HasColumnName("index2")
                        .HasColumnType("integer");

                    b.Property<string>("LocalizedName")
                        .IsRequired()
                        .HasColumnName("localized_name")
                        .HasColumnType("text");

                    b.ToTable("addresses2ef","public");

                    b.HasDiscriminator().HasValue("Address2EF");
                });
#pragma warning restore 612, 618
        }
    }
}
