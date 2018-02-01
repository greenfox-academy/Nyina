﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PracticeWebshop.Entities;
using System;

namespace PracticeWebshop.Migrations
{
    [DbContext(typeof(WebshopContext))]
    partial class WebshopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PracticeWebshop.Models.WebshopModel", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<string>("ItemName");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Size");

                    b.Property<double>("UnitPrice");

                    b.HasKey("Id");

                    b.ToTable("PracticeWarehouse");
                });
#pragma warning restore 612, 618
        }
    }
}
